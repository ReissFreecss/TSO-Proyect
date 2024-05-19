using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net02.Views
{
    public partial class modificar : Form
    {
        private string NC;
        public modificar(string nC)
        {
            InitializeComponent();
            if (nC== null || nC.Trim() == string.Empty)
            {
                this.Close();
            }
            NC = nC;
        }

        private void modificar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'curp_xa_2023DataSet3.Carreras' Puede moverla o quitarla según sea necesario.
            this.carrerasTableAdapter.Fill(this.curp_xa_2023DataSet3.Carreras);
            cmbCarrera.ValueMember = "ID";
            txtNC1.Text = NC;
            txtNC1.Enabled = true;
            SqlConnection conn = new SqlConnection("Data Source=WICHOLIK\\SQLEXPRESS;Initial Catalog=curp_xa_2023;" +
            "Persist Security Info=True;User ID=sa;Password=toonlinkike;" +
            "Encrypt=False;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand(
                "SELECT Nombre,IDCarrera FROM Alumnos WHERE NC = '"+NC+"' AND Borrado = 0;", conn
                );
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                this.Close ();
            }
            while (reader.Read())
            {
                txtNombre.Text = reader.GetString(0);
                cmbCarrera.SelectedValue = reader.GetInt32(1).ToString();
            }
            reader.Close();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=WICHOLIK\\SQLEXPRESS;Initial Catalog=curp_xa_2023;" +
            "Persist Security Info=True;User ID=sa;Password=toonlinkike;" +
            "Encrypt=False;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand(
                "UPDATE Alumnos SET Nombre='"+txtNombre.Text+
                "', IDCarrera="+cmbCarrera.SelectedValue+" WHERE NC='"+NC+"';", conn
                );
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("El Alumno " + txtNombre.Text + "fue modificado exitosamente");

        }
    }
}
