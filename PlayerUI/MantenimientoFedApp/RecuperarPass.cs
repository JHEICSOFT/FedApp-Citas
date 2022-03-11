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

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace PlayerUI
{
    public partial class RecuperarPass : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public RecuperarPass()
        {
            InitializeComponent();
        }



        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "lb9bGeiKqFTj7OqRuiZIEkqy0fte0P8Hu2jyXAU5",
            BasePath = "https://usuariosfed-1b8f8-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;


        private void button1_Click(object sender, EventArgs e)
        {
            string usurio = txtpass.Text;
            FirebaseResponse response = client.Get("Usuarios/");

            Dictionary<string, usuariosFirebase> resulta = response.ResultAs<Dictionary<string, usuariosFirebase>>();

            foreach (var get in resulta)
            {
                string userresult = get.Value.txtdni;
                string nombreUsuario = get.Value.txtnombre;
                if (usurio == userresult)
                {

                    var result = client.Get("Usuarios/" + usurio);
                    usuariosFirebase std = result.ResultAs<usuariosFirebase>();
                    lblpass.Text ="HOLA, "+nombreUsuario;
                    lblnombre.Text=("Su contraseña es: "+std.txtpass);

                }
                else if (usurio == "")
                {
                    lblnombre.Text="Ingrese su usuario!";
                    txtpass.Focus();
                }
                else if (usurio != userresult)
                {
                                                                     // registrado en la base de datos (firebase)
                }
            }


        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RecuperarPass_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {

                MessageBox.Show("Revisa tu conexion de Internet");
            }

        }

        private void RecuperarPass_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
