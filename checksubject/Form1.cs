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
    public partial class MainForm : Form
    {
        //string id;

        public MainForm()
        {
            InitializeComponent();
            
        }
         
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form4 reg = new Form4();
        
            reg.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        public string id;
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ||
                    textBox2.Text == ""
                    )
            {
                MessageBox.Show("账号或密码不能为空",
                                     "信息提示",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.\\SQLExpress;uid=sa;pwd=a3252016;database=select-the-topic";
            con.Open();
            //string sql;
            if (radioButton1.Checked == true)
            {
                string sql = string.Format("select * from Saccount where sno='{0}'and password='{1}'", textBox1.Text, textBox2.Text);
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //MessageBox.Show("成功！");
                    id = textBox1.Text;
                    Form6 f6 = new Form6(id);

                    f6.Show();
                    this.Hide();
                    con.Close();
                    con.Dispose();
                 

                }
                else
                {
                    MessageBox.Show("账号或密码错误失败！",
                                      "信息提示",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }
                
            }
            else if(radioButton2.Checked == true)
            {
                string sql = string.Format("select * from Taccount where tno='{0}'and password='{1}'", textBox1.Text, textBox2.Text);
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //MessageBox.Show("成功！");
                    id = textBox1.Text;
                    Form3 f3 = new Form3(id);
                    f3.Show();
                    this.Hide();
                    con.Close();
                    con.Dispose();
                    
                }
                else
                {
                    MessageBox.Show("登录失败，请重试！",
                                     "信息提示",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("请选择身份！",
                                 "信息提示",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
            }

            







        }


    }


}
