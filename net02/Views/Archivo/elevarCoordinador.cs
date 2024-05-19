using net02.Data;
using net02.Models;
using net02.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net02.Views.Archivo
{
    public partial class elevarCoordinador : Form
    {
        private readonly int ID = 1;
        private UsuariosModel U;


        public elevarCoordinador(UsuariosModel U)
        {
            
            this.U = U;

            InitializeComponent();
          if (!Permisos.tienePermiso(U.Tipo, ID))
          {
            AContext.insertaBitacora(U.Nombre, "DANGER : trato de entrar al ID " + ID + " sin permiso - " +
            Dns.GetHostEntry(Dns.GetHostName()));
            this.Close();
          } else {
            AContext.insertaBitacora(U.Nombre,
                "INFO : Ingreso a " + ID + " - " + Dns.GetHostEntry(Dns.GetHostName()));
          }
        }
    }
}
