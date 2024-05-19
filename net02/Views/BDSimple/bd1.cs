using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net02.Views.BDSimple
{
    public partial class bd1 : Form
    {
        public bd1()
        {
            InitializeComponent();
        }

        private void bd1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'curp_xa_2023DataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.curp_xa_2023DataSet.Usuarios);

        }
    }
}
