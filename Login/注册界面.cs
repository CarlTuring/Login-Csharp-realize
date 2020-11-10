using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class 注册界面 : Form
    {
        MySqlConnection con;//定义数据库连接
        MySqlCommand cmd = new MySqlCommand();//定义数据库执行操作类
        public 注册界面()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            登录界面 next = new 登录界面();
            next.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sqlConn = "server=localhost;port=3306;user=root;password=123456;database=login";//定义连接字符串,Charset=utf8使可以填充中文字符不出现乱码
            con = new MySqlConnection(sqlConn);//
            con.Open();
            cmd.CommandText = string.Format("INSERT INTO login.log(userName,userPassword) values('{0}','{1}');", this.textBox1.Text,this.textBox2.Text);
            cmd.Connection = con;
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("注册成功");
                登录界面 next = new 登录界面();
                next.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("注册失败");
                登录界面 next = new 登录界面();
                next.Show();
                this.Hide();
            }

        }
    }
}
