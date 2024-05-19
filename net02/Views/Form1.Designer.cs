namespace net02
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAP1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAP2 = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre(s):";
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.Color.Silver;
            this.txtNombre.Location = new System.Drawing.Point(168, 26);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(265, 22);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtAP1
            // 
            this.txtAP1.Location = new System.Drawing.Point(168, 68);
            this.txtAP1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAP1.Name = "txtAP1";
            this.txtAP1.Size = new System.Drawing.Size(265, 22);
            this.txtAP1.TabIndex = 8;
            this.txtAP1.Enter += new System.EventHandler(this.txtAP1_Enter);
            this.txtAP1.Leave += new System.EventHandler(this.txtAP1_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primer Apellido:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundo Apellido:";
            // 
            // txtAP2
            // 
            this.txtAP2.Location = new System.Drawing.Point(168, 116);
            this.txtAP2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAP2.Name = "txtAP2";
            this.txtAP2.Size = new System.Drawing.Size(265, 22);
            this.txtAP2.TabIndex = 9;
            this.txtAP2.Enter += new System.EventHandler(this.txtAP2_Enter);
            this.txtAP2.Leave += new System.EventHandler(this.txtAP2_Leave);
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(168, 164);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(265, 22);
            this.dtFecha.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Género";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(168, 213);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(200, 24);
            this.cmbGenero.Sorted = true;
            this.cmbGenero.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(168, 263);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 24);
            this.cmbEstado.TabIndex = 12;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(725, 119);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 28);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(725, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGenerar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1067, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.txtAP2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAP1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "EDC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAP2;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button button1;
    }
}

