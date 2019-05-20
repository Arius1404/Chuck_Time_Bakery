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
    public partial class Form_staff_sales : Form
    {
        public Form_staff_sales()
        {
            InitializeComponent();
        }

        private void Staff_SalesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.staff_SalesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form_staff_sales_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.chuck_TimeDataSet.Staff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Staff_Sales". При необходимости она может быть перемещена или удалена.
            this.staff_SalesTableAdapter.Fill(this.chuck_TimeDataSet.Staff_Sales);

        }

        private static Form_staff_sales f;
        public static Form_staff_sales fss
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Form_staff_sales();
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
