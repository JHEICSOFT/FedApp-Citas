using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;

namespace PlayerUI
{
    public partial class ImportarCnv : Form
    {
        private DataSet dtsTablas = new DataSet();
        public ImportarCnv()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTable dt = tableCollection[cbhojas.SelectedItem.ToString()];
            //dgvImportar.DataSource = dt;

        }
        DataTableCollection tableCollection;

        private void button1_Click(object sender, EventArgs e)
        {

                //configuracion de ventana para seleccionar un archivo
                OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.Filter = "Excel Worbook|*.xlsx";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                cbhojas.Items.Clear();
                dgvImportar.DataSource = null;

                txtruta.Text = oOpenFileDialog.FileName;

                //FileStream nos permite leer, escribir, abrir y cerrar archivos en un sistema de archivos, como matrices de bytes
                FileStream fsSource = new FileStream(oOpenFileDialog.FileName, FileMode.Open, FileAccess.Read);


                //ExcelReaderFactory.CreateBinaryReader = formato XLS
                //ExcelReaderFactory.CreateOpenXmlReader = formato XLSX
                //ExcelReaderFactory.CreateReader = XLS o XLSX
                IExcelDataReader reader = ExcelReaderFactory.CreateReader(fsSource);

                //convierte todas las hojas a un DataSet
                dtsTablas = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = true
                    }
                });

                //obtenemos las tablas y añadimos sus nombres en el desplegable de hojas
                foreach (DataTable tabla in dtsTablas.Tables)
                {
                    cbhojas.Items.Add(tabla.TableName);
                }
                cbhojas.SelectedIndex = 0;

                reader.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvImportar.DataSource = dtsTablas.Tables[cbhojas.SelectedIndex];
        }

        private void ImportarCnv_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataHISDataSet1.CNV' Puede moverla o quitarla según sea necesario.
            // this.cNVTableAdapter.Fill(this.dataHISDataSet1.CNV);
            // TODO: esta línea de código carga datos en la tabla 'dataHISDataSet.HIS' Puede moverla o quitarla según sea necesario.
            //  this.hISTableAdapter.Fill(this.dataHISDataSet.HIS);
            DiseñoInicial();

        }
        private void DiseñoInicial()
        {
            btnBuscar.Cursor = Cursors.Hand;
            btnMostrar.Cursor = Cursors.Hand;
            btninsertar.Cursor = Cursors.Hand;
            txtruta.Enabled = true;

            dgvImportar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvImportar.MultiSelect = false;
            dgvImportar.ReadOnly = true;
            dgvImportar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImportar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvImportar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            DataTable data = (DataTable)(dgvImportar.DataSource);

            bool resultado = new ImportarCnvSql().CargarData(data);

            if (resultado)
            {
                MessageBox.Show("Se registro la data");
            }
            else
            {
                MessageBox.Show("Hubo un problema al registrar");
            }

        }
    }
}
