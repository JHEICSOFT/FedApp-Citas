
namespace PlayerUI.Forms_consultorio
{
    partial class AdmisionCita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalCitas = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.filtroconsultorio = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvcitas = new System.Windows.Forms.DataGridView();
            this.IdConsultorio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcitas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalCitas);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.fechaInicio);
            this.panel1.Controls.Add(this.IdConsultorio);
            this.panel1.Controls.Add(this.filtroconsultorio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 88);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalCitas
            // 
            this.lblTotalCitas.AutoSize = true;
            this.lblTotalCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCitas.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTotalCitas.Location = new System.Drawing.Point(622, 21);
            this.lblTotalCitas.Name = "lblTotalCitas";
            this.lblTotalCitas.Size = new System.Drawing.Size(30, 25);
            this.lblTotalCitas.TabIndex = 14;
            this.lblTotalCitas.Text = "...";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.DarkOrange;
            this.label28.Location = new System.Drawing.Point(623, 4);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(106, 20);
            this.label28.TabIndex = 15;
            this.label28.Text = "Total de Citas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PlayerUI.Properties.Resources.informacion;
            this.pictureBox2.Location = new System.Drawing.Point(537, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlayerUI.Properties.Resources.admision;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label27.Location = new System.Drawing.Point(263, 32);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(84, 13);
            this.label27.TabIndex = 7;
            this.label27.Text = "Area Consultorio";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label25.Location = new System.Drawing.Point(409, 32);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "Fecha de Cita";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label24.Location = new System.Drawing.Point(90, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(128, 20);
            this.label24.TabIndex = 9;
            this.label24.Text = "FILTRAR CITAS";
            // 
            // fechaInicio
            // 
            this.fechaInicio.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.fechaInicio.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.fechaInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fechaInicio.CustomFormat = "dd-MM-yyyy";
            this.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaInicio.Location = new System.Drawing.Point(412, 49);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fechaInicio.Size = new System.Drawing.Size(97, 20);
            this.fechaInicio.TabIndex = 11;
            this.fechaInicio.ValueChanged += new System.EventHandler(this.fechaInicio_ValueChanged);
            // 
            // filtroconsultorio
            // 
            this.filtroconsultorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(185)))));
            this.filtroconsultorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtroconsultorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filtroconsultorio.ForeColor = System.Drawing.Color.White;
            this.filtroconsultorio.FormattingEnabled = true;
            this.filtroconsultorio.Items.AddRange(new object[] {
            "TODO"});
            this.filtroconsultorio.Location = new System.Drawing.Point(262, 49);
            this.filtroconsultorio.Name = "filtroconsultorio";
            this.filtroconsultorio.Size = new System.Drawing.Size(144, 21);
            this.filtroconsultorio.TabIndex = 12;
            this.filtroconsultorio.SelectedIndexChanged += new System.EventHandler(this.filtroconsultorio_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvcitas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1116, 571);
            this.panel2.TabIndex = 1;
            // 
            // dgvcitas
            // 
            this.dgvcitas.AllowUserToAddRows = false;
            this.dgvcitas.AllowUserToDeleteRows = false;
            this.dgvcitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvcitas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvcitas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvcitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvcitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcitas.EnableHeadersVisualStyles = false;
            this.dgvcitas.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvcitas.Location = new System.Drawing.Point(0, 0);
            this.dgvcitas.Name = "dgvcitas";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.dgvcitas.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvcitas.Size = new System.Drawing.Size(1116, 571);
            this.dgvcitas.TabIndex = 35;
            // 
            // IdConsultorio
            // 
            this.IdConsultorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(185)))));
            this.IdConsultorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IdConsultorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IdConsultorio.ForeColor = System.Drawing.Color.White;
            this.IdConsultorio.FormattingEnabled = true;
            this.IdConsultorio.Items.AddRange(new object[] {
            "ENFERMERIA",
            "MEDICINA"});
            this.IdConsultorio.Location = new System.Drawing.Point(89, 49);
            this.IdConsultorio.Name = "IdConsultorio";
            this.IdConsultorio.Size = new System.Drawing.Size(167, 21);
            this.IdConsultorio.TabIndex = 12;
            this.IdConsultorio.SelectedIndexChanged += new System.EventHandler(this.IdConsultorio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(90, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Consultorio";
            // 
            // AdmisionCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1116, 659);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdmisionCita";
            this.Text = "AdmisionCita";
            this.Load += new System.EventHandler(this.AdmisionCita_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.ComboBox filtroconsultorio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvcitas;
        private System.Windows.Forms.Label lblTotalCitas;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox IdConsultorio;
    }
}