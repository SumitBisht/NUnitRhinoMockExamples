using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using UnitTesting.src;

namespace UnitTesting.test
{
    class TestMyClass
    {
        [Test]  //Mark this method as a test
        public static void TestAddition()
        {
            //Now perform validations - here we will assert our beliefs
            Assert.AreEqual(2, MyClass.add(1, 1));
            Assert.AreEqual(0, MyClass.add(5, -5));
            Assert.AreEqual(0, MyClass.add(-5, 5));
            Assert.AreEqual(0, MyClass.add(0, 0));

            Assert.AreNotEqual(1, MyClass.add(1, -1));
            Assert.AreNotEqual(1, MyClass.add(-1, 1));
            Assert.AreNotEqual(1, MyClass.add(-1, -1));
            Assert.AreNotEqual(1, MyClass.add(0, 0));
        }
        [Test]
        public static void TestFactorial()
        {
            Assert.AreEqual(1, MyClass.factorial(1));
            Assert.AreEqual(2, MyClass.factorial(2));
            Assert.AreEqual(6, MyClass.factorial(3));
            Assert.AreEqual(720, MyClass.factorial(6));
            Assert.AreNotEqual(1080, MyClass.factorial(10));
            Assert.AreEqual(1, MyClass.factorial(0));
            Assert.AreEqual(1, MyClass.factorial(-6));
        }
    }
}
