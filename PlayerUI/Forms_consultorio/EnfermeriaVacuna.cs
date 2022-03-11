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
    public partial class EnfermeriaVacuna : Form
    {
        public EnfermeriaVacuna()
        {
            InitializeComponent();
        }

        private void cbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            if ( txtbuscar.Text != "")
            {
                using (SqlConnection cnn = Conexion.ObternerConexion())
                {

                    //mostrar informacion de covid_casos
                    SqlCommand cmdcados = cnn.CreateCommand();
                    cmdcados.CommandType = CommandType.Text;
                    //SELECT H.RENAES,H.NOM_ESTABLEC,H.NRO_DOC,H.FECHA_NAC,H.NOMBRE_PACIENTE,H.TIP_EDAD,H.EDAD_A,H.EDAD_D,H.EDAD_M,H.COD_ITEM,H.LAB,H.FECHA AS FECHA_ATENCION,(P.NOMBRES_PERSONAL+' '+P.APELLIDO_PATERNO_PERSONAL+' '+P.APELLIDO_MATERNO_PERSONAL)AS NOMBRE_PROFESIONAL FROM HIS AS H INNER JOIN PERSONAL AS P ON H.DOC_ATIENDE=P.NUMERO_DOCUMENTO WHERE H.LOTE IN('CAR','ACT')
                    cmdcados.CommandText = "SELECT H.RENAES,H.NOM_ESTABLEC,H.NRO_DOC,H.FECHA_NAC,H.NOMBRE_PACIENTE,H.TIP_EDAD,H.EDAD_A,H.EDAD_D,H.EDAD_M,H.COD_ITEM,H.LAB,H.FECHA AS FECHA_ATENCION,(P.NOMBRES_PERSONAL+' '+P.APELLIDO_PATERNO_PERSONAL+' '+P.APELLIDO_MATERNO_PERSONAL)AS NOMBRE_PROFESIONAL FROM HIS AS H INNER JOIN PERSONAL AS P ON H.DOC_ATIENDE=P.NUMERO_DOCUMENTO WHERE H.NRO_DOC='"+txtbuscar.Text+ "' AND H.LOTE IN('CAR','ACT','SGV') GROUP BY H.RENAES,H.NOM_ESTABLEC,H.NRO_DOC,H.FECHA_NAC,H.NOMBRE_PACIENTE,H.TIP_EDAD,H.EDAD_A,H.EDAD_D,H.EDAD_M,H.COD_ITEM,H.LAB,H.FECHA ,P.NOMBRES_PERSONAL,P.APELLIDO_PATERNO_PERSONAL,P.APELLIDO_MATERNO_PERSONAL";
                    cmdcados.ExecuteNonQuery();
                    DataTable dtcasos = new DataTable();
                    SqlDataAdapter dacasos = new SqlDataAdapter(cmdcados);
                    dacasos.Fill(dtcasos);
                    dataGridView1.DataSource = dtcasos;
                    cnn.Close();
                }
            }
        }
    }
}
