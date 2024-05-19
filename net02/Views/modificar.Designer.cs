namespace net02.Views
{
    partial class modificar
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Carrera = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNC1 = new System.Windows.Forms.TextBox();
            this.curp_xa_2023DataSet3 = new net02.curp_xa_2023DataSet3();
            this.carrerasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrerasTableAdapter = new net02.curp_xa_2023DataSet3TableAdapters.CarrerasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.curp_xa_2023DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(122, 180);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Modificar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.DataSource = this.carrerasBindingSource;
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(97, 102);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(362, 24);
            this.cmbCarrera.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(97, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(442, 22);
            this.txtNombre.TabIndex = 17;
            // 
            // Carrera
            // 
            this.Carrera.AutoSize = true;
            this.Carrera.Location = new System.Drawing.Point(24, 102);
            this.Carrera.Name = "Carrera";
            this.Carrera.Size = new System.Drawing.Size(52, 16);
            this.Carrera.TabIndex = 13;
            this.Carrera.Text = "Carrera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "NC";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNC1
            // 
            this.txtNC1.Location = new System.Drawing.Point(97, 23);
            this.txtNC1.Name = "txtNC1";
            this.txtNC1.Size = new System.Drawing.Size(148, 22);
            this.txtNC1.TabIndex = 21;
            // 
            // curp_xa_2023DataSet3
            // 
            this.curp_xa_2023DataSet3.DataSetName = "curp_xa_2023DataSet3";
            this.curp_xa_2023DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carrerasBindingSource
            // 
            this.carrerasBindingSource.DataMember = "Carreras";
            this.carrerasBindingSource.DataSource = this.curp_xa_2023DataSet3;
            // 
            // carrerasTableAdapter
            // 
            this.carrerasTableAdapter.ClearBeforeFill = true;
            // 
            // modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 225);
            this.Controls.Add(this.txtNC1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Carrera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "modificar";
            this.Text = "modificar";
            this.Load += new System.EventHandler(this.modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.curp_xa_2023DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Carrera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNC1;
        private curp_xa_2023DataSet3 curp_xa_2023DataSet3;
        private System.Windows.Forms.BindingSource carrerasBindingSource;
        private curp_xa_2023DataSet3TableAdapters.CarrerasTableAdapter carrerasTableAdapter;
    }
}