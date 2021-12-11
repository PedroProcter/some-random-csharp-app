using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    public class Presentacion
    {
        string numDocumento = null;
        public string ConversionDatos(int value, string TipoDocumento)
        {

            switch (TipoDocumento)
            {

                case "Cedula":
                    numDocumento = value.ToString("###-#######-#");
                    break;

                case "RNC":
                    numDocumento = value.ToString("#-##-########");
                    break;

                case "Pasaporte":
                    numDocumento = value.ToString("#########");
                    break;

            }
            return numDocumento;

        }
    }
}
