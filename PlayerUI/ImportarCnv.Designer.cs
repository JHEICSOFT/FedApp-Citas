
namespace PlayerUI
{
    partial class ImportarCnv
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Ruta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbhojas = new System.Windows.Forms.ComboBox();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btninsertar = new System.Windows.Forms.Button();
            this.dgvImportar = new System.Windows.Forms.DataGridView();
            this.cNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataHISDataSet1 = new PlayerUI.DataHISDataSet1();
            this.dataHISDataSet = new PlayerUI.DataHISDataSet();
            this.hISBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hISTableAdapter = new PlayerUI.DataHISDataSetTableAdapters.HISTableAdapter();
            this.hISBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cNVTableAdapter = new PlayerUI.DataHISDataSet1TableAdapters.CNVTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHISDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISBindingSource1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ruta
            // 
            this.Ruta.AutoSize = true;
            this.Ruta.Location = new System.Drawing.Point(21, 9);
            this.Ruta.Name = "Ruta";
            this.Ruta.Size = new System.Drawing.Size(30, 13);
            this.Ruta.TabIndex = 0;
            this.Ruta.Text = "Ruta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.btnMostrar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.cbhojas);
            this.panel1.Controls.Add(this.txtruta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Ruta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 60);
            this.panel1.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(635, 33);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(635, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbhojas
            // 
            this.cbhojas.FormattingEnabled = true;
            this.cbhojas.Location = new System.Drawing.Point(57, 33);
            this.cbhojas.Name = "cbhojas";
            this.cbhojas.Size = new System.Drawing.Size(572, 21);
            this.cbhojas.TabIndex = 2;
            this.cbhojas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtruta
            // 
            this.txtruta.Location = new System.Drawing.Point(57, 6);
            this.txtruta.Name = "txtruta";
            this.txtruta.ReadOnly = true;
            this.txtruta.Size = new System.Drawing.Size(572, 20);
            this.txtruta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hojas";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dgvImportar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(989, 516);
            this.panel2.TabIndex = 2;
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(868, 6);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(75, 23);
            this.btninsertar.TabIndex = 3;
            this.btninsertar.Text = "Insertar SQL";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // dgvImportar
            // 
            this.dgvImportar.AllowUserToAddRows = false;
            this.dgvImportar.AllowUserToDeleteRows = false;
            this.dgvImportar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvImportar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvImportar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvImportar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImportar.EnableHeadersVisualStyles = false;
            this.dgvImportar.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvImportar.Location = new System.Drawing.Point(0, 0);
            this.dgvImportar.Name = "dgvImportar";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportar.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvImportar.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvImportar.Size = new System.Drawing.Size(989, 516);
            this.dgvImportar.TabIndex = 36;
            // 
            // cNVBindingSource
            // 
            this.cNVBindingSource.DataMember = "CNV";
            this.cNVBindingSource.DataSource = this.dataHISDataSet1;
            // 
            // dataHISDataSet1
            // 
            this.dataHISDataSet1.DataSetName = "DataHISDataSet1";
            this.dataHISDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataHISDataSet
            // 
            this.dataHISDataSet.DataSetName = "DataHISDataSet";
            this.dataHISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hISBindingSource
            // 
            this.hISBindingSource.DataMember = "HIS";
            this.hISBindingSource.DataSource = this.dataHISDataSet;
            // 
            // hISTableAdapter
            // 
            this.hISTableAdapter.ClearBeforeFill = true;
            // 
            // hISBindingSource1
            // 
            this.hISBindingSource1.DataMember = "HIS";
            this.hISBindingSource1.DataSource = this.dataHISDataSet;
            // 
            // cNVTableAdapter
            // 
            this.cNVTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(185)))));
            this.panel3.Controls.Add(this.btninsertar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 475);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(989, 41);
            this.panel3.TabIndex = 37;
            // 
            // ImportarCnv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ImportarCnv";
            this.Text = "ImportarCnv";
            this.Load += new System.EventHandler(this.ImportarCnv_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHISDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISBindingSource1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Ruta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvImportar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbhojas;
        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Label label1;
        private DataHISDataSet dataHISDataSet;
        private System.Windows.Forms.BindingSource hISBindingSource;
        private DataHISDataSetTableAdapters.HISTableAdapter hISTableAdapter;
        private System.Windows.Forms.BindingSource hISBindingSource1;
        private DataHISDataSet1 dataHISDataSet1;
        private System.Windows.Forms.BindingSource cNVBindingSource;
        private DataHISDataSet1TableAdapters.CNVTableAdapter cNVTableAdapter;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Panel panel3;
    }
}