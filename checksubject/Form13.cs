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
    public partial class Form13 : Form
    {
        public string id;
        public Form13(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“subjiectSelectionDataSet4.题目表”中。您可以根据需要移动或删除它。
            //this.题目表TableAdapter.Fill(this.subjiectSelectionDataSet4.题目表);
            // TODO: 这行代码将数据加载到表“subjiectSelectionDataSet3.选题表”中。您可以根据需要移动或删除它。
            //this.选题表TableAdapter.Fill(this.subjiectSelectionDataSet3.选题表);
            using (SqlConnection conn = new SqlConnection("server =.\\SQLEXPRESS; database=select-the-topic; uid = sa; Pwd = a3252016"))
            {
                conn.Open();
                string sql = string.Format("select TP.tpno,tpname,tpcon,goal from TP,XT where sno='{0}'and TP.tpno = XT.tpno", id); // select rpname,grade from UP,PY where sno = {0} and UP.rpname=PY.rpname",
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            //SqlConnection cn = new SqlConnection("server = .; database = advnet;uid = sa;pwd = sa");
            

        }
    }
}
