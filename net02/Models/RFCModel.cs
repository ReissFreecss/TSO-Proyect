using net02.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net02.Models
{
    internal class RFCModel
    {
        /*1.-Constantes*/
        /*2.-Atributos*/
        /*Existen atributos de entrada*/
        public string Nombre { get; }
        public string AP { get; }
        public string AM { get; }
        public DateTime Fecha { get; }

        /*Atributos procesables*/
        public string NombreN { get; set; }
        public string APN { get; set; }
        public string AMN { get; set; }

        /*Atributos finales o procesados*/
        public string RFC { get; set; }

        public string RFC10 { get; set; }

        public string Homonimia { get; set; }


        /*3.-Constructores*/
        public RFCModel(string Nombre, string AP, string AM, DateTime Fecha)
        {
            this.Nombre = Nombre;
            this.AP = AP;
            this.AM = AM;
            this.Fecha = Fecha;

            this.NombreN = Nombre;
            this.APN = AP;
            this.AMN = AM;
            this.RFC = String.Empty;
            this.RFC10 = String.Empty;
            this.Homonimia = String.Empty;


            
            /*Normalizar los valores iniciales*/
            RFCNormalizator n = new RFCNormalizator(this);

            /*Segundo Momento: Validar los valores iniciales de acuerdo al algoritmo*/
            RFCValidator v= new RFCValidator(this);
            /*Procesamos acciones*/
            RFCController controller = new RFCController(this);

        }
        /*4.-Métodos*/
    }
}
