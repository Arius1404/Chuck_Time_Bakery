using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuck_Time_Bakery
{
    public partial class Form_login_edit : Form
    {
        public Form_login_edit()
        {
            InitializeComponent();
        }

        private void LoginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.loginBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Form_login_edit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.chuck_TimeDataSet.Staff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.chuck_TimeDataSet.Customers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Login". При необходимости она может быть перемещена или удалена.
            this.loginTableAdapter.Fill(this.chuck_TimeDataSet.Login);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static Form_login_edit f;
        public static Form_login_edit fle
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Form_login_edit();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}
