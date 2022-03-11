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
    public partial class UpdateCitas : Form
    {
        public UpdateCitas()
        {
            InitializeComponent();
        }
        public static string idcita;
        public static string totalhora;
        public static string fecActual;
        public static int cantidadHora;
        private void button1_Click(object sender, EventArgs e)
        {
            BuscarCita();
           
        }
        public void BuscarCita()
        {
            if (txtbuscar.Text!="")
            {
                try
                {
                    using (SqlConnection cnn = Conexion.ObternerConexion())
                    {
                        SqlCommand cmd;
                        SqlDataReader dr;
                        SqlDataAdapter da;
                        DataTable dt;
                        da = new SqlDataAdapter("SELECT * FROM CITAS WHERE DNI='" + txtbuscar.Text + "'", cnn);
                        dt = new DataTable();
                        da.Fill(dt);
                        dgvcitas.DataSource = dt;
                        cnn.Close();
                        if (dt is null)
                        {
                            MessageBox.Show("El dni ingresado no tiene Citas");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El dni ingresado no tiene Citas" + ex.ToString());
                }
            }else
            {
                MessageBox.Show("Ingrese DNI");
            }
            
        }

        private void dgvcitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvcitas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                dgvcitas.CurrentRow.Selected = true;
                //txtdni.Text = dgvusuarios.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                idcita = dgvcitas.Rows[e.RowIndex].Cells[0].Value.ToString();
                dni.Text = dgvcitas.Rows[e.RowIndex].Cells[1].Value.ToString();
                nomPac.Text = dgvcitas.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbIdConsultorio.Text = dgvcitas.Rows[e.RowIndex].Cells[22].Value.ToString();
                cargar_Areaconsultorio();
                dtfechaAtencion.Text = dgvcitas.Rows[e.RowIndex].Cells[3].Value.ToString();
      
                edadActual.Text = dgvcitas.Rows[e.RowIndex].Cells[5].Value.ToString();
                mesActual.Text = dgvcitas.Rows[e.RowIndex].Cells[6].Value.ToString();
                diaActual.Text = dgvcitas.Rows[e.RowIndex].Cells[7].Value.ToString();
                sexo.Text = dgvcitas.Rows[e.RowIndex].Cells[8].Value.ToString();
                fecNac.Text = dgvcitas.Rows[e.RowIndex].Cells[9].Value.ToString();
                edadAtencion.Text = dgvcitas.Rows[e.RowIndex].Cells[10].Value.ToString();
                mesAtencion.Text = dgvcitas.Rows[e.RowIndex].Cells[11].Value.ToString();
                diaAtencion.Text = dgvcitas.Rows[e.RowIndex].Cells[12].Value.ToString();
                hcl.Text = dgvcitas.Rows[e.RowIndex].Cells[13].Value.ToString();
                cel.Text = dgvcitas.Rows[e.RowIndex].Cells[14].Value.ToString();
                motAte.Text = dgvcitas.Rows[e.RowIndex].Cells[15].Value.ToString();
                cbAreaConsultorio.Text = dgvcitas.Rows[e.RowIndex].Cells[16].Value.ToString();
                contarSiExisteHora();
                cargar_HoraConsul();
                cbhora.Text = dgvcitas.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbprofesional.Text = dgvcitas.Rows[e.RowIndex].Cells[17].Value.ToString();
                direccion.Text = dgvcitas.Rows[e.RowIndex].Cells[18].Value.ToString();
                observacion.Text = dgvcitas.Rows[e.RowIndex].Cells[19].Value.ToString();
                

                btnactualizar.Visible = true;
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de modificar la Cita?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (idcita != "" || idcita is null)
                {
                    using (SqlConnection cnn = Conexion.ObternerConexion())
                    {

                        SqlCommand cmd = new SqlCommand("UPDATE  CITAS SET DNI='" + dni.Text + "',NOMBRE_PACIENTE='" + nomPac.Text + "',FECHA_ATENCION='" + fechaAtencion.Text +
                                                        "',HORA_ATENCION='" + cbhora.Text + "',EDAD_ACTUAL='" + edadActual.Text + "',MES_ACTUAL='" + mesActual.Text +
                                                        "',DIA_ACTUAL='" + diaActual.Text + "',SEXO='" + sexo.Text + "',FECHA_NACIMIENTO='" + fecNac.Text +
                                                        "',EDAD_ATENCION='" + edadAtencion.Text + "',MES_ATENCION='" + mesAtencion.Text + "',DIA_ATENCION='" + diaAtencion.Text +
                                                        "',HCL='" + hcl.Text + "',CEL='" + cel.Text + "',MOTIVO_ATENCION='" + motAte.Text + "',CONSULTORIO='" + cbAreaConsultorio.Text +
                                                        "',PROFESIONAL_REGISTRA='" + cbprofesional.Text + "',DIRECCION='" + direccion.Text + "',OBSERVACIONES='" + observacion.Text + "',ID_CONSULTORIO='" + cbIdConsultorio.Text + "' where id_cita=" + Convert.ToInt32(idcita), cnn);
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                    }
                    //actualiza la tabla 
                    idcita = "";
                    BuscarCita();
                    MessageBox.Show("Cita Actualizada");
                }
                else
                {
                    MessageBox.Show("No hay citas para el documento: " + txtbuscar.Text);
                }
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            calcularEdad();
            contarSiExisteHora();
            cargar_HoraConsul();
            calcularEdadAtencion();
        }
        public void calcularEdad()
        {
            DateTime FechaNacimiento = Convert.ToDateTime(fecNac.Text);
            DateTime FechaActual = Convert.ToDateTime(fecActual);

            int año = FechaNacimiento.Year;
            int mes = FechaNacimiento.Month;
            int dias = FechaNacimiento.Day;

            int año_bisiesto = 0;
            for (int i = año; i < FechaActual.Year; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    ++año_bisiesto;
                }
            }

            TimeSpan timeSpan = FechaActual.Subtract(FechaNacimiento);
            dias = timeSpan.Days - año_bisiesto;
            int r = 0;
            año = Math.DivRem(dias, 365, out r);
            mes = Math.DivRem(r, 30, out r);
            dias = r;

            edadActual.Text = año.ToString();
            mesActual.Text = mes.ToString();
            diaActual.Text = dias.ToString();
        }
        public void calcularEdadAtencion()
        {
            DateTime FechaNacimiento = Convert.ToDateTime(fecNac.Text);
            DateTime FechaActual = Convert.ToDateTime(fechaAtencion.Text);

            int año = FechaNacimiento.Year;
            int mes = FechaNacimiento.Month;
            int dias = FechaNacimiento.Day;

            int año_bisiesto = 0;
            for (int i = año; i < FechaActual.Year; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    ++año_bisiesto;
                }
            }

            TimeSpan timeSpan = FechaActual.Subtract(FechaNacimiento);
            dias = timeSpan.Days - año_bisiesto;
            int r = 0;
            año = Math.DivRem(dias, 365, out r);
            mes = Math.DivRem(r, 30, out r);
            dias = r;

            edadAtencion.Text = año.ToString();
            mesAtencion.Text = mes.ToString();
            diaAtencion.Text = dias.ToString();
        }

        public void contarSiExisteHora()
        {
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {
                // muestra el total del denominador en un label
                string query = "SELECT COUNT(*) FROM (SELECT HORA_ATENCION  FROM CITAS WHERE CONVERT(DATE,FECHA_ATENCION,103)='" + dtfechaAtencion.Text + "'AND CONSULTORIO='" + cbAreaConsultorio.Text + "' AND ID_CONSULTORIO='" + cbIdConsultorio.Text + "' AND (HORA_ATENCION NOT IN('')OR HORA_ATENCION IS NULL))T";
                SqlCommand cmd2 = new SqlCommand(query, cnn);
                totalhora = cmd2.ExecuteScalar().ToString();
                cantidadHora = Int32.Parse(totalhora);
                cnn.Close();
            }
        }
        public void cargar_HoraConsul()
        {
            if (totalhora != "0")
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    //mostrara las HORAS DISPONIBLES SEGUN LOS CAMPOS SELECCIONAS Y TAMBIEN ESTARA DISPONIBLE LA HORA YA REGISTRADA
                    SqlCommand cmd = new SqlCommand("Select CC.NOMBRE_CONS,CC.HORA from CONSULTORIO_CITA AS CC INNER JOIN CITAS AS C ON C.CONSULTORIO=CC.NOMBRE_CONS where not exists (select C.CONSULTORIO from CITAS AS C where C.HORA_ATENCION = CC.HORA)AND C.ID_CONSULTORIO='" + cbIdConsultorio.Text + "' AND C.CONSULTORIO='" + cbAreaConsultorio.Text + "' and  CONVERT(DATE, C.FECHA_ATENCION,103)='" + dtfechaAtencion.Text + "' AND  CC.HORA NOT IN (C.HORA_ATENCION) GROUP BY CC.NOMBRE_CONS,CC.HORA", cnn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DataRow dr = dt.NewRow();
                    dt.Rows.InsertAt(dr, 1);
                    cbhora.ValueMember = "HORA";
                    cbhora.DataSource = dt;
                    cnn.Close();
                }
            }
            else
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    // muestra el total del denominador en un label
                    SqlCommand cmd = new SqlCommand("SELECT HORA FROM CONSULTORIO_CITA WHERE  CONSULTORIO='" + cbIdConsultorio.Text + "' AND NOMBRE_CONS='" + cbAreaConsultorio.Text + "'", cnn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DataRow dr = dt.NewRow();
                    dt.Rows.InsertAt(dr, 1);
                    cbhora.ValueMember = "HORA";
                    cbhora.DataSource = dt;
                    cnn.Close();
                }
            }

        }

        private void cbconsultorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            contarSiExisteHora();
            cargar_HoraConsul();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de eliminar la Cita?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                if (idcita != "")
                {
                    using (SqlConnection cnn = Conexion.ObternerConexion())
                    {

                        SqlCommand cmd = new SqlCommand(" DELETE FROM CITAS WHERE ID_CITA=" + Convert.ToInt32(idcita), cnn);
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        MessageBox.Show("Cita eliminado");
                    }
                    limpiarTxt();
                    idcita = "";
                }
                else
                {
                    MessageBox.Show("Selecciones para eliminar");
                }
            }
        }

        public void limpiarTxt()
        {
            dni.Clear();
            nomPac.Clear();
            dni.Clear();
            edadActual.Clear();
            mesActual.Clear();
            diaActual.Clear();
            edadAtencion.Clear();
            mesAtencion.Clear();
            hcl.Clear();
            cel.Clear();
            motAte.Text = "";
            direccion.Clear();
            observacion.Clear();
            sexo.Text = "";
        }

        private void UpdateCitas_Load(object sender, EventArgs e)
        {
            fecActual = DateTime.Now.ToString("dd-MM-yyyy");
            cbIdConsultorio.Enabled = false;
            cargar_Areaconsultorio();


        }

        private void fecNac_ValueChanged(object sender, EventArgs e)
        {
            calcularEdad();
            calcularEdadAtencion();
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BuscarCita();
            }
        }

        public void cargar_Areaconsultorio()
        {
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {

                SqlCommand cmd = new SqlCommand("select NOMBRE_CONS from CONSULTORIO_CITA where CONSULTORIO='" + cbIdConsultorio.Text + "' GROUP BY NOMBRE_CONS", cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();

                DataRow fila = dt.NewRow();
                dt.Rows.InsertAt(fila, 0);

                cbAreaConsultorio.ValueMember = "NOMBRE_CONS";
                cbAreaConsultorio.DisplayMember = "NOMBRE_CONS";
                cbAreaConsultorio.DataSource = dt;
            }
        }

        private void cbIdConsultorio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
