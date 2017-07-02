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
    public partial class Form6 : Form
    {
        public string id;
        public Form6(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void studentview_Load(object sender, EventArgs e)
        {
            //textBox1.Text = id;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.\\SQLExpress;uid=sa;pwd=a3252016;database=SubjiectSelection";
            con.Open();
            string sql = string.Format("select 姓名 from 学生 where 学号='{0}'", id);
            SqlCommand cmd = new SqlCommand(sql, con);
            // cmd.Connection = con;
            // SqlDataReader dr = cmd.ExecuteReader();
            textBox1.Text = (string)cmd.ExecuteScalar();
            //if (dr.Read())
            // {

            // textBox1.Text = dr.ToString();

            con.Close();
            con.Dispose();  //释放连接
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form12 f12 = new Form12(id);
            //f8.button1.Visible = false;
            f12.TopLevel = false;    //设置为非顶级窗体
            f12.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //设置窗体为非边框样式
            f12.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel
            panel1.Controls.Add(f12);      //添加窗体
            f12.Show();                    //窗体运行
        }
    }
}
