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
using net02.Data;
using net02.Models;

namespace net02.Views.BDSimple
{
    public partial class bd2 : Form
    {

        //curp_xa2023ConectionString
        public bd2()
        {
            InitializeComponent();
        }

        private void bd2_Load(object sender, EventArgs e)
        {
            AContext.insertaBitacora("Nadie","INFO: Inició la aplicación"); ;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AContext.insertaBitacora("Nadie", "INFO: Cerró la aplicación"); 
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim().Length > 0)
            {
                if (txtClave.Text.Trim().Length > 0)
                {
                    try
                    {
                        UsuariosModel U = AContext.Login(
                            txtUsuario.Text,
                            txtClave.Text
                            );
                        txtUsuario.Text = string.Empty;
                        txtClave.Text = string.Empty;
                        this.Hide();
                        Menu F = new Menu(U);
                        F.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else {
                    MessageBox.Show("Escribe una Contrasena");
                    txtClave.Focus();
                    AContext.insertaBitacora("nadie",
                    "WARNING: Trato de iniciar sesion sin Contrasena desde : " +
                    Dns.GetHostEntry(Dns.GetHostName()));


                }
   
            }
            else
            {
                MessageBox.Show("Escribe un Usuario");
                txtUsuario.Focus();
                AContext.insertaBitacora("Nadie", 
                    "WARNING: Trató de iniciar sesión sin usuario desde : " +
                    Dns.GetHostEntry(Dns.GetHostName()));
            }
        }
    }
}
