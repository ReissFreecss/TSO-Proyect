namespace net02.Views
{
    partial class altas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Carrera = new System.Windows.Forms.Label();
            this.txtNC22 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.carrerasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.curp_xa_2023DataSet4 = new net02.curp_xa_2023DataSet4();
            this.curpxa2023DataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.curp_xa_2023DataSet2 = new net02.curp_xa_2023DataSet2();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCarrera = new System.Windows.Forms.Button();
            this.txtNC1 = new System.Windows.Forms.MaskedTextBox();
            this.txtNC11 = new System.Windows.Forms.TextBox();
            this.txtNC2 = new System.Windows.Forms.MaskedTextBox();
            this.carrerasTableAdapter = new net02.curp_xa_2023DataSet4TableAdapters.CarrerasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curp_xa_2023DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curpxa2023DataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curp_xa_2023DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // Carrera
            // 
            this.Carrera.AutoSize = true;
            this.Carrera.Location = new System.Drawing.Point(13, 85);
            this.Carrera.Name = "Carrera";
            this.Carrera.Size = new System.Drawing.Size(52, 16);
            this.Carrera.TabIndex = 2;
            this.Carrera.Text = "Carrera";
            // 
            // txtNC22
            // 
            this.txtNC22.Location = new System.Drawing.Point(538, 7);
            this.txtNC22.Name = "txtNC22";
            this.txtNC22.Size = new System.Drawing.Size(47, 22);
            this.txtNC22.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "09";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(86, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(362, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.DataSource = this.carrerasBindingSource;
            this.cmbCarrera.DisplayMember = "Nombre";
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(86, 85);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(362, 24);
            this.cmbCarrera.TabIndex = 8;
            this.cmbCarrera.ValueMember = "ID";
            // 
            // carrerasBindingSource
            // 
            this.carrerasBindingSource.DataMember = "Carreras";
            this.carrerasBindingSource.DataSource = this.curp_xa_2023DataSet4;
            // 
            // curp_xa_2023DataSet4
            // 
            this.curp_xa_2023DataSet4.DataSetName = "curp_xa_2023DataSet4";
            this.curp_xa_2023DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // curpxa2023DataSet2BindingSource
            // 
            this.curpxa2023DataSet2BindingSource.DataSource = this.curp_xa_2023DataSet2;
            this.curpxa2023DataSet2BindingSource.Position = 0;
            // 
            // curp_xa_2023DataSet2
            // 
            this.curp_xa_2023DataSet2.DataSetName = "curp_xa_2023DataSet2";
            this.curp_xa_2023DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(111, 163);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCarrera
            // 
            this.btnCarrera.Location = new System.Drawing.Point(490, 85);
            this.btnCarrera.Name = "btnCarrera";
            this.btnCarrera.Size = new System.Drawing.Size(75, 23);
            this.btnCarrera.TabIndex = 10;
            this.btnCarrera.Text = "+";
            this.btnCarrera.UseVisualStyleBackColor = true;
            // 
            // txtNC1
            // 
            this.txtNC1.Location = new System.Drawing.Point(72, 7);
            this.txtNC1.Mask = "999999999";
            this.txtNC1.Name = "txtNC1";
            this.txtNC1.Size = new System.Drawing.Size(62, 22);
            this.txtNC1.TabIndex = 11;
            // 
            // txtNC11
            // 
            this.txtNC11.Location = new System.Drawing.Point(484, 7);
            this.txtNC11.Name = "txtNC11";
            this.txtNC11.Size = new System.Drawing.Size(48, 22);
            this.txtNC11.TabIndex = 3;
            // 
            // txtNC2
            // 
            this.txtNC2.Location = new System.Drawing.Point(167, 7);
            this.txtNC2.Mask = "999999999";
            this.txtNC2.Name = "txtNC2";
            this.txtNC2.Size = new System.Drawing.Size(63, 22);
            this.txtNC2.TabIndex = 12;
            // 
            // carrerasTableAdapter
            // 
            this.carrerasTableAdapter.ClearBeforeFill = true;
            // 
            // altas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 201);
            this.Controls.Add(this.txtNC2);
            this.Controls.Add(this.txtNC1);
            this.Controls.Add(this.btnCarrera);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNC22);
            this.Controls.Add(this.txtNC11);
            this.Controls.Add(this.Carrera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "altas";
            this.Text = "altas";
            this.Load += new System.EventHandler(this.altas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curp_xa_2023DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curpxa2023DataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curp_xa_2023DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Carrera;
        private System.Windows.Forms.TextBox txtNC22;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCarrera;
        private System.Windows.Forms.BindingSource curpxa2023DataSet2BindingSource;
        private curp_xa_2023DataSet2 curp_xa_2023DataSet2;
        private System.Windows.Forms.MaskedTextBox txtNC1;
        private System.Windows.Forms.TextBox txtNC11;
        private System.Windows.Forms.MaskedTextBox txtNC2;
        private curp_xa_2023DataSet4 curp_xa_2023DataSet4;
        private System.Windows.Forms.BindingSource carrerasBindingSource;
        private curp_xa_2023DataSet4TableAdapters.CarrerasTableAdapter carrerasTableAdapter;
    }
}