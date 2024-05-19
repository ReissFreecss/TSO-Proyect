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
    public partial class AlumnosPrincipal : Form
    {
        public AlumnosPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            altas F = new altas();
            F.ShowDialog();
          //  this.dataTableAlumnosTableAdapter.Fill(this.alumnosDataSet.DataTableAlumnos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            for (int x=0; x< dataGridView1.SelectedRows.Count; x++) {
                DialogResult d = MessageBox.Show(
                    "Confirmación",
                    "¿Deseas borrar a " + dataGridView1.SelectedRows[x].Cells[1].Value,
                    MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    AContext.borraAlumno(dataGridView1.SelectedRows[x].Cells[0].Value.ToString());
                    MessageBox.Show("El Alumno " + dataGridView1.SelectedRows[x].Cells[1].Value + "fue borrado exitosamente");
                }
                
            }
         //   this.dataTableAlumnosTableAdapter.Fill(this.alumnosDataSet.DataTableAlumnos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modificar f = new modificar(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            f.ShowDialog();
        //    this.dataTableAlumnosTableAdapter.Fill(this.alumnosDataSet.DataTableAlumnos);
            
        }

        private void AlumnosPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'alumnosOKDS.DataTable1' Puede moverla o quitarla según sea necesario.
            this.dataTable1TableAdapter.Fill(this.alumnosOKDS.DataTable1);
            // TODO: esta línea de código carga datos en la tabla 'alumnosDataSet.DataTableAlumnos' Puede moverla o quitarla según sea necesario.
           // this.dataTableAlumnosTableAdapter.Fill(this.alumnosDataSet.DataTableAlumnos);

        }
    }
}
