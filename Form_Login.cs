using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Chuck_Time_Bakery
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }
        
        private void Button_login_guest_Click(object sender, EventArgs e)
        {
            Hide();
            Form_main fm = new Form_main();
            fm.status = "Вы вошли как гость!";
            fm.редактироватьУчетнуюЗаписьToolStripMenuItem.Visible = false;
            fm.Show();
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Arius;Initial Catalog=Chuck_Time;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Role FROM Login WHERE Login = '" + textBox_login.Text + "' and Password = '" + textBox_password.Text + "'", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt); //dt.Rows[0][0].ToString();
            if (dt.Rows.Count == 1)
            {
                Hide();
                Form_main fm = new Form_main();
                fm.status = dt.Rows[0][0].ToString();
                dt.Clear();
                con.Close();
                fm.Show();

            }
            else
            {
                MessageBox.Show("Логин и/или пароль введены неверно!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_login.Text = "";
                textBox_password.Text = "";
                textBox_login.Focus();
            }
        }

        private void Form_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
