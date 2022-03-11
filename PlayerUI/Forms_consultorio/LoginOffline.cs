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
    public partial class LoginOffline : Form
    {
        public LoginOffline()
        {
            InitializeComponent();
        }
        public static string dniOfline;
        public static string nombreOffline;
        public static string consOffline;
        private void btnacceder_Click(object sender, EventArgs e)
        {


            if (dni.Text != "" && cbconsultorio.Text!="")
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    // busca en la tabla his
                    SqlCommand cmd = new SqlCommand("SELECT NUMERO_DOCUMENTO, (NOMBRES_PERSONAL +' '+APELLIDO_PATERNO_PERSONAL+' '+APELLIDO_MATERNO_PERSONAL) AS PERSONAL FROM PERSONAL WHERE NUMERO_DOCUMENTO='" + dni.Text+ "' GROUP BY NUMERO_DOCUMENTO, NOMBRES_PERSONAL,APELLIDO_PATERNO_PERSONAL,APELLIDO_MATERNO_PERSONAL", cnn);
                    SqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read() == true)
                    {
                        //NRO_DOC,NOMBRE_PACIENTE,FECHA_NAC,SEXO,HCL,
                        dniOfline = leer["NUMERO_DOCUMENTO"].ToString();
                        nombreOffline = leer["PERSONAL"].ToString();
                        consOffline = cbconsultorio.Text;

                        Forms_consultorio.citasNurse citasNurse = new Forms_consultorio.citasNurse();
                            citasNurse.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No se Encontraron Datos del Usuario");
                    }
                    cnn.Close();
                }

            }else
            {
                MessageBox.Show("Ingrese DNI y/o Seleccione su consultorio");
            }
                
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginFed login = new LoginFed();
            login.Show();
            this.Hide();
        }
    }
}
