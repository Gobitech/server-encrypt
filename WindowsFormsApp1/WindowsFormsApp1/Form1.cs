using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Remoting.Contexts;

namespace Login_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            SqlConnection Connect = new SqlConnection(@"Data Source=GOBI;Initial Catalog=QLSV; User ID=sa;Password=Goblin2002");
            try
            {
                Connect.Open();
                string name = User_name.Text;
                string password = pass.Text;
                string sql = "Select *from SINHVIEN where TENDN = '" + name + "' and MATKHAU = HASHBYTES('MD5','" + password + "') ";
                string SQL_con = "select * from NHANVIEN where TENDN = '" + name + "' and MATKHAU = HASHBYTES('SHA1','" + password + "')";
                SqlCommand cmd = new SqlCommand(sql, Connect);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng Nhập Thành Công");
                }
                else
                {
                    dta.Close();
                    cmd = new SqlCommand(SQL_con, Connect);
                    dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                        MessageBox.Show("Đăng Nhập Thành Công");
                    else
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối");
            }
        }

    }

}
