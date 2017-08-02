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
    public partial class Form16 : Form
    {
        public string id;
        public Form16(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("server =.\\SQLEXPRESS; database=select-the-topic; uid = sa; Pwd = a3252016"))
            {
                conn.Open();
                // string sql = "select sno from S "; // 
                string sql = string.Format(" select UP.sno,RP.rpname,rpcon from UP,RP,XT,CT where UP.sno =XT.sno and CT.tpno=XT.tpno and CT.tno= '{0}'and UP.rpname =RP.rpname", id);
                //string sql ="select RP.rpname,rpcon from XT,CT,TP,RP,UP";//and RP.rpname =UP.rpname   where CT.tpno =XT.tpno and XT.sno =UP.sno 

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
    }
}
