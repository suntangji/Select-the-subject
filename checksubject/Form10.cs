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
    public partial class Form10 : Form
    {
        public string id;
        public Form10(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            string sqlString =string.Format( "SELECT tpname FROM TP,CT where tno ='{0}'and TP.tpno=CT.tpno",id);
            DataSet ds = GetData(sqlString);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                listBox1.Items.Add(row["tpname"].ToString());
            }
        }
        DataSet GetData(String queryString)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=select-the-topic; User ID=sa; Pwd=a3252016"))
            {
                DataSet ds = new DataSet();
                try
                {
                    // Connect to the database and run the query.
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(queryString, conn);
                    // Fill the DataSet.
                    adapter.Fill(ds);
                    // conn.Close();
                }
                catch
                {
                    MessageBox.Show("查看失败！",
                                     "信息提示",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }
                return ds;

                //conn.Dispose();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)//如果选中某列
            {
                using (SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=select-the-topic; User ID=sa; Pwd=a3252016"))
                {
                    conn.Open();
                    string sql2 = string.Format("select tpno from TP where tpname ='{0}'", listBox1.SelectedItem.ToString());
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);
                    string dra = cmd2.ExecuteScalar().ToString();
                    conn.Close();
                    conn.Open();
                    //MessageBox.Show(dra);
                    // string sql3 = string.Format("select tpno from XT where tpno ='{0}'and tno ='{1}'", listBox1.SelectedItem.ToString(), id);
                    // SqlDataReader dr = cmd2.ExecuteReader();

                    // string dr = (string)cmd2.ExecuteScalar().ToString();
                    string sql4= string.Format("select sno from XT where tpno ='{0}'", dra);  
                    SqlCommand cmd4 = new SqlCommand(sql4, conn);
                    //string dra2 = cmd4.ExecuteScalar().ToString();
                    SqlDataReader dra2 = cmd4.ExecuteReader();
                    if (dra2.Read())
                     {
                     MessageBox.Show("已有人选题！",
                                     "信息提示",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                        dra2.Close();
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();

                        string sql = string.Format("delete from CT where tpno='{0}'", dra);
                        string sql3 = string.Format("delete from TP where tpno='{0}'", dra);
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        conn.Open();
                        SqlCommand cmd3 = new SqlCommand(sql3, conn);
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("已删除" + listBox1.SelectedItem.ToString(),
                                        "信息提示",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                        conn.Close();
                        listBox1.Items.Remove(listBox1.SelectedItem);
                    }
                  
                    
                  /*  catch (Exception )
                    {
                        MessageBox.Show("已有人选做，不能删除",
                                          "信息提示",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                    }*/





                    // SqlDataReader dr = cmd.ExecuteReader();
                    //if (dr.Read())
                    // {
                    // MessageBox.Show("成功！");
                    // }
                }

               
            }
            else
            {
                MessageBox.Show("未选中！",
                                "信息提示",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }

    }
}

