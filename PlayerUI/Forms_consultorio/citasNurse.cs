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

using System.Data.SqlClient;
namespace PlayerUI.Forms_consultorio
{
    public partial class citasNurse : Form
    {
        public static string resultadoBusqueda;
        public static string fecActual;
        public static string totalhora;
        public static int cantidadHora;
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "lb9bGeiKqFTj7OqRuiZIEkqy0fte0P8Hu2jyXAU5",
            BasePath = "https://usuariosfed-1b8f8-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public citasNurse()
        {
            InitializeComponent();


        }

        public void buscarCitas()
        {
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {
                if (txtbuscar.MaxLength >= 8)
                {
                    // busca en la tabla cita
                    SqlCommand cmdCita = new SqlCommand(" SELECT * FROM CITAS WHERE DNI='" + txtbuscar.Text + "'", cnn);
                    SqlDataReader leerCita = cmdCita.ExecuteReader();

                    if (leerCita.Read() == true)
                    {
                        dni.Text = leerCita["DNI"].ToString();
                        nomPac.Text = leerCita["NOMBRE_PACIENTE"].ToString();
                        fecNac.Text = leerCita["FECHA_NACIMIENTO"].ToString();
                        sexo.Text = leerCita["SEXO"].ToString();
                        hcl.Text = leerCita["HCL"].ToString();
                        cel.Text = leerCita["CEL"].ToString();
                        direccion.Text = leerCita["DIRECCION"].ToString();
                        resultadoBusqueda = leerCita["DNI"].ToString();

                        calcularEdad();
                        calcularEdadAtencion();

                    }
                    else
                    {
                        resultadoBusqueda = "";
                    }
                    cnn.Close();
                }
                else
                {
                    MessageBox.Show("Ingrese 8 digitos");
                }

            }
        }
        //BUSCA EN LA TABLA PADRONNOMINAL
        public void buscarPadronNominal()
        {
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {
                if (txtbuscar.MaxLength >= 8)
                {
                    // busca en la tabla cita
                    SqlCommand cmdCita = new SqlCommand(" SELECT CNV,([NOMBRES DEL NIÑO] + [APELLIDO PATERNO_DEL NIÑO] + [APELLIDO MATERNO_DEL NIÑO]) AS NOMBRE,[FECHA DE NACIMIENTO_DEL NIÑO(DD/MM/AAAA)]AS FECHA_NAC , CASE  [CÓDIGO DE SEXO_DEL NIÑO_(1=MASCULINO_2=FEMENINO)] WHEN '1' THEN'M' WHEN '2' THEN 'F' ELSE 'NO ASIGNADO'END AS SEXO , [NUMERO DE CELULAR DE LA MADRE] AS CEL,[REFERENCIA DE DIRECCIÓN] AS DIRECCION FROM Padron_Nominal WHERE CNV='" + txtbuscar.Text + "'", cnn);
                    SqlDataReader leerCita = cmdCita.ExecuteReader();

                    if (leerCita.Read() == true)
                    {
                        dni.Text = leerCita["CNV"].ToString();
                        nomPac.Text = leerCita["NOMBRE"].ToString();
                        fecNac.Text = leerCita["FECHA_NAC"].ToString();
                        sexo.Text = leerCita["SEXO"].ToString();
                        //hcl.Text = leerCita["HCL"].ToString();
                        cel.Text = leerCita["CEL"].ToString();
                        direccion.Text = leerCita["DIRECCION"].ToString();
                        resultadoBusqueda = leerCita["CNV"].ToString();

                        calcularEdad();
                        calcularEdadAtencion();

                    }
                    else
                    {
                        resultadoBusqueda = "";
                    }
                    cnn.Close();
                }
                else
                {
                    MessageBox.Show("Ingrese 8 digitos");
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
            motAte.Text="";
            direccion.Clear();
            observacion.Clear();
            sexo.Text="";
            cbhora.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            buscarCitas();
            buscarPadronNominal();
            if (txtbuscar.MaxLength>=8)
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    // busca en la tabla his
                    SqlCommand cmd = new SqlCommand("SELECT * FROM HIS WHERE NRO_DOC='" + txtbuscar.Text + "'", cnn);
                    SqlDataReader leer = cmd.ExecuteReader();
                    if (resultadoBusqueda != "")
                    {
                        buscarCitas();
                    }
                    else if (leer.Read() == true)
                    {
                        //NRO_DOC,NOMBRE_PACIENTE,FECHA_NAC,SEXO,HCL,
                        dni.Text = leer["NRO_DOC"].ToString();
                        nomPac.Text = leer["NOMBRE_PACIENTE"].ToString();
                        fecNac.Text = leer["FECHA_NAC"].ToString();
                        sexo.Text = leer["SEXO"].ToString();
                        hcl.Text = leer["HCL"].ToString();
                        dni.Text = leer["NRO_DOC"].ToString();

                        calcularEdad();
                        calcularEdadAtencion();
                        indicadorFed();
                    }
                    else
                    {
                        buscarPadronNominal();
                    }
                    cnn.Close();
                }
            }
            else if (txtbuscar.MaxLength <8)
            {
                MessageBox.Show("Ingrese 8 digitos");   
            }

        }

        public void indicadorFed()
        {
            if (edadActual.Text=="0" && mesActual.Text=="4")
            {
                try
                {
                    using (SqlConnection cnn = Conexion.ObternerConexion())
                    {
                        string thb = "SELECT COUNT (*)FROM (SELECT DOCIDENTIDAD_NIÑ@  FROM DENOMINADORSII02 WHERE DOCIDENTIDAD_NIÑ@='" + txtbuscar.Text + "') AS T";
                        SqlCommand hbt = new SqlCommand(thb, cnn);
                        string totalhb;
                        totalhb = hbt.ExecuteScalar().ToString();
                        ////////////////////////////////////////////////
                        if (totalhb != "0")
                        {
                            lblestaIndicador.Text = "SI";
                            lblestaIndicador.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblestaIndicador.Text = "NO";
                            lblestaIndicador.ForeColor = Color.Red;
                        }
                        //--------------------
                        string tvih = "SELECT COUNT (*)FROM (SELECT DOCIDENTIDAD_NIÑ@  FROM NUMERADOR2 WHERE DOCIDENTIDAD_NIÑ@='" + txtbuscar.Text + "') AS T";
                        SqlCommand viht = new SqlCommand(tvih, cnn);
                        string totalvih;
                        totalvih = viht.ExecuteScalar().ToString();
                        ////////////////////////////////////////////////
                        if (totalvih != "0")
                        {
                            lblCumpleIndicador.Text = "SI";
                            lblCumpleIndicador.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblCumpleIndicador.Text = "NO";
                            lblCumpleIndicador.ForeColor = Color.Red;
                        }

                        cnn.Close();
                    }
                }
                catch (Exception ex)
                {

                }
            }else if(edadActual.Text == "0"  && mesActual.Text =="6" || mesActual.Text == "7" || mesActual.Text == "8")
            {
                try
                {
                    using (SqlConnection cnn = Conexion.ObternerConexion())
                    {
                        string thb = "SELECT COUNT (*)FROM (SELECT DOCIDENTIDAD FROM PADRON WHERE DOCIDENTIDAD='" + txtbuscar.Text + "') AS T";
                        SqlCommand hbt = new SqlCommand(thb, cnn);
                        string totalhb;
                        totalhb = hbt.ExecuteScalar().ToString();
                        ////////////////////////////////////////////////
                        if (totalhb != "0")
                        {
                            lblestaIndicador.Text = "SI";
                            lblestaIndicador.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblestaIndicador.Text = "NO";
                            lblestaIndicador.ForeColor = Color.Red;
                        }
                        //--------------------
                        string tvih = "SELECT COUNT (*)FROM (SELECT DOCIDENTIDAD FROM NUMERADOR3 WHERE DOCIDENTIDAD='" + txtbuscar.Text + "') AS T";
                        SqlCommand viht = new SqlCommand(tvih, cnn);
                        string totalvih;
                        totalvih = viht.ExecuteScalar().ToString();
                        ////////////////////////////////////////////////
                        if (totalvih != "0")
                        {
                            lblCumpleIndicador.Text = "SI";
                            lblCumpleIndicador.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblCumpleIndicador.Text = "NO";
                            lblCumpleIndicador.ForeColor = Color.Red;
                        }

                        cnn.Close();
                    }
                }
                catch (Exception ex)
                {

                }
            }
            
        }
        //calcular edad a la fecha de actual
        public void calcularEdad()
        {
            DateTime FechaNacimiento =Convert.ToDateTime(fecNac.Text);
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
        //calcular edad a la fecha de atencion
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

        private void citasNurse_Load(object sender, EventArgs e)
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
            usuariosFirebase resultado = resp2.ResultAs<usuariosFirebase>();
            /// variable para mostrar red si su microred es todo--

            string area = resultado.cbarea;
            string consultorio = resultado.cbconsultorio;

            if (area == "ENFERMERIA")
            {
                cbarea.Text = resultado.cbarea;
                cbconsultorio.Text = resultado.cbconsultorio;
                cbprofesional.Text = resultado.txtnombre;

                cbarea.Enabled = false;
                cbconsultorio.Enabled = false;
                cbprofesional.Enabled = false;
            }
            else if (area=="MEDICINA")
            {
                cbarea.Text = resultado.cbarea;
                cbconsultorio.Text = resultado.cbconsultorio;
                cbprofesional.Text = resultado.txtnombre;

                cbarea.Enabled = false;
                cbconsultorio.Enabled = false;
                cbprofesional.Enabled = false;
            }
            else
            {
                btnguardar.Visible = false;
            }

            totalhora = "0";
           
            //AreaCons.Enabled = false;
            cbFiltroConsu.Text = resultado.cbarea;
            if ( cbFiltroConsu.Text=="MEDICINA")
            {
                cbFiltroConsu.Enabled = false;
                DetalleCitas.Visible = true;
                DetalleIndicador.Visible = false;
            }
            else if(cbFiltroConsu.Text == "ENFERMERIA")
            {
                cbFiltroConsu.Enabled = false;
                DetalleCitas.Visible = true;
                DetalleIndicador.Visible = true;
            }

            filtroAreaConsultorio.Text = resultado.cbconsultorio;
            filtroAreaConsultorio.Enabled = false;
            //cargar_Areaconsultorio();

            fecActual = DateTime.Now.ToString("dd-MM-yyyy");
            lblFechaActual.Text = fecActual;
            lblfechpc.Text = DateTime.Now.ToLongDateString();
            //SiAtendio();

            //carga el total de citas disponibles
            CitasDisponible();
        }

        private void fechaAtencion_TabIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void fechaAtencion_ValueChanged(object sender, EventArgs e)
        {
            contarSiExisteHora();
            cargar_HoraConsul();
            calcularEdadAtencion();
            calcularEdad();
            indicadorFed();
            CitasDisponible();

        }

        ///CARGA LOS CONSULTARIO --SE DESHABILITO EN LA VERSION EN LINEA
        //public void cargar_consultorio()
        //{
        //    using (SqlConnection cnn = Conexion.ObternerConexion())
        //    {

        //        SqlCommand cmd = new SqlCommand("select NOMBRE_CONS from CONSULTORIO_CITA where CONSULTORIO='" + cbarea.Text + "' GROUP BY NOMBRE_CONS", cnn);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        cnn.Close();

        //        DataRow fila = dt.NewRow();
        //        dt.Rows.InsertAt(fila, 0);

        //        cbconsultorio.ValueMember = "NOMBRE_CONS";
        //        cbconsultorio.DisplayMember = "NOMBRE_CONS";
        //        cbconsultorio.DataSource = dt;
        //    }
        //}
        ///----------------------------------------------
        public void cargar_Areaconsultorio()
        {
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {

                SqlCommand cmd = new SqlCommand("select NOMBRE_CONS from CONSULTORIO_CITA where CONSULTORIO='" + cbFiltroConsu.Text + "' GROUP BY NOMBRE_CONS", cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();

                DataRow fila = dt.NewRow();
                fila["NOMBRE_CONS"] = "TODO";
                dt.Rows.InsertAt(fila, 0);

                filtroAreaConsultorio.ValueMember = "NOMBRE_CONS";
                filtroAreaConsultorio.DisplayMember = "NOMBRE_CONS";
                filtroAreaConsultorio.DataSource = dt;
            }
        }
        public void cargar_Madre_consultorio()
        {
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {

                SqlCommand cmd = new SqlCommand("select CONSULTORIO from CONSULTORIO_CITA  GROUP BY CONSULTORIO", cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();

                DataRow fila = dt.NewRow();
                dt.Rows.InsertAt(fila, 1);

                cbFiltroConsu.ValueMember = "CONSULTORIO";
                cbFiltroConsu.DisplayMember = "CONSULTORIO";
                cbFiltroConsu.DataSource = dt;
            }
        }
        //
        public void cargar_datosPersonal()
        {
            if (Forms_consultorio.LoginOffline.dniOfline is null)
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    SqlCommand cmd = new SqlCommand("SELECT NUMERO_DOCUMENTO, (NOMBRES_PERSONAL +' '+APELLIDO_PATERNO_PERSONAL+' '+APELLIDO_MATERNO_PERSONAL) AS PERSONAL FROM PERSONAL WHERE NUMERO_DOCUMENTO='" + LoginFed.dniOfline + "' GROUP BY NUMERO_DOCUMENTO, NOMBRES_PERSONAL,APELLIDO_PATERNO_PERSONAL,APELLIDO_MATERNO_PERSONAL", cnn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cnn.Close();
                    DataRow dr = dt.NewRow();
                    dt.Rows.InsertAt(dr, 1);
                    cbprofesional.ValueMember = "PERSONAL";
                    cbprofesional.ValueMember = "PERSONAL";
                    cbprofesional.DataSource = dt;
                }
            }
            else 
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    SqlCommand cmd = new SqlCommand("SELECT NUMERO_DOCUMENTO, (NOMBRES_PERSONAL +' '+APELLIDO_PATERNO_PERSONAL+' '+APELLIDO_MATERNO_PERSONAL) AS PERSONAL FROM PERSONAL WHERE NUMERO_DOCUMENTO='" + Forms_consultorio.LoginOffline.dniOfline + "' GROUP BY NUMERO_DOCUMENTO, NOMBRES_PERSONAL,APELLIDO_PATERNO_PERSONAL,APELLIDO_MATERNO_PERSONAL", cnn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cnn.Close();
                    DataRow dr = dt.NewRow();
                    dt.Rows.InsertAt(dr, 1);

                    cbprofesional.ValueMember = "PERSONAL";
                    cbprofesional.ValueMember = "PERSONAL";
                    cbprofesional.DataSource = dt;
                    filtroAreaConsultorio.Text = Forms_consultorio.LoginOffline.consOffline;
                    cbarea.Text = Forms_consultorio.LoginOffline.consOffline;
                }
            }
            

            
        }
        public void contarSiExisteHora()
        {
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {
                // muestra el total del denominador en un label
                string query = "SELECT COUNT(*) FROM (SELECT HORA_ATENCION  FROM CITAS WHERE CONVERT(DATE,FECHA_ATENCION,103)='" + fechaAtencion.Text + "'AND CONSULTORIO='" + cbconsultorio.Text + "' AND ID_CONSULTORIO='"+cbarea.Text+"' AND (HORA_ATENCION NOT IN('')OR HORA_ATENCION IS NULL))T";
                SqlCommand cmd2 = new SqlCommand(query, cnn);
                totalhora = cmd2.ExecuteScalar().ToString();
                cantidadHora = Int32.Parse(totalhora);

                cnn.Close();
            }
        }
        public void cargar_HoraConsul()
        {
            if (cantidadHora >=1)
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Select CC.NOMBRE_CONS,CC.HORA,CC.CONSULTORIO from CONSULTORIO_CITA AS CC INNER JOIN CITAS AS C ON C.CONSULTORIO=CC.NOMBRE_CONS  where CC.HORA NOT IN (select c.HORA_ATENCION from citas as c inner join CONSULTORIO_CITA as cc on  c.HORA_ATENCION=cc.hora  where CONVERT(DATE, C.FECHA_ATENCION,103)='" + fechaAtencion.Text + "' AND (C.ID_CONSULTORIO='" + cbarea.Text + "' AND C.CONSULTORIO='" + cbconsultorio.Text + "'))  AND (C.ID_CONSULTORIO='" + cbarea.Text + "' AND C.CONSULTORIO='" + cbconsultorio.Text + "')  GROUP BY CC.NOMBRE_CONS,CC.HORA,CC.CONSULTORIO", cnn);
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
            else if(cantidadHora==0)
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    // muestra el total del denominador en un label
                    SqlCommand cmd = new SqlCommand("SELECT HORA FROM CONSULTORIO_CITA WHERE  CONSULTORIO='" + cbarea.Text + "' AND NOMBRE_CONS='" + cbconsultorio.Text + "'", cnn);
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

            }
 
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (dni.Text =="" || nomPac.Text == "" || fechaAtencion.Text =="" || cbhora.Text == "" || cbhora.Text == "  :" || sexo.Text == "" || hcl.Text =="" || cel.Text == "" || cbarea.Text == "" || cbhora    .Text == "" || direccion.Text == "")
            {
                MessageBox.Show("Por Favor completar los campos obligatorios");
            }
            else
            {

                guardarCitas();
                filtroCitas();
                totalCitas();
                cargar_HoraConsul();
                limpiarTxt();

                lblestaIndicador.Text = "";
                lblCumpleIndicador.Text = "";
            } 
        }
        public void guardarCitas()
        {
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO CITAS(DNI,NOMBRE_PACIENTE,FECHA_ATENCION,HORA_ATENCION,EDAD_ACTUAL,MES_ACTUAL,DIA_ACTUAL,SEXO,FECHA_NACIMIENTO," +
                    "EDAD_ATENCION,MES_ATENCION,DIA_ATENCION,HCL,CEL,MOTIVO_ATENCION,CONSULTORIO,PROFESIONAL_REGISTRA,DIRECCION,OBSERVACIONES,FEC_REGIST_CITA,ID_CONSULTORIO)" +
                    "VALUES('" +this.dni.Text+ "','" + this.nomPac.Text + "','" + this.fechaAtencion.Text + "','" + this.cbhora.Text + "'" +
                    ",'" + this.edadActual.Text + "','" + this.mesActual.Text + "','" + this.diaActual.Text + "','" + this.sexo.Text +
                    "','" + this.fecNac.Text + "','" + this.edadAtencion.Text + "','" + this.mesAtencion.Text + "','" + this.diaAtencion.Text +
                    "','" + this.hcl.Text + "','" + this.cel.Text + "','" + this.motAte.Text + "','" + this.cbconsultorio.Text + "','" + this.cbprofesional.Text +
                    "','" + this.direccion.Text + "','" + this.observacion.Text + "','"+this.lblFechaActual.Text+ "','" + this.cbarea.Text + "')", cnn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cita Guardado");

                cnn.Close();
            }
        }
        public void UpdateCita()
        {
            if (lbl_IdCita.Text!="..." && lblNomPac.Text!="...")
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {

                    SqlCommand cmd = new SqlCommand("UPDATE  CITAS SET ESTADO='" + seAtendio.Text + "' where id_cita=" + Convert.ToInt32(lbl_IdCita.Text), cnn);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                filtroCitas();//actualiza la tabla 
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (LoginFed.estadosesion !="1")
            {
                 this.Close();
            }
            else
            {
                Application.Exit();
            }
            
        }

        private void fecNac_ValueChanged(object sender, EventArgs e)
        {
            calcularEdadAtencion();
            calcularEdad();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiarTxt();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtroCitas();
            totalCitas();
        }

        public void filtroCitas()
        {
            string fechainicio = fechaInicio.Value.ToString("dd-MM-yyyy");

            if (filtroAreaConsultorio.Text=="TODO")
            {
                try
                {
                    using (SqlConnection cnn = Conexion.ObternerConexion())
                    {
                        SqlCommand cmd;
                        SqlDataReader dr;
                        SqlDataAdapter da;
                        DataTable dt;
                        da = new SqlDataAdapter("SELECT * FROM CITAS WHERE ID_CONSULTORIO='"+cbFiltroConsu.Text+ "' AND CONVERT(DATE,FECHA_ATENCION,103) ='" + fechainicio + "'", cnn);
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
            }else
                try
                {
                    using (SqlConnection cnn = Conexion.ObternerConexion())
                    {
                        SqlCommand cmd;
                        SqlDataReader dr;
                        SqlDataAdapter da;
                        DataTable dt;
                        da = new SqlDataAdapter("SELECT * FROM CITAS WHERE ID_CONSULTORIO='" + cbFiltroConsu.Text + "' AND  CONSULTORIO IN('" + filtroAreaConsultorio.Text + "') AND CONVERT(DATE,FECHA_ATENCION,103)='" + fechainicio + "'", cnn);
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

        public void totalCitas ()
        {
            if (filtroAreaConsultorio.Text=="TODO")
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    string fechainicio = fechaInicio.Value.ToString("dd-MM-yyyy");
                    // muestra el total del denominador en un label
                    string query = "SELECT count(*)  FROM (SELECT DNI FROM CITAS WHERE  ID_CONSULTORIO='" + cbFiltroConsu.Text + "' AND  CONVERT(DATE,FECHA_ATENCION,103) ='" + fechainicio+ "')AS T";
                    SqlCommand cmd2 = new SqlCommand(query, cnn);
                    lblTotalCitas.Text = cmd2.ExecuteScalar().ToString();

                    string query3 = "SELECT count(*)  FROM (SELECT DNI FROM CITAS WHERE ID_CONSULTORIO='" + cbFiltroConsu.Text + "' AND  CONSULTORIO IN('" + filtroAreaConsultorio.Text + "') AND  CONVERT(DATE,FECHA_ATENCION,103) ='" + fechainicio + "' AND ESTADO='SI')AS T";
                    SqlCommand cmd3 = new SqlCommand(query3, cnn);
                    lblAtendidos.Text = cmd3.ExecuteScalar().ToString();

                    string query4 = "SELECT count(*)  FROM (SELECT DNI FROM CITAS WHERE ID_CONSULTORIO='" + cbFiltroConsu.Text + "' AND  CONSULTORIO IN('" + filtroAreaConsultorio.Text + "') AND  CONVERT(DATE,FECHA_ATENCION,103) ='" + fechainicio + "' AND (ESTADO='NO'OR ESTADO IS NULL))AS T";
                    SqlCommand cmd4 = new SqlCommand(query4, cnn);
                    lblFaltaAtende.Text = cmd4.ExecuteScalar().ToString();

                    cnn.Close();
                }
            }else
                {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    string fechainicio = fechaInicio.Value.ToString("dd-MM-yyyy");

                    // muestra el total del denominador en un label
                    string query = "SELECT count(*)  FROM (SELECT DNI FROM CITAS WHERE ID_CONSULTORIO='" + cbFiltroConsu.Text + "' AND CONSULTORIO IN('" + filtroAreaConsultorio.Text+ "') AND CONVERT(DATE,FECHA_ATENCION,103) ='" + fechainicio + "')AS T";
                    SqlCommand cmd2 = new SqlCommand(query, cnn);
                    lblTotalCitas.Text = cmd2.ExecuteScalar().ToString();

                    string query3 = "SELECT count(*)  FROM (SELECT DNI FROM CITAS WHERE ID_CONSULTORIO='" + cbFiltroConsu.Text + "' AND CONSULTORIO IN('" + filtroAreaConsultorio.Text + "') AND CONVERT(DATE,FECHA_ATENCION,103) ='" + fechainicio + "' AND ESTADO='SI')AS T";
                    SqlCommand cmd3 = new SqlCommand(query3, cnn);
                    lblAtendidos.Text = cmd3.ExecuteScalar().ToString();

                    string query4 = "SELECT count(*)  FROM (SELECT DNI FROM CITAS WHERE ID_CONSULTORIO='" + cbFiltroConsu.Text + "' AND CONSULTORIO IN('" + filtroAreaConsultorio.Text + "') AND CONVERT(DATE,FECHA_ATENCION,103) ='" + fechainicio + "' AND (ESTADO='NO'OR ESTADO IS NULL))AS T";
                    SqlCommand cmd4 = new SqlCommand(query4, cnn);
                    lblFaltaAtende.Text = cmd4.ExecuteScalar().ToString();
                    cnn.Close();
                }
            }

        }


        //CITAS DISPONIBLE
        public void CitasDisponible()
        {
            string totalCitas;
            string citasOcupadas;
            int CitasDispo;

                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    string fechainicio = fechaInicio.Value.ToString("dd-MM-yyyy");
                    // muestra el total del denominador en un label
                    string query = "SELECT count(*) AS TOTAL  FROM (SELECT HORA FROM CONSULTORIO_CITA WHERE  CONSULTORIO='"+cbarea.Text+"' AND NOMBRE_CONS='"+cbconsultorio.Text+"' )AS T";
                    SqlCommand cmd2 = new SqlCommand(query, cnn);
                    totalCitas = cmd2.ExecuteScalar().ToString();

                    string query3 = "SELECT count(*) AS TOTAL  FROM (SELECT DNI FROM CITAS WHERE  ID_CONSULTORIO='"+cbarea.Text+"' AND CONSULTORIO='"+cbconsultorio.Text+"' AND  CONVERT(DATE,FECHA_ATENCION,103) ='"+fechaAtencion.Text+"')AS T";
                    SqlCommand cmd3 = new SqlCommand(query3, cnn);
                    citasOcupadas = cmd3.ExecuteScalar().ToString();

                CitasDispo = Convert.ToInt32(totalCitas)- Convert.ToInt32(citasOcupadas);
                lblcitasDisponibles.Text = Convert.ToString(CitasDispo);

                    cnn.Close();
                }
       
        }

        private void dgvcitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        public void SiAtendio()
        {

        }
        public void controlesFed()//no se esta utilizando ...
        {

            try
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    string thb = "SELECT COUNT (*)FROM (SELECT ID_CITA  FROM HIS WHERE ID_CITA=" + dgvcitas.CurrentRow.Cells["ID_CITA"].Value.ToString() + " AND COD_ITEM IN ('85018' ,'85018.01')) AS T";
                    SqlCommand hbt = new SqlCommand(thb, cnn);

                }
            }
            catch (Exception ex)
            {

            }

        }

        private void cbprofesional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void observacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbconsultorio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvcitas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            lbl_IdCita.Text = dgvcitas.CurrentRow.Cells["ID_CITA"].Value.ToString();
            lblNomPac.Text = dgvcitas.CurrentRow.Cells["NOMBRE_PACIENTE"].Value.ToString();
            seAtendio.Text = dgvcitas.CurrentRow.Cells["ESTADO"].Value.ToString();

            if (lbl_IdCita.Text != "..." && lblNomPac.Text != "...")
            {
                btnActualizaAtendio.Enabled = true;
            }
            else
            {
                btnActualizaAtendio.Enabled = false;
            }


        }

        public void ActualizaVistaPregunta()
        {
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {
                lblNomPac.Text = "";
                seAtendio.Text = "";
                // muestra el total del denominador en un label
                string query = "select ID_CITA,NOMBRE_PACIENTE,ESTADO from CITAS where id_cita=" + Convert.ToInt32(lbl_IdCita.Text);
                SqlCommand cmd2 = new SqlCommand(query, cnn);
                SqlDataReader leer1 = cmd2.ExecuteReader();
                if (leer1.Read() == true)
                {
                    lbl_IdCita.Text = leer1["ID_CITA"].ToString();
                    lblNomPac.Text = leer1["NOMBRE_PACIENTE"].ToString();
                    seAtendio.Text = leer1["ESTADO"].ToString();
                }

                cnn.Close();
            }
        }

        private void btnActualizaAtendio_Click(object sender, EventArgs e)
        {
            if (seAtendio.Text != "" && lbl_IdCita.Text != "..." && lblNomPac.Text != "...")
            {
                UpdateCita();
                filtroCitas();
                totalCitas();
                ActualizaVistaPregunta();
            }
            else
                btnActualizaAtendio.Enabled = false;
        }

        private void lbl_IdCita_TextChanged(object sender, EventArgs e)
        {
            if (lbl_IdCita.Text != "..." && lblNomPac.Text!="...")
            {
                btnActualizaAtendio.Enabled = true;
            }
            else
                btnActualizaAtendio.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms_consultorio.UpdateCitas UpdateCitas = new Forms_consultorio.UpdateCitas();
            UpdateCitas.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            limpiarTxt();
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                buscarCitas();
                if (txtbuscar.MaxLength >= 8)
                {
                    using (SqlConnection cnn = Conexion.ObternerConexion())
                    {
                        // busca en la tabla his
                        SqlCommand cmd = new SqlCommand("SELECT * FROM HIS WHERE NRO_DOC='" + txtbuscar.Text + "'", cnn);
                        SqlDataReader leer = cmd.ExecuteReader();
                        if (resultadoBusqueda != "")
                        {
                            buscarCitas();
                        }
                        else if (leer.Read() == true)
                        {
                            //NRO_DOC,NOMBRE_PACIENTE,FECHA_NAC,SEXO,HCL,
                            dni.Text = leer["NRO_DOC"].ToString();
                            nomPac.Text = leer["NOMBRE_PACIENTE"].ToString();
                            fecNac.Text = leer["FECHA_NAC"].ToString();
                            sexo.Text = leer["SEXO"].ToString();
                            hcl.Text = leer["HCL"].ToString();
                            dni.Text = leer["NRO_DOC"].ToString();

                            calcularEdad();
                            calcularEdadAtencion();
                            indicadorFed();
                        }
                        else
                        {
                            MessageBox.Show("No se Encontraron Datos del Paciente");
                        }
                        cnn.Close();
                    }
                }
                else if (txtbuscar.MaxLength < 8)
                {
                    MessageBox.Show("Ingrese 8 digitos");
                }
            }
        }

        private void AreaCons_SelectedIndexChanged(object sender, EventArgs e)
        {
            contarSiExisteHora();
            cargar_HoraConsul();
        }

        private void cbFiltroConsu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargar_Areaconsultorio();
            filtroCitas();
            totalCitas();
        }

        private void lblTotalCitas_Click(object sender, EventArgs e)
        {

        }
    }
}
