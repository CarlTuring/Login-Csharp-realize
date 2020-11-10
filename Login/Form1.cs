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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 next = new Form3();//创建将要打开的窗体对象
            next.Show(); 
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String userName = this.textBox1.Text; // 获取里面的值

            String userPassword = this.textBox2.Text;

            userName = userName.Trim();

            userPassword = userPassword.Trim();

            if (userName.Equals("") || userPassword.Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
            else
            {
                string strcon = "server=localhost;database=login;uid=root;pwd=123456;";
                MySqlConnection con = new MySqlConnection(strcon);
                try
                {
                    con.Open();
                    string sqlSel = "select count(*) from login.log where userName = '" + userName + "' and userPassword = '" + userPassword + "'";
                    MySqlCommand com = new MySqlCommand(sqlSel, con);
                    if (Convert.ToInt32(com.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("登录成功！");
                        /*this.DialogResult = DialogResult.OK;
                          this.Dispose();
                          this.Close();*/
                        Form2 next = new Form2();//创建将要打开的窗体对象
                        next.Show(); // 打开新窗体--Show非模式对话框--ShowDialog模式对话框
                        this.Hide();// this.Close()关闭当前窗体,因为登录是主窗体所以不能关闭
                                    //用户名和密码验证错误，提示错误。
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + "打开数据库失败");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", "D:/workspace/login/userlaw.txt");
        }
    }
}
