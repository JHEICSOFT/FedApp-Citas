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

namespace PlayerUI.Forms_Usuario
{
    public partial class Editar_Usuario : Form
    {
        public static string datosusuarios = LoginFed.datosusurios;
        public static string usuario;
        public Editar_Usuario()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "lb9bGeiKqFTj7OqRuiZIEkqy0fte0P8Hu2jyXAU5",
            BasePath = "https://usuariosfed-1b8f8-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        private void Editar_Usuario_Load(object sender, EventArgs e)
        {
            mis_datos();

            txtdni.Enabled = false;
            cbnivel.Enabled = false;
            cbestado.Enabled = false;
            cbambito.Enabled = false;
            cbdepartamento.Enabled = false;
            cbred.Enabled = false;
            cbmicrored.Enabled = false;
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {

                MessageBox.Show("Revisa tu conexion de Internet");
            }
        }
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
            usuariosFirebase std = resp2.ResultAs<usuariosFirebase>();
            /// variable para mostrar red si su microred es todo--
            /// 
            txtdni.Text = std.txtdni;
            txtnombre.Text = std.txtnombre;
            txtpass.Text = std.txtpass;
            cbnivel.Text = std.cbnivel;
            cbestado.Text = std.cbestado;
            cbambito.Text = std.cbambito;
            cbdepartamento.Text = std.cbdepartamento;
            cbred.Text = std.cbred;
            cbmicrored.Text = std.cbmicrored;
        }


        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (txtdni.Text!="")
            {
                usuariosFirebase std = new usuariosFirebase()
                {
                    txtdni = txtdni.Text,
                    txtnombre = txtnombre.Text,
                    txtpass = txtpass.Text,
                    cbnivel = cbnivel.Text,
                    cbestado = cbestado.Text,
                    cbambito = cbambito.Text,
                    cbdepartamento = cbdepartamento.Text,
                    cbred = cbred.Text,
                    cbmicrored = cbmicrored.Text,
                };
                var setter = client.Update("Usuarios/" + txtdni.Text, std);
                MessageBox.Show("Usuario " + txtdni.Text + " modificado corectamente!");
            }else
            {
                MessageBox.Show("Error al actualizar!");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
