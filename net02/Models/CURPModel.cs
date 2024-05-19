using net02.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net02.Models
{
    internal class CURPModel
    {
        public RFCModel RFC { get; }
        public char Genero { get; }
        public string Entidad { get; } 
        public string CURP { get; set; }


        public CURPModel(RFCModel R, char Genero, string Entidad) {
            this.RFC = R;
            this.Genero = Genero;
            this.Entidad = Entidad;
            this.CURP = this.RFC.RFC10;
            /*CURPNormalizator N = new CURPNormalizator(this);*/
            /*CURPValidator V = new CURPValidator(this);*/
            CURPController C = new CURPController(this);
        }
    }
}
