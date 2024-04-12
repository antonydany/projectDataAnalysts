using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectDataAnalysts
{
    public partial class MainWindow : Form
    {
        private OpenFileDialog openFileDialogCsv;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void ImportCsvBtn_Click(object sender, EventArgs e)
        {
            openFileDialogCsv = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv"
            };


            if (openFileDialogCsv.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //base de datos para TODA la info de la tabla
                    DataTable allDataTable = new DataTable();


                    using (var sr = new StreamReader(openFileDialogCsv.FileName, Encoding.UTF8))
                    {
                        //encabezados de la tabla
                        string[] headers = sr.ReadLine().Split(',');

                        foreach (string header in headers)
                        {
                            allDataTable.Columns.Add(header);
                        }

                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();
                            var values = line.Split(',');

                            if(values.Length == headers.Length)
                            {
                                allDataTable.Rows.Add(values);
                            }
                            else { 

                            Console.WriteLine('e');
                            }
                        } 
                    }
                    //pasa los valores al gridview
                    gridAllData.DataSource = allDataTable;

                }
                catch (Exception ex)
                {
                    // Handle any exceptions here
                    MessageBox.Show($"Error reading file: {ex.Message}");
                }
            }
        }

        private void BtnCleanGridData_Click(object sender, EventArgs e)
        {
            gridAllData.DataSource = null;
        }
    }
}
