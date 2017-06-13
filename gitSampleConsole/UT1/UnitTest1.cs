using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gitSampleConsole;

namespace UT1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            gitSampleConsole.Program ts = new Program();
            int rs=ts.testAdd(1 , 2);
            Assert.IsTrue(rs == 3, "passes the test");
       
        }
    }
}
