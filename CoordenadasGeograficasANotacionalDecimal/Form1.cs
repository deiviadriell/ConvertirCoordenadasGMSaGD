using System;
using System.Data.SqlClient;
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
using ExcelDataReader.Core;
using ExcelDataReader.Log;

namespace CoordenadasGeograficasANotacionalDecimal
{
    public partial class Form1 : Form
    {
        public DataTable firstTable = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.Size = new Size(544, 663);
        }

        private void btnCargarExcel_Click(object sender, EventArgs e)
        {
            resetCarga();
            string path = "";
            int celda = -1;
            opnSeleccionArchivo.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            opnSeleccionArchivo.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (opnSeleccionArchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                path = opnSeleccionArchivo.FileName;
                txtRutaArchivo.Text = path;
                
                
                using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateOpenXmlReader(stream))
                    {
                        
                        DataSet dts = reader.AsDataSet();
                        //obtengo el resultado como un dataSet
                        firstTable = dts.Tables[0];
                        stream.Close();
                        if (firstTable.Rows.Count > 1)
                        {

                            //sin 
                            cambiarDimensionesPantalla(825, 663);
                            
                            int y = 80;
                            cboColumnaLatitud.Items.Add("Seleccione un valor");
                            cboColumnaLongitud.Items.Add("Seleccione un valor");


                            foreach (DataColumn column in firstTable.Columns)
                            {
                                string cName = firstTable.Rows[0][column.ColumnName].ToString();
                                if (!firstTable.Columns.Contains(cName) && cName != "")
                                {
                                    column.ColumnName = cName;

                                    cboColumnaLatitud.Items.Add(cName);
                                    cboColumnaLongitud.Items.Add(cName);
                                    CheckBox chk = new CheckBox();
                                    chk.Text = cName;
                                    chk.Location = new Point(9, y);
                                    y += 23;
                                    grpColumnas.Controls.Add(chk);
                                }

                            }
                            cboColumnaLatitud.SelectedIndex = 0;
                            cboColumnaLongitud.SelectedIndex = 0;
                            firstTable.Rows[0].Delete();
                            dgvExcelSeleccionado.DataSource = firstTable;
                            reader.Close();


                        }
                        else
                        { }
                        
                    }

                }
            }
        }


        private void cambiarDimensionesPantalla(int x, int y)
        {
            this.Size = new Size(x, y);
        }
        public void transformations(string valor, ref string grado, ref string minuto, ref string segundo, ref string direccion, ref string observacion, ref string decimales, int lat)
        {
            try
            {

                grado = valor.Substring(0, valor.IndexOf('°'));
                valor = valor.Substring((grado.Length), (valor.Length - grado.Length));
                valor = valor.Remove(0, 1);
                minuto = valor.Substring(0, valor.IndexOf('\''));                
                valor = valor.Substring((minuto.Length), (valor.Length - minuto.Length));
                valor = valor.Remove(0, 1);
                if (valor.IndexOf('\"') == -1)
                {
                    segundo = "0";
                }
                else
                {
                    segundo = valor.Substring(0, valor.IndexOf('\"'));
                    valor = valor.Substring((segundo.Length), (valor.Length - segundo.Length));
                }
                direccion = valor;
                if (direccion.Length > 1)
                    direccion = direccion.Remove(0, 1);
                observacion = "correcto";
                if (lat == 1)
                    decimales = convertirCoordenadasADecimales(grado, minuto, segundo, direccion,"latitud");
                else
                    decimales = convertirCoordenadasADecimales(grado, minuto, segundo, direccion,"longitud");
                
            }
            catch (Exception ex)
            {
                observacion = "error";
            }
        }      
        public string convertirCoordenadasADecimales(string grados, string minutos, string segundos, string direccion,string conversion)
        {
            if (conversion == "latitud")
            {
                int latitude_sign = 1;
                if (direccion.ToLower() == "s")
                    latitude_sign = -1;
                double latitude_sec, latitude_min, aux = 1000000.0, absdlat, absmlat, absslat;
                latitude_sec = Math.Abs(Math.Round(Convert.ToDouble(segundos) * aux) / 1000000);
                latitude_min = Math.Abs(Math.Round(Convert.ToDouble(minutos) * aux) / 1000000);

                // Calculations

                absdlat = Math.Abs(Math.Round(Convert.ToInt32(grados) * 1000000.0));
                absmlat = Math.Abs(Math.Round(latitude_min * 1000000.0));
                absslat = Math.Abs(Math.Round(latitude_sec * 1000000.0));
                // Final calculation

                string latitude = "";
                latitude = (Math.Round(absdlat + (absmlat / 60) + (absslat / 3600.0)) * latitude_sign / 1000000).ToString();
                //longitude = Math.round(absdlon + (absmlon / 60) + (absslon / 3600)) * longitude_sign / 1000000;


                return latitude;
            }
            else
            {

                int longitude_sign = 1;
                if (direccion.ToLower() == "w")
                    longitude_sign = -1;
                double longitude_min, longitude_sec, aux = 1000000.0, absdlon, absmlon, absslon;
                /*latitude_sec = Math.Abs(Math.Round(Convert.ToInt32(segundos) * aux) / 1000000);
                latitude_min = Math.Abs(Math.Round(Convert.ToUInt32(minutos) * aux) / 1000000);*/

                longitude_min = Math.Abs(Math.Round(Convert.ToDouble(minutos) * 1000000.0) / 1000000);
                longitude_sec = Math.Abs(Math.Round(Convert.ToDouble(segundos) * 1000000.0) / 1000000);

                // Calculations

                /*absdlat = Math.Abs(Math.Round(Convert.ToInt32(grados) * 1000000.0));
                absmlat = Math.Abs(Math.Round(latitude_min * 1000000.0));
                absslat = Math.Abs(Math.Round(latitude_sec * 1000000.0));*/

                absdlon = Math.Abs(Math.Round(Convert.ToInt32(grados) * 1000000.0));
                absmlon = Math.Abs(Math.Round(longitude_min * 1000000));
                absslon = Math.Abs(Math.Round(longitude_sec * 1000000.0));
                // Final calculation

                string longitud = "";
                longitud = (Math.Round(absdlon + (absmlon / 60) + (absslon / 3600)) * longitude_sign / 1000000).ToString();


                return longitud;

            }
        }        
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (cboColumnaLatitud.SelectedIndex != 0 && cboColumnaLongitud.SelectedIndex != 0)
            {
                if (cboColumnaLatitud.SelectedIndex != cboColumnaLongitud.SelectedIndex)
                {
                    //List<string> nombresColumnasSeleccionadas = new List<string>();
                    DataTable tbResults = new DataTable();
                    foreach (Control controles in grpColumnas.Controls)
                    {
                        if ((controles is CheckBox) && ((CheckBox)controles).Checked)
                            tbResults.Columns.Add(controles.Text);                                                    
                    }
                    tbResults.Columns.Add("grados latitud");
                    tbResults.Columns.Add("minutos latitud");
                    tbResults.Columns.Add("segundos latitud");
                    tbResults.Columns.Add("direccion latitud");
                    tbResults.Columns.Add("Grados Decimales Latitud");
                    tbResults.Columns.Add("observacion Latitud");

                    tbResults.Columns.Add("grados longitud");
                    tbResults.Columns.Add("minutos longitud");
                    tbResults.Columns.Add("segundos longitud");
                    tbResults.Columns.Add("direccion longitud");
                    tbResults.Columns.Add("Grados Decimales Longitud");
                    tbResults.Columns.Add("observacion Longitud");
                    for (int i = 1; i < firstTable.Rows.Count; i++)
                    {
                        DataRow row = tbResults.NewRow();
                        foreach (Control controles in grpColumnas.Controls)
                        {
                            if ((controles is CheckBox) && ((CheckBox) controles).Checked)                                
                                    row[controles.Text] = firstTable.Rows[i][controles.Text].ToString();
                        }
                        
                        string grado = "", minuto = "", segundo = "", direccion = "", observacion = "", decimales = "";
                        transformations(firstTable.Rows[i][cboColumnaLatitud.SelectedIndex-1].ToString(), ref grado, ref minuto, ref segundo, ref direccion, ref observacion, ref decimales,1);
                        row["grados latitud"] = grado;
                        row["minutos latitud"] = minuto;
                        row["segundos latitud"] = segundo;
                        row["direccion latitud"] = direccion;
                        row["Grados Decimales Latitud"] = decimales;
                        row["observacion Latitud"] = observacion;
                        grado = ""; minuto = ""; segundo = ""; direccion = ""; observacion = ""; decimales = "";
                        transformations(firstTable.Rows[i][cboColumnaLongitud.SelectedIndex-1].ToString(), ref grado, ref minuto, ref segundo, ref direccion, ref observacion, ref decimales,0);

                        row["grados longitud"]=grado;
                        row["minutos longitud"]=minuto;
                        row["segundos longitud"]=segundo;
                        row["direccion longitud"] = direccion;
                        row["Grados Decimales Longitud"]=decimales;
                        row["observacion Longitud"]=observacion;
                        tbResults.Rows.Add(row);
                    }
                    dgvResultado.DataSource = tbResults;
                    cambiarDimensionesPantalla(1440, 663);
                    btnExportarExcelResultado.Visible = true;
                }
                else
                { MessageBox.Show("Debe seleccionar columnas diferentes para realizar la conversión de las coordenadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            else
            { MessageBox.Show("Debe de Seleccionar la columna que contiene la latitud y la longitud para poder realizar la conversión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void resetCarga()
        {
            dgvExcelSeleccionado.DataSource = null;
            dgvResultado.DataSource = null;
            cboColumnaLatitud.Items.Clear();
            cboColumnaLongitud.Items.Clear();
            txtRutaArchivo.Text = "";

           
        }

        
    }
}
