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
    public partial class Form7 : Form
    {
        public string id;
        public Form7(string id)
        {
            InitializeComponent();
            this.id = id;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.\\SQLExpress;uid=sa;pwd=a3252016;database=SubjiectSelection";
            con.Open();
           // string sql = string.Format("select count(*) from 教师 where 教师号='{0}'", textBox2.Text);
            //SqlConnection cnn = new SqlConnection(sqlconn);
            //SqlCommand cmd = new SqlCommand(sql, con);
            
            
            


                if (textBox1.Text != "")
                {
                    StringBuilder strsql = new StringBuilder();
                    strsql.Append("insert into 题目表");
                    strsql.Append(" values (");
                    strsql.Append("'" + textBox1.Text.Trim().ToString() + "',");
                    strsql.Append("'" + id + "',");
                    strsql.Append("'" + richTextBox1.Text.Trim().ToString() + "'");
                    //strsql.Append("'" + textBox6.Text.Trim().ToString() + "'");
                    strsql.Append(");");
                try
                {
                    using (SqlCommand cmd2 = new SqlCommand(strsql.ToString(), con))
                    {
                        // con.Open();    //con.Open();//打开数据库                     
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    MessageBox.Show("添加成功！",
                                     "信息提示",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);//信息显示
                                                                 //this.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("题目名已存在！",
                                     "信息提示",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);

                }


                }



                else
                {
                    MessageBox.Show("题目名不能为空！",
                                      "信息提示",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                }
            
            
        }
    }
}
