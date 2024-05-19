using net02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net02.Controllers
{
    internal class CURPController
    {
        public CURPModel M { get; set; }
        public CURPController (CURPModel m)
        {
            this.M = m;
            creaCURP();
        }

        private void creaCURP()
        {
            M.CURP += M.Genero.ToString() + M.Entidad;
            if (M.RFC.AP== string.Empty) {
                M.CURP += "X";
            }
            else
            {
                M.CURP += siguienteConsonante(M.RFC.APN);
            }

            if (M.RFC.AM == string.Empty)
            {
                M.CURP += "X";
            }
            else
            {
                M.CURP += siguienteConsonante(M.RFC.AMN);
            }

            M.CURP += siguienteConsonante(M.RFC.NombreN);

            int x = (((M.RFC.Fecha.Year % 1000) % 100)%10);
            if (M.RFC.Fecha.Year < 2000)
            {
                M.CURP += x.ToString();
            }
            else
            {
                M.CURP += ('A' + x).ToString();
            }


            /*Digito Verificador, IGUAL AL DEL RFC pero con mas Espacios*/

        }


        private string siguienteConsonante(string palabra)
        {
            for (int x = 1; x < palabra.Length; x++)
            {
                if (palabra[x] == 'A' || palabra[x] == 'E' || palabra[x] == 'I' || palabra[x] == 'O' || palabra[x] == 'U')
                    return palabra[x].ToString();
            }
            return "X";
        }
    }
}
