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

namespace PlayerUI
{
    public partial class MantenimientoApp : Form
    {
        public MantenimientoApp()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "lb9bGeiKqFTj7OqRuiZIEkqy0fte0P8Hu2jyXAU5",
            BasePath = "https://usuariosfed-1b8f8-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void MantenimientoApp_Load(object sender, EventArgs e)
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

        private void Registrar_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Get("MantenimientoApp/");
            Dictionary<string, mantenimientoFirebase> resulta = response.ResultAs<Dictionary<string, mantenimientoFirebase>>();

            //funciona el foreach si ya existe la tabla Usuarios en firebase si no existe ejecutar solo despues del else.

            foreach (var get in resulta)
            {
                string userresult = get.Value.id;

                if (txtid.Text == userresult)
                {

                    MessageBox.Show("id " + txtid.Text + " ya existe!    Actualiza");


                }
                else if (txtid.Text == "")
                {
                    MessageBox.Show("Llene los campos Obligatorios");

                }
                else
                {
                    mantenimientoFirebase std = new mantenimientoFirebase()
                    {
                        idmantenimiento = txtidmantenimiento.Text,
                        id = txtid.Text,
                        version = txtversion.Text,
                        mantenimineto = cbmantenimiento.Text,
                        fecha = dtfecha.Text,
                        estado = cbestado.Text,
                        mensaje = txtmensaje.Text,
                        link = txtlink.Text,
                    };
                    var setter = client.Set("MantenimientoApp/" + txtid.Text, std);
                    MessageBox.Show("ID " + txtid.Text + " Registrado");
                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Get("MantenimientoApp/");
            Dictionary<string, mantenimientoFirebase> resulta = response.ResultAs<Dictionary<string, mantenimientoFirebase>>();

            foreach (var get in resulta)
            {
                string userresult = get.Value.id;

                if (txtid.Text == userresult)
                {
                    var result = client.Get("MantenimientoApp/" + txtid.Text);
                    mantenimientoFirebase std = result.ResultAs<mantenimientoFirebase>();

                    txtidmantenimiento.Text = std.idmantenimiento;
                    txtid.Text = std.id;
                    txtversion.Text = std.version;
                    cbmantenimiento.Text = std.mantenimineto;
                    dtfecha.Text = std.fecha;
                    cbestado.Text = std.estado;
                    txtmensaje.Text = std.mensaje;
                    txtlink.Text = std.link;
                }
                else if (txtid.Text == "")
                {
                    MessageBox.Show("Ingrese id para realizar la Busqueda.");
                    txtid.Focus();
                }
                else if (txtid.Text != userresult)
                {
                    MessageBox.Show( txtid.Text + " no existe");// muestra un mensaje si el usurio no se encuetra
                                                                             // registrado en la base de datos (firebase)
                }
            }
        }

        private void nombre_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mantenimientoFirebase std = new mantenimientoFirebase()
            {
                idmantenimiento = txtidmantenimiento.Text,
                id = txtid.Text,
                version = txtversion.Text,
                mantenimineto = cbmantenimiento.Text,
                fecha = dtfecha.Text,
                estado = cbestado.Text,
                mensaje = txtmensaje.Text,
                link = txtlink.Text,
            };

            var setter = client.Update("MantenimientoApp/" + txtid.Text, std);
            MessageBox.Show(txtidmantenimiento.Text + " modificado!");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
