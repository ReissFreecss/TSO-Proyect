using net02.Data;
using net02.Models;
using net02.Views.Archivo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net02.Views
{
    public partial class Menu : Form
    {
        private UsuariosModel U;

        public Menu(UsuariosModel U)
        {
            if (U == null)
            {
                AContext.insertaBitacora("Nadie",
                        "DANGER: Menú se abrió sin usuario desde : " +
                        Dns.GetHostEntry(Dns.GetHostName()));
                Application.Exit();
            }
            InitializeComponent();
            this.U = U;
            this.Text = "Bienvenido " + U.Nombre;

            revisarMenus();
        }

        private void revisarMenus()
        {
            if (U.Tipo >= 0 && U.Tipo <= 3)
            {
                elevarUnUsuarioACoordinadorToolStripMenuItem.Visible = false;
                elevarUnUusuarioASecretariaToolStripMenuItem.Visible = false;
                alumnosToolStripMenuItem.Visible = false;
                darDeAltaToolStripMenuItem.Visible = false;
                darDeBajaToolStripMenuItem.Visible = false;
                inscribirEnGrupoToolStripMenuItem.Visible = false;
                reportesToolStripMenuItem.Visible = false;
                reporteDeBitácorasToolStripMenuItem.Visible = false;
            }
            switch (U.Tipo)
            {
                case -1: break;
                case 0:
                    elevarUnUsuarioACoordinadorToolStripMenuItem.Visible = true;
                    elevarUnUusuarioASecretariaToolStripMenuItem.Visible=true;
                    promedioDelAlumnoToolStripMenuItem.Visible = false;
                    break;
                case 1:
                    alumnosToolStripMenuItem.Visible = true;
                    darDeBajaToolStripMenuItem.Visible = true;
                    inscribirEnGrupoToolStripMenuItem.Visible = true;
                    reportesToolStripMenuItem.Visible = true;
                    break;
                case 2:
                    alumnosToolStripMenuItem.Visible = true;
                    darDeAltaToolStripMenuItem.Visible = true;
                    reportesToolStripMenuItem.Visible = true;
                    break;
                case 3:
                    reportesToolStripMenuItem.Visible = true;
                    break;
                default:
                    AContext.insertaBitacora(U.Nombre,
                    "DANGER : Tiene un Rol desconocido: " + U.Tipo + " - " +
                    Dns.GetHostEntry(Dns.GetHostName()));
                    AContext.logoutUsuario(U.Usuario);
                    Application.Exit();
                    break;

                    
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            AContext.logoutUsuario(U.Usuario);
            Application.Exit();
        }

        private void elevarUnUsuarioACoordinadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            elevarCoordinador F = new elevarCoordinador(U);

            F.Show();
        }

        private void elevarUnUsuarioACoordinadorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
