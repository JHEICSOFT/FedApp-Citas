using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PlayerUI
{
   public class ImportarCnvSql
    {
        public bool CargarData(DataTable tbData)
        {
            bool resultado = true;
            using (SqlConnection cnn = Conexion.ObternerConexion())
            {              
                using (SqlBulkCopy s = new SqlBulkCopy(cnn))
                {

                    //ingresamos COLUMNAS ORIGEN | COLUMNAS DESTINOS
                    s.ColumnMappings.Add("Documento Identidad", "DocumentoIdentidad");
                    s.ColumnMappings.Add("Nombres", "Nombres");
                    s.ColumnMappings.Add("Telefono", "Telefono");
                    s.ColumnMappings.Add("Correo", "Correo");
                    s.ColumnMappings.Add("Ciudad", "Ciudad");

                    //definimos la tabla a cargar
                    s.DestinationTableName = "USUARIO";


                    s.BulkCopyTimeout = 1500;
                    try
                    {
                        s.WriteToServer(tbData);
                    }
                    catch (Exception e)
                    {
                        string st = e.Message;
                        resultado = false;
                    }


                }
            }

            return resultado;
        }



        //n
        //CNV
        //Estado
        //Cod_EESS
        //EESS
        //M_Primer_Apellido
        //M_Segundo
        //M_Nombres
        //M_Edad
        //M_Fec_Nac
        //M_Gest_Sem
        //M_TipoDoc
        //M_Documento
        //M_Cod_EESS_Prenatal
        //M_EESS_Prenatal
        //N_Fecha
        //N_Hora
        //N_Sexo
        //N_Peso_g
        //N_Talla_cm
        //N_Apgar
        //N_Perímetro_cefálico
        //N_Perímetro_torácico
        //N_Malf_congénita
        //N_Tiempo_Lig_Cord
        //N_Lactancia_precoz
        //P_Primer_Apellido
        //P_Segundo
        //P_Nombres
        //P_Profesión
        //P_N_Colegio
        //P_Fecha_Registro
        //Usu_Reg_Primer_Apellido
        //Usu_Reg_Segundo_Apellido
        //Usu_Reg_Nombres
        //Condicion
        //Red_de_salud
        //Micro_red_de_salud
        //Mes
    }
}
