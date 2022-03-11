using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Runtime.InteropServices;
namespace PlayerUI
{
    public partial class MAIN : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static string datosusuarios = LoginFed.datosusurios;
        public static string usuario;
        public static string url;
      
        

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "lb9bGeiKqFTj7OqRuiZIEkqy0fte0P8Hu2jyXAU5",
            BasePath = "https://usuariosfed-1b8f8-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        
        public void mis_datos()
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
                if (client != null)
                {
                    this.CenterToScreen();
                    //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                    this.WindowState = FormWindowState.Normal;
                }
            }
            catch
            {
                MessageBox.Show("No tiene coneccion a Internet");
            }

            client = new FireSharp.FirebaseClient(fcon);
            FirebaseResponse resp2 = client.Get("Usuarios/" + LoginFed.datosusurios);
            usuariosFirebase resultado = resp2.ResultAs<usuariosFirebase>();
            /// variable para mostrar red si su microred es todo--

            string ambito = resultado.cbambito;
            if (ambito=="Disa")
            {
                lblnombre.Text = resultado.txtnombre;
                lblmicrored.Text = resultado.cbambito;
                lblnivel.Text = resultado.cbnivel;
            }

            else if(ambito=="Red")
            {
                lblnombre.Text = resultado.txtnombre;
                lblmicrored.Text = resultado.cbred;
                lblnivel.Text = resultado.cbnivel;
            }
            else
            {
                lblnombre.Text =resultado.txtnombre;
                lblmicrored.Text = resultado.cbmicrored;
                lblnivel.Text = resultado.cbnivel;
            }
            // mostrara de en el panel menu de acuerdo a su nivel de usuario
            if (resultado.cbnivel== "Reporteador")
            {
                btnusuarios.Visible = false;
                btnmantenimiento.Visible = false;
                btnenfermeria.Visible = false;
            }
            else if (resultado.cbnivel=="Enfermeria")
            {
                btnusuarios.Visible = false;
                btnPlaylist.Visible = false;
                btnmantenimiento.Visible = false;
                btnenfermeria.Visible = true;
                btnmantenimiento.Visible = false;
            }
            else if (resultado.cbnivel == "Admision")
            {
                btnusuarios.Visible = false;
                btnPlaylist.Visible = false;
                btnmantenimiento.Visible = false;
                btnenfermeria.Visible = true;
                btnmantenimiento.Visible = false;
                btnMedia.Visible = false;
                btngestante.Visible = false;
                btnhelp.Visible = false;
                btndescargar.Visible = false;

            }

            // este codigo es para mostrar las opciones de actualizacion y sms 
            client = new FireSharp.FirebaseClient(fcon);
            FirebaseResponse resp3 = client.Get("MantenimientoApp/" + LoginFed.idfed);
            mantenimientoFirebase resultado1 = resp3.ResultAs<mantenimientoFirebase>();

            string id = resultado1.id;
            string id_version = resultado1.version;
            string tipo = resultado1.mantenimineto;
            url = resultado1.link;
            if (id == lbl_id.Text && tipo == "Actualización" && resultado1.estado == "Activo" && id_version != lblversion.Text)
            {
                btnactualizar.Visible = true;
                btnactualizar.Text = "Actualización Disponible " + id_version;

                //ponstrara el panel de de mensaje en el form: MAIN
                panelsms.Visible = true;
                lbltitulo.Text = "Tipo: " + resultado1.mantenimineto;
                lblmensaje.Text = resultado1.mensaje;
                lbllinkmensaje.Text = "Link: " + url;
                lblfechamensaje.Text = "Fecha del Mensaje: " + resultado1.fecha;
            }
            else
            {
                btnactualizar.Visible = false;
                panelsms.Visible = false;
            }

        }


        public MAIN()
        {
            InitializeComponent();
            hideSubMenu();
            mis_datos();
        }

        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelgestante.Visible = false;
            panelmoduloenfer.Visible = false;
           
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms_ninio.RNBAJOPESO());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // aqui estoy llamando al formulario del indicador 2

            openChildForm(new INDICADOR2());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new INDICADOR3());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms_Indicadores.GestanteVifPosi());
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
            
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms_Covid.Covid());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            Usuarios login = new Usuarios();
            login.ShowDialog();   
          
            //  openChildForm(new Usuarios());
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
           openChildForm(new Buscar());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //openChildForm(new DescPadronNominal());
            //..
            //your codes
            //..
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1MW6sc3d4hN3l8SD-ERGMPQ1KgPUoOiYk?usp=sharing");
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //este codigo sirve para adaptar el tamaño a cualquier pantalla
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            lbl_id.Visible = false;
        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnmaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new BuscarPacCovid());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Forms_Mujer.Gesta4Exmanes());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Forms_ninio.RecienNacTamiza());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btngestante_Click(object sender, EventArgs e)
        {
            showSubMenu(panelgestante);

        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnmantenimiento_Click(object sender, EventArgs e)
        {
            openChildForm(new MantenimientoApp());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(url);
        }

        private void cerrarsms_Click(object sender, EventArgs e)
        {
            panelsms.Visible = false;
        }

        private void btnCredCompleto_Click(object sender, EventArgs e)
        {
            openChildForm(new Indicadores.credCompleto());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Forms_ninio.CredQuintilesCompleto());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Forms_Indicadores.UsuariaPpffViole());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Forms_Mujer.GestaQuinComple());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void lblprofile_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms_Usuario.Editar_Usuario());
        }

        private void btnvacuna_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms_consultorio.EnfermeriaVacuna());
            hideSubMenu();
        }

        private void btnenfermeria_Click(object sender, EventArgs e)
        {
            showSubMenu(panelmoduloenfer);
        }

        private void lbllinkmensaje_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(url);
        }

        private void btnhelp_Click_1(object sender, EventArgs e)
        {
            openChildForm(new DescPadronNominal());
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms_consultorio.citasNurse());
            hideSubMenu();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Forms_consultorio.AdmisionCita());
            hideSubMenu();
        }

        private void btncred_Click(object sender, EventArgs e)
        {
            Forms_consultorio.UserConsultorio usuariCitas = new Forms_consultorio.UserConsultorio();
            usuariCitas.ShowDialog();
            
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            openChildForm(new ImportarCnv());
            hideSubMenu();
        }
    }
}
