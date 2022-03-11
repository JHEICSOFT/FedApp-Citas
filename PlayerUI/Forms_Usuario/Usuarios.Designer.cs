
namespace PlayerUI
{
    partial class Usuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.nivel = new System.Windows.Forms.Label();
            this.Registrar = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvusuarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbnivel = new System.Windows.Forms.ComboBox();
            this.estado = new System.Windows.Forms.Label();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmicrored = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbred = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbambito = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbdepartamento = new System.Windows.Forms.ComboBox();
            this.cbarea = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbconsultorio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlconsultorio = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnexportar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelChildForm.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlconsultorio.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtdni
            // 
            this.txtdni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtdni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdni.ForeColor = System.Drawing.Color.White;
            this.txtdni.Location = new System.Drawing.Point(98, 10);
            this.txtdni.MaxLength = 8;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(225, 22);
            this.txtdni.TabIndex = 0;
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.White;
            this.txtnombre.Location = new System.Drawing.Point(98, 38);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(225, 22);
            this.txtnombre.TabIndex = 0;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.White;
            this.txtpass.Location = new System.Drawing.Point(98, 65);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(225, 22);
            this.txtpass.TabIndex = 0;
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni.ForeColor = System.Drawing.Color.White;
            this.dni.Location = new System.Drawing.Point(5, 13);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(31, 16);
            this.dni.TabIndex = 1;
            this.dni.Text = "DNI";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.White;
            this.nombre.Location = new System.Drawing.Point(5, 41);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(57, 16);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "Nombre";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.White;
            this.pass.Location = new System.Drawing.Point(5, 68);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(77, 16);
            this.pass.TabIndex = 1;
            this.pass.Text = "Contraseña";
            // 
            // nivel
            // 
            this.nivel.AutoSize = true;
            this.nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivel.ForeColor = System.Drawing.Color.White;
            this.nivel.Location = new System.Drawing.Point(5, 88);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(39, 16);
            this.nivel.TabIndex = 1;
            this.nivel.Text = "Nivel";
            // 
            // Registrar
            // 
            this.Registrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.Location = new System.Drawing.Point(98, 420);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(95, 32);
            this.Registrar.TabIndex = 2;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = false;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.Color.Teal;
            this.btnselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselect.Location = new System.Drawing.Point(196, 420);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(127, 32);
            this.btnselect.TabIndex = 2;
            this.btnselect.Text = "Buscar";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Location = new System.Drawing.Point(98, 458);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(95, 30);
            this.btnactualizar.TabIndex = 2;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btneliminar.Location = new System.Drawing.Point(199, 458);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(124, 30);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.panel2);
            this.panelChildForm.Controls.Add(this.panel1);
            this.panelChildForm.Controls.Add(this.btnexportar);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1333, 569);
            this.panelChildForm.TabIndex = 3;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dgvusuarios);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(336, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 366);
            this.panel2.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mantenimiento de Usuarios Firebase";
            // 
            // dgvusuarios
            // 
            this.dgvusuarios.AllowUserToAddRows = false;
            this.dgvusuarios.AllowUserToDeleteRows = false;
            this.dgvusuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvusuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvusuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvusuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvusuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvusuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column9,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column10,
            this.Column11});
            this.dgvusuarios.EnableHeadersVisualStyles = false;
            this.dgvusuarios.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvusuarios.Location = new System.Drawing.Point(27, 62);
            this.dgvusuarios.MultiSelect = false;
            this.dgvusuarios.Name = "dgvusuarios";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvusuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvusuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvusuarios.Size = new System.Drawing.Size(958, 301);
            this.dgvusuarios.TabIndex = 33;
            this.dgvusuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgusuarios_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlconsultorio);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.btnactualizar);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.btnselect);
            this.panel1.Controls.Add(this.Registrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 569);
            this.panel1.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlayerUI.Properties.Resources.user_edit1;
            this.pictureBox1.Location = new System.Drawing.Point(153, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 9);
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
            "Consultorio",
            "Admision"});
            this.cbnivel.Location = new System.Drawing.Point(98, 90);
            this.cbnivel.Name = "cbnivel";
            this.cbnivel.Size = new System.Drawing.Size(225, 21);
            this.cbnivel.TabIndex = 3;
            this.cbnivel.SelectedIndexChanged += new System.EventHandler(this.cbnivel_SelectedIndexChanged);
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.ForeColor = System.Drawing.Color.White;
            this.estado.Location = new System.Drawing.Point(3, 8);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(51, 16);
            this.estado.TabIndex = 1;
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
            this.cbestado.Location = new System.Drawing.Point(98, 3);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(225, 21);
            this.cbestado.TabIndex = 3;
            this.cbestado.SelectedIndexChanged += new System.EventHandler(this.cbestado_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departamento";
            // 
            // cbmicrored
            // 
            this.cbmicrored.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cbmicrored.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmicrored.ForeColor = System.Drawing.Color.White;
            this.cbmicrored.FormattingEnabled = true;
            this.cbmicrored.Location = new System.Drawing.Point(98, 108);
            this.cbmicrored.Name = "cbmicrored";
            this.cbmicrored.Size = new System.Drawing.Size(225, 21);
            this.cbmicrored.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ambito";
            // 
            // cbred
            // 
            this.cbred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cbred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbred.ForeColor = System.Drawing.Color.White;
            this.cbred.FormattingEnabled = true;
            this.cbred.Location = new System.Drawing.Point(98, 82);
            this.cbred.Name = "cbred";
            this.cbred.Size = new System.Drawing.Size(225, 21);
            this.cbred.TabIndex = 3;
            this.cbred.SelectedIndexChanged += new System.EventHandler(this.cbred_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Red";
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
            this.cbambito.Location = new System.Drawing.Point(98, 28);
            this.cbambito.Name = "cbambito";
            this.cbambito.Size = new System.Drawing.Size(225, 21);
            this.cbambito.TabIndex = 3;
            this.cbambito.SelectedIndexChanged += new System.EventHandler(this.cbambito_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Microred";
            // 
            // cbdepartamento
            // 
            this.cbdepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cbdepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbdepartamento.ForeColor = System.Drawing.Color.White;
            this.cbdepartamento.FormattingEnabled = true;
            this.cbdepartamento.Location = new System.Drawing.Point(98, 53);
            this.cbdepartamento.Name = "cbdepartamento";
            this.cbdepartamento.Size = new System.Drawing.Size(225, 21);
            this.cbdepartamento.TabIndex = 3;
            this.cbdepartamento.SelectedIndexChanged += new System.EventHandler(this.cbambito_SelectedIndexChanged);
            // 
            // cbarea
            // 
            this.cbarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cbarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbarea.ForeColor = System.Drawing.Color.White;
            this.cbarea.FormattingEnabled = true;
            this.cbarea.Items.AddRange(new object[] {
            "ENFERMERIA",
            "MEDICINA"});
            this.cbarea.Location = new System.Drawing.Point(98, 9);
            this.cbarea.Name = "cbarea";
            this.cbarea.Size = new System.Drawing.Size(225, 21);
            this.cbarea.TabIndex = 3;
            this.cbarea.SelectedIndexChanged += new System.EventHandler(this.cbarea_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Area";
            // 
            // cbconsultorio
            // 
            this.cbconsultorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cbconsultorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbconsultorio.ForeColor = System.Drawing.Color.White;
            this.cbconsultorio.FormattingEnabled = true;
            this.cbconsultorio.Location = new System.Drawing.Point(98, 42);
            this.cbconsultorio.Name = "cbconsultorio";
            this.cbconsultorio.Size = new System.Drawing.Size(225, 21);
            this.cbconsultorio.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Consultorio";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbred);
            this.panel3.Controls.Add(this.cbambito);
            this.panel3.Controls.Add(this.cbmicrored);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cbdepartamento);
            this.panel3.Controls.Add(this.cbestado);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.estado);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 139);
            this.panel3.TabIndex = 7;
            // 
            // pnlconsultorio
            // 
            this.pnlconsultorio.Controls.Add(this.cbconsultorio);
            this.pnlconsultorio.Controls.Add(this.label8);
            this.pnlconsultorio.Controls.Add(this.label7);
            this.pnlconsultorio.Controls.Add(this.cbarea);
            this.pnlconsultorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlconsultorio.Location = new System.Drawing.Point(0, 202);
            this.pnlconsultorio.Name = "pnlconsultorio";
            this.pnlconsultorio.Size = new System.Drawing.Size(336, 73);
            this.pnlconsultorio.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.nivel);
            this.panel5.Controls.Add(this.cbnivel);
            this.panel5.Controls.Add(this.pass);
            this.panel5.Controls.Add(this.txtpass);
            this.panel5.Controls.Add(this.nombre);
            this.panel5.Controls.Add(this.txtnombre);
            this.panel5.Controls.Add(this.dni);
            this.panel5.Controls.Add(this.txtdni);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 81);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(336, 121);
            this.panel5.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(336, 81);
            this.panel6.TabIndex = 10;
            // 
            // btnexportar
            // 
            this.btnexportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.Location = new System.Drawing.Point(342, 369);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(95, 32);
            this.btnexportar.TabIndex = 2;
            this.btnexportar.Text = "Excel";
            this.btnexportar.UseVisualStyleBackColor = false;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DNI";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column1.Width = 55;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOMBRE";
            this.Column2.Name = "Column2";
            this.Column2.Width = 86;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PASS";
            this.Column3.Name = "Column3";
            this.Column3.Width = 61;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "NIVEL";
            this.Column4.Name = "Column4";
            this.Column4.Width = 67;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ESTADO";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "AMBITO";
            this.Column9.Name = "Column9";
            this.Column9.Width = 78;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DEPARTAMENTO";
            this.Column6.Name = "Column6";
            this.Column6.Width = 132;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "RED";
            this.Column7.Name = "Column7";
            this.Column7.Width = 57;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "MICRORED";
            this.Column8.Name = "Column8";
            this.Column8.Width = 101;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "AREA";
            this.Column10.Name = "Column10";
            this.Column10.Width = 65;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "CONSULTORIO";
            this.Column11.Name = "Column11";
            this.Column11.Width = 122;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 569);
            this.Controls.Add(this.panelChildForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panelChildForm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlconsultorio.ResumeLayout(false);
            this.pnlconsultorio.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label nivel;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.ComboBox cbdepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmicrored;
        private System.Windows.Forms.ComboBox cbred;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbnivel;
        private System.Windows.Forms.ComboBox cbambito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvusuarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbconsultorio;
        private System.Windows.Forms.ComboBox cbarea;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlconsultorio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnexportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}