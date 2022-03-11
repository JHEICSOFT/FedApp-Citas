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

namespace PlayerUI.Indicadores
{
    public partial class credCompleto : Form
    {
        public credCompleto()
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
            if (resultado.cbambito == "Disa")
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

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void credCompleto_Load(object sender, EventArgs e)
        {
            fechainicio.Value = DateTime.Now;
            fechafin.Value = DateTime.Now;
            mis_datos();
            denominador.Visible = false;
            btnnumerador.Visible = false;
            btnexportar.Visible = false;
            btnfalta.Visible = false;
            llenarItems(cbanio);
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
                        strSql = "SP_CRED_COMPLETODISA";
                        SqlDataAdapter da = new SqlDataAdapter(strSql, cnn);

                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.Add("@fechainicio", SqlDbType.VarChar).Value = fechainicio.Text;
                        da.SelectCommand.Parameters.Add("@fechafin", SqlDbType.VarChar).Value = fechafin.Text;
                        da.SelectCommand.Parameters.Add("@disa", SqlDbType.VarChar).Value = cbdisa.Text;
                        //da.SelectCommand.Parameters.Add("@red", SqlDbType.VarChar).Value = cbred.Text;
                        // da.SelectCommand.Parameters.Add("@microred", SqlDbType.VarChar).Value = cbmicrored.Text;
                        da.Fill(dt);

                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandTimeout = 100;

                        cargar_denominador(dataGridView1);
                        // muestra el total del denominador en un label
                        string query = "SELECT count(*) from (SELECT DOCIDENTIDAD FROM POBLACIONSI06 group by DOCIDENTIDAD)as t";
                        SqlCommand cmd2 = new SqlCommand(query, cnn);
                        lbldenominador.Text = cmd2.ExecuteScalar().ToString();

                        // muestra el total del numerador en un label
                        string query2 = "SELECT count(*) from (SELECT NUMERO_DOCUMENTO FROM NUMERADORCREDCOMPLETO group by NUMERO_DOCUMENTO)as t";
                        SqlCommand cmd3 = new SqlCommand(query2, cnn);
                        lblnumerador.Text = cmd3.ExecuteScalar().ToString();

                        // muestra el total del numerador en un label
                        string query3 = "SELECT count(*) from (select d.DOCIDENTIDAD from POBLACIONSI06 as d LEFT join NUMERADORCREDCOMPLETO as n ON D.DOCIDENTIDAD=n.NUMERO_DOCUMENTO WHERE n.CODIGO_ITEM IS NULL group by d.DOCIDENTIDAD) as t";
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
                        strSql = "SP_CRED_COMPLETORED";
                        SqlDataAdapter da = new SqlDataAdapter(strSql, cnn);

                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.Add("@fechainicio", SqlDbType.VarChar).Value = fechainicio.Text;
                        da.SelectCommand.Parameters.Add("@fechafin", SqlDbType.VarChar).Value = fechafin.Text;
                        da.SelectCommand.Parameters.Add("@disa", SqlDbType.VarChar).Value = cbdisa.Text;
                        da.SelectCommand.Parameters.Add("@red", SqlDbType.VarChar).Value = cbred.Text;
                       // da.SelectCommand.Parameters.Add("@microred", SqlDbType.VarChar).Value = cbmicrored.Text;
                        da.Fill(dt);

                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandTimeout = 100;
                        cargar_denominador(dataGridView1);
                        // muestra el total del denominador en un label
                        string query = "SELECT count(*) from (SELECT DOCIDENTIDAD FROM POBLACIONSI06 group by DOCIDENTIDAD)as t";
                        SqlCommand cmd2 = new SqlCommand(query, cnn);
                        lbldenominador.Text = cmd2.ExecuteScalar().ToString();

                        // muestra el total del numerador en un label
                        string query2 = "SELECT count(*) from (SELECT NUMERO_DOCUMENTO FROM NUMERADORCREDCOMPLETO group by NUMERO_DOCUMENTO)as t";
                        SqlCommand cmd3 = new SqlCommand(query2, cnn);
                        lblnumerador.Text = cmd3.ExecuteScalar().ToString();

                        // muestra el total del numerador en un label
                        string query3 = "SELECT count(*) from (select d.DOCIDENTIDAD from POBLACIONSI06 as d LEFT join NUMERADORCREDCOMPLETO as n ON D.DOCIDENTIDAD=n.NUMERO_DOCUMENTO WHERE n.CODIGO_ITEM IS NULL group by d.DOCIDENTIDAD) as t";
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
                        strSql = "SP_CRED_COMPLETO";
                        SqlDataAdapter da = new SqlDataAdapter(strSql, cnn);

                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.Add("@fechainicio", SqlDbType.VarChar).Value = fechainicio.Text;
                        da.SelectCommand.Parameters.Add("@fechafin", SqlDbType.VarChar).Value = fechafin.Text;
                        da.SelectCommand.Parameters.Add("@disa", SqlDbType.VarChar).Value = cbdisa.Text;
                        da.SelectCommand.Parameters.Add("@red", SqlDbType.VarChar).Value = cbred.Text;
                        da.SelectCommand.Parameters.Add("@microred", SqlDbType.VarChar).Value = cbmicrored.Text;
                        da.Fill(dt);
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandTimeout = 100;
                        cargar_denominador(dataGridView1);
                        // muestra el total del denominador en un label
                        string query = "SELECT count(*) from (SELECT DOCIDENTIDAD FROM POBLACIONSI06 group by DOCIDENTIDAD)as t";
                        SqlCommand cmd2 = new SqlCommand(query, cnn);
                        lbldenominador.Text = cmd2.ExecuteScalar().ToString();

                        // muestra el total del numerador en un label
                        string query2 = "SELECT count(*) from (SELECT NUMERO_DOCUMENTO FROM NUMERADORCREDCOMPLETO group by NUMERO_DOCUMENTO)as t";
                        SqlCommand cmd3 = new SqlCommand(query2, cnn);
                        lblnumerador.Text = cmd3.ExecuteScalar().ToString();

                        // muestra el total del numerador en un label
                        string query3 = "SELECT count(*) from (select d.DOCIDENTIDAD from POBLACIONSI06 as d LEFT join NUMERADORCREDCOMPLETO as n ON D.DOCIDENTIDAD=n.NUMERO_DOCUMENTO WHERE n.CODIGO_ITEM IS NULL group by d.DOCIDENTIDAD) as t";
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

        public void cargar_denominador(DataGridView dgv)
        {
            try
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    SqlCommand cmd;
                    SqlDataReader dr;
                    SqlDataAdapter da;
                    DataTable dt;
                    da = new SqlDataAdapter("SELECT * FROM POBLACIONSI06", cnn);
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

        public void cargar_numerador(DataGridView dgv)
        {
            try
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    SqlCommand cmd;
                    SqlDataReader dr;
                    SqlDataAdapter da;
                    DataTable dt;
                    da = new SqlDataAdapter("SELECT * FROM NUMERADORCREDCOMPLETO", cnn);
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

        public void falta(DataGridView dgv)
        {
            try
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    SqlCommand cmd;
                    SqlDataReader dr;
                    SqlDataAdapter da;
                    DataTable dt;

                    da = new SqlDataAdapter("select * from POBLACIONSI06 as d LEFT join NUMERADORCREDCOMPLETO as n ON D.DOCIDENTIDAD=n.NUMERO_DOCUMENTO WHERE n.CODIGO_ITEM IS NULL", cnn);
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

        private void cbdisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbdisa.SelectedValue.ToString() != null)
            {
                string departamento = cbdisa.SelectedValue.ToString();
                cargar_datosRed(departamento);
            }
        }

        private void cbred_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbred.SelectedValue.ToString() != null)
            {
                string provincia = cbred.SelectedValue.ToString();
                cargar_datosMicrored(provincia);
            }
        }

        private void denominador_Click(object sender, EventArgs e)
        {
            cargar_denominador(dataGridView1);
        }

        private void btnnumerador_Click(object sender, EventArgs e)
        {
            cargar_numerador(dataGridView1);
        }

        private void btnfalta_Click(object sender, EventArgs e)
        {
            falta(dataGridView1);
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            csv(dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
