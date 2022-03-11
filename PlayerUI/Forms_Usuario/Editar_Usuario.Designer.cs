
namespace PlayerUI.Forms_Usuario
{
    partial class Editar_Usuario
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
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbnivel = new System.Windows.Forms.ComboBox();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.cbmicrored = new System.Windows.Forms.ComboBox();
            this.cbred = new System.Windows.Forms.ComboBox();
            this.cbambito = new System.Windows.Forms.ComboBox();
            this.cbdepartamento = new System.Windows.Forms.ComboBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.Label();
            this.nivel = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Controls.Add(this.label5);
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.cbnivel);
            this.panelChildForm.Controls.Add(this.cbestado);
            this.panelChildForm.Controls.Add(this.cbmicrored);
            this.panelChildForm.Controls.Add(this.cbred);
            this.panelChildForm.Controls.Add(this.cbambito);
            this.panelChildForm.Controls.Add(this.cbdepartamento);
            this.panelChildForm.Controls.Add(this.txtdni);
            this.panelChildForm.Controls.Add(this.btncancelar);
            this.panelChildForm.Controls.Add(this.txtnombre);
            this.panelChildForm.Controls.Add(this.btnactualizar);
            this.panelChildForm.Controls.Add(this.txtpass);
            this.panelChildForm.Controls.Add(this.label4);
            this.panelChildForm.Controls.Add(this.label3);
            this.panelChildForm.Controls.Add(this.label6);
            this.panelChildForm.Controls.Add(this.label2);
            this.panelChildForm.Controls.Add(this.estado);
            this.panelChildForm.Controls.Add(this.nivel);
            this.panelChildForm.Controls.Add(this.dni);
            this.panelChildForm.Controls.Add(this.pass);
            this.panelChildForm.Controls.Add(this.nombre);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(359, 390);
            this.panelChildForm.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(201, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mantenimiento de Usuarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbnivel
            // 
            this.cbnivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cbnivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbnivel.ForeColor = System.Drawing.Color.White;
            this.cbnivel.FormattingEnabled = true;
            this.cbnivel.Items.AddRange(new object[] {
            "Reporteador",
            "Administrador",
            "Enfermeria"});
            this.cbnivel.Location = new System.Drawing.Point(127, 181);
            this.cbnivel.Name = "cbnivel";
            this.cbnivel.Size = new System.Drawing.Size(218, 21);
            this.cbnivel.TabIndex = 3;
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
            this.cbestado.Location = new System.Drawing.Point(127, 208);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(218, 21);
            this.cbestado.TabIndex = 3;
            // 
            // cbmicrored
            // 
            this.cbmicrored.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cbmicrored.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmicrored.ForeColor = System.Drawing.Color.White;
            this.cbmicrored.FormattingEnabled = true;
            this.cbmicrored.Location = new System.Drawing.Point(127, 311);
            this.cbmicrored.Name = "cbmicrored";
            this.cbmicrored.Size = new System.Drawing.Size(218, 21);
            this.cbmicrored.TabIndex = 3;
            // 
            // cbred
            // 
            this.cbred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cbred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbred.ForeColor = System.Drawing.Color.White;
            this.cbred.FormattingEnabled = true;
            this.cbred.Location = new System.Drawing.Point(127, 285);
            this.cbred.Name = "cbred";
            this.cbred.Size = new System.Drawing.Size(218, 21);
            this.cbred.TabIndex = 3;
            // 
            // cbambito
            // 
            this.cbambito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cbambito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbambito.ForeColor = System.Drawing.Color.White;
            this.cbambito.FormattingEnabled = true;
            this.cbambito.Items.AddRange(new object[] {
            "Disa",
            "Red",
            "Microred"});
            this.cbambito.Location = new System.Drawing.Point(127, 233);
            this.cbambito.Name = "cbambito";
            this.cbambito.Size = new System.Drawing.Size(218, 21);
            this.cbambito.TabIndex = 3;
            // 
            // cbdepartamento
            // 
            this.cbdepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cbdepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbdepartamento.ForeColor = System.Drawing.Color.White;
            this.cbdepartamento.FormattingEnabled = true;
            this.cbdepartamento.Location = new System.Drawing.Point(127, 258);
            this.cbdepartamento.Name = "cbdepartamento";
            this.cbdepartamento.Size = new System.Drawing.Size(218, 21);
            this.cbdepartamento.TabIndex = 3;
            // 
            // txtdni
            // 
            this.txtdni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtdni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdni.ForeColor = System.Drawing.Color.White;
            this.txtdni.Location = new System.Drawing.Point(127, 102);
            this.txtdni.MaxLength = 8;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(218, 22);
            this.txtdni.TabIndex = 0;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Teal;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(239, 338);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(106, 37);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.White;
            this.txtnombre.Location = new System.Drawing.Point(127, 128);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(218, 22);
            this.txtnombre.TabIndex = 0;
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Location = new System.Drawing.Point(127, 338);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(106, 37);
            this.btnactualizar.TabIndex = 2;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.White;
            this.txtpass.Location = new System.Drawing.Point(127, 154);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(218, 22);
            this.txtpass.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Microred";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Red";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ambito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departamento";
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.ForeColor = System.Drawing.Color.White;
            this.estado.Location = new System.Drawing.Point(12, 213);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(51, 16);
            this.estado.TabIndex = 1;
            this.estado.Text = "Estado";
            // 
            // nivel
            // 
            this.nivel.AutoSize = true;
            this.nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivel.ForeColor = System.Drawing.Color.White;
            this.nivel.Location = new System.Drawing.Point(12, 186);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(39, 16);
            this.nivel.TabIndex = 1;
            this.nivel.Text = "Nivel";
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni.ForeColor = System.Drawing.Color.White;
            this.dni.Location = new System.Drawing.Point(12, 108);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(31, 16);
            this.dni.TabIndex = 1;
            this.dni.Text = "DNI";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.White;
            this.pass.Location = new System.Drawing.Point(12, 160);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(77, 16);
            this.pass.TabIndex = 1;
            this.pass.Text = "Contraseña";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.White;
            this.nombre.Location = new System.Drawing.Point(12, 134);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(57, 16);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlayerUI.Properties.Resources.user_edit;
            this.pictureBox1.Location = new System.Drawing.Point(127, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Editar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 390);
            this.Controls.Add(this.panelChildForm);
            this.Name = "Editar_Usuario";
            this.Text = "Editar_Usuario";
            this.Load += new System.EventHandler(this.Editar_Usuario_Load);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbnivel;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.ComboBox cbmicrored;
        private System.Windows.Forms.ComboBox cbred;
        private System.Windows.Forms.ComboBox cbambito;
        private System.Windows.Forms.ComboBox cbdepartamento;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label nivel;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}