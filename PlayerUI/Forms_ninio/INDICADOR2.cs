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
using System.IO;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace PlayerUI
{
    public partial class INDICADOR2 : Form
    {

        public INDICADOR2()
        {
            InitializeComponent();

            cargar_datosDisa();
        }

        public static string datosusuarios = LoginFed.datosusurios;
        public static string usuario;
        public static string ambito;

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "lb9bGeiKqFTj7OqRuiZIEkqy0fte0P8Hu2jyXAU5",
            BasePath = "https://usuariosfed-1b8f8-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public void cargar_datosDisa()
        {
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {

                SqlCommand cmd = new SqlCommand("SELECT DISA FROM ESTABLECIMIENTOS  GROUP BY DISA ORDER BY DISA", cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();

                DataRow fila = dt.NewRow();
                fila["DISA"] = "Seleccione Disa";
                dt.Rows.InsertAt(fila, 0);

                cbdisa.ValueMember = "disa";
                cbdisa.DisplayMember = "disa";
                cbdisa.DataSource = dt;
            }
        }

        public void cargar_datosRed(string disa)
        {
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT RED FROM ESTABLECIMIENTOS WHERE Disa=@disa  GROUP BY RED", cnn);
                cmd.Parameters.AddWithValue("disa", disa);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();

                DataRow dr = dt.NewRow();
                dr["Red"] = "Seleccione Red";
                dt.Rows.InsertAt(dr, 0);

                cbred.ValueMember = "RED";
                cbred.ValueMember = "RED";
                cbred.DataSource = dt;

            }
        }


        public void cargar_datosMicrored(string red)
        {
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT MICRORED FROM ESTABLECIMIENTOS WHERE red=@red  GROUP BY MICRORED", cnn);
                cmd.Parameters.AddWithValue("red", red);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();

                DataRow dr = dt.NewRow();
                dr["MicroRed"] = "Seleccione Microred";
                dt.Rows.InsertAt(dr, 0);

                cbmicrored.ValueMember = "MicroRed";
                cbmicrored.ValueMember = "MicroRed";
                cbmicrored.DataSource = dt;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////////////////////////////segun usurio////////////////////////////////////////////////////////////////
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
            usuariosFirebase resultado = resp2.ResultAs<usuariosFirebase>();
            cbambito.Text = resultado.cbambito;
            cbdisa.Text = resultado.cbdepartamento;
            cbred.Text = resultado.cbred;
            cbmicrored.Text = resultado.cbmicrored;

/////////////////////////////////////////////////////////
            ambito = resultado.cbambito;
            if (resultado.cbambito=="Disa")
            {
                cbambito.Items.Add("Disa");
                cbambito.Items.Add("Red");
                cbambito.Items.Add("Microred");

                cbdisa.Enabled = false;
                cbred.Enabled = false;
                cbmicrored.Enabled = false;
            }
            else if (resultado.cbambito == "Red")
            {
                cbambito.Items.Add("Red");
                cbambito.Items.Add("Microred");

                cbdisa.Enabled = false;
                cbred.Enabled = false;
                cbmicrored.Enabled = false;
            }
            else
            {
                cbambito.Enabled = false;
                cbdisa.Enabled = false;
                cbred.Enabled = false;
                cbmicrored.Enabled = false;

            }

        }


        private void INDICADOR2_Load(object sender, EventArgs e)
        {
            fechainicio.Value = DateTime.Now;
            fechafin.Value = DateTime.Now;
            mis_datos();

            denominador.Visible = false;
            btnnumerador.Visible = false;
            btnexportar.Visible = false;
            btnfalta.Visible = false;
            llenarItems(cbanio);///LLENA EL COMBO BOX AÑO DE L DATAHIS TABLA HIS MINSA
            //c.llenarRed(cbdepartamento);///LLENA EL COMBO BOX AÑO DE L DATAHIS TABLA ESTABLECIMIENTO


        }
        public void llenarItems(ComboBox cb)
        {
            try
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    SqlCommand cmd;
                    SqlDataReader dr;
                    SqlDataAdapter da;
                    DataTable dt;
                    cmd = new SqlCommand("select anio from his group by anio ", cnn);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        cb.Items.Add(dr["ANIO"].ToString());
                    }
                    cb.SelectedIndex = 0;
                    dr.Close();
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void cbred_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbdisa.SelectedValue.ToString() != null)
            {
                string departamento = cbdisa.SelectedValue.ToString();
                cargar_datosRed(departamento);
            }

        }

        private void cbmicrored_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbred.SelectedValue.ToString() != null)
            {
                string provincia = cbred.SelectedValue.ToString();
                cargar_datosMicrored(provincia);
            }

        }

        /////////////////boton procesar indicador 2
        private void btnprocesar_Click(object sender, EventArgs e)
        {      
            denominador.Visible = true;
            btnnumerador.Visible = true;
            btnexportar.Visible = true;
            btnfalta.Visible = true;
            if (cbambito.Text == "Disa")
            {
                if (cbmicrored.Text == "")
                {
                    MessageBox.Show("Seleccione su Disa");
                }
                else  //45 spacios segun combobox
                {
                    using (SqlConnection cnn = Conexion.ObternerConexion())
                    {
                        DataTable dt = new DataTable();
                        string strSql;
                        strSql = "SP_INDICADOR2DISA";
                        SqlDataAdapter da = new SqlDataAdapter(strSql, cnn);

                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.Add("@fechainicio", SqlDbType.VarChar).Value = fechainicio.Text;
                        da.SelectCommand.Parameters.Add("@fechafin", SqlDbType.VarChar).Value = fechafin.Text;
                        da.SelectCommand.Parameters.Add("@disa", SqlDbType.VarChar).Value = cbdisa.Text;
                        //da.SelectCommand.Parameters.Add("@red", SqlDbType.VarChar).Value = cbred.Text;
                        //da.SelectCommand.Parameters.Add("@microred", SqlDbType.VarChar).Value = cbmicrored.Text;
                        da.Fill(dt);
                        cargar_indicador2(dataGridView1);
                        // muestra el total del denominador en un label
                        string query = "SELECT count(*) from (SELECT DOCIDENTIDAD_NIÑ@ FROM DENOMINADORSII02 group by DOCIDENTIDAD_NIÑ@)as t";
                        SqlCommand cmd2 = new SqlCommand(query, cnn);
                        lbldenominador.Text = cmd2.ExecuteScalar().ToString();

                        // muestra el total del numerador en un label
                        string query2 = "SELECT count(*) from (SELECT DOCIDENTIDAD_NIÑ@ FROM NUMERADOR2 group by DOCIDENTIDAD_NIÑ@)as t";
                        SqlCommand cmd3 = new SqlCommand(query2, cnn);
                        lblnumerador.Text = cmd3.ExecuteScalar().ToString();

                        // muestra el total del numerador en un label
                        string query3 = "SELECT count(*) from (select d.DOCIDENTIDAD_NIÑ@ from DENOMINADORSII02 as d LEFT join NUMERADOR2 as n ON D.DOCIDENTIDAD_NIÑ@=n.DOCIDENTIDAD_NIÑ@ WHERE n.CODIGO_ITEM IS NULL group by d.DOCIDENTIDAD_NIÑ@) as t";
                        SqlCommand cmd4 = new SqlCommand(query3, cnn);
                        lblfalta.Text = cmd4.ExecuteScalar().ToString();
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Indicador 2 Listo.");
                        }
                        else
                        {
                            // mostrara el mesaje despues de cargar la tabla
                            MessageBox.Show("Proceso Termindo");
                        }
                        cnn.Close();
                    }
                }
            }
            else if (cbambito.Text == "Red")
            {
                if (cbmicrored.Text == "")
                {
                    MessageBox.Show("Seleccione su red");
                }
                else  //45 spacios segun combobox
                {
                    using (SqlConnection cnn = Conexion.ObternerConexion())
                    {
                        DataTable dt = new DataTable();
                        string strSql;
                        strSql = "SP_INDICADOR2RED";
                        SqlDataAdapter da = new SqlDataAdapter(strSql, cnn);

                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.Add("@fechainicio", SqlDbType.VarChar).Value = fechainicio.Text;
                        da.SelectCommand.Parameters.Add("@fechafin", SqlDbType.VarChar).Value = fechafin.Text;
                        da.SelectCommand.Parameters.Add("@disa", SqlDbType.VarChar).Value = cbdisa.Text;
                        da.SelectCommand.Parameters.Add("@red", SqlDbType.VarChar).Value = cbred.Text;
                        //da.SelectCommand.Parameters.Add("@microred", SqlDbType.VarChar).Value = cbmicrored.Text;
                        da.Fill(dt);
                        cargar_indicador2(dataGridView1);
                        // muestra el total del denominador en un label
                        string query = "SELECT count(*) from (SELECT DOCIDENTIDAD_NIÑ@ FROM DENOMINADORSII02 group by DOCIDENTIDAD_NIÑ@)as t";
                        SqlCommand cmd2 = new SqlCommand(query, cnn);
                        lbldenominador.Text = cmd2.ExecuteScalar().ToString();

                        // muestra el total del numerador en un label
                        string query2 = "SELECT count(*) from (SELECT DOCIDENTIDAD_NIÑ@ FROM NUMERADOR2 group by DOCIDENTIDAD_NIÑ@)as t";
                        SqlCommand cmd3 = new SqlCommand(query2, cnn);
                        lblnumerador.Text = cmd3.ExecuteScalar().ToString();

                        // muestra el total del numerador en un label
                        string query3 = "SELECT count(*) from (select d.DOCIDENTIDAD_NIÑ@ from DENOMINADORSII02 as d LEFT join NUMERADOR2 as n ON D.DOCIDENTIDAD_NIÑ@=n.DOCIDENTIDAD_NIÑ@ WHERE n.CODIGO_ITEM IS NULL group by d.DOCIDENTIDAD_NIÑ@) as t";
                        SqlCommand cmd4 = new SqlCommand(query3, cnn);
                        lblfalta.Text = cmd4.ExecuteScalar().ToString();
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Indicador 2 Listo.");
                        }
                        else
                        {
                            // mostrara el mesaje despues de cargar la tabla
                            MessageBox.Show("Proceso Termindo");
                        }
                        cnn.Close();
                    }
                }
            }
            else if (cbambito.Text == "Microred")
            {
                if (cbmicrored.Text == "")
                {
                    MessageBox.Show("Seleccione su microred");
                }
                else  //45 spacios segun combobox
                {
                    using (SqlConnection cnn = Conexion.ObternerConexion())
                    {
                        DataTable dt = new DataTable();
                        string strSql;
                        strSql = "SP_INDICADOR2";
                        SqlDataAdapter da = new SqlDataAdapter(strSql, cnn);

                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.Add("@fechainicio", SqlDbType.VarChar).Value = fechainicio.Text;
                        da.SelectCommand.Parameters.Add("@fechafin", SqlDbType.VarChar).Value = fechafin.Text;
                        da.SelectCommand.Parameters.Add("@disa", SqlDbType.VarChar).Value = cbdisa.Text;
                        da.SelectCommand.Parameters.Add("@red", SqlDbType.VarChar).Value = cbred.Text;
                        da.SelectCommand.Parameters.Add("@microred", SqlDbType.VarChar).Value = cbmicrored.Text;
                        da.Fill(dt);
                        cargar_indicador2(dataGridView1);
                        // muestra el total del denominador en un label
                        string query = "SELECT count(*) from (SELECT DOCIDENTIDAD_NIÑ@ FROM DENOMINADORSII02 group by DOCIDENTIDAD_NIÑ@)as t";
                        SqlCommand cmd2 = new SqlCommand(query, cnn);
                        lbldenominador.Text = cmd2.ExecuteScalar().ToString();

                        // muestra el total del numerador en un label
                        string query2 = "SELECT count(*) from (SELECT DOCIDENTIDAD_NIÑ@ FROM NUMERADOR2 group by DOCIDENTIDAD_NIÑ@)as t";
                        SqlCommand cmd3 = new SqlCommand(query2, cnn);
                        lblnumerador.Text = cmd3.ExecuteScalar().ToString();

                        // muestra el total del numerador en un label
                        string query3 = "SELECT count(*) from (select d.DOCIDENTIDAD_NIÑ@ from DENOMINADORSII02 as d LEFT join NUMERADOR2 as n ON D.DOCIDENTIDAD_NIÑ@=n.DOCIDENTIDAD_NIÑ@ WHERE n.CODIGO_ITEM IS NULL group by d.DOCIDENTIDAD_NIÑ@) as t";
                        SqlCommand cmd4 = new SqlCommand(query3, cnn);
                        lblfalta.Text = cmd4.ExecuteScalar().ToString();
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Indicador 2 Listo.");
                        }
                        else
                        {
                            // mostrara el mesaje despues de cargar la tabla
                            MessageBox.Show("Proceso Termindo");
                        }
                        cnn.Close();
                    }
                }
            }
        }

        //boton mostrar denominador 
        private void denominador_Click(object sender, EventArgs e)
        {
            cargar_indicador2(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargar_numerador2(dataGridView1);
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        /// exportar a un ecel
        public void ExportarDatos(DataGridView datalistado)
        {
            Microsoft.Office.Interop.Excel.Application exportarexcel = new Microsoft.Office.Interop.Excel.Application();

            exportarexcel.Application.Workbooks.Add(true);

            int indicecolumna = 0;


            foreach (DataGridViewColumn columna in datalistado.Columns)
            {
                indicecolumna++;

                exportarexcel.Cells[1, indicecolumna] = columna.Name;
            }

            int indicefila = 0;
            foreach (DataGridViewRow fila in datalistado.Rows)
            {
                indicefila++;
                indicecolumna = 0;

                foreach (DataGridViewColumn columna in datalistado.Columns)
                {
                    indicecolumna++;
                    exportarexcel.Cells[indicefila + 1, indicecolumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarexcel.Visible = true;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //ExportarDatos(dataGridView1);
            csv(dataGridView1);
        }

        public void csv(DataGridView tabla)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Archivo csv|*.csv" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                List<string> filas = new List<string>();

                List<string> cabeceras = new List<string>();
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    cabeceras.Add(col.HeaderText);
                }
                string SEP = ",";
                filas.Add(string.Join(SEP, cabeceras));

                foreach (DataGridViewRow fila in dataGridView1.Rows)
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


        public void cargar_indicador2(DataGridView dgv)
        {
            try
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    SqlCommand cmd;
                    SqlDataReader dr;
                    SqlDataAdapter da;
                    DataTable dt;
                    da = new SqlDataAdapter("SELECT departamento, Provincia,MicroRed,[CÓDIGO DEL EESS],ESTABLECIMIENTO,FECHANACIMIENTO,DOCIDENTIDAD_NIÑ@,NACIMIENTO,NOMBRE_NIÑ@,MADRE,[NOMBRE DE LA_PROVINCIA] FROM DENOMINADORSII02 GROUP BY departamento, Provincia,MicroRed,[CÓDIGO DEL EESS],ESTABLECIMIENTO,FECHANACIMIENTO,DOCIDENTIDAD_NIÑ@,NACIMIENTO,NOMBRE_NIÑ@,MADRE,[NOMBRE DE LA_PROVINCIA]", cnn);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay registros" + ex.ToString());
            }
        }


        public void cargar_numerador2(DataGridView dgv)
        {
            try
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    SqlCommand cmd;
                    SqlDataReader dr;
                    SqlDataAdapter da;
                    DataTable dt;
                    da = new SqlDataAdapter("SELECT ESTABLECIMIENTO,EESS_NACIMIENTO,FECHA_NACIMIENTO,DOCIDENTIDAD_NIÑ@,NOMBRE_NIÑ@,MADRE,CODIGO_ITEM,VALOR_LAB,FECHA_ATENCION FROM NUMERADOR2 GROUP BY ESTABLECIMIENTO,EESS_NACIMIENTO,FECHA_NACIMIENTO,DOCIDENTIDAD_NIÑ@,NOMBRE_NIÑ@,MADRE,CODIGO_ITEM,VALOR_LAB,FECHA_ATENCION", cnn);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay registros" + ex.ToString());
            }
        }

        public void falta2(DataGridView dgv)
        {
            try
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    SqlCommand cmd;
                    SqlDataReader dr;
                    SqlDataAdapter da;
                    DataTable dt;

                    da = new SqlDataAdapter("select d.Provincia,d.MicroRed,d.ESTABLECIMIENTO,d.FECHANACIMIENTO,d.NACIMIENTO,d.NOMBRE_NIÑ@,d.MADRE,d.DOCIDENTIDAD_NIÑ@,d.[NOMBRE DE LA_PROVINCIA] from DENOMINADORSII02 as d LEFT join NUMERADOR2 as n ON D.DOCIDENTIDAD_NIÑ@=n.DOCIDENTIDAD_NIÑ@ WHERE n.CODIGO_ITEM IS NULL group by d.Provincia,d.MicroRed,d.ESTABLECIMIENTO,d.FECHANACIMIENTO,d.NACIMIENTO,d.NOMBRE_NIÑ@,d.MADRE,d.DOCIDENTIDAD_NIÑ@,d.[NOMBRE DE LA_PROVINCIA]", cnn);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay registros" + ex.ToString());
            }
        }

        private void btnfalta_Click(object sender, EventArgs e)
        {
            falta2(dataGridView1);
        }

        private void fechafin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fechainicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbambito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbambito.Text == "Disa")
            {
                cbdisa.Enabled = false;
                cbred.Enabled = false;
                cbmicrored.Enabled = false;
            }
            else if (cbambito.Text == "Red" && ambito == "Disa")
            {
                cbdisa.Enabled = false;
                cbred.Enabled = true;
                cbmicrored.Enabled = false;
            }
            else if (cbambito.Text == "Microred" && ambito == "Disa")
            {
                cbdisa.Enabled = false;
                cbred.Enabled = true;
                cbmicrored.Enabled = true;
            }
            else if (cbambito.Text == "Red" && ambito == "Red")
            {
                cbdisa.Enabled = false;
                cbred.Enabled = false;
                cbmicrored.Enabled = false;
            }
            else if (cbambito.Text == "Microred" && ambito == "Red")
            {
                cbmicrored.Enabled = true;
            }
            else
            {
                cbdisa.Enabled = false;
                cbred.Enabled = false;
                cbmicrored.Enabled = false;
            }
        }
    }
}
