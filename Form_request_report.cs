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
    public partial class Form_request_report : Form
    {
        public Form_request_report()
        {
            InitializeComponent();
        }

        private static Form_request_report f;
        public static Form_request_report frr
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Form_request_report();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void RequestsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requestsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);

        }

        private void Form_request_report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Vendor". При необходимости она может быть перемещена или удалена.
            this.vendorTableAdapter.Fill(this.chuck_TimeDataSet.Vendor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Materials". При необходимости она может быть перемещена или удалена.
            this.materialsTableAdapter.Fill(this.chuck_TimeDataSet.Materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.chuck_TimeDataSet.Requests);

        }

        private void Button_request_report_Click(object sender, EventArgs e)
        {
            // ГЕНЕРАТОР ОТЧЕТА
        }
    }
}
