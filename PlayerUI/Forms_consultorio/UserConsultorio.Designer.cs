
namespace PlayerUI.Forms_consultorio
{
    partial class UserConsultorio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtfechCreaci = new System.Windows.Forms.DateTimePicker();
            this.dtfechNac = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.btnselect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.nivel = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.Label();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbconsultorio = new System.Windows.Forms.ComboBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.cbAreaCons = new System.Windows.Forms.ComboBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(185)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 26);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.dtfechCreaci);
            this.panel2.Controls.Add(this.dtfechNac);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnactualizar);
            this.panel2.Controls.Add(this.nombre);
            this.panel2.Controls.Add(this.btneliminar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pass);
            this.panel2.Controls.Add(this.btnselect);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dni);
            this.panel2.Controls.Add(this.btnregistrar);
            this.panel2.Controls.Add(this.nivel);
            this.panel2.Controls.Add(this.estado);
            this.panel2.Controls.Add(this.cbestado);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbconsultorio);
            this.panel2.Controls.Add(this.txtpass);
            this.panel2.Controls.Add(this.cbAreaCons);
            this.panel2.Controls.Add(this.txtuser);
            this.panel2.Controls.Add(this.txtdocumento);
            this.panel2.Controls.Add(this.txtnombre);
            this.panel2.Controls.Add(this.txtdni);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 430);
            this.panel2.TabIndex = 1;
            // 
            // dtfechCreaci
            // 
            this.dtfechCreaci.CustomFormat = "dd-MM-yyyy";
            this.dtfechCreaci.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfechCreaci.Location = new System.Drawing.Point(131, 268);
            this.dtfechCreaci.Name = "dtfechCreaci";
            this.dtfechCreaci.Size = new System.Drawing.Size(225, 20);
            this.dtfechCreaci.TabIndex = 31;
            // 
            // dtfechNac
            // 
            this.dtfechNac.CustomFormat = "dd-MM-yyyy";
            this.dtfechNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfechNac.Location = new System.Drawing.Point(131, 140);
            this.dtfechNac.Name = "dtfechNac";
            this.dtfechNac.Size = new System.Drawing.Size(225, 20);
            this.dtfechNac.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlayerUI.Properties.Resources.user_edit1;
            this.pictureBox1.Location = new System.Drawing.Point(212, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Location = new System.Drawing.Point(131, 359);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(95, 30);
            this.btnactualizar.TabIndex = 21;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.White;
            this.nombre.Location = new System.Drawing.Point(21, 118);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(57, 16);
            this.nombre.TabIndex = 18;
            this.nombre.Text = "Nombre";
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btneliminar.Location = new System.Drawing.Point(232, 359);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(124, 30);
            this.btneliminar.TabIndex = 20;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Pass";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.White;
            this.pass.Location = new System.Drawing.Point(21, 169);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(37, 16);
            this.pass.TabIndex = 17;
            this.pass.Text = "User";
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.Color.Teal;
            this.btnselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselect.Location = new System.Drawing.Point(276, 68);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(80, 22);
            this.btnselect.TabIndex = 19;
            this.btnselect.Text = "Buscar";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "N° Documento";
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni.ForeColor = System.Drawing.Color.White;
            this.dni.Location = new System.Drawing.Point(21, 71);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(31, 16);
            this.dni.TabIndex = 16;
            this.dni.Text = "DNI";
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Location = new System.Drawing.Point(131, 321);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(225, 32);
            this.btnregistrar.TabIndex = 22;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // nivel
            // 
            this.nivel.AutoSize = true;
            this.nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivel.ForeColor = System.Drawing.Color.White;
            this.nivel.Location = new System.Drawing.Point(21, 142);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(105, 16);
            this.nivel.TabIndex = 14;
            this.nivel.Text = "Fec. Nacimiento";
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.ForeColor = System.Drawing.Color.White;
            this.estado.Location = new System.Drawing.Point(21, 296);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(51, 16);
            this.estado.TabIndex = 15;
            this.estado.Text = "Estado";
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
            this.cbestado.Location = new System.Drawing.Point(131, 294);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(225, 21);
            this.cbestado.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Area Consultorio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Consultorio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fec. Creación";
            // 
            // cbconsultorio
            // 
            this.cbconsultorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cbconsultorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbconsultorio.ForeColor = System.Drawing.Color.White;
            this.cbconsultorio.FormattingEnabled = true;
            this.cbconsultorio.Items.AddRange(new object[] {
            "ENFERMERIA",
            "MEDICINA"});
            this.cbconsultorio.Location = new System.Drawing.Point(131, 218);
            this.cbconsultorio.Name = "cbconsultorio";
            this.cbconsultorio.Size = new System.Drawing.Size(225, 21);
            this.cbconsultorio.TabIndex = 27;
            this.cbconsultorio.SelectedIndexChanged += new System.EventHandler(this.cbconsultorio_SelectedIndexChanged);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.White;
            this.txtpass.Location = new System.Drawing.Point(131, 192);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(225, 22);
            this.txtpass.TabIndex = 8;
            // 
            // cbAreaCons
            // 
            this.cbAreaCons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cbAreaCons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAreaCons.ForeColor = System.Drawing.Color.White;
            this.cbAreaCons.FormattingEnabled = true;
            this.cbAreaCons.Location = new System.Drawing.Point(131, 242);
            this.cbAreaCons.Name = "cbAreaCons";
            this.cbAreaCons.Size = new System.Drawing.Size(225, 21);
            this.cbAreaCons.TabIndex = 28;
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.White;
            this.txtuser.Location = new System.Drawing.Point(131, 166);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(225, 22);
            this.txtuser.TabIndex = 8;
            // 
            // txtdocumento
            // 
            this.txtdocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtdocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumento.ForeColor = System.Drawing.Color.White;
            this.txtdocumento.Location = new System.Drawing.Point(131, 91);
            this.txtdocumento.MaxLength = 8;
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(225, 22);
            this.txtdocumento.TabIndex = 7;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.White;
            this.txtnombre.Location = new System.Drawing.Point(131, 115);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(225, 22);
            this.txtnombre.TabIndex = 9;
            // 
            // txtdni
            // 
            this.txtdni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtdni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdni.ForeColor = System.Drawing.Color.White;
            this.txtdni.Location = new System.Drawing.Point(131, 68);
            this.txtdni.MaxLength = 8;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(139, 22);
            this.txtdni.TabIndex = 7;
            // 
            // UserConsultorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 456);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserConsultorio";
            this.Text = "UserCita";
            this.Load += new System.EventHandler(this.UserConsultorio_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Label nivel;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbconsultorio;
        private System.Windows.Forms.ComboBox cbAreaCons;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.DateTimePicker dtfechNac;
        private System.Windows.Forms.DateTimePicker dtfechCreaci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdocumento;
    }
}