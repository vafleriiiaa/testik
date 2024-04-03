using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using тест2;

namespace Auto2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(DemoExam.Exam("15", "10", "5"), 30);
            //Assert.AreNotEqual(DemoExam.Exam("0", "10", "5"), 30);
            //Assert.AreNotEqual(DemoExam.Exam("t", "0", "-1"), 30);
        }
    }
}
