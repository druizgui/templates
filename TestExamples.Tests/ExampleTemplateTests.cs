// -----------------------------------------------------------------
// <copyright>Copyright (C) 2020, David Ruiz.</copyright>
// Licensed under the Apache License, Version 2.0.
// You may not use this file except in compliance with the License:
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Software is distributed on an "AS IS", WITHOUT WARRANTIES
// OR CONDITIONS OF ANY KIND, either express or implied.
// -----------------------------------------------------------------

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

[TestClass]
public class ExampleTemplateTests
{
    public TestContext Context { get; set; }

    [AssemblyInitialize]
    public static void AssemblyInitialize(TestContext context)
    {
        Console.WriteLine("AssemblyInitialize");
    }

    [AssemblyCleanup]
    public static void AssemblyCleanup()
    {
        Console.WriteLine("AssemblyCleanup");
    }

    [ClassInitialize]
    public static void ClassInitialize(TestContext context)
    {
        var settings = new JsonSerializerSettings()
        {
          ReferenceLoopHandling = ReferenceLoopHandling.Ignore, Formatting = Formatting.Indented
        };
        Console.WriteLine("ClassInitialize");

        Console.WriteLine($"Context={Environment.NewLine} { JsonConvert.SerializeObject(context, settings)}");
    }

    [ClassCleanup]
    public static void ClassCleanup()
    {
        Console.WriteLine("ClassCleanup");
    }

    [TestInitialize]
    public void TestInit()
    {
        Console.WriteLine("TestInit");
    }

    [TestCleanup]
    public void TestCleanup()
    {
        Console.WriteLine("TestCleanup");
    }

    [TestMethod]
    //[DataSource(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Projects\MyBank\TestData\AccountsTest.accdb",   "AddIntegerHelperData")]  
    //To create a data-driven test for the AddIntegerHelper method, we first create an Access database named AccountsTest.accdb and a table named AddIntegerHelperData. The AddIntegerHelperData table defines columns to specify the first and second operands of the addition and a column to specify the expected result. We fill a number of rows with appropriate values.
    //[Timeout(TestTimeout.Infinite)] // Milliseconds  
    //[ExpectedException(typeof(ArgumentOutOfRangeException))]  
    public void Example1()
    {
        Console.WriteLine("Example1");

        //ARRANGE

        //ACT

        //ASSERT

        /*
            Use different components to validate results:

                - Assert
                - CollectionAssert
                - StringAssert
                - AssertFailedException
                - AssertInconclusiveException
                - UnitTestAssertException
                - ExpectedExceptionAttribute
        */
    }

    [TestMethod]
    public void Example2()
    {
        Console.WriteLine("Example2");
    }
}