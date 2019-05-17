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
    public partial class Form_request_materials : Form
    {
        public Form_request_materials()
        {
            InitializeComponent();
        }

        private void Request_MaterialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.request_MaterialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);

        }

        private void Form_request_materials_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.chuck_TimeDataSet.Requests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Materials". При необходимости она может быть перемещена или удалена.
            this.materialsTableAdapter.Fill(this.chuck_TimeDataSet.Materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Request_Materials". При необходимости она может быть перемещена или удалена.
            this.request_MaterialsTableAdapter.Fill(this.chuck_TimeDataSet.Request_Materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Materials". При необходимости она может быть перемещена или удалена.
            this.materialsTableAdapter.Fill(this.chuck_TimeDataSet.Materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.chuck_TimeDataSet.Requests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Request_Materials". При необходимости она может быть перемещена или удалена.
            this.request_MaterialsTableAdapter.Fill(this.chuck_TimeDataSet.Request_Materials);

        }

        private static Form_request_materials f;
        public static Form_request_materials frm
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Form_request_materials();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void Request_MaterialsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.request_MaterialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);

        }
    }
}
