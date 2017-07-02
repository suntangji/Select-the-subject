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
    public partial class Form8 : Form
    {
        public string id;
        public Form8(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
       
            string sqlString =string.Format( "SELECT 题目名 FROM 题目表 where 教师号 = {0}",id);
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
    
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

     
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //代码

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)//如果选中某列
            {
                

                using (SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=SubjiectSelection; User ID=sa; Pwd=a3252016"))
                {
                    conn.Open();
                    string sql = string.Format("delete  from 题目表 where 题目名='{0}'",listBox1.SelectedItem.ToString() );
                    //SqlConnection cnn = new SqlConnection(sqlconn);
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                   // SqlDataReader dr = cmd.ExecuteReader();
                    //if (dr.Read())
                   // {
                      // MessageBox.Show("成功！");
                   // }
                 }
                MessageBox.Show(listBox1.SelectedItem.ToString()+"删除成功",
                                    "信息提示",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("删除失败！",
                                 "信息提示",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
            }
        }
    }
}
