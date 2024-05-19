using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace net02.Models
{
    internal class RFCNormalizator
    {
        public RFCModel modelo { get; set; }

        public RFCNormalizator(RFCModel rFCModel)
        {
            this.modelo = rFCModel;
            Normalizar();
        }

        public void Normalizar()
        {
            modelo.NombreN = quitarAcentos(modelo.NombreN);
            modelo.APN = quitarAcentos(modelo.APN);
            modelo.AMN = quitarAcentos(modelo.AMN);

            quitarMariaJose();

            modelo.NombreN = quitarArticulos(modelo.NombreN);
            modelo.APN = quitarArticulos(modelo.APN);
            modelo.AMN = quitarArticulos(modelo.AMN);
        }


        private void quitarMariaJose()
        {
            string[] nombres = modelo.Nombre.Split(' ');
            if (nombres.Length > 1)
            {
                int x = 0;
                if (nombres[0] == "JOSE" || nombres[0] == "MARIA")
                {
                    x = 1;
                }
                modelo.NombreN = String.Empty;
                for (; x < nombres.Length; x++)
                {
                    modelo.NombreN += nombres[x];
                    if (x < nombres.Length - 1)
                    {
                        modelo.NombreN += " ";
                    }
                }
            }

            else
            {
                modelo.NombreN = nombres[0];
            }
        }


        private string quitarArticulos(string palabra)
        {
            string[] palabras = palabra.Split(' ');
            string aux = string.Empty;
            if (palabras.Length > 1)
            {
                for (int x = 0; x < palabra.Length; x++)
                {
                    if (palabras[x] != "LA" && palabras[x] != "LAS" && palabras[x] != "LO" &&
                        palabras[x] != "LOS" && palabras[x] != "DE" && palabras[x] != "DEL" &&
                        palabras[x] != "Y" && palabras[x] != "EL")
                    {
                        aux += palabras[x];
                        if (x < palabras.Length - 1)
                            aux += " ";
                    }
                }
                palabras = aux.Split(' ');
                aux = string.Empty;
                for (int x = 0; x < palabras.Length; x++)
                {
                    aux += palabras[x];
                    if (x < palabras.Length - 1)
                        aux += " ";
                }
            }
            else
            {
                aux = palabra;
            }
            return aux;
        }


        //Regla 10
        private string quitarAcentos(string palabra)
        {
            ArrayList posiciones = new ArrayList();

            for (int x = 0; x < palabra.Length; x++)
            {
                if (palabra[x] == 'Ñ')
                {
                    posiciones.Add(x);
                }
            }

            String aux = new String(palabra.Normalize(System.Text.NormalizationForm.FormD)
                .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                .ToArray())
            .Normalize(System.Text.NormalizationForm.FormC);
            //Practica del dia

            for (int x = 0; x < posiciones.Count; x++)
            {
                int p = int.Parse(posiciones[x].ToString());
                char[] aux2 = aux.ToArray();
                aux2[p] = 'Ñ';
                aux = string.Empty;
                for (int y = 0; y < aux2.Length; y++)
                {
                    aux += aux2[y].ToString();
                }
            }

            aux = new string(aux.Where(c => !char.IsPunctuation(c)).ToArray());
            aux = aux.Trim('\'');
            return aux;
        }
    }
}