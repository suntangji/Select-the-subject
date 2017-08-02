using checksubject;
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
            con.ConnectionString = "server=.\\SQLExpress;uid=sa;pwd=a3252016;database=select-the-topic";
            con.Open();
            string sql = string.Format("select sname from S where sno='{0}'", id);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form13 f13 = new Form13(id);
            //f8.button1.Visible = false;
            f13.TopLevel = false;    //设置为非顶级窗体
            f13.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //设置窗体为非边框样式
            f13.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel
            panel1.Controls.Add(f13);      //添加窗体
            f13.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form14 f14 = new Form14(id);
            //f8.button1.Visible = false;
            f14.TopLevel = false;    //设置为非顶级窗体
            f14.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //设置窗体为非边框样式
            f14.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel
            panel1.Controls.Add(f14);      //添加窗体
            f14.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm f1 = new MainForm();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();//id
            Form15 f15 = new Form15(id);
            //f8.button1.Visible = false;
            f15.TopLevel = false;    //设置为非顶级窗体
            f15.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //设置窗体为非边框样式
            f15.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel
            panel1.Controls.Add(f15);      //添加窗体
            f15.Show();
        }
    }
}
