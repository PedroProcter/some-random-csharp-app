﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Negocio
    {
        private static string mensaje;
        public static string Mensaje { get => mensaje; set => mensaje = value; }

        public string ValidarLimiteCredito(int Limite)
        {
            if (Limite <= 0)
            {
                mensaje = "Ingrese un valor mayor que cero";
                return mensaje;
            }
            else
                return Limite.ToString();
        }

        /*
         * if (negocio.ValidarLimiteCredito(Limite) > 0)
         * {
         *  //guardar
         * }
         * else
         * MessageBox(negocio.ValidarLimiteCredito(Limite));
         * 
         */
    }
}
