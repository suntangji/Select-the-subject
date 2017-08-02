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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.\\SQLExpress;uid=sa;pwd=a3252016;database=select-the-topic";

            string sql = string.Format("select count(*) from Taccount where tno='{0}'", textBox1.Text);
            //SqlConnection cnn = new SqlConnection(sqlconn);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            int a = (int)cmd.ExecuteScalar();//返回一个值,看看有没有 
            if (a == 0)
            {
                StringBuilder strsql = new StringBuilder();
                strsql.Append("insert into T");
                strsql.Append(" values (");
                strsql.Append("'" + textBox1.Text.Trim().ToString() + "',");
                strsql.Append("'" + textBox2.Text.Trim().ToString() + "',");
                strsql.Append("'" + textBox5.Text.Trim().ToString() + "'");
                //strsql.Append("'" + textBox6.Text.Trim().ToString() + "'");
                strsql.Append(");");
                if (textBox1.Text != "" &&
                    textBox2.Text != "" &&
                    textBox3.Text != "" &&
                    textBox4.Text != "" &&
                    textBox5.Text != "" &&
                    //textBox6.Text != "" &&
                    textBox4.Text == textBox5.Text
                    )
                {
                    strsql.Append("insert into Taccount");
                    strsql.Append(" values (");
                    strsql.Append("'" + textBox1.Text.Trim().ToString() + "',");
                    strsql.Append("'" + textBox4.Text.Trim().ToString() + "'");
                    strsql.Append(")");

                    using (SqlCommand cmd2 = new SqlCommand(strsql.ToString(), con))
                    {
                        //con.Open();//打开数据库                     
                        cmd2.ExecuteNonQuery();
                        con.Dispose();
                        con.Close();
                    }
                    MessageBox.Show("注册成功！",
                                 "信息提示",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);//信息显示
                    this.Close();
                }
                else
                {
                    MessageBox.Show("两次输入密码不一致,或者信息不全",
                                    "信息提示",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;
                    textBox4.Text = null;
                    textBox5.Text = null;
                }

            }
            else
            {
                MessageBox.Show("用户已存在",
                                 "信息提示",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);//
                con.Close();
            }

        }
    }
}
