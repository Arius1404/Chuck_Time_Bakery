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
    public partial class Form_goods : Form
    {
        public Form_goods()
        {
            InitializeComponent();
        }

        private static Form_goods f;
        public static Form_goods fg
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Form_goods();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void GoodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.goodsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);

        }

        private void Form_goods_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.chuck_TimeDataSet.Goods);

        }

        private void СоставИзделийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_recipes_materials.frm.ShowForm();
        }
    }
}
