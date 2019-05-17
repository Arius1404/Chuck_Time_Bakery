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
    public partial class Form_requested_goods : Form
    {
        public Form_requested_goods()
        {
            InitializeComponent();
        }

        private void Requested_goodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requested_goodsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);

        }

        private void Form_requested_goods_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.chuck_TimeDataSet.Goods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Requested_goods". При необходимости она может быть перемещена или удалена.
            this.requested_goodsTableAdapter.Fill(this.chuck_TimeDataSet.Requested_goods);

        }



        private static Form_requested_goods f;
        public static Form_requested_goods frg
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Form_requested_goods();
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
