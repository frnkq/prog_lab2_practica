﻿using System;
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
    public class Local : Llamada, IGuardar<Local>
    {
        #region Fields
        protected float costo;
        public string thisIsAValue = "this is a value";
        #endregion

        #region Properties
        /// <summary>
        /// Read Only. Retorna el costo de la llamada calculado con el metodo CalcularCosto()
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
        public Local() : base((float)32.3, "123123", "456456")
        {

        }
        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        #endregion


        #region Methods
        /// <summary>
        /// Recopila información de la llamada en un string, utilizando el metodo Mostrar() de llamada y agregando los campos locales
        /// </summary>
        /// <returns>informacion de la llamada</returns>
        protected override string Mostrar()
        {
            StringBuilder datosLocal = new StringBuilder();
            datosLocal.Append(base.Mostrar());
            datosLocal.AppendLine(String.Format("Costo de la llamada: {0}", this.CostoLlamada));

            return datosLocal.ToString();
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
        /// Analiza si un objeto es del tipo Local
        /// </summary>
        /// <param name="obj">Objeto a comparar</param>
        /// <returns>True si el objeto es del tipo local</returns>
        public override bool Equals(object obj)
        {
            return obj is Local;
        }


        /// <summary>
        /// Calcula el costo de la llamada multiplicando la duración por el costo de la misma
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }

        public bool Guardar()
        {
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                            "\\local.cs";
            XmlSerializer serializer = new XmlSerializer(typeof(Local));
            XmlWriter xmlWriter = XmlWriter.Create(fileName);
            try
            {
                serializer.Serialize(xmlWriter, this);
                return true;
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                xmlWriter.Close();
            }
        }

        public Local Leer()
        {
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                            "\\local.bin";
            XmlReader xmlReader = XmlReader.Create(fileName);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Local));
            Object aux;
            try
            {
                aux = xmlSerializer.Deserialize(xmlReader);
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                xmlReader.Close();
            }
            if (aux is Local)
                return (Local)aux;
            else
                throw new InvalidCastException();
        }
        #endregion

    }
}
