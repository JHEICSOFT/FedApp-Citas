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
    public partial class BuscarPacCovid : Form
    {
        public BuscarPacCovid()
        {
            InitializeComponent();
        }

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkcasos_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void BuscarPacCovid_Load(object sender, EventArgs e)
        {
        }

        private void checkseguimiento_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkmedicamentos_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkcasos_Click(object sender, EventArgs e)
        {
            checkseguimiento.Checked = false;
            checkmedicamentos.Checked = false;
        }

        private void checkseguimiento_Click(object sender, EventArgs e)
        {
            checkcasos.Checked = false;
            checkmedicamentos.Checked = false;
        }

        private void checkmedicamentos_Click(object sender, EventArgs e)
        {
           checkcasos.Checked = false;
           checkseguimiento.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkcasos.Checked && txtbuscar.Text!="")
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {

                    //mostrar informacion de covid_casos
                    SqlCommand cmdcados = cnn.CreateCommand();
                    cmdcados.CommandType = CommandType.Text;
                    cmdcados.CommandText = "select * from COVID_CASOS WHERE [Nro Documento] LIKE ('%"+txtbuscar.Text+"')";
                    cmdcados.ExecuteNonQuery();
                    DataTable dtcasos = new DataTable();
                    SqlDataAdapter dacasos = new SqlDataAdapter(cmdcados);
                    dacasos.Fill(dtcasos);
                    dgvcovid.DataSource = dtcasos;
                    cnn.Close();
                }
            }
            else if(checkmedicamentos.Checked && txtbuscar.Text != "")
             {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {

                    //mostrar informacion de covid_casos
                    SqlCommand cmdcados = cnn.CreateCommand();
                    cmdcados.CommandType = CommandType.Text;
                    cmdcados.CommandText = "select * from COVID_MEDICAMENTOS where NUMERO_DOCUMENTO LIKE ('%" + txtbuscar.Text + "')";
                    cmdcados.ExecuteNonQuery();
                    DataTable dtcasos = new DataTable();
                    SqlDataAdapter dacasos = new SqlDataAdapter(cmdcados);
                    dacasos.Fill(dtcasos);
                    dgvcovid.DataSource = dtcasos;
                    cnn.Close();
                }

            }
            else if (checkseguimiento.Checked && txtbuscar.Text != "")
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {

                    //mostrar informacion de covid_casos
                    SqlCommand cmdcados = cnn.CreateCommand();
                    cmdcados.CommandType = CommandType.Text;
                    cmdcados.CommandText = "select * from COVID_SEGUIMIENTOS where [Nro Documento] LIKE ('%" + txtbuscar.Text + "')";
                    cmdcados.ExecuteNonQuery();
                    DataTable dtcasos = new DataTable();
                    SqlDataAdapter dacasos = new SqlDataAdapter(cmdcados);
                    dacasos.Fill(dtcasos);
                    dgvcovid.DataSource = dtcasos;
                    cnn.Close();
                }

            }

            else
            {
                MessageBox.Show("Ingrese DNI");
            }
            }  
        }
    
}
