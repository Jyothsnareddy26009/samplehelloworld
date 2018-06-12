using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.BLL;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ConsoleScreen console = new ConsoleScreen();
            console.WriteOutput("Test output: Hello World");
        }
    }
}
