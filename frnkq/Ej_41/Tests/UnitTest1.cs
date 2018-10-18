using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej_41;
namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestTryingToDivide()
        {
            Divider.TryingToDivide();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDefaultConstructor()
        {
            new Divider();
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void TestConstructorWithIntParameter()
        {
            new Divider(5);
        }


        [TestMethod]
        [ExpectedException(typeof(MiException))]
        public void TestConstructorWithIntAndStringParameter()
        {
            new Divider(5, "asd");
        }

    }
}
