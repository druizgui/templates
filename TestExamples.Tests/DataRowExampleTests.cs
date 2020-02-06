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

[TestClass]
public class DataRowExampleTests
{
    /// <summary>
    ///     Example of DataRow test. With the same test method you can test with different values
    ///     See the web page:
    ///     <see
    ///         href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.testtools.unittesting.datarowattribute?view=mstest-net-1.2.0">
    ///         DataRow
    ///         attribute.
    ///     </see>
    /// </summary>
    /// <param name="value">A integer value.</param>
    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    [DataRow(4)]
    public void Example_DataRow(int value)
    {
        Console.WriteLine($"value: {value}");
    }

    /// <summary>     Example of DataRow test with DisplayName. </summary>
    /// <param name="value">A integer value.</param>
    [TestMethod]
    [DataRow(1, DisplayName = "Value 1 are equal")]
    [DataRow(2, DisplayName = "Value 2 not equal")]
    public void Example_DataRow_With_Message(int value)
    {
        Console.WriteLine($"value: {value}");
        Assert.AreEqual(1, value);
    }
}