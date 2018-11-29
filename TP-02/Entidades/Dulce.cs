﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Dulce :Producto
    {
        public Dulce(EMarca marca, string patente, ConsoleColor color):base(patente,marca,color)
        {
        }

        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }

        public override sealed string Mostrar() // se cambio la visibilidad a public segun el diagrama
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar());   
            sb.AppendLine(string.Format("CALORIAS :{0}", this.CantidadCalorias));
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
