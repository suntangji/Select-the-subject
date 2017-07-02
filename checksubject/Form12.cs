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
            string sqlString = "SELECT 题目名 FROM 题目表 ";
            DataSet ds = GetData(sqlString);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                listBox1.Items.Add(row["题目名"].ToString());
            }

        }

        DataSet GetData(String queryString)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=SubjiectSelection; User ID=sa; Pwd=a3252016"))
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


                using (SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=SubjiectSelection; User ID=sa; Pwd=a3252016"))
                {
                    try
                    {
                        conn.Open();
                        string sql = string.Format("insert into  选题表 values('{0}','{1}')", listBox1.SelectedItem.ToString(), id);                            //{0}','{1}'",        //);
                                                                                                                                                             //SqlConnection cnn = new SqlConnection(sqlconn);
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("已选择" + listBox1.SelectedItem.ToString());

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("你已经选过了",
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
