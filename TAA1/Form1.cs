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

namespace TAA1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void fillTables()
        {
            // Clear the combo box first
            cmbInputTable.Items.Clear();
            // Define the SQL Connection String
            String myConStr;
            myConStr = "Data Source=SISUMANK1\\SUMANDB;Initial Catalog=test;User id=sa;Password=S1u2m3a4n5";

            // Define the SQL Statement
            String mySqlStm;
            mySqlStm = "SELECT TABLE_NAME FROM information_schema.tables WHERE TABLE_TYPE=\'BASE TABLE\' and TABLE_CATALOG=\'test\';";
            // mySqlStm = "SELECT [Incident Identifier] from [test].[dbo].[input]";

            // Start the SQL Connection Object Loop
            using (SqlConnection conn = new SqlConnection())
            {
                // Set the connection String
                conn.ConnectionString = myConStr;

                // Open the connection
                conn.Open();

                // Define the SQL Command and execute the SQL Statement defined above.
                SqlCommand command = new SqlCommand(mySqlStm, conn);

                // Open the loop to read each record of SQL command query output
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbInputTable.Items.Add(reader[0]);
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Define the default Stop Words File Location
            tbStopWords.Text = "C:\\Temp\\stopword.txt";

            msgBox.Text = DateTime.Now.ToString("hh:mm:ss") + ": Thank you for using HPE MWS Text Analysis Tool.\n" + msgBox.Text;
            msgBox.Text = DateTime.Now.ToString("hh:mm:ss") + ": Please choose the input table name and click on process.\n" + msgBox.Text;
            msgBox.Text = DateTime.Now.ToString("hh:mm:ss") + ": Optionally you can also select a stop words file to be added.\n" + msgBox.Text;
            fillTables();
            progressBar.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void cmbInputTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Program to check if the file name already exists in the tables list.
            bool fileNameSet = false;   // Flag to check if file name set

            List<string> mInputTables;
            mInputTables = new List<string>();
            // Define the SQL Connection String
            String myConStr;
            myConStr = "Data Source=SISUMANK1\\SUMANDB;Initial Catalog=test;User id=sa;Password=S1u2m3a4n5";

            // Define the SQL Statement
            String mySqlStm;
            mySqlStm = "SELECT TABLE_NAME FROM information_schema.tables WHERE TABLE_TYPE=\'BASE TABLE\' and TABLE_CATALOG=\'test\';";
            // mySqlStm = "SELECT [Incident Identifier] from [test].[dbo].[input]";

            // Start the SQL Connection Object Loop
            using (SqlConnection conn = new SqlConnection())
            {
                // Set the connection String
                conn.ConnectionString = myConStr;

                // Open the connection
                conn.Open();

                // Define the SQL Command and execute the SQL Statement defined above.
                SqlCommand command = new SqlCommand(mySqlStm, conn);

                // Open the loop to read each record of SQL command query output
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mInputTables.Add(reader[0].ToString());
                    }
                }
            }

            string mInputTable = cmbInputTable.Text;
            string mSumTable = "";
            string mDetTable = "";
            int mcounter = 1;
            while (!fileNameSet)
            {
                mSumTable = mInputTable + "_sum_" + mcounter.ToString();
                mDetTable = mInputTable + "_det_" + mcounter.ToString();
                if (mInputTables.Contains(mSumTable) || mInputTables.Contains(mDetTable))
                {
                    mcounter++;
                }
                else
                {
                    tbSumTable.Text = mSumTable;
                    tbDetTable.Text = mDetTable;
                    fileNameSet = true;
                }
            }
        }

        private void btnStopWords_Click(object sender, EventArgs e)
        {
            ofdStopWords.FileName = tbStopWords.Text;
            ofdStopWords.Title = "Open Stop Words File";
            ofdStopWords.DefaultExt = "txt";
            ofdStopWords.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            ofdStopWords.CheckFileExists = true;
            ofdStopWords.CheckPathExists = true;
            ofdStopWords.Multiselect = false;
            msgBox.Text = DateTime.Now.ToString("hh:mm:ss") + ": File selection dialog opened\n" + msgBox.Text;
            if (ofdStopWords.ShowDialog() == DialogResult.OK)
            {
                tbStopWords.Text = ofdStopWords.FileName;
                msgBox.Text = DateTime.Now.ToString("hh:mm:ss") + ": File \'" + tbStopWords.Text + "\' selected\n" + msgBox.Text;
            }
            else
            {
                msgBox.Text = DateTime.Now.ToString("hh:mm:ss") + ": File not selected\n" + msgBox.Text;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fillTables();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            // Initialize the progress bar.
            progressBar.Visible = true;
            progressBar.Minimum = 0;
            progressBar.Value = 0;
            progressBar.Maximum = 1000;

            // Open the file to start writing the text
            string oPath = "c:\\temp\\output.csv";
            using (StreamWriter sw = new StreamWriter(oPath))
            {
                String myConStr;
                myConStr = "Data Source=SISUMANK1\\SUMANDB;Initial Catalog=test;User id=sa;Password=S1u2m3a4n5";

                // Define the SQL Statement
                String mySqlStm;
                mySqlStm = "SELECT TABLE_NAME FROM information_schema.tables WHERE TABLE_TYPE=\'BASE TABLE\' and TABLE_CATALOG=\'test\';";
                // mySqlStm = "SELECT [Incident Identifier] from [test].[dbo].[input]";

                // Start the SQL Connection Object Loop
                using (SqlConnection conn = new SqlConnection())
                {
                    // Set the connection String
                    conn.ConnectionString = myConStr;

                    // Open the connection
                    conn.Open();

                    // Define the SQL Command and execute the SQL Statement defined above.
                    SqlCommand command = new SqlCommand(mySqlStm, conn);

                    // Open the loop to read each record of SQL command query output
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbInputTable.Items.Add(reader[0]);
                        }
                    } // Closing of SQL Data Reader reader
                }  // Closing of SQL Connection conn
            }  // Closing of Stream Writer for writing output path
        } // Closing of btnProcess_Click procedure
    } // Closing of Partial Class Form
}// Closing of namespace TAA1
