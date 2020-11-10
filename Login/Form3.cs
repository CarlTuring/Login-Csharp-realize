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
    public partial class Form3 : Form
    {
        MySqlConnection con;//定义数据库连接
        MySqlCommand cmd = new MySqlCommand();//定义数据库执行操作类
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 next = new Form1();
            next.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sqlConn = "server=localhost;port=3306;user=root;password=123456;database=login";//定义连接字符串,Charset=utf8使可以填充中文字符不出现乱码
            con = new MySqlConnection(sqlConn);//
            con.Open();
            cmd.CommandText = string.Format("INSERT INTO login.log(userName,userPassword,sex,telephone,invite,rePassword,date) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}');"
                , this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, this.textBox5.Text, this.textBox6.Text, this.textBox7.Text,this.dateTimePicker1.Value);
            cmd.Connection = con;
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("注册成功");
                Form1 next = new Form1();
                next.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("注册失败");
                Form1 next = new Form1();
                next.Show();
                this.Hide();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", "D:/workspace/login/userlaw.txt");
        }
    }
}
