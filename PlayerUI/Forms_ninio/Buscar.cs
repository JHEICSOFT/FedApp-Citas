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
namespace PlayerUI
{
    public partial class Buscar : Form
    {

       
        public Buscar()
        {
            InitializeComponent();
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            lblpadron.Visible = false;
            lblatenciones.Visible = false;
            dgvpadron.Visible = false;
            dgvatenciones.Visible = false;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            //muestra la informacion conforme escribimos en el texbox

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            if (txtbuscar.Text != "")
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {

                    //mostrar informacion del padron
                    SqlCommand cmdpadron = cnn.CreateCommand();
                    cmdpadron.CommandType = CommandType.Text;
                    cmdpadron.CommandText = "select * from padron_nominal where cnv like ('" + txtbuscar.Text + "%')  or [CÓDIGO UNICO DE IDENTIDAD (CUI)]like ('" + txtbuscar.Text + "%') or [número de documento nacional de identificación (dni)] like ('" + txtbuscar.Text + "%')";
                    cmdpadron.ExecuteNonQuery();
                    DataTable dtpadron = new DataTable();
                    SqlDataAdapter dapadron = new SqlDataAdapter(cmdpadron);
                    dapadron.Fill(dtpadron);

                    lblpadron.Visible = true;
                    lblatenciones.Visible = true;
                    dgvpadron.Visible = true;
                    dgvatenciones.Visible = true;
                    dgvpadron.DataSource = dtpadron;

                    //mostrar informacion de atenciones
                    SqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from his where nro_doc like ('%" + txtbuscar.Text + "%')";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    lblpadron.Visible = true;
                    lblatenciones.Visible = true;
                    dgvpadron.Visible = true;
                    dgvatenciones.Visible = true;
                    dgvatenciones.DataSource = dt;
                    cnn.Close();
                }
            }else
            {
                MessageBox.Show("Ingrese DNI");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
