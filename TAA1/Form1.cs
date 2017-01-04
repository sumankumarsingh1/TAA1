using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Configuration;

namespace TAA1
{
    public partial class Form1 : Form
    {
        string myConStr;
        string mySqlStm;
        string IncidentId;
        string IncidentSource;
        string Description;
        string searchWord;
        int mTotalRecords;
        int mTotalFields;
        int mCurrentRecord;
        int mCurrentDetailRec;
        Regex rgx = new Regex("[^a-zA-Z0-9 -']");
        List<string> stopWord;
        bool stopWordTableFlag;
        string newStopWord;

        public Form1()
        {
            InitializeComponent();
        }

        private void setSystemMessage(string s)
        {
            string s1 = DateTime.Now.ToString("hh:mm:ss") + ":" + s + "\n" + msgBox.Text;
            msgBox.Text = s1;
            using (StreamWriter sw = new StreamWriter("c:\\temp\\taa_log.txt"))
            {
                sw.WriteLine(s1);sw.Close();sw.Dispose();
            }
            
        }

        private void setSystemMessage2(string s)
        {
            msgBox2.Text = s; 
        }

        private void makeConnString()
        {
            myConStr = "Data Source=" + tbDBSource.Text;
            myConStr += ";Initial Catalog=" + tbDBCatalog.Text;
            myConStr += ";User id=" + tbDBUsername.Text;
            myConStr += ";Password=" + tbDBPassword.Text;
           myConStr += ";MultipleActiveResultSets=true";
        }

        private void setAllFieldsSelectedIndex(int n)
        {
            if (lbxAllFields.Items.Count > n)
            {
                lbxAllFields.SelectedIndex = n;
            }
        }


        public string removeLineEndings(string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return value;
            }
            string lineSeparator = ((char)0x2028).ToString();
            string paragraphSeparator = ((char)0x2029).ToString();

            return value.Replace("\r\n", " ").Replace("\n", " ").Replace("\"", " ").Replace("\'", " ").Replace("\r", " ").Replace(lineSeparator, " ").Replace(paragraphSeparator, " ");
        }
        private void fillTables()
        {
            // Clear the combo box first
            cmbInputTable.Items.Clear();

            // Start the SQL Connection Object Loop
            using (SqlConnection conn = new SqlConnection())
            {
                // Set the connection String
                try
                {
                    makeConnString();
                    conn.ConnectionString = myConStr;
                    conn.Open();
                    mySqlStm = "SELECT TABLE_NAME FROM information_schema.tables WHERE TABLE_TYPE=\'BASE TABLE\' and TABLE_CATALOG=\'" + tbDBCatalog.Text + "\';";
                    using (SqlCommand command = new SqlCommand(mySqlStm, conn))
                    {
                        // Open the loop to read each record of SQL command query output
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            stopWordTableFlag = false;
                            while (reader.Read())
                            {
                                if (reader[0].ToString() != "stopwords")
                                {
                                    cmbInputTable.Items.Add(reader[0]);
                                }
                                else
                                {
                                    stopWordTableFlag = true;
                                }

                            }
                        }
                    }
                }
                catch (SqlException)
                {
                    setSystemMessage("SQL Exceltion: Could not fetch tables from the database.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Define the default Stop Words File Location
            gbTableSelection.Visible = false;
            gbFieldSelection.Visible = false;
            progressBar.Visible = false;
            btnDropTables.Visible = false;

            tbStopWords.Text = "C:\\Temp\\stopword.txt";


            var appSettings= ConfigurationManager.AppSettings;
            tbDBSource.Text = appSettings["DataSource"]; 
            tbDBCatalog.Text = appSettings["InitialCatalog"];
            tbDBUsername.Text = appSettings["Username"];
            tbDBPassword.Text = "";
            setSystemMessage("Thank you for using HPE MWS Text Analysis Tool.");
            setSystemMessage2("Step 1: Please click on the connect button to connect to the database.");
            //fillTables();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btnDBConnect_Click(object sender, EventArgs e)
        {
            setSystemMessage("Database Connect button clicked.");
            lblConnState.Text = "Connecting! Please Wait...";
            lblConnState.BackColor = Color.Yellow;
            lblConnState.Update();

            using (SqlConnection conn = new SqlConnection())
            {
                // Open the connection
                    makeConnString();
                    conn.ConnectionString = myConStr;
                    conn.Open();

                    if (conn != null && conn.State == ConnectionState.Open)
                    {

                        lblConnState.Text = "Connected!";
                        lblConnState.BackColor = Color.LightGreen;
                        gbTableSelection.Visible = true;

                        // Disable the Database Selection controls
                        btnDBConnect.Enabled = false;
                        tbDBSource.ReadOnly = true;
                        tbDBCatalog.ReadOnly = true;
                        tbDBUsername.ReadOnly = true;
                        tbDBPassword.ReadOnly = true;

                        fillTables();
                        setSystemMessage("Database Connected!");
                        setSystemMessage2("Step 2: Select the Input Table from the Drop Down");
                    }
                    else
                    {
                        lblConnState.Text = "Not Connected!";
                        lblConnState.BackColor = Color.Pink;
                        setSystemMessage2("Step 1a: Please check database source, catalog, username and password and reconnect.");
                    }
            }
        }

        private void cmbInputTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            setSystemMessage("Input table "+ cmbInputTable.Text +" selected.");
            gbFieldSelection.Visible = true;

            // disable table selection controls
            cmbInputTable.Enabled = false;
            btnRefresh.Enabled = false;

            // Program to clear the previous selected items
            tbTktNoField.Text = "";
            tbTktSrcField.Text = "";
            lbxAllFields.Items.Clear();
            lbxTextFields.Items.Clear();

            // Program to check if the file name already exists in the tables list.
            bool fileNameSet = false;   // Flag to check if file name set

            List<string> mInputTables;
            string mInputTable = cmbInputTable.Text;
            string mSumTable = "";
            string mDetTable = "";
            mInputTables = new List<string>();

            // Start the SQL Connection Object Loop
            using (SqlConnection conn = new SqlConnection())
            {
                try
                {
                    makeConnString();
                    conn.ConnectionString = myConStr;
                    conn.Open();
                    mySqlStm = "SELECT TABLE_NAME FROM information_schema.tables WHERE TABLE_TYPE=\'BASE TABLE\' and TABLE_CATALOG=\'test\';";
                    using (SqlCommand command = new SqlCommand(mySqlStm, conn))
                    {
                        // Open the loop to read each record of SQL command query output
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                mInputTables.Add(reader[0].ToString());
                            }
                        } // Close SqlDataReader reader
                    }


                    // Program to Clear the list box first
                    lbxAllFields.Items.Clear();
                    // Program to populate the list box of tables

                    mySqlStm = "SELECT * FROM [" + mInputTable + "] WHERE 1=2;";
                    using (SqlCommand command = new SqlCommand(mySqlStm, conn))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            var tableSchema = reader.GetSchemaTable();
                            foreach (DataRow row in tableSchema.Rows)
                            {
                                // add to the list box
                                lbxAllFields.Items.Add(row["ColumnName"]);
                            }
                        } // Close SqlDataReader reader
                    }
                }
                catch (SqlException)
                {
                    setSystemMessage("SQL Exception: Unable to connect to database to check the tables");
                }
            }    // Close SqlConnection conn

            // Program to derive the name of the Summary and Detail Table names
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
            }  // Close while (!fileNameSet)
            setAllFieldsSelectedIndex(0);
            setSystemMessage2("Step 3: Please select the Ticket Number Field");
        }  // Close cmbInputTable_SelectedIndexChanged

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fillTables();
        }
        
        private void btnTktNoSelect_Click(object sender, EventArgs e)
        {
            // Program to check if item is selected and move the same to Ticket No Field.
            if (lbxAllFields.SelectedItems.Count!=1)
            {
                MessageBoxButtons mButtons = MessageBoxButtons.OK;
                MessageBox.Show ("Please select a field.","Message: Nothing Selected!",mButtons);
                setSystemMessage("Ticket Number Field select button pressed with no selection!");
            }
            else
            {
                if (tbTktNoField.Text!="")
                {
                    lbxAllFields.Items.Add(tbTktNoField.Text);
                    setSystemMessage("Unselected Ticket No Field: [" + tbTktNoField.Text + "]");
                }
                tbTktNoField.Text = lbxAllFields.SelectedItem.ToString();
                lbxAllFields.Items.RemoveAt(lbxAllFields.SelectedIndex);
                setAllFieldsSelectedIndex(0);
                setSystemMessage("Selected Ticket No Field: " + tbTktNoField.Text + "]");
                setSystemMessage2("Step 4: Please select the Ticket Source Field.");
            }
        }

        private void btnTktNoUnSelect_Click(object sender, EventArgs e)
        {
            if(tbTktNoField.Text=="")
            {
                MessageBoxButtons mButtons = MessageBoxButtons.OK;
                MessageBox.Show("Noting to Unselect", "Message:", mButtons);
                setSystemMessage("Warning: Ticket Number Field unselect button pressed with no selection!");
            }
            else
            {
                lbxAllFields.Items.Add(tbTktNoField.Text);
                setSystemMessage("Unselected Ticket No Field: " + tbTktNoField.Text);
                tbTktNoField.Text = "";
            }
            setSystemMessage2("Step 3: Please select the Ticket Number Field");
        }

        private void btnTktSrcSelect_Click(object sender, EventArgs e)
        {
            // Program to check if item is selected and move the same to Ticket Source Field.
            if (lbxAllFields.SelectedItems.Count != 1)
            {
                MessageBoxButtons mButtons = MessageBoxButtons.OK;
                MessageBox.Show("Please select a field.", "Message: Nothing Selected!", mButtons);
                setSystemMessage("Warning: Ticket Source Field Select button pressed with no selection!");
            }
            else
            {
                if (tbTktSrcField.Text != "")
                {
                    lbxAllFields.Items.Add(tbTktSrcField.Text);
                    setSystemMessage("Unselected Ticket Source Field: " + tbTktSrcField.Text +"]");
                }
                tbTktSrcField.Text = lbxAllFields.SelectedItem.ToString();
                lbxAllFields.Items.RemoveAt(lbxAllFields.SelectedIndex);
                setAllFieldsSelectedIndex(0);
                setSystemMessage("Selected Ticket No Field: " + tbTktSrcField.Text + "]");
                setSystemMessage2("Step 5: Please select the Text Fields for Analysis.");
            }

        }

        private void btnTktSrcUnSelect_Click(object sender, EventArgs e)
        {
            if (tbTktSrcField.Text == "")
            {
                MessageBoxButtons mButtons = MessageBoxButtons.OK;
                MessageBox.Show("Noting to Unselect", "Message:", mButtons);
                setSystemMessage("Warning: Ticket Source Field Unselect button pressed with no selection!");
            }
            else
            {
                lbxAllFields.Items.Add(tbTktSrcField.Text);
                tbTktSrcField.Text = "";
                setSystemMessage("Unselected Ticket Source Field: " + tbTktSrcField.Text + "]");
                setSystemMessage2("Step 4: Please select the Ticket Source Field.");
             }
        }

        private void btnTextFieldsSFSelect_Click(object sender, EventArgs e)
        {
            // Program to check if item is selected and move the same to Ticket Text Field.
            if (tbTktNoField.Text == "" || tbTktSrcField.Text == "")
            {
                MessageBoxButtons mbotton = MessageBoxButtons.OK;
                MessageBox.Show("Please Choose Both Ticket Number and Ticket Source \nBefore Selecting Remaining Text Fields.", "Message:", mbotton);
                setSystemMessage("Warning: Ticket Text Field select button pressed with unselected Ticket No and/or Ticket Source field!");
            }
            else
            {
                if (lbxAllFields.SelectedItems.Count != 1)
                {
                    MessageBoxButtons mButtons = MessageBoxButtons.OK;
                    MessageBox.Show("Please select a field.\nNothing is selected.", "Message:", mButtons);
                    setSystemMessage("Warning: Ticket Text Field selected button pressed with no field selected!");
                }
                else
                {
                    lbxTextFields.Items.Add(lbxAllFields.SelectedItem);
                    setSystemMessage("Selected Text Field: " + lbxAllFields.SelectedItem.ToString() + "]");
                    lbxAllFields.Items.RemoveAt(lbxAllFields.SelectedIndex);
                }
            }

        }

        private void btnTextFieldsSFUnselect_Click(object sender, EventArgs e)
        {
            if (lbxTextFields.SelectedItems.Count != 1)
            {
                MessageBoxButtons mButtons = MessageBoxButtons.OK;
                MessageBox.Show("Please select a field.\nNothing is selected.", "Message:", mButtons);
                setSystemMessage("Warning: Ticket Text Field unselect button pressed with no field selected!");
                // lbxAllFields.ClearSelected();
            }
            else
            {
                lbxAllFields.Items.Add(lbxTextFields.SelectedItem);
                setSystemMessage("Unselected Ticket Source Field: " + lbxTextFields.SelectedItem.ToString() + "]");
                lbxTextFields.Items.RemoveAt(lbxTextFields.SelectedIndex);
            }
        }

        private void btnTextFieldsMFSelect_Click(object sender, EventArgs e)
        {
            if(tbTktNoField.Text=="" || tbTktSrcField.Text=="")
            {
                MessageBoxButtons mbotton=MessageBoxButtons.OK;
                MessageBox.Show("Please Choose Both Ticket Number and Ticket Source \nBefore Selecting Remaining Text Fields.","Message:",mbotton);
            }
            else
            {
                for (int i = 0; i < lbxAllFields.Items.Count; i++)
                {
                    lbxTextFields.Items.Add(lbxAllFields.Items[i]);
                    setSystemMessage("Selected Multiple Text Field (" + i.ToString() + "): " + lbxAllFields.Items[i].ToString() + "]");
                }
                lbxAllFields.Items.Clear();
            }
        }

        private void btnTextFieldsMFUnselect_Click(object sender, EventArgs e)
        {
            if(lbxTextFields.Items.Count>0)
            {
                for (int i = 0; i < lbxTextFields.Items.Count; i++)
                {
                    lbxAllFields.Items.Add(lbxTextFields.Items[i]);
                    setSystemMessage("Unselected Multiple Text Field (" + i.ToString() + "): " + lbxAllFields.Items[i].ToString() + "]");
                }
                lbxTextFields.Items.Clear();
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
                setSystemMessage("File [" + tbStopWords.Text + "] selected");
            }
            else
            {
                setSystemMessage("File Dialog opened but. File not selected");

            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            // Initialize the progress bar.
            progressBar.Visible = true;
            progressBar.Minimum = 0;
            progressBar.Value = 0;
            progressBar.Maximum = 100;

            // Open the connection to the dataase 

            using (SqlConnection conn = new SqlConnection())
            {

                //-------------------------------------------
                //--- 01 Program to find the number of records 
                //-------------------------------------------
                try
                {
                    makeConnString();
                    conn.ConnectionString = myConStr;
                    conn.Open();
                    mySqlStm = "SELECT count(*) as TCOUNT from [" + cmbInputTable.Text + "]";
                    SqlCommand command = new SqlCommand(mySqlStm, conn); ;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            mTotalRecords = int.Parse(reader[0].ToString());
                            setSystemMessage("Total Records In Input file=" + mTotalRecords.ToString());
                            progressBar.Maximum = mTotalRecords;
                            progressBar.Value = 0;
                            tbInputRecords.Text = mTotalRecords.ToString();
                            tbInputRecords.Update();
                        }
                    }
                }
                catch (SqlException)
                {
                    setSystemMessage("SQL Exception: Could not calculate total input records");
                }




                //-------------------------------------------
                //--- 02 Program to create the detail table.
                //-------------------------------------------
                try
                {
                    mySqlStm = "create table [" + tbDetTable.Text
                        + "] (IncidentNo char(50), IncidentSource char(50), Word char(50), Count int);";
                    SqlCommand command = new SqlCommand(mySqlStm, conn);
                    command.ExecuteNonQuery();
                    setSystemMessage("Created Detail table!" + tbDetTable);
                }
                catch (SqlException)
                {
                    setSystemMessage("SQL Exception: Could not create Detail table!" + tbDetTable);
                }



                //-------------------------------------------
                //--- 04 Program to load stopword table if exist into the array else create.
                //-------------------------------------------
                stopWord = new List<string>();
                if (stopWordTableFlag)  // this flag was set during fill tables.
                {
                    setSystemMessage("The stopwords table already exists! Start reading from table.");
                    try
                    {
                        mySqlStm = "SELECT words from stopwords";
                        using (SqlCommand command = new SqlCommand(mySqlStm, conn))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    stopWord.Add(reader[0].ToString());
                                    setSystemMessage("Read from Stop Word Table word:" + reader[0].ToString());
                                }
                            }
                            setSystemMessage("Completed reading from stop word table.");
                        }
                    }
                    catch (SqlException)
                    {
                        setSystemMessage("SQL Exception: Could not load stop words from stopwords table");
                    }
                }
                else
                {
                    try
                    {
                        mySqlStm = "create table [stopwords] (Word char(50));";
                        using (SqlCommand command = new SqlCommand(mySqlStm, conn))
                        {
                            command.ExecuteNonQuery();
                        }
                        setSystemMessage("Created stopwords table!");
                    }
                    catch (SqlException)
                    {
                        setSystemMessage("SQL Exception: Could not create stopwords table!");
                    }
                }

                //-------------------------------------------
                //--- 05 Program to check if the stopword file specified has new words add to the list.
                //-------------------------------------------
                if (File.Exists(tbStopWords.Text))
                {
                    if (stopWord.Count == 0) stopWord.Add("");
                    using (StreamReader sr2 = new StreamReader(tbStopWords.Text))
                    {
                        while (sr2.Peek() > 0)
                        {
                            newStopWord = sr2.ReadLine().Trim().ToLower();
                            if (stopWord.Contains(newStopWord))
                            {
                                setSystemMessage("Stop Word from file already Exists: " + newStopWord);
                            }
                            else
                            {
                                try
                                {
                                    stopWord.Add(newStopWord);
                                    mySqlStm = "insert into stopwords values('" + newStopWord + "');";

                                    using (SqlCommand command = new SqlCommand(mySqlStm, conn))
                                    {
                                        command.ExecuteNonQuery();
                                    }
                                }
                                catch (SqlException)
                                {
                                    setSystemMessage("SQL Exception: Could not add to table new stop word:" + newStopWord);
                                }
                            }  // End else                                 
                        }   // end while loop
                    }  // end steam reader
                    setSystemMessage("Stop Word File loading completed...");
                } // end if stopword file exists
                else
                {
                    setSystemMessage("Stop Word File not found skipping load of file...");
                }
            } // Closing SQL Connection conn


            using (SqlConnection conn = new SqlConnection())
            {
                makeConnString();
                conn.ConnectionString = myConStr;
                conn.Open();

                //--- 06 Program to fetch the records and process word count to populate details table.

                mySqlStm = "SELECT ";
                mySqlStm += "[" + tbTktNoField.Text + "]";
                mySqlStm += ",[" + tbTktSrcField.Text + "]";
                mTotalFields = 2 + lbxTextFields.Items.Count;

                for (int i = 0; i < lbxTextFields.Items.Count; i++)
                    mySqlStm += ",[" + lbxTextFields.Items[i].ToString() + "]";
                mySqlStm += " from " + cmbInputTable.Text;

                setSystemMessage("Created SQL Stm: "+ mySqlStm + "\n" + msgBox.Text);
                using (SqlCommand command = new SqlCommand(mySqlStm, conn))
                {
                    // Open the loop to read each record of SQL command query output
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        mCurrentRecord = 1;
                        mCurrentDetailRec = 1;
                        while (reader.Read())
                        {
                            // The code to process each record.
                            IncidentId = reader[0].ToString();
                            IncidentSource = reader[1].ToString();
                            Description = "";
                            for (int i = 2; i < mTotalFields; i++)
                            { Description += " "+reader[i].ToString(); }

                            Description = removeLineEndings(Description);
                            Description = rgx.Replace(Description, " ");

                            // Program to split the words of Description by space
                            var desWords = Description.Split(' ');

                            // Program to sort the words found in description
                            Array.Sort<string>(desWords);

                            // Proram to process the Description and count the words and store
                            string newDesWord = "";
                            searchWord = tbOptSearchString.Text;
                            int newDesWordCnt = 1;
                            for (int i = 0; i < desWords.Length; i++)
                            {
                                // convert the description word to lower
                                desWords[i] = desWords[i].ToLower();

                                // Program to skip the words if the word are in stop words array
                                if (stopWord.Contains(desWords[i])) continue;

                                // Program to skip the words if the word does not match searchWord
                                if (searchWord != "") if (!(desWords[i].IndexOf(searchWord) >= 0)) continue;

                                // Program to parse through the sorted list of description words and write when the words change with count.
                                if (desWords[i] == newDesWord)
                                    newDesWordCnt++;
                                else
                                {
                                    // Program to insert the record in the detail table
                                    // sw.WriteLine(IncidentId + ',' + IncidentSource + ',' + desWords[i] + ',' + newDesWordCnt.ToString());
                                    // TODO
                                    mySqlStm = "insert into [" + tbDetTable.Text
                                        + "] values('" + IncidentId
                                        + "','" + IncidentSource
                                        + "','" + desWords[i]
                                        + "'," + newDesWordCnt.ToString()
                                        + ");";

                                    using (SqlCommand command2 = new SqlCommand(mySqlStm, conn))
                                    {
                                            command2.ExecuteNonQuery();
                                    }

                                    newDesWord = desWords[i];
                                    newDesWordCnt = 1;
                                    // Incrementing the output file record counter by 1
                                    tbOutputRecords.Text = mCurrentDetailRec.ToString();
                                    tbOutputRecords.Update();
                                    mCurrentDetailRec++;

                                }
                            }

                            // Incrementing the input file record counter by 1
                            setSystemMessage("Record: " + mCurrentRecord.ToString() + " Word Count Processed...");
                            progressBar.Value = mCurrentRecord;
                            tbCurrRecord.Text = mCurrentRecord.ToString();
                            tbCurrRecord.Update();
                            mCurrentRecord++;

                        }
                    } // Closing of SQL Data Reader reader

                    //-------------------------------------------
                    //--- 03 Program to create the summary table.
                    //-------------------------------------------
                    try
                    {
                        // mySqlStm = "create table [" + tbSumTable.Text + "] (Word char(50), Incidents int);";
                        mySqlStm = "select Word, IncidentSource, count(*) as [IncidentCount] ";
                        mySqlStm += "into [" + tbSumTable.Text + "] ";
                        mySqlStm += "from [" + tbDetTable.Text + "] ";
                        mySqlStm += "group by Word, IncidentSource ";
                        mySqlStm += "order by IncidentCount Desc";

                        using (SqlCommand command2 = new SqlCommand(mySqlStm, conn))
                        {
                            command2.ExecuteNonQuery();
                        }
                        setSystemMessage("Created Summary table!" + tbSumTable);
                    }
                    catch (SqlException)
                    {
                        setSystemMessage("SQL Exception Could not create Summary table!" + tbSumTable);
                    }

                    setSystemMessage("Done!");

                }
            }  // Closing of SQL Connection conn
        } // Closing of btnProcess_Click procedure

        private void tbDBSource_TextChanged(object sender, EventArgs e)
        {
            makeConnString();
        }

        private void loadCSV_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("C:\\Users\\sisumank\\Documents\\Share_Mothi\\apr16_pipe.csv"))
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    myConStr = "Data Source=SISUMANK1\\SUMANDB" ;
                    myConStr += ";Initial Catalog=test" ;
                    myConStr += ";User id=sa" ;
                    myConStr += ";Password=S1u2m3a4n5" ;
                    myConStr += ";MultipleActiveResultSets=true";

                    conn.ConnectionString = myConStr;
                    conn.Open();
                    int mrowcount=0;
                    setSystemMessage("Start :"+mrowcount.ToString());
                    while (sr.Peek()>0)
                    {
                        string mline = sr.ReadLine();

                        if(mrowcount>=60000)
                        {
                            string[] mfields = mline.Split('|');
                            mySqlStm = "insert into input values('";
                            mySqlStm += mfields[0].Replace("\'", " ").Replace("\"", " ") + "','";
                            mySqlStm += mfields[1].Replace("\'", " ").Replace("\"", " ") + "','";
                            mySqlStm += mfields[2].Replace("\'", " ").Replace("\"", " ") + "','";
                            mySqlStm += mfields[3].Replace("\'", " ").Replace("\"", " ") + "','";
                            mySqlStm += mfields[4].Replace("\'", " ").Replace("\"", " ") + "','";
                            mySqlStm += mfields[5].Replace("\'", " ").Replace("\"", " ") + "')";
                            using (SqlCommand command = new SqlCommand(mySqlStm, conn))
                            {
                                command.ExecuteNonQuery();
                            }
                        }
                        setSystemMessage("Inserted :" + mrowcount.ToString());
                        if (mrowcount == 100000) break;
                        mrowcount++;
                    }  // while loop ends
                    setSystemMessage("End :" + mrowcount.ToString());
                }  // sql connection end
            } // stream reader end
        }  //load csv end 
    } // Closing of Partial Class Form
}// Closing of namespace TAA1
