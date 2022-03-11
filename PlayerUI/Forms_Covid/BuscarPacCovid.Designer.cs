
namespace PlayerUI
{
    partial class BuscarPacCovid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkmedicamentos = new System.Windows.Forms.CheckBox();
            this.checkseguimiento = new System.Windows.Forms.CheckBox();
            this.checkcasos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvcovid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcerrar = new System.Windows.Forms.Label();
            this.panelChildForm.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcovid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.panel1);
            this.panelChildForm.Controls.Add(this.dgvcovid);
            this.panelChildForm.Controls.Add(this.label2);
            this.panelChildForm.Controls.Add(this.lblcerrar);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(810, 679);
            this.panelChildForm.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkmedicamentos);
            this.panel1.Controls.Add(this.checkseguimiento);
            this.panel1.Controls.Add(this.checkcasos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtbuscar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 89);
            this.panel1.TabIndex = 7;
            // 
            // checkmedicamentos
            // 
            this.checkmedicamentos.AutoSize = true;
            this.checkmedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkmedicamentos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkmedicamentos.Location = new System.Drawing.Point(193, 11);
            this.checkmedicamentos.Name = "checkmedicamentos";
            this.checkmedicamentos.Size = new System.Drawing.Size(122, 22);
            this.checkmedicamentos.TabIndex = 5;
            this.checkmedicamentos.Text = "Medicamentos";
            this.checkmedicamentos.UseVisualStyleBackColor = true;
            this.checkmedicamentos.Click += new System.EventHandler(this.checkmedicamentos_Click);
            // 
            // checkseguimiento
            // 
            this.checkseguimiento.AutoSize = true;
            this.checkseguimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkseguimiento.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkseguimiento.Location = new System.Drawing.Point(81, 11);
            this.checkseguimiento.Name = "checkseguimiento";
            this.checkseguimiento.Size = new System.Drawing.Size(106, 22);
            this.checkseguimiento.TabIndex = 5;
            this.checkseguimiento.Text = "Seguimiento";
            this.checkseguimiento.UseVisualStyleBackColor = true;
            this.checkseguimiento.Click += new System.EventHandler(this.checkseguimiento_Click);
            // 
            // checkcasos
            // 
            this.checkcasos.AutoSize = true;
            this.checkcasos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkcasos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkcasos.Location = new System.Drawing.Point(6, 11);
            this.checkcasos.Name = "checkcasos";
            this.checkcasos.Size = new System.Drawing.Size(68, 22);
            this.checkcasos.TabIndex = 5;
            this.checkcasos.Text = "Casos";
            this.checkcasos.UseVisualStyleBackColor = true;
            this.checkcasos.Click += new System.EventHandler(this.checkcasos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese DNI  del paciente";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscar.Location = new System.Drawing.Point(3, 62);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(315, 24);
            this.txtbuscar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(324, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvcovid
            // 
            this.dgvcovid.AllowUserToAddRows = false;
            this.dgvcovid.AllowUserToDeleteRows = false;
            this.dgvcovid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvcovid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvcovid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvcovid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvcovid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcovid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvcovid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcovid.EnableHeadersVisualStyles = false;
            this.dgvcovid.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvcovid.Location = new System.Drawing.Point(8, 146);
            this.dgvcovid.Name = "dgvcovid";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcovid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvcovid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvcovid.Size = new System.Drawing.Size(738, 157);
            this.dgvcovid.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(30, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar pacientes covid";
            // 
            // lblcerrar
            // 
            this.lblcerrar.AutoSize = true;
            this.lblcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcerrar.ForeColor = System.Drawing.Color.White;
            this.lblcerrar.Location = new System.Drawing.Point(3, 3);
            this.lblcerrar.Name = "lblcerrar";
            this.lblcerrar.Size = new System.Drawing.Size(27, 25);
            this.lblcerrar.TabIndex = 0;
            this.lblcerrar.Text = "X";
            this.lblcerrar.Click += new System.EventHandler(this.lblcerrar_Click);
            // 
            // BuscarPacCovid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 679);
            this.Controls.Add(this.panelChildForm);
            this.Name = "BuscarPacCovid";
            this.Text = "Buscar pacientes covid";
            this.Load += new System.EventHandler(this.BuscarPacCovid_Load);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcovid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dgvcovid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkmedicamentos;
        private System.Windows.Forms.CheckBox checkseguimiento;
        private System.Windows.Forms.CheckBox checkcasos;
    }
}