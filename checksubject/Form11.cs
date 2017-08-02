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
    public partial class Form11 : Form
    {
        public string id;
        public Form11(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ||
                   textBox2.Text == ""
                   )
            {
                MessageBox.Show("学号或成绩不能为空",
                                     "信息提示",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
            else
            {

                using (SqlConnection conn = new SqlConnection("server =.\\SQLEXPRESS; database=select-the-topic; uid = sa; Pwd = a3252016"))
                {
                    conn.Open();

                    string sql4 = string.Format("select grade from Grade where sno={0}", textBox1.Text);
                    SqlCommand cmd4 = new SqlCommand(sql4, conn);
                    SqlDataReader dr = cmd4.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("你也提交过成绩",
                                         "信息提示",
                                          MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
                        dr.Close();
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                        string sql = string.Format("select sno from XT,CT  where sno='{0}'and CT.tpno =XT.tpno and CT.tno='{1}'", textBox1.Text, id);
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataReader dr2 = cmd.ExecuteReader();
                        if (dr2.Read())
                        {
                            conn.Close();
                            try
                            {
                                conn.Open();
                                string sql2 = string.Format("insert into  Grade values('{0}','{1}')", textBox1.Text, textBox2.Text);
                                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                                cmd2.ExecuteNonQuery();
                                MessageBox.Show("提交成功！",
                                             "信息提示",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("提交失败！",
                                            "信息提示",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            }
                        }

                        else
                        {
                            MessageBox.Show("学号不存在！",
                                            "信息提示",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            conn.Close();

                        }


                   }
              }
                   

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
