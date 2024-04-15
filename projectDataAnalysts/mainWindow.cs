using System;
using System.Data;
using System.IO;
using System.Text;
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

        private void ImportCsvDropGridData_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                string lastFile = files[files.Length - 1];

                if (files.Length == 1 && Path.GetExtension(lastFile).ToLower() == ".csv")
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        //cargar svg arrastrando el archivo al DataGridView
        private void ImportCsvDropGridData_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string lastFile = files[files.Length - 1];
            //activar cuando se suelta el objeto
            WriteToGridAllData(lastFile);
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
                    WriteToGridAllData(openFileDialogCsv.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}");
                }
            }
        }

        private void BtnCleanGridData_Click(object sender, EventArgs e)
        {
            gridAllData.DataSource = null;
        }
        private void WriteToGridAllData(string filename)
        {
            //base de datos para TODA la info de la tabla
            DataTable allDataTable = new DataTable();


            using (var sr = new StreamReader(filename, Encoding.UTF8))
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

                    if (values.Length == headers.Length)
                    {
                        allDataTable.Rows.Add(values);
                    }
                }
            }
            //pasa los valores al gridview
            gridAllData.DataSource = allDataTable;
        }
    }
}
