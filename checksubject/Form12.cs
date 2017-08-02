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
    public partial class Form12 : Form
    {
        public string id;
        public Form12(string id )
        {
            InitializeComponent();
            this.id = id;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form12_Load(object sender, EventArgs e)
        {
            string sqlString = "SELECT tpname FROM TP ";
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

                    try
                     {
                     
                        string sql3 = string.Format("select tpno from XT where sno ='{0}'",id);
                        SqlCommand cmd3 = new SqlCommand(sql3, conn);
                        SqlDataReader dr = cmd3.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("你已经选过了",
                                             "信息提示",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                            dr.Close();
                           
                        }
                        else
                        {
                            conn.Close();
                            conn.Open();
                            string sql2 = string.Format("select tpno from TP where tpname ='{0}'", listBox1.SelectedItem.ToString());
                            //string sql2 = "select tpno from TP ";
                            SqlCommand cmd2 = new SqlCommand(sql2, conn);
                            string dra = cmd2.ExecuteScalar().ToString();

                            // MessageBox.Show(dra);

                            // SqlDataReader dr = cmd2.ExecuteReader();

                            // string dr = (string)cmd2.ExecuteScalar().ToString();
                            conn.Close();
                            conn.Open();

                            string sql4 = string.Format("select count(sno) from XT where tpno={0}", dra);
                            SqlCommand cmd4 = new SqlCommand(sql4, conn);
                            int dra2 = (int)cmd4.ExecuteScalar();
                            if (dra2 >= 2)
                            {
                                MessageBox.Show("已达人数上限",
                                                    "信息提示",
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Error);
                                conn.Close();
                                /// con.Open();

                            }
                            else
                            {
                                conn.Close();
                                conn.Open();
                                string sql = string.Format("insert into  XT values('{0}','{1}')", id, dra);                            //{0}','{1}'",        //);
                                                                                                                                       //SqlConnection cnn = new SqlConnection(sqlconn);
                                SqlCommand cmd = new SqlCommand(sql, conn);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("已选择" + listBox1.SelectedItem.ToString(),
                                            "信息提示",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
                            }
                           
                          
                        }
                       

                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show(ex.ToString(),
                                         "信息提示",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                      
                    }
                    // SqlDataReader dr = cmd.ExecuteReader();
                    //if (dr.Read())
                    // {
                    // MessageBox.Show("成功！");
                    // }
                }

                //listBox1.Items.Remove(listBox1.SelectedItem);
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
