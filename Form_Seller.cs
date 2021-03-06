﻿using System;
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
    public partial class Form_seller : Form
    {
        public Form_seller()
        {
            InitializeComponent();
        }

        private void SalesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.salesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void Form_Seller_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Vehicles". При необходимости она может быть перемещена или удалена.
            this.vehiclesTableAdapter.Fill(this.chuck_TimeDataSet.Vehicles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.chuck_TimeDataSet.Customers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.chuck_TimeDataSet.Sales);
            if (Form_main.status == "Продавец-кассир")
            {
                bindingNavigatorDeleteItem.Visible = false;
                contextMenuStrip_seller.Visible = false;
                созданиеОтчетаToolStripMenuItem.Visible = false;
                ToolStripMenuItem_staff_sales.Visible = false;
            }
        }

        private static Form_seller f;
        public static Form_seller fs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Form_seller();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void ToolStripMenuItem_info_Click(object sender, EventArgs e)
        {
            Form_requested_goods.frg.ShowForm();
        }

        private void ToolStripMenuItem_staff_sales_Click(object sender, EventArgs e)
        {
            Form_staff_sales.fss.ShowForm();
        }

        private void СозданиеОтчетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_sales_report.fsr.ShowForm();
        }


    }
}
