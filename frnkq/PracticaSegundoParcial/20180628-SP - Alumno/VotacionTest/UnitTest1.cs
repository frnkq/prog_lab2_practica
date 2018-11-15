using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
namespace VotacionTest
{
    [TestClass]
    public class UnitTest1
    {
        int contador = 0;

        [TestMethod]
        [ExpectedException(typeof(ErrorArchivoException))]
        public void TestMethod1()
        {
            Votacion votacion = new Votacion("Ley", new System.Collections.Generic.Dictionary<string, Votacion.EVoto>());
            SerializarXML<Votacion> serializarXML = new SerializarXML<Votacion>();
            serializarXML.Guardar("C:\\Windows\\Archivo.xml", votacion);
        }

        [TestMethod]
        public void TestMethod2()
        {
            
            System.Collections.Generic.Dictionary<string, Votacion.EVoto> senadores = new System.Collections.Generic.Dictionary<string, Votacion.EVoto>()
            {
                {"1", Votacion.EVoto.Abstencion },
                {"2", Votacion.EVoto.Afirmativo }
            };

            Votacion votacion = new Votacion("Ley", senadores);
            votacion.EventoVotoEfectuado += UnitTest1_evento;
            votacion.Simular();

            Assert.AreEqual(2, contador);
        }

        private void UnitTest1_evento(string senador, Votacion.EVoto voto)
        {
            contador++;
        }
    }
}
