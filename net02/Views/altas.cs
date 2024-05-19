using net02.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net02.Views
{
    public partial class altas : Form
    {
        public altas()
        {
            InitializeComponent();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }


        private void altas_Load(object sender, EventArgs e)
        {
            // TODO: esta linea de codigo carga datos en la tabla 'curp_xa_2023DataSet3.Carreras' Puede moverla o quitarla segun sea necesario.
          //  this.carrerasTableAdapter.Fill(this.curp_xa_2023DataSet2.Carreras);
        }

            private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*Aquí validan*/
            try
            {
                AContext.insertaAlumno(
                txtNC1.Text + "09" + txtNC2.Text,
                txtNombre.Text,
                cmbCarrera.SelectedValue.ToString(),
                "admin");
                MessageBox.Show(txtNombre.Text + " insertado exitosamente");
                txtNC1.Text = txtNC2.Text = txtNombre.Text = string.Empty;
                cmbCarrera.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void altas_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'curp_xa_2023DataSet4.Carreras' Puede moverla o quitarla según sea necesario.
            this.carrerasTableAdapter.Fill(this.curp_xa_2023DataSet4.Carreras);

        }
    }
}
