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
    public partial class INDICADOR3 : Form
    {
        public static string estado;//para mostrar informacion de sus atenciones

        public INDICADOR3()
        {
            InitializeComponent();
            cargar_datosDisa();
        }


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


        public static string datosusuarios = LoginFed.datosusurios;
        public static string usuario;
        public static string ambito;

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "lb9bGeiKqFTj7OqRuiZIEkqy0fte0P8Hu2jyXAU5",
            BasePath = "https://usuariosfed-1b8f8-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;


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
        ///////////////////////////////////////////////////////////////////////////////////////////////////

        private void INDICADOR3_Load(object sender, EventArgs e)
        {
            fechainicio.Value = DateTime.Now;
            fechafin.Value = DateTime.Now;
            mis_datos();

            btndenominador.Visible = false;
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

        private void cbdepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbdisa.SelectedValue.ToString() != null)
            {
                string departamento = cbdisa.SelectedValue.ToString();
                cargar_datosRed(departamento);
            }
        }

        private void cbprovincia_SelectedIndexChanged(object sender, EventArgs e)
        {
    
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            estado ="0";
            btndenominador.Visible = true;
            btnnumerador.Visible = true;
            btnexportar.Visible = true;
            btnfalta.Visible = true;
            // si selecciona nueva cajamarca
            if (cbambito.Text == "Disa")
            {
                if (cbred.Text == "")
                {
                    MessageBox.Show("Seleccione su Disa");
                }
                else  //45 spacios segun combobox
                {

                    using (SqlConnection cnn = Conexion.ObternerConexion())
                    {
                        DataTable dt = new DataTable();
                        string strSql;
                        strSql = "SP_INDICADOR3DISA";
                        SqlDataAdapter da = new SqlDataAdapter(strSql, cnn);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.Add("@fechainicio", SqlDbType.VarChar).Value = fechainicio.Text;
                        da.SelectCommand.Parameters.Add("@fechafin", SqlDbType.VarChar).Value = fechafin.Text;
                        da.SelectCommand.Parameters.Add("@disa", SqlDbType.VarChar).Value = cbdisa.Text;
                        //da.SelectCommand.Parameters.Add("@red", SqlDbType.VarChar).Value = cbred.Text;
                        //da.SelectCommand.Parameters.Add("@microred", SqlDbType.VarChar).Value = cbmicrored.Text;
                        da.Fill(dt);
                        cargar_indicador3(dataGridView1);

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Indicador 3 Listo.");
                        }
                        else
                        {
                            // mostrara el mesaje despues de cargar la tabla
                            MessageBox.Show("Proceso Termindo");
                        }

                        // muestra el total del denominador en un label
                        string query = "SELECT count(*) from (SELECT DOCIDENTIDAD FROM PADRON group by DOCIDENTIDAD)as t";
                        SqlCommand cmd2 = new SqlCommand(query, cnn);
                        lbldenominador.Text = cmd2.ExecuteScalar().ToString();

                        // muestra el total del numerador en un label
                        string query2 = "SELECT count(*) from (SELECT DOCIDENTIDAD FROM NUMERADOR3 group by DOCIDENTIDAD)as t";
                        SqlCommand cmd3 = new SqlCommand(query2, cnn);
                        lblnumerador.Text = cmd3.ExecuteScalar().ToString();

                        // muestra lo que del numerador en un label
                        string query3 = "SELECT count(*) from (select d.DOCIDENTIDAD from PADRON as d LEFT join NUMERADOR3 as n ON D.DOCIDENTIDAD=n.DOCIDENTIDAD WHERE n.RESULTADO IS NULL group by d.DOCIDENTIDAD) as t";
                        SqlCommand cmd4 = new SqlCommand(query3, cnn);
                        lblfalta.Text = cmd4.ExecuteScalar().ToString();
                        /////////////////////////////////////////////////////////////
                        cnn.Close();
                    }
                }
            }
            else if (cbambito.Text == "Red")
            {
                if (cbred.Text == "")
                {
                    MessageBox.Show("Seleccione su Microred");
                }
                else  //45 spacios segun combobox
                {

                    using (SqlConnection cnn = Conexion.ObternerConexion())
                    {
                        DataTable dt = new DataTable();
                        string strSql;
                        strSql = "SP_INDICADOR3RED";
                        SqlDataAdapter da = new SqlDataAdapter(strSql, cnn);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.Add("@fechainicio", SqlDbType.VarChar).Value = fechainicio.Text;
                        da.SelectCommand.Parameters.Add("@fechafin", SqlDbType.VarChar).Value = fechafin.Text;
                        da.SelectCommand.Parameters.Add("@disa", SqlDbType.VarChar).Value = cbdisa.Text;
                        da.SelectCommand.Parameters.Add("@red", SqlDbType.VarChar).Value = cbred.Text;
                       //da.SelectCommand.Parameters.Add("@microred", SqlDbType.VarChar).Value = cbmicrored.Text;
                        da.Fill(dt);
                        cargar_indicador3(dataGridView1);

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Indicador 3 Listo.");
                        }
                        else
                        {
                            // mostrara el mesaje despues de cargar la tabla
                            MessageBox.Show("Proceso Termindo");
                        }

                        // muestra el total del denominador en un label
                        string query = "SELECT count(*) from (SELECT DOCIDENTIDAD FROM PADRON group by DOCIDENTIDAD)as t";
                        SqlCommand cmd2 = new SqlCommand(query, cnn);
                        lbldenominador.Text = cmd2.ExecuteScalar().ToString();

                        // muestra el total del numerador en un label
                        string query2 = "SELECT count(*) from (SELECT DOCIDENTIDAD FROM NUMERADOR3 group by DOCIDENTIDAD)as t";
                        SqlCommand cmd3 = new SqlCommand(query2, cnn);
                        lblnumerador.Text = cmd3.ExecuteScalar().ToString();

                        // muestra lo que del numerador en un label
                        string query3 = "SELECT count(*) from (select d.DOCIDENTIDAD from PADRON as d LEFT join NUMERADOR3 as n ON D.DOCIDENTIDAD=n.DOCIDENTIDAD WHERE n.RESULTADO IS NULL group by d.DOCIDENTIDAD) as t";
                        SqlCommand cmd4 = new SqlCommand(query3, cnn);
                        lblfalta.Text = cmd4.ExecuteScalar().ToString();
                        /////////////////////////////////////////////////////////////
                        cnn.Close();
                    }
                }
            }
            else if (cbambito.Text == "Microred")
            {
                if (cbmicrored.Text == "")
                {
                    MessageBox.Show("Seleccione su Microred");
                }
                else  //45 spacios segun combobox
                {

                    using (SqlConnection cnn = Conexion.ObternerConexion())
                    {
                        DataTable dt = new DataTable();
                        string strSql;
                        strSql = "SP_INDICADOR3";
                        SqlDataAdapter da = new SqlDataAdapter(strSql, cnn);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.Add("@fechainicio", SqlDbType.VarChar).Value = fechainicio.Text;
                        da.SelectCommand.Parameters.Add("@fechafin", SqlDbType.VarChar).Value = fechafin.Text;
                        da.SelectCommand.Parameters.Add("@disa", SqlDbType.VarChar).Value = cbdisa.Text;
                        da.SelectCommand.Parameters.Add("@red", SqlDbType.VarChar).Value = cbred.Text;
                        da.SelectCommand.Parameters.Add("@microred", SqlDbType.VarChar).Value = cbmicrored.Text;
                        da.Fill(dt);
                        cargar_indicador3(dataGridView1);

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Indicador 3 Listo.");
                        }
                        else
                        {
                            // mostrara el mesaje despues de cargar la tabla
                            MessageBox.Show("Proceso Termindo");
                        }

                        // muestra el total del denominador en un label
                        string query = "SELECT count(*) from (SELECT DOCIDENTIDAD FROM PADRON group by DOCIDENTIDAD)as t";
                        SqlCommand cmd2 = new SqlCommand(query, cnn);
                        lbldenominador.Text = cmd2.ExecuteScalar().ToString();

                        // muestra el total del numerador en un label
                        string query2 = "SELECT count(*) from (SELECT DOCIDENTIDAD FROM NUMERADOR3 group by DOCIDENTIDAD)as t";
                        SqlCommand cmd3 = new SqlCommand(query2, cnn);
                        lblnumerador.Text = cmd3.ExecuteScalar().ToString();

                        // muestra lo que del numerador en un label
                        string query3 = "SELECT count(*) from (select d.DOCIDENTIDAD from PADRON as d LEFT join NUMERADOR3 as n ON D.DOCIDENTIDAD=n.DOCIDENTIDAD WHERE n.RESULTADO IS NULL group by d.DOCIDENTIDAD) as t";
                        SqlCommand cmd4 = new SqlCommand(query3, cnn);
                        lblfalta.Text = cmd4.ExecuteScalar().ToString();
                        /////////////////////////////////////////////////////////////
                        cnn.Close();
                    }
                }
            }
        }

        private void denominador_Click(object sender, EventArgs e)
        {
            estado = "0";//buscara solo si tiene atenciones
           cargar_indicador3(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            estado = "1";
          cargar_numerador3(dataGridView1);
;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            // ExportarDatos(dataGridView1);
            csv(dataGridView1);
        }

        private void cbdepartamento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbdisa.SelectedValue.ToString() != null)
            {
                string departamento = cbdisa.SelectedValue.ToString();
                cargar_datosRed(departamento);
            }
        }

        private void cbprovincia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbred.SelectedValue.ToString() != null)
            {
                string provincia = cbred.SelectedValue.ToString();
                cargar_datosMicrored(provincia);
            }
        }

        ///////////////////////////inicio indicador 3//////////////////////////////////////////////

        public void cargar_indicador3(DataGridView dgv)
        {
            try
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    SqlCommand cmd;
                    SqlDataReader dr;
                    SqlDataAdapter da;
                    DataTable dt;
                    da = new SqlDataAdapter("SELECT * FROM PADRON ", cnn);
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


        public void cargar_numerador3(DataGridView dgv)
        {
            try
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    SqlCommand cmd;
                    SqlDataReader dr;
                    SqlDataAdapter da;
                    DataTable dt;
                    da = new SqlDataAdapter("SELECT * FROM NUMERADOR3", cnn);
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
        public void falta3(DataGridView dgv)
        {
            try
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    SqlCommand cmd;
                    SqlDataReader dr;
                    SqlDataAdapter da;
                    DataTable dt;

                    da = new SqlDataAdapter("select d.* from PADRON as d LEFT join NUMERADOR3 as n ON D.DOCIDENTIDAD=n.DOCIDENTIDAD WHERE n.RESULTADO IS NULL ", cnn);
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
            estado = "0";
            falta3(dataGridView1);
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
        private void detalleAtencion()
        {
            try
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    SqlCommand cmd;
                    SqlDataReader dr;
                    SqlDataAdapter da;
                    DataTable dt;

                    da = new SqlDataAdapter("SELECT ID_CITA,ANIO,FECHA,LOTE,NUM_PAG,NUM_REG,RENAES,NOM_ESTABLEC,EDAD_A,EDAD_M,EDAD_D,NOMBRE_PACIENTE,LAB,COD_ITEM FROM HIS WHERE ID_CITA=" + dataGridView1.CurrentRow.Cells["ID_CITA"].Value.ToString() + " ORDER BY ID_C ASC", cnn);
                    dt = new DataTable();
                    da.Fill(dt);
                    listAtenciones.DataSource = dt;
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay registros" + ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (estado=="1")
            {
                detalleAtencion();
                controlesFed();
            }
            else
            {
                detalleAtencionDni();
                controlesDni();
            }

 
        }

        public void controlesFed()
        {
            try
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    string thb = "SELECT COUNT (*)FROM (SELECT ID_CITA  FROM HIS WHERE ID_CITA='" + dataGridView1.CurrentRow.Cells["ID_CITA"].Value.ToString() + "' AND COD_ITEM IN ('85018' ,'85018.01')) AS T";
                    SqlCommand hbt = new SqlCommand(thb, cnn);
                    string totalhb;
                    totalhb = hbt.ExecuteScalar().ToString();
                    ////////////////////////////////////////////////
                    if (totalhb != "0")
                    {
                        hb.Text = "SI";
                        hb.ForeColor = Color.Green;
                    }
                    else
                    {
                        hb.Text = "NO";
                        hb.ForeColor = Color.Red;
                    }
                    //--------------------
                    string tsupl = "SELECT COUNT (*)FROM (SELECT ID_CITA  FROM HIS WHERE ID_CITA='" + dataGridView1.CurrentRow.Cells["ID_CITA"].Value.ToString() + "' AND (COD_ITEM IN ('Z298','99199.17') AND LAB IN('SF1','P01','PO1'))) AS T";
                    SqlCommand suplt = new SqlCommand(tsupl, cnn);
                    string totalsupl;
                    totalsupl = suplt.ExecuteScalar().ToString();
                    ////////////////////////////////////////////////
                    if (totalsupl != "0")
                    {
                        suplementacion.Text = "SI";
                        suplementacion.ForeColor = Color.Green;
                    }
                    else
                    {
                        suplementacion.Text = "NO";
                        suplementacion.ForeColor = Color.Red;
                    }
 
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        //////////////////////////////////BUSCAR ATENCIONES POR DNI O CNV///////////////////////////
        private void detalleAtencionDni()
        {
            try
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    SqlCommand cmd;
                    SqlDataReader dr;
                    SqlDataAdapter da;
                    DataTable dt;
                    da = new SqlDataAdapter("SELECT ID_CITA,ANIO,FECHA,LOTE,NUM_PAG,NUM_REG,RENAES,NOM_ESTABLEC,EDAD_A,EDAD_M,EDAD_D,NOMBRE_PACIENTE,LAB,COD_ITEM FROM HIS WHERE NRO_DOC='" + dataGridView1.CurrentRow.Cells["DOCIDENTIDAD"].Value.ToString() + "' AND (TIP_EDAD='M' AND EDAD_M BETWEEN '5' AND '8')AND (TIP_EDAD='M' AND EDAD_M BETWEEN '5' AND '8') AND (COD_ITEM IN ('Z001','99381','Z298','99199.17','85018')) ORDER BY ID_C ASC", cnn);
                    dt = new DataTable();
                    da.Fill(dt);
                    listAtenciones.DataSource = dt;
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay registros" + ex.ToString());
            }
        }
        //////////////////////////////////BUSCAR REQUISITOS FED POR DNI O CNV///////////////////////////
        public void controlesDni()
        {
            try
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {
                    string thb = "SELECT COUNT (*)FROM (SELECT ID_CITA  FROM HIS WHERE NRO_DOC='" + dataGridView1.CurrentRow.Cells["DOCIDENTIDAD"].Value.ToString() + "' AND (TIP_EDAD='M' AND EDAD_M BETWEEN '5' AND '8') AND COD_ITEM IN ('85018' ,'85018.01')) AS T";
                    SqlCommand hbt = new SqlCommand(thb, cnn);
                    string totalhb;
                    totalhb = hbt.ExecuteScalar().ToString();
                    ////////////////////////////////////////////////
                    if (totalhb != "0")
                    {
                        hb.Text = "SI";
                        hb.ForeColor = Color.Green;
                    }
                    else
                    {
                        hb.Text = "NO";
                        hb.ForeColor = Color.Red;
                    }
                    //--------------------
                    string tsupl = "SELECT COUNT (*)FROM (SELECT ID_CITA  FROM HIS WHERE NRO_DOC='" + dataGridView1.CurrentRow.Cells["DOCIDENTIDAD"].Value.ToString() + "' AND (TIP_EDAD='M' AND EDAD_M BETWEEN '5' AND '8') AND (COD_ITEM IN ('Z298','99199.17') AND LAB IN('SF1','P01','PO1'))) AS T";
                    SqlCommand suplt = new SqlCommand(tsupl, cnn);
                    string totalsupl;
                    totalsupl = suplt.ExecuteScalar().ToString();
                    ////////////////////////////////////////////////
                    if (totalsupl != "0")
                    {
                        suplementacion.Text = "SI";
                        suplementacion.ForeColor = Color.Green;
                    }
                    else
                    {
                        suplementacion.Text = "NO";
                        suplementacion.ForeColor = Color.Red;
                    }

                    cnn.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
