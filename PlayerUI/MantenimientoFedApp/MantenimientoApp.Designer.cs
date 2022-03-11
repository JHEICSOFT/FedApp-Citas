namespace PlayerUI
{
    partial class MantenimientoApp
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
            this.txtidmantenimiento = new System.Windows.Forms.TextBox();
            this.txtlink = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Registrar = new System.Windows.Forms.Button();
            this.cbmantenimiento = new System.Windows.Forms.ComboBox();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtversion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtidmantenimiento
            // 
            this.txtidmantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtidmantenimiento.Enabled = false;
            this.txtidmantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidmantenimiento.ForeColor = System.Drawing.Color.White;
            this.txtidmantenimiento.Location = new System.Drawing.Point(124, 49);
            this.txtidmantenimiento.Name = "txtidmantenimiento";
            this.txtidmantenimiento.Size = new System.Drawing.Size(96, 22);
            this.txtidmantenimiento.TabIndex = 3;
            this.txtidmantenimiento.Text = "FedApp";
            // 
            // txtlink
            // 
            this.txtlink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlink.ForeColor = System.Drawing.Color.White;
            this.txtlink.Location = new System.Drawing.Point(124, 243);
            this.txtlink.Multiline = true;
            this.txtlink.Name = "txtlink";
            this.txtlink.Size = new System.Drawing.Size(383, 48);
            this.txtlink.TabIndex = 4;
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni.ForeColor = System.Drawing.Color.White;
            this.dni.Location = new System.Drawing.Point(329, 52);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(36, 16);
            this.dni.TabIndex = 5;
            this.dni.Text = "Tipo";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.White;
            this.pass.Location = new System.Drawing.Point(12, 249);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(57, 16);
            this.pass.TabIndex = 6;
            this.pass.Text = "Link (url)";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.White;
            this.nombre.Location = new System.Drawing.Point(348, 86);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(51, 16);
            this.nombre.TabIndex = 7;
            this.nombre.Text = "Estado";
            this.nombre.Click += new System.EventHandler(this.nombre_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtfecha);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Registrar);
            this.panel1.Controls.Add(this.cbmantenimiento);
            this.panel1.Controls.Add(this.cbestado);
            this.panel1.Controls.Add(this.txtmensaje);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.txtversion);
            this.panel1.Controls.Add(this.txtidmantenimiento);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtlink);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dni);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 350);
            this.panel1.TabIndex = 8;
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(252, 84);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(96, 20);
            this.dtfecha.TabIndex = 10;
            this.dtfecha.Value = new System.DateTime(2021, 9, 6, 18, 30, 8, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(370, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(247, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Registrar
            // 
            this.Registrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.Location = new System.Drawing.Point(124, 297);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(117, 37);
            this.Registrar.TabIndex = 9;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = false;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // cbmantenimiento
            // 
            this.cbmantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cbmantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmantenimiento.ForeColor = System.Drawing.Color.White;
            this.cbmantenimiento.FormattingEnabled = true;
            this.cbmantenimiento.Items.AddRange(new object[] {
            "Actualización",
            "Mensaje"});
            this.cbmantenimiento.Location = new System.Drawing.Point(371, 50);
            this.cbmantenimiento.Name = "cbmantenimiento";
            this.cbmantenimiento.Size = new System.Drawing.Size(136, 21);
            this.cbmantenimiento.TabIndex = 8;
            // 
            // cbestado
            // 
            this.cbestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cbestado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbestado.ForeColor = System.Drawing.Color.White;
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbestado.Location = new System.Drawing.Point(405, 84);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(102, 21);
            this.cbestado.TabIndex = 8;
            // 
            // txtmensaje
            // 
            this.txtmensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmensaje.ForeColor = System.Drawing.Color.White;
            this.txtmensaje.Location = new System.Drawing.Point(124, 109);
            this.txtmensaje.Multiline = true;
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(383, 128);
            this.txtmensaje.TabIndex = 3;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.White;
            this.txtid.Location = new System.Drawing.Point(252, 49);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(71, 22);
            this.txtid.TabIndex = 3;
            // 
            // txtversion
            // 
            this.txtversion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtversion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtversion.ForeColor = System.Drawing.Color.White;
            this.txtversion.Location = new System.Drawing.Point(123, 83);
            this.txtversion.Name = "txtversion";
            this.txtversion.Size = new System.Drawing.Size(71, 22);
            this.txtversion.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(4, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RosyBrown;
            this.label5.Location = new System.Drawing.Point(44, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Registra o modifica mensajes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id mantenimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(200, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mensaje";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(226, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Version";
            // 
            // MantenimientoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(518, 350);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantenimientoApp";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "MantenimientoApp";
            this.Load += new System.EventHandler(this.MantenimientoApp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtidmantenimiento;
        private System.Windows.Forms.TextBox txtlink;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.ComboBox cbmantenimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmensaje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtversion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
    }
}