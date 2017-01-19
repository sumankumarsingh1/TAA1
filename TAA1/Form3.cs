using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAA1
{
    public partial class Form3 : Form
    {
        public Form3(string mySqlStm, string myConStr)
        {
            InitializeComponent();
            FillData(mySqlStm, myConStr);
        }
        void FillData(string mySqlStm, string myConStr)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
