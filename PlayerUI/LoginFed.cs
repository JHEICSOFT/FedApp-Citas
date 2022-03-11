using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace PlayerUI
{
    public partial class LoginFed : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static string datosusurios;
        public static string idfed;
        public static string dni;

        public static string estadosesion;///si esta en 1 inicio de sesion offline si es null inicio de sesion online

        /// </////////variables ofline////>
        public static string dniOfline;
        public static string nombreOffline;
        public static string consOffline;
        public static string areaConsulOffline;
        /// </////////variables ofline////>

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "lb9bGeiKqFTj7OqRuiZIEkqy0fte0P8Hu2jyXAU5",
            BasePath = "https://usuariosfed-1b8f8-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public LoginFed()
        {
            InitializeComponent();
        }

        private void LoginFed_Load(object sender, EventArgs e)
        {
            linkLabel2.Visible = false;

            try
            {
                client = new FireSharp.FirebaseClient(fcon);
                if (client !=null)
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
        }

        public static string usernamepass;
        
        public void loginFed()
        {
            if (string.IsNullOrEmpty(txtusuario.Text) || string.IsNullOrEmpty(txtpass.Text))
            {
                MessageBox.Show("Ingrese su usuario o Contraseña");
            }
            else
            {
                FirebaseResponse response = client.Get("Usuarios/");
                Dictionary<string, usuariosFirebase> result = response.ResultAs<Dictionary<string, usuariosFirebase>>();

                foreach (var get in result)
                {
                    string userresult = get.Value.txtdni;
                    string passresult = get.Value.txtpass;
                    string nombre = get.Value.txtnombre;

                    if (txtusuario.Text == userresult)
                    {
                        
                        if (txtpass.Text == passresult)
                        {
                            
                            datosusurios = txtusuario.Text;// sirve para mandar al otro fotmulario
                            idfed = "100"; //identifica el id de la version actual de FedApp
                            usernamepass = txtusuario.Text;
                            MAIN main = new MAIN();
                            this.Hide();
                            main.ShowDialog();
                            
                        }
                        else
                        {
                            lblmensaje.Text = "BIENVENIDO: " + nombre;
                        }

                    }

                    else
                    {
                        
                       // lblmensaje.Text = "USUARIO: " +userresult+" ";
                    }

                }
            }
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
           // loginOfflineDatos();
            loginFed();
         
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text=="Usuario")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.LightGray;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if(txtusuario.Text=="")
            {
                txtusuario.Text = "Usuario";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if(txtpass.Text=="Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if(txtpass.Text=="")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
                    
            }
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            RecuperarPass recuperar = new RecuperarPass();
            recuperar.Show();
        }

        private void LoginFed_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ACCEDE AL SISTEMA SI CON LA TECLA ENTER

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                loginOfflineDatos();
                loginFed();
            }

        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtpass.Focus();
            }
        }



        ////////////////login ofline//// en desarrollo modulo citas///////////////////////////////////
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            estadosesion = "1";
            loginOffline();

        }
        public void loginOffline()
        {
            if (txtusuario.Text != "" && txtpass.Text != "")
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    // busca en la tabla his
                    SqlCommand cmd = new SqlCommand("select DNI, NOMBRE_PROFESIONAL,CONSULTORIO,AREA_CONSULTORIO,ESTADO from USER_CITA WHERE DNI='" + txtusuario.Text + "' AND PASS='" + txtpass.Text + "' GROUP BY DNI, NOMBRE_PROFESIONAL,CONSULTORIO,AREA_CONSULTORIO,ESTADO", cnn);
                    SqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read() == true)
                    {
                        //NRO_DOC,NOMBRE_PACIENTE,FECHA_NAC,SEXO,HCL,
                        dniOfline = leer["DNI"].ToString();
                        nombreOffline = leer["NOMBRE_PROFESIONAL"].ToString();
                        consOffline = leer["CONSULTORIO"].ToString();
                        areaConsulOffline = leer["AREA_CONSULTORIO"].ToString();

                        if (consOffline=="ENFERMERIA")
                        {
                            Forms_consultorio.citasNurse citasNurse = new Forms_consultorio.citasNurse();
                            citasNurse.Show();
                            this.Hide();
                        }
                        else if (consOffline == "MEDICINA")
                        {
                            Forms_consultorio.citasNurse citasNurse = new Forms_consultorio.citasNurse();
                            citasNurse.Show();
                            this.Hide();
                        }
                        else if (consOffline == "ADMISION")
                        {
                            Forms_consultorio.AdmisionCita admision = new Forms_consultorio.AdmisionCita();
                            admision.Show();
                            this.Hide();
                        }
                        else
                        {
                            Forms_consultorio.citasNurse citasNurse = new Forms_consultorio.citasNurse();
                            citasNurse.Show();
                            this.Hide();
                        }

                    }
                    else
                    {
                        MessageBox.Show("No se Encontraron Datos del Usuario");
                    }
                    cnn.Close();
                }
            }
            else
            {
                MessageBox.Show("llene los campos correctamente");
            }
        }
        public void loginOfflineDatos()
        {
            if (txtusuario.Text != "" && txtpass.Text != "")
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    // busca en la tabla his
                    SqlCommand cmd = new SqlCommand("select DNI, NOMBRE_PROFESIONAL,CONSULTORIO,AREA_CONSULTORIO,ESTADO from USER_CITA WHERE DNI='" + txtusuario.Text + "' AND PASS='" + txtpass.Text + "' GROUP BY DNI, NOMBRE_PROFESIONAL,CONSULTORIO,AREA_CONSULTORIO,ESTADO", cnn);
                    SqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read() == true)
                    {
                        //NRO_DOC,NOMBRE_PACIENTE,FECHA_NAC,SEXO,HCL,
                        dniOfline = leer["DNI"].ToString();
                        nombreOffline = leer["NOMBRE_PROFESIONAL"].ToString();
                        consOffline = leer["CONSULTORIO"].ToString();
                        areaConsulOffline = leer["AREA_CONSULTORIO"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se Encontraron Datos del Usuario");
                    }
                    cnn.Close();
                }
            }
            else
            {
                MessageBox.Show("llene los campos correctamente");
            }
        }


    }
}
