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
    public partial class Form_discount_cards : Form
    {
        public Form_discount_cards()
        {
            InitializeComponent();
        }

        private static Form_discount_cards f;
        public static Form_discount_cards fdc
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Form_discount_cards();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void Discount_cardsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.discount_cardsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);

        }

        private void Form_discount_cards_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.chuck_TimeDataSet.Customers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Discount_cards". При необходимости она может быть перемещена или удалена.
            this.discount_cardsTableAdapter.Fill(this.chuck_TimeDataSet.Discount_cards);
            if (Form_main.status == "Продавец-кассир")
                bindingNavigatorDeleteItem.Visible = false;
            else if (Form_main.status == "Доставщик")
            {
                bindingNavigatorDeleteItem.Visible = false;
                bindingNavigatorAddNewItem.Visible = false;
                discount_cardsBindingNavigatorSaveItem.Visible = false;
                discount_cardsDataGridView.ReadOnly = true;
            }
        }
    }

    
}
