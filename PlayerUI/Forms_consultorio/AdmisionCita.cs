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
    public partial class AdmisionCita : Form
    {
        public AdmisionCita()
        {
            InitializeComponent();
        }

        private void filtroconsultorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtroCitas();
            totalCitas();
        }

        private void filtroCitas()
        {
            string fechainicio = fechaInicio.Value.ToString("dd-MM-yyyy");

            if (filtroconsultorio.Text == "TODO")
            {
                try
                {
                    using (SqlConnection cnn = Conexion.ObternerConexion())
                    {
                        SqlCommand cmd;
                        SqlDataReader dr;
                        SqlDataAdapter da;
                        DataTable dt;
                        da = new SqlDataAdapter("SELECT HCL,DNI,NOMBRE_PACIENTE,SEXO,FECHA_ATENCION,HORA_ATENCION,EDAD_ACTUAL,MES_ACTUAL,DIA_ACTUAL,FECHA_NACIMIENTO,CEL,CONSULTORIO,MOTIVO_ATENCION,DIRECCION,OBSERVACIONES,PROFESIONAL_REGISTRA,FEC_REGIST_CITA,ESTADO FROM CITAS WHERE ID_CONSULTORIO='" + IdConsultorio.Text + "'AND CONVERT(DATE,FECHA_ATENCION,103) ='" + fechainicio + "'", cnn);
                        dt = new DataTable();
                        da.Fill(dt);
                        dgvcitas.DataSource = dt;
                        cnn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No hay registros" + ex.ToString());
                }
            }
            else
                try
                {
                    using (SqlConnection cnn = Conexion.ObternerConexion())
                    {
                        SqlCommand cmd;
                        SqlDataReader dr;
                        SqlDataAdapter da;
                        DataTable dt;
                        da = new SqlDataAdapter("SELECT HCL,DNI,NOMBRE_PACIENTE,SEXO,FECHA_ATENCION,HORA_ATENCION,EDAD_ACTUAL,MES_ACTUAL,DIA_ACTUAL,FECHA_NACIMIENTO,CEL,CONSULTORIO,MOTIVO_ATENCION,DIRECCION,OBSERVACIONES,PROFESIONAL_REGISTRA,FEC_REGIST_CITA,ESTADO FROM CITAS WHERE ID_CONSULTORIO='" + IdConsultorio.Text + "'AND CONSULTORIO='" + filtroconsultorio.Text + "'  AND CONVERT(DATE,FECHA_ATENCION,103)='" + fechainicio + "'", cnn);
                        dt = new DataTable();
                        da.Fill(dt);
                        dgvcitas.DataSource = dt;
                        cnn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No hay registros" + ex.ToString());
                }

        }

        private void fechaInicio_ValueChanged(object sender, EventArgs e)
        {
            filtroCitas();
            totalCitas();
        }

        private void fechaFin_ValueChanged(object sender, EventArgs e)
        {
            filtroCitas();
            totalCitas();
        }

        public void totalCitas()
        {
            if (filtroconsultorio.Text == "TODO")
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    string fechainicio = fechaInicio.Value.ToString("dd-MM-yyyy");
                    // muestra el total del denominador en un label
                    string query = "SELECT count(*)  FROM (SELECT DNI FROM CITAS WHERE ID_CONSULTORIO='"+IdConsultorio.Text+"'  AND CONVERT(DATE,FECHA_ATENCION,103) ='" + fechainicio + "')AS T";
                    SqlCommand cmd2 = new SqlCommand(query, cnn);
                    lblTotalCitas.Text = cmd2.ExecuteScalar().ToString();

                    cnn.Close();
                }
            }
            else
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    string fechainicio = fechaInicio.Value.ToString("dd-MM-yyyy");
                    // muestra el total del denominador en un label
                    string query = "SELECT count(*)  FROM (SELECT DNI FROM CITAS WHERE ID_CONSULTORIO='" + IdConsultorio.Text + "' AND CONSULTORIO='" + filtroconsultorio.Text + "' AND CONVERT(DATE,FECHA_ATENCION,103) ='" + fechainicio + "')AS T";
                    SqlCommand cmd2 = new SqlCommand(query, cnn);
                    lblTotalCitas.Text = cmd2.ExecuteScalar().ToString();

                    cnn.Close();
                }
            }

        }

        private void AdmisionCita_Load(object sender, EventArgs e)
        {
            cargar_consultorio();
        }
        public void cargar_consultorio()
        {
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {

                SqlCommand cmd = new SqlCommand("select CONSULTORIO from CONSULTORIO_CITA GROUP BY CONSULTORIO", cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();

                DataRow fila = dt.NewRow();
                dt.Rows.InsertAt(fila, 0);

                IdConsultorio.ValueMember = "CONSULTORIO";
                IdConsultorio.DisplayMember = "CONSULTORIO";
                IdConsultorio.DataSource = dt;
            }
        }
        public void cargar_AreaConsultorio()
        {
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {

                SqlCommand cmd = new SqlCommand("select NOMBRE_CONS from CONSULTORIO_CITA WHERE CONSULTORIO='"+IdConsultorio.Text+"' GROUP BY NOMBRE_CONS", cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();

                DataRow fila = dt.NewRow();
                fila["NOMBRE_CONS"] = "TODO";
                dt.Rows.InsertAt(fila, 0);

                filtroconsultorio.ValueMember = "NOMBRE_CONS";
                filtroconsultorio.DisplayMember = "NOMBRE_CONS";
                filtroconsultorio.DataSource = dt;
            }
        }

        private void IdConsultorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargar_AreaConsultorio();
        }
    }
}
