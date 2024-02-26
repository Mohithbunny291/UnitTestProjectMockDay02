using EmpLib2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace UnitTestProjectMockDay02
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void MockTest()
        {
            //Problem
            //CheckEmpSecondDev chk = new CheckEmpSecondDev();
            //ProcessEmp process = new ProcessEmp();
            //Assert.AreEqual(true, process.InsertEmp(chk));

            Mock<CheckEmpSecondDev> chk = new Mock<CheckEmpSecondDev>();
            chk.Setup(x => x.CheckEmp()).Returns(true);

            ProcessEmp process = new ProcessEmp();
            Assert.AreEqual(true, process.InsertEmp(chk.Object));
        }
    }
}
