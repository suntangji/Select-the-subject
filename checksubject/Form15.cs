using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checksubject
{
    public partial class Form15 : Form
    {
        public string id;
        public Form15(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void Form15_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(op.FileName);
                if (fi.Exists)
                    fi.CopyTo(@"E:\报告" + op.SafeFileName);
            }*/

            using (SqlConnection con = new SqlConnection("server =.\\SQLExpress; uid = sa; pwd = a3252016; database =select-the-topic")) 
            {
                //con.ConnectionString = "server=.\\SQLExpress;uid=sa;pwd=a3252016;database=select-the-topic";
                con.Open();
                string sql2 = string.Format("select rpname from UP where sno={0}",id);
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                SqlDataReader dr = cmd2.ExecuteReader();
                if(dr.Read())
                {
                    MessageBox.Show("你也提交过报告",
                                     "信息提示",
                                      MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                    dr.Close();
                    con.Close();
                }
                else
                {
                    con.Close();
                    con.Open();
                    string sql = string.Format("insert into RP values('{0}','{1}');insert into UP values('{2}','{3}')", textBox1.Text, richTextBox1.Text, id, textBox1.Text);
                    //SqlConnection cnn = new SqlConnection(sqlconn);
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("提交成功",
                                    "信息提示",
                                     MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);

                }
            }
            

        }
    }
}
