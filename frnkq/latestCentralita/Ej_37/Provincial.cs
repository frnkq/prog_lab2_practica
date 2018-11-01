using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
namespace CentralitaHerencia
{
    [Serializable]
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        #region Fields
        protected Franja franjaHoraria;
        #endregion

        #region Properties
        /// <summary>
        /// Read Only. Retorna el costo de la llamada utilizando el metodo CalcularCosto()
        /// </summary>
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public string RutaDeArchivo
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public Provincial() : base((float)32.3, "123123", "456456")
        {

        }
        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        #endregion


        #region Methods

        /// <summary>
        /// Recopila información de la llamada en un string, utilizando el metodo Mostrar() de llamada y agregando los campos locales
        /// </summary>
        /// <returns>informacion de la llamada</returns>
        protected override string Mostrar()
        {
            StringBuilder datosProvincial = new StringBuilder();
            datosProvincial.Append(base.Mostrar());
            datosProvincial.Append(String.Format("Costo de la llamada: {0} franja horaria: {1}", this.CostoLlamada, this.franjaHoraria));

            return datosProvincial.ToString();
        }
        /// <summary>
        /// Recopila informacion de la llamada utilizando el metodo Mostrar
        /// </summary>
        /// <returns>Informacion de la llamada</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Calcula el costo de la llamada dependiendo su franja horaria
        /// Franja_1: 0,99
        /// Franja_2: 1.25
        /// Franja_3: 0.66
        /// </summary>
        /// <returns>Retorna el costo de la llamada, o -1 en caso de producirse un error</returns>
        private float CalcularCosto()
        {
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    return (float)0.99 * this.duracion;
                    
                case Franja.Franja_2:
                    return (float)1.25 * this.duracion;

                case Franja.Franja_3:
                    return (float)0.66 * this.duracion;

                default:
                    return -1;
            }
        }


        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }


        public bool Guardar()
        {
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                            "\\provincial.cs";
            XmlSerializer serializer = new XmlSerializer(typeof(Provincial));
            XmlWriter xmlWriter = XmlWriter.Create(fileName);
            try
            {
                serializer.Serialize(xmlWriter, this);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                xmlWriter.Close();
            }
        }

        public Provincial Leer()
        {
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                            "\\local.bin";
            XmlReader xmlReader = XmlReader.Create(fileName);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Provincial));
            Object aux;
            try
            {
                aux = xmlSerializer.Deserialize(xmlReader);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                xmlReader.Close();
            }
            if (aux is Provincial)
                return (Provincial)aux;
            else
                throw new InvalidCastException();
        }
        #endregion

        #region Enums
        //Enumerado de las distintas franjas horarias
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        #endregion
    }
}
