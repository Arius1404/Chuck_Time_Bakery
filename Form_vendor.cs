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
    public partial class Form_vendor : Form
    {
        public Form_vendor()
        {
            InitializeComponent();
        }

        private static Form_vendor f;
        public static Form_vendor fv
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Form_vendor();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void VendorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);

        }

        private void Form_vendor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Vendor". При необходимости она может быть перемещена или удалена.
            this.vendorTableAdapter.Fill(this.chuck_TimeDataSet.Vendor);

        }
    }
}
