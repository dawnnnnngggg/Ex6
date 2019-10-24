using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex6b;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPop()
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.AreEqual(3, s.Pop());
            Assert.AreEqual(2, s.Pop());
        }
        [TestMethod]
        public void TestPeek()
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.AreEqual(3, s.Peek());
            Assert.AreEqual(2, s.Count());
        }
        [TestMethod]
        public void TestPush()
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.AreEqual(3, s.Count());
            Assert.AreEqual(2, s.Pop());
        }
        [TestMethod]
        public void TestClear()
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.AreEqual(3, s.Pop());
            Assert.AreEqual(2, s.Pop());
        }
    }
}
