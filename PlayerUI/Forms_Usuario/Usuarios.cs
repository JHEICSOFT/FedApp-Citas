using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.IO;

namespace PlayerUI
{
    public partial class Usuarios : Form
    {

        public Usuarios()
        {
            InitializeComponent();
            cargar_datosDepartamento();

        }

       
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "lb9bGeiKqFTj7OqRuiZIEkqy0fte0P8Hu2jyXAU5",
            BasePath = "https://usuariosfed-1b8f8-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;



        public void cargar_datosDepartamento()
        {
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {

                SqlCommand cmd = new SqlCommand("SELECT Departamento FROM ESTABLECIMIENTOS GROUP BY  Departamento", cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();

                DataRow fila = dt.NewRow();
                fila["Departamento"] = "Seleccione Departamento";
                dt.Rows.InsertAt(fila, 0);

                cbdepartamento.ValueMember = "Departamento";
                cbdepartamento.DisplayMember = "Departamento";
                cbdepartamento.DataSource = dt;
            }
        }


        public void cargar_datosProvincia(string departamento)
        {
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT Departamento, Provincia FROM ESTABLECIMIENTOS WHERE Disa=@departamento  GROUP BY  Departamento, Provincia", cnn);
                cmd.Parameters.AddWithValue("departamento", departamento);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();

                DataRow dr = dt.NewRow();
                dr["Provincia"] = "Seleccione Provincia";
                dt.Rows.InsertAt(dr, 0);

                cbred.ValueMember = "Provincia";
                cbred.ValueMember = "Provincia";
                cbred.DataSource = dt;
            }
        }

        public void cargar_datosDistrito(string provincia)
        {
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT Provincia,MicroRed FROM ESTABLECIMIENTOS WHERE Provincia=@provincia GROUP BY Provincia, MicroRed", cnn);
                cmd.Parameters.AddWithValue("provincia", provincia);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();

                DataRow dr = dt.NewRow();
                dr["MicroRed"] = "TODO";
                dt.Rows.InsertAt(dr, 0);

                cbmicrored.ValueMember = "MicroRed";
                cbmicrored.ValueMember = "MicroRed";
                cbmicrored.DataSource = dt;
            }

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
                        
            btnactualizar.Visible = false;
            btneliminar.Visible = false;
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch 
            {

                MessageBox.Show("Revisa tu conexion de Internet");
            }
            cargarUsuarios();//CARGAR AL DGV LOS USUARIOS DESDE FIREBASE
        }
        public void cargarUsuarios()
        {
            FirebaseResponse response = client.Get("Usuarios/");
            Dictionary<string, usuariosFirebase> resulta = response.ResultAs<Dictionary<string, usuariosFirebase>>();
            
            foreach (var get in resulta)
            {
                dgvusuarios.Rows.Add(
                    get.Value.txtdni,
                    get.Value.txtnombre,
                    get.Value.txtpass,
                    get.Value.cbnivel,
                    get.Value.cbestado,
                    get.Value.cbambito,
                    get.Value.cbdepartamento,
                    get.Value.cbred,
                    get.Value.cbmicrored,
                    get.Value.cbarea,
                    get.Value.cbconsultorio
                    );
            }
        }
        private void Registrar_Click(object sender, EventArgs e)
        {
            if (txtdni.Text=="" || txtnombre.Text == "" || txtpass.Text == "" || cbnivel.Text == "" || cbestado.Text == "" || cbambito.Text == "" || cbmicrored.Text == "")
            {
                MessageBox.Show("Llene los campos correctamente");
            }else
            {
                GuardarUser();
            }

        }
        public void GuardarPrimerUser()
        {
            usuariosFirebase std = new usuariosFirebase()
            {
                txtdni = txtdni.Text,
                txtnombre = txtnombre.Text,
                txtpass = txtpass.Text,
                cbnivel = cbnivel.Text,
                cbarea = cbarea.Text,
                cbconsultorio = cbconsultorio.Text,
                cbestado = cbestado.Text,
                cbambito = cbambito.Text,
                cbdepartamento = cbdepartamento.Text,
                cbred = cbred.Text,
                cbmicrored = cbmicrored.Text,

            };
            var setter = client.Set("Usuarios/" + txtdni.Text, std);
            MessageBox.Show(txtdni.Text + " Usuario Registrado");
        }

        public void GuardarUser()
        {
                FirebaseResponse response = client.Get("Usuarios/");
                Dictionary<string, usuariosFirebase> resulta = response.ResultAs<Dictionary<string, usuariosFirebase>>();

                foreach (var get in resulta)
                {
                    string userresult = get.Value.txtdni;

                    if (txtdni.Text == userresult)
                    {

                        MessageBox.Show("Usuario " + txtdni.Text + " ya existe.");
                        txtdni.Clear();
                        txtdni.Focus();

                    }
                    else
                    {
                    //CODICO 25: ESTO SOLO FUNCIONA PARA EL PRIMER REGISTRO
                    usuariosFirebase std = new usuariosFirebase()
                    {
                             txtdni = txtdni.Text,
                             txtnombre = txtnombre.Text,
                             txtpass = txtpass.Text,
                             cbnivel = cbnivel.Text,
                             cbarea = cbarea.Text,
                             cbconsultorio = cbconsultorio.Text,
                            cbestado = cbestado.Text,
                            cbambito = cbambito.Text,
                            cbdepartamento = cbdepartamento.Text,
                            cbred = cbred.Text,
                            cbmicrored = cbmicrored.Text,

                        };
                        var setter = client.Set("Usuarios/" + txtdni.Text, std);
                        MessageBox.Show(txtdni.Text + " Usuario Registrado");

                        //FIN CODIGO 25:
                    }
                }
        }
        private void btnselect_Click(object sender, EventArgs e)
        {
            
            FirebaseResponse response = client.Get("Usuarios/");

            Dictionary<string, usuariosFirebase> resulta = response.ResultAs<Dictionary<string, usuariosFirebase>>();

            foreach (var get in resulta)
            {
                string userresult = get.Value.txtdni;

                if (txtdni.Text == userresult)
                {

                    var result = client.Get("Usuarios/" + txtdni.Text);
                    usuariosFirebase std = result.ResultAs<usuariosFirebase>();

                    txtnombre.Text = std.txtnombre;
                    txtpass.Text = std.txtpass;
                    cbnivel.Text = std.cbnivel;
                    cbestado.Text = std.cbestado;
                    cbarea.Text = std.cbarea;
                    cbconsultorio.Text = std.cbconsultorio;
                    cbambito.Text = std.cbambito;
                    cbdepartamento.Text = std.cbdepartamento;
                    cbred.Text = std.cbred;
                    cbmicrored.Text = std.cbmicrored;

                    btnactualizar.Visible = true;
                    btneliminar.Visible = true;
                }
                else if(txtdni.Text=="")
                {
                    MessageBox.Show("Ingrese dni para realizar la Busqueda.");
                    txtdni.Focus();
                }
                else if(txtdni.Text!=userresult)
                {
                   // MessageBox.Show("Usuario "+txtdni.Text+" no existe");// muestra un mensaje si el usurio no se encuetra
                                                                            // registrado en la base de datos (firebase)
                }
            }
        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (txtdni.Text!="" && txtnombre.Text!="")
            {
                usuariosFirebase std = new usuariosFirebase()
                {
                    txtdni = txtdni.Text,
                    txtnombre = txtnombre.Text,
                    txtpass = txtpass.Text,
                    cbnivel = cbnivel.Text,
                    cbarea = cbarea.Text,
                    cbconsultorio = cbconsultorio.Text,
                    cbestado = cbestado.Text,
                    cbambito = cbambito.Text,
                    cbdepartamento = cbdepartamento.Text,
                    cbred = cbred.Text,
                    cbmicrored = cbmicrored.Text,
                };

                var setter = client.Update("Usuarios/" + txtdni.Text, std);
                MessageBox.Show("USUARIO " + txtdni.Text + " MODIFICADO!");
                txtdni.Clear();
                txtnombre.Clear();
                txtpass.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese su dni");
            }
        }


        private void btneliminar_Click(object sender, EventArgs e)
        {
            var result = client.Delete("Usuarios/" + txtdni.Text);

            MessageBox.Show("USUARIO "+txtdni.Text+" ELININADO");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbambito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbdepartamento.SelectedValue.ToString() != null)
            {
                string departamento = cbdepartamento.SelectedValue.ToString();
                cargar_datosProvincia(departamento);
            }
        }


        private void cbnivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbnivel.Text == "Consultorio")
            {
                pnlconsultorio.Visible = true;
                
            }
            else
            {
                pnlconsultorio.Visible = false;
            }
        }
        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbestado.Text == "INACTIVO")
            {
                cbdepartamento.Enabled = false;
                cbred.Enabled = false;
                cbmicrored.Enabled = false;
            }
            else
            {
                cbdepartamento.Enabled = true;
                cbred.Enabled = true;
                cbmicrored.Enabled = true;
            }
        }
        private void cbred_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbred.SelectedValue.ToString() != null)
            {
                string provincia = cbred.SelectedValue.ToString();
                cargar_datosDistrito(provincia);
            }
        }

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {

            // solo acepte numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dvgusuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvusuarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvusuarios.CurrentRow.Selected = true;
                //txtdni.Text = dgvusuarios.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                txtdni.Text =         dgvusuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtnombre.Text =      dgvusuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtpass.Text =        dgvusuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbnivel.Text =        dgvusuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbestado.Text =       dgvusuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbambito.Text =       dgvusuarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbdepartamento.Text = dgvusuarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbred.Text =          dgvusuarios.Rows[e.RowIndex].Cells[7].Value.ToString();
                cbmicrored.Text =     dgvusuarios.Rows[e.RowIndex].Cells[8].Value.ToString();
                cbarea.Text =         dgvusuarios.Rows[e.RowIndex].Cells[9].Value.ToString();
                cbconsultorio.Text =  dgvusuarios.Rows[e.RowIndex].Cells[10].Value.ToString();

                btnactualizar.Visible = true;
                btneliminar.Visible = true;
        }
            else
            { 

            }
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbarea.Text == "ENFERMERIA")
            {
                cbconsultorio.Items.Clear();
                cbconsultorio.Items.Add("CONSULTORIO 1");
                cbconsultorio.Items.Add("CONSULTORIO 1");
                cbconsultorio.Items.Add("ADISIONAL");
            }
            else if (cbarea.Text=="MEDICINA")
            {
                cbconsultorio.Items.Clear();
                cbconsultorio.Items.Add("MEDICINA 1");
                cbconsultorio.Items.Add("MEDICINA 2");

            }


        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            csv(dgvusuarios);
        }

        public void csv(DataGridView tabla)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Archivo csv|*.csv" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                List<string> filas = new List<string>();

                List<string> cabeceras = new List<string>();
                foreach (DataGridViewColumn col in dgvusuarios.Columns)
                {
                    cabeceras.Add(col.HeaderText);
                }
                string SEP = ",";
                filas.Add(string.Join(SEP, cabeceras));

                foreach (DataGridViewRow fila in dgvusuarios.Rows)
                {
                    try
                    {
                        List<string> celdas = new List<string>();
                        foreach (DataGridViewCell c in fila.Cells)

                            celdas.Add(c.Value.ToString());
                        filas.Add(string.Join(SEP, celdas));

                    }
                    catch (Exception ex) { }

                }

                File.WriteAllLines(sfd.FileName, filas);
            }
        }
    }

}
