using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;
namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLlamadasInstanciadas()
        {
            //arrange
            Centralita c = new Centralita();

            //act

            //asset
            Assert.IsNotNull(c.Llamadas);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestCentralitaException()
        {
            //arrange
            Centralita c = new Centralita();
            Provincial llamada1 = new Provincial("Bernal", Provincial.Franja.Franja_1, 32, "123");
            Provincial llamada2 = llamada1;

            //act
            c += llamada1;
            c += llamada1;
            
            //assert
            Assert.IsNotNull(c.Llamadas);
        }

        [TestMethod]
        public void TestLocalesYProvincialesEquiality()
        {
            //arrange
            Centralita c = new Centralita();
            Provincial llamada1 = new Provincial("Bernal", Provincial.Franja.Franja_1, 32, "123");
            Provincial llamada2 = new Provincial("Bernal", Provincial.Franja.Franja_1, 32, "123");

            Local llamada3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Local llamada4 = new Local("Lanús", 45, "San Rafael", 1.99f);

            //act

            //assert
            Assert.IsTrue(llamada1 == llamada2);
            Assert.IsTrue(llamada1 != llamada3);
            Assert.IsTrue(llamada1 != llamada4);

            Assert.IsTrue(llamada3 == llamada4);
            Assert.IsTrue(llamada3 != llamada2);
        }
    }
}
