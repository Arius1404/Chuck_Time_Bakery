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
    public partial class Form_customers : Form
    {
        public Form_customers()
        {
            InitializeComponent();
        }

        private static Form_customers f;
        public static Form_customers fc
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Form_customers();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void CustomersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);

        }

        private void Form_customers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Discount_cards". При необходимости она может быть перемещена или удалена.
            this.discount_cardsTableAdapter.Fill(this.chuck_TimeDataSet.Discount_cards);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.chuck_TimeDataSet.Customers);
            if (Form_main.status == "Доставщик")
            {
                bindingNavigatorDeleteItem.Visible = false;
                bindingNavigatorAddNewItem.Visible = false;
                customersBindingNavigatorSaveItem.Visible = false;
                customersDataGridView.ReadOnly = true;
            }
        }

        private void СписокКартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_discount_cards.fdc.ShowForm();
        }
    }
}
