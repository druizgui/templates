namespace SeleniumNetCore.Tests
{
    using System;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;

    [TestClass]
    public class WebdriverTests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();

            baseURL = "https://www.google.es/";
            verificationErrors = new StringBuilder();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [TestMethod]
        public void TheWebdriverTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/?hl=es");
            driver.FindElement(By.XPath("//div[@value='es']")).Click();
            driver.FindElement(By.Id("source")).Clear();
            driver.FindElement(By.Id("source")).SendKeys("casa");
            driver.FindElement(By.LinkText("Google Translator Toolkit")).Click();
            driver.FindElement(By.Id("Email")).Clear();
            driver.FindElement(By.Id("Email")).SendKeys("druizg@efronconsulting.com");
            driver.FindElement(By.Id("next")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}




//namespace SeleniumNetCore.Tests
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        [TestMethod]
//        public void TestMethod1()
//        {
//        }
//    }


//}


