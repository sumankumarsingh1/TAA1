using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TAA1
{
    public partial class Form2 : Form
    {
        string mInputTable1;
        string mSumTableLst1;
        string mDetTableLst1;
        string myConStr1;
        
        public Form2(string mySqlStm,string myConStr, string mInputTable, string mSumTableLst, string mDetTableLst)
        {
            InitializeComponent();
            myConStr1 = myConStr;
            mInputTable1 = mInputTable;
            mSumTableLst1 = mSumTableLst;
            mDetTableLst1 = mDetTableLst;
            FillData(mySqlStm,myConStr);
        }

        void FillData(string mySqlStm,string myConStr)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = myConStr;
                conn.Open();
                using (SqlCommand sqlcmd = new SqlCommand(mySqlStm, conn))
                {
                    using (SqlDataAdapter sda1 = new SqlDataAdapter(sqlcmd))
                    {
                        DataTable dt = new DataTable();
                        sda1.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            MessageBoxButtons mButtons = MessageBoxButtons.OK;
            MessageBox.Show("Selected Cell: ", "Message:", mButtons);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string mWord = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            string mySqlStm;
            mySqlStm = "SELECT [Incident Identifier],[Source System Name],[Incident Title Description],[Configuration Item Name],[Affected Configuration Item Name] ";
            mySqlStm += "FROM[test].[dbo].[" + mInputTable1 + "] where[Incident Identifier] in ";
            mySqlStm += "(SELECT [IncidentNo] FROM [" + mDetTableLst1 + "] WHERE [word] = '" + mWord + "')";
            //MessageBoxButtons mButtons = MessageBoxButtons.OK;
            //MessageBox.Show("Selected Row: "+mySqlStm, "Message:", mButtons);

            Form3 f3 = new Form3(mySqlStm, myConStr1);
            f3.Show();

        }
    }
}
