using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checksubject
{
    public partial class Form9 : Form
    {
        public string id;
        public Form9(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        



        }

        private void Form9_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("server =.\\SQLEXPRESS; database=select-the-topic; uid = sa; Pwd = a3252016"))
            {
                conn.Open();
                string sql = string.Format("select TP.tpno,tpname,tpcon,goal from TP,CT where tno = {0} and TP.tpno=CT.tpno", id); // 

                //SqlConnection cnn = new SqlConnection(sqlconn);
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //MessageBox.Show(da.ToString());
                DataTable dt = new DataTable();
                // MessageBox.Show(dt.ToString());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }
       

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 题目表BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
