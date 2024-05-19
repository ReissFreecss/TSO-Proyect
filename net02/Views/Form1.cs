    using net02.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Drawing.Text;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace net02
    {
        public partial class Form1 : Form
        {
            private readonly string textNombre = "Escribe tu Nombre(s)";
            private readonly string textAP1 = "Primer Apellido";
            private readonly string textAP2 = "Segundo Apellido (Opcional)";

            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e) {

                // MessageBox. Show(Catalogos. Entidades. Count. ToString());
                llenarCombo(cmbEstado, Catalogos.Entidades, btnGenerar, true);
                llenarCombo(cmbGenero, new Dictionary<string, string>() {
                    { "H","Masculino"},
                    { "M", "Femenino"},
                    { "X", "LGBT"}
                    }, btnGenerar, false);

                textInicial(txtNombre, Properties.Resources.textoNombre);
                textInicial(txtAP1, textAP1);
                textInicial(txtAP2, textAP2);
            }


        private void textInicial(TextBox txt, string text)
        {
            if (txt.Text.Trim().Length == 0)
            {
                txt.CharacterCasing = CharacterCasing.Normal;
                txt.ForeColor = Color.Silver;
                txt.Text = text;

            }

        }


        private void textCambia(TextBox txt)
        {
            if (txt.ForeColor != Color.Black)
            {
                txt.CharacterCasing = CharacterCasing.Upper;
                txt.ForeColor = Color.Black;
                txt.Text = String.Empty;
            }
        }

                    /*txtNombre.CharacterCasing = CharacterCasing.Normal;
                    txtNombre.ForeColor = Color.Silver;
                    txtNombre.Text = textNombre;

                    txtAP1.CharacterCasing = CharacterCasing.Normal;
                    txtAP1.ForeColor = Color.Silver;
                    txtAP1.Text = textAP1;

                    txtAP2.CharacterCasing = CharacterCasing.Normal;
                    txtAP2.ForeColor = Color.Silver;
                    txtAP2.Text = "Segundo Apellido (Opcional)";*/


                

            /*Todo metodo que ejecurte operaciones siempre debe ser PRIVATE*/



            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void label6_Click(object sender, EventArgs e)
            {

            }


            private void txtNombre_Enter(object sender, EventArgs e)
            {
                textCambia(txtNombre);
            }

            private void txtNombre_Leave(object sender, EventArgs e)
            {
                textInicial(txtNombre, Properties.Resources.textoNombre);

            }

            private void txtAP1_Enter(object sender, EventArgs e)
            {
                textCambia(txtAP1);
            }

            private void txtAP1_Leave(object sender, EventArgs e)
            {
                textInicial(txtAP1, textAP1);
            }

            private void txtAP2_Enter(object sender, EventArgs e)
            {
            textCambia(txtAP2);
            }

            private void txtAP2_Leave(object sender, EventArgs e)
            {
            textInicial(txtAP2, textAP2);

            }

            private void llenarCombo(ComboBox cmb, Dictionary<string, string> datos, Button btn, Boolean ordenado)
            {
                cmb.DataSource = null;
                cmb.Items.Clear();
                if (datos != null && datos.Count > 0)
                {
                    cmb.Sorted = ordenado;
                    cmb.DataSource = new BindingSource(datos, null);
                    cmb.DisplayMember = "Value";
                    cmb.ValueMember = "Key";
                    cmb.Enabled = true;
                    if (btn.Enabled)
                    {
                        btn.Enabled = true;
                    }
                }
                else
                {
                    cmb.Items.Add("No hay datos");
                    cmb.Enabled = false;
                    cmb.Enabled = false;

                }
                cmb.SelectedIndex = 0;
            }

            private void btnGenerar_Click(object sender, EventArgs e)
            {
            /* 1. Primer Momento: Al recibir la información */
            if (txtNombre.Text.Trim().Length > 0) {

                /* TIP: no enlacen validaciones, anidenlas */
                if (txtAP1.Text.Trim().Length > 0 || txtAP2.Text.Trim().Length > 0)
                {
                    try
                    {
                        /* aqui vamos a chambear */
                        RFCModel rfc = new RFCModel(txtNombre.Text, txtAP1.Text, txtAP2.Text, dtFecha.Value);

                        MessageBox.Show(rfc.NombreN + " " + rfc.APN + " " + rfc.AMN + "\n"
                        + rfc.RFC);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    /* TIP: Siempre guien al usuario */
                    MessageBox.Show("Escribe por lo menos un apellido");
                    txtAP1.Focus();
                }

                    } else {
                        /* TIP: Siempre guien al usuario */
                        MessageBox.Show("Escribe algo en el campo nombre");
                        txtNombre.Focus();
                    }
                }

                        private void txtNombre_TextChanged(object sender, EventArgs e)
            {

            }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
            !char.IsPunctuation(e.KeyChar) && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
                return;
            }
        }

        //Construir métodos para evitar repetir código, también los ifs
    }
    }



