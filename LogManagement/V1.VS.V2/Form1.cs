using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using V1.VS.V2.Vtwo;
using Excel = Microsoft.Office.Interop.Excel;

namespace V1.VS.V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 5;
        }

        private void GO_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            try
            {
                var clientV1 = new Vone.DetectionClientClient();
                var clientV2 = new Vtwo.IdentifierPersonneContractClient();

                progressBar1.Increment(1);

                var resultOne = clientV1.IsCustomerAgent(null, CodePostalBox.Text, null, NameBox.Text, null, PrenomBox.Text,
                                                         null, EmailBox.Text);

                progressBar1.Increment(1);

                if (resultOne)
                {
                    V1Result.Text = "DETECTED";
                }
                else
                {
                    V1Result.Text = "NOT DETECTED";
                }

                var output_one = new ListeContratDetecte();
                var whatever = new DetenteurProduit();
                var output_two = new Distributeur();
                var output_three = new DonneesPersonneIdentifiee();
                var output_four = new Segmentation();
                var output_five = new StatutFoyer();

                progressBar1.Increment(1);

                var resultTwo = clientV2.IdentiferPersonneGenerique(null, null, null,
                                                                    new DonneesPersonneAIdentifier
                                                                    {
                                                                        CodePostal = CodePostalBox.Text,
                                                                        Email = EmailBox.Text,
                                                                        Nom = NameBox.Text,
                                                                        Prenom = PrenomBox.Text
                                                                    }, out output_one,
                                                                    out whatever,
                                                                    out output_two, out output_three, out output_four,
                                                                    out output_five);

                progressBar1.Increment(1);

                if (resultTwo == 0)
                {
                    V2Result.Text = "NOT DETECTED";
                }
                else
                {
                    V2Result.Text = "DETECTED";
                }

                progressBar1.Increment(1);
            }
            catch (Exception)
            { 
                MessageBox.Show("Service Unavailable", "Service Process", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void ReadExcel(string filePath)
        {
            DataTable table = new DataTable();
            string strConn = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1;TypeGuessRows=0;ImportMixedTypes=Text\"", filePath);
            using (OleDbConnection dbConnection = new OleDbConnection(strConn))
            {
                using (OleDbDataAdapter dbAdapter = new OleDbDataAdapter("SELECT * FROM [Feuil1$]", dbConnection)) //rename sheet if required!
                    dbAdapter.Fill(table);
                int rows = table.Rows.Count;
            }
            // On lock
            NameBox.ReadOnly = true;
            PrenomBox.ReadOnly = true;
            CodePostalBox.ReadOnly = true;
            EmailBox.ReadOnly = true;

            DataTable output = new DataTable();
            output.Columns.Add("Nom");
            output.Columns.Add("Prenom");

            output.Columns.Add("V1_Result");
            output.Columns.Add("V2_Result");

            for (int i = 0; i < table.Rows.Count; i++)
            {
                NameBox.Text =(string) table.Rows[i][0];
                PrenomBox.Text =(string) table.Rows[i][1];
                CodePostalBox.Text = table.Rows[i][2].ToString();
                //EmailBox.Text = (string)table.Rows[i][3];
                GO_Click(null, null);

                DataRow newCustomersRow = output.NewRow();

                newCustomersRow["Nom"] = NameBox.Text;
                newCustomersRow["Prenom"] = PrenomBox.Text;

                newCustomersRow["V1_Result"] = V1Result.Text;
                newCustomersRow["V2_Result"] = V2Result.Text;
               output.Rows.Add(newCustomersRow);
            }

            NameBox.ReadOnly = false;
            PrenomBox.ReadOnly = false;
            CodePostalBox.ReadOnly = false;
            EmailBox.ReadOnly = false;

            SaveExcel(output);
            
        }

        private void SaveExcel(DataTable output)
        {
            int i = 0;
            int j = 0;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


            for (i = 0; i <= output.Rows.Count - 1; i++)
            {
                for (j = 0; j <= output.Columns.Count - 1; j++)
                {
                    string data = output.Rows[i].ItemArray[j].ToString();
                    xlWorkSheet.Cells[i + 1, j + 1] = data;
                }
            }

            xlWorkBook.SaveAs(OutputBox.Text+"\\ResultOutput.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created, "+OutputBox.Text+"\\ResultOutput.xls");
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void FileSelection_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Fichiers Excel (*.xlsx)|*.xlsx";
            Input.Text = openFileDialog1.FileName;

            folderBrowserDialog1.ShowDialog();
            OutputBox.Text = folderBrowserDialog1.SelectedPath;

            try
            {
                ReadExcel(Input.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel File format not acceptable : " + ex.Message, "Parsing process", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
