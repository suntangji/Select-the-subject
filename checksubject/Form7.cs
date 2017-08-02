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
            con.ConnectionString = "server=.\\SQLExpress;uid=sa;pwd=a3252016;database=select-the-topic";
            con.Open();
           // string sql = string.Format("select count(*) from T where tno='{0}'", textBox2.Text);
            //SqlConnection cnn = new SqlConnection(sqlconn);
            //SqlCommand cmd = new SqlCommand(sql, con);
            
            
            


                if (textBox1.Text != ""&&
                textBox2.Text != ""&&
                richTextBox1.Text!=""&&
                richTextBox2.Text!="")
                {
                string sql2 = string.Format("select count(tpno) from CT where tno={0}", id);
                SqlCommand cmd3 = new SqlCommand(sql2, con);
                int dra =(int)cmd3.ExecuteScalar();
                if(dra >=3)
                { MessageBox.Show("已达题目上限",
                                      "信息提示",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                    con.Close();
                   /// con.Open();

                }
                else
                {
                    string strsql = string.Format("insert into TP values('{0}','{1}','{2}','{3}');insert into CT  values('{4}','{5}')", textBox1.Text, textBox2.Text, richTextBox1.Text, richTextBox2.Text, id, textBox1.Text);

                    try
                    {
                        SqlCommand cmd2 = new SqlCommand(strsql.ToString(), con);

                        // con.Open();    //con.Open();//打开数据库                     
                        cmd2.ExecuteNonQuery();

                        con.Close();
                        con.Dispose();

                        MessageBox.Show("添加成功！",
                                         "信息提示",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);//信息显示
                                                                     //this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(),
                                         "信息提示",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
                        con.Close();
                        con.Dispose();
                    }

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
