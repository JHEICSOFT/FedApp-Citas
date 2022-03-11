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
namespace PlayerUI.Forms_consultorio
{
    public partial class UserConsultorio : Form
    {
        public UserConsultorio()
        {
            InitializeComponent();
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            buscarProfesional();
        }

        public void buscarProfesional()
        {
            if (txtdni.MaxLength >= 8)
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    // busca en la tabla his
                    SqlCommand cmd = new SqlCommand("SELECT * FROM HIS WHERE NRO_DOC='" + txtdni.Text + "'", cnn);
                    SqlDataReader leer = cmd.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        //NRO_DOC,NOMBRE_PACIENTE,FECHA_NAC,SEXO,HCL,
                        txtdocumento.Text = leer["NRO_DOC"].ToString();
                        txtnombre.Text = leer["NOMBRE_PACIENTE"].ToString();
                        dtfechNac.Text = leer["FECHA_NAC"].ToString();
                        txtuser.Text = leer["NRO_DOC"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se Encontraron Datos del Paciente! -Registre Manual-");
                    }
                    cnn.Close();
                }
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtdocumento.Text =="" || txtnombre.Text==""|| txtuser.Text=="" || txtpass.Text=="" || cbconsultorio.Text == "" || cbAreaCons.Text == "" || cbestado.Text == "")
            {
                MessageBox.Show("Llene los campos correctamente...");
            }
            else
            {
                guardarCitas();
            }
           
        }

        public void guardarCitas()
        {
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO USER_CITA(DNI,NOMBRE_PROFESIONAL,FECHA_NACI,USUARIO,PASS,CONSULTORIO,AREA_CONSULTORIO,FECHA_CREACION,ESTADO)" +
                    "VALUES('" + this.txtdocumento.Text + "','" + this.txtnombre.Text + "','" + this.dtfechNac.Text + "','" + this.txtuser.Text + "'" +
                    ",'" + this.txtpass.Text + "','" + this.cbconsultorio.Text + "','" + this.cbAreaCons.Text + "','" + this.dtfechCreaci.Text +
                    "','" + this.cbestado.Text + "')", cnn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Guardado");

                cnn.Close();
            }
        }

        private void cbconsultorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargar_consultorio();
        }

        public void cargar_consultorio()
        {
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {

                SqlCommand cmd = new SqlCommand("select NOMBRE_CONS from CONSULTORIO_CITA where CONSULTORIO='"+cbconsultorio.Text+"' GROUP BY NOMBRE_CONS", cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();

                DataRow fila = dt.NewRow();
                dt.Rows.InsertAt(fila, 0);

                cbAreaCons.ValueMember = "NOMBRE_CONS";
                cbAreaCons.DisplayMember = "NOMBRE_CONS";
                cbAreaCons.DataSource = dt;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserConsultorio_Load(object sender, EventArgs e)
        {

        }
    }
}
