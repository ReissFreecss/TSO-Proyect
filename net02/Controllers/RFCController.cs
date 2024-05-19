using net02.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net02.Controllers
{
    internal class RFCController
    {
        public RFCModel M { get; set; }
        public RFCController(RFCModel m) {
            M = m;
            creaRFC();
        }

        private void creaRFC()
        {
            if (M.APN.Length == 0 && M.AMN.Length > 0)
            {
                M.RFC += M.AMN[0].ToString() + M.AMN[1].ToString();
                M.RFC += M.NombreN[0].ToString() + M.NombreN[1].ToString();
            }
            else if (M.APN.Length > 0 && M.AMN.Length == 0)
            {
                M.RFC += M.APN[0].ToString() + M.APN[1].ToString();
                M.RFC += M.NombreN[0].ToString() + M.NombreN[1].ToString();
            }
            else if (M.APN.Length > 0 && M.AMN.Length > 0)
            {
                /* tiene ambos*/
                if (M.APN.Length <= 2)
                {
                    M.RFC += M.APN[0].ToString() + M.AMN[0].ToString();
                    M.RFC += M.NombreN[0].ToString() + M.NombreN[1].ToString();
                }
                else
                {
                    M.RFC += M.APN[0].ToString() + siguienteVocal(M.APN);
                    M.RFC += M.AMN[0].ToString();
                    M.RFC += M.NombreN[0].ToString();
                }
            }
            else
            {
                /* no tiene nada*/
                throw new Exception("Que no pusiste apellidos animal...");
            }
            quitarProhibidas();

            M.RFC += M.Fecha.ToString("yyMMdd");
            M.RFC10 = M.RFC;
            calcularHomonimia();
            M.RFC += digitoVerificador();
            M.Homonimia += digitoVerificador();
        }

        private string digitoVerificador()
        {
            int C = 0;
            int c = 13;
            for (int y = 0; y < M.RFC.Length; y++)
            {
                for (int x = 0; x < Catalogos.Anexo3.Count; x++)
                {
                    KeyValuePair<char, int> V = Catalogos.Anexo3.ElementAt(x);

                    if (M.RFC[y] == V.Key)
                    {
                        C += V.Value * (c--);
                    }
                }
            }
            C = C % 11;
            if (C == 0)
                return "0";
            else if (C > 0 && C < 10)
            {
                return (11 - C).ToString();
            }
            return "A";


        }

        private void calcularHomonimia()
        {
            string H = "0";
            string N = M.Nombre + " " + M.AP + " " + M.AM;
            N = quitarAcentos(N);
            for (int x = 0; x < N.Length; x++)
            {
                for (int y = 0; y < Catalogos.Anexo1.Count; y++)
                {
                    KeyValuePair<char, string> A1 = Catalogos.Anexo1.ElementAt(y);
                    if (N[x] == A1.Key)
                    {
                        H += A1.Value;
                    }
                }
            }
            int num = 0;
            for (int x = 0; x < N.Length - 1; x++)
            {
                num = int.Parse(N[x].ToString() + N[x + 1].ToString()) *
                    int.Parse(N[x + 1].ToString());
            }
            num = num % 1000;
            int c = num / 34;
            int r = num % 34;
            for (int x = 0; x < Catalogos.Anexo2.Count; x++)
            {
                KeyValuePair<int, char> v = Catalogos.Anexo2.ElementAt(x);
                if (v.Key == c)
                {
                    M.RFC += v.Value.ToString();
                    M.Homonimia += v.Value.ToString();
                }
            }
            for (int x = 0; x < Catalogos.Anexo2.Count; x++)
            {
                KeyValuePair<int, char> v = Catalogos.Anexo2.ElementAt(x);
                if (v.Key == r)
                {
                    M.RFC += v.Value.ToString();
                    M.Homonimia += v.Value.ToString();
                }
            }

        }

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
            // Practica del dia:            
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

        private void quitarProhibidas()
        {
            for (int x = 0; x < Catalogos.Anexo4.Count; x++)
            {
                KeyValuePair<string, string> p = Catalogos.Anexo4.ElementAt(x);
                if (p.Key == M.RFC)
                {
                    M.RFC = p.Value;
                    break;
                }
            }
        }

        private string siguienteVocal(string palabra)
        {
            for (int x = 1; x < palabra.Length; x++)
            {
                if (palabra[x] == 'A' || palabra[x] == 'E' || palabra[x] == 'I' || palabra[x] == 'O' ||
                    palabra[x] == 'U')
                    return palabra[x].ToString();
            }
            return "X";
        }
    }
}
