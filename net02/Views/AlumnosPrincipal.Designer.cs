namespace net02.Views
{
    partial class AlumnosPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carreraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnosOKDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosOKDS = new net02.AlumnosOKDS();
            this.dataTable1TableAdapter = new net02.AlumnosOKDSTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosOKDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosOKDS)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(793, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(789, 67);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(782, 118);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nCDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.carreraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alumnosOKDSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(763, 226);
            this.dataGridView1.TabIndex = 4;
            // 
            // nCDataGridViewTextBoxColumn
            // 
            this.nCDataGridViewTextBoxColumn.DataPropertyName = "NC";
            this.nCDataGridViewTextBoxColumn.HeaderText = "NC";
            this.nCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nCDataGridViewTextBoxColumn.Name = "nCDataGridViewTextBoxColumn";
            this.nCDataGridViewTextBoxColumn.ReadOnly = true;
            this.nCDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // carreraDataGridViewTextBoxColumn
            // 
            this.carreraDataGridViewTextBoxColumn.DataPropertyName = "Carrera";
            this.carreraDataGridViewTextBoxColumn.HeaderText = "Carrera";
            this.carreraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carreraDataGridViewTextBoxColumn.Name = "carreraDataGridViewTextBoxColumn";
            this.carreraDataGridViewTextBoxColumn.ReadOnly = true;
            this.carreraDataGridViewTextBoxColumn.Width = 125;
            // 
            // alumnosOKDSBindingSource
            // 
            this.alumnosOKDSBindingSource.DataMember = "DataTable1";
            this.alumnosOKDSBindingSource.DataSource = this.alumnosOKDS;
            // 
            // alumnosOKDS
            // 
            this.alumnosOKDS.DataSetName = "AlumnosOKDS";
            this.alumnosOKDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // AlumnosPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AlumnosPrincipal";
            this.Text = "AlumnosPrincipal";
            this.Load += new System.EventHandler(this.AlumnosPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosOKDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosOKDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carreraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource alumnosOKDSBindingSource;
        private AlumnosOKDS alumnosOKDS;
        private AlumnosOKDSTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    }
}