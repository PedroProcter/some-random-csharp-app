using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    public class Presentacion
    {
        public int ConversionDatos(int value, string TipoDocumento)
        {
            /*   AQUI CON ESTE METODO RESIVIRE COMO PARAMETRO EL VALOR INTRODUCIDO POR EL NUMERO DE IDENTIDAD Y EL TIPO DE 
             *   DOCUMENTO Y SEGUN EL TIPO SE 
             *   LE APLICARA EL FORMATO CORRESPONDIENTE, SE HARA CON UN CASE Y SE ALMACENARA EN UNA VARIABLE QUE SERA RETORNADA 
             *  Console.WriteLine(value.ToString("(###) ###-####"));
                Console.WriteLine(String.Format("{0:(###) ###-####}", value));
                // Displays (123) 456-7890
             * 
             * 
             */
            int numDocumento
            switch (TipoDocumento)
            {
                case "RNC"
                    numDocumeto = value.ToString("###-#######-#");
                break;

                case "RNC"
                    numDocumeto = value.ToString("#-##-########");
                break;

                case "RNC"
                    numDocumeto = value.ToString("#########");
                break;
               
            }
            return numDocumento;

        }
    }
}
