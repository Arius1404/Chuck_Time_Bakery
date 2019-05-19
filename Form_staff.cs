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
    public partial class Form_staff : Form
    {
        public Form_staff()
        {
            InitializeComponent();
        }

        private static Form_staff f;
        public static Form_staff fs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Form_staff();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void StaffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);

        }

        private void Form_staff_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.chuck_TimeDataSet.Staff);
            if (Form_main.status == "Администратор")
            {
                bindingNavigatorDeleteItem.Visible = false;
                bindingNavigatorAddNewItem.Visible = false;
                staffBindingNavigatorSaveItem.Visible = false;
                staffDataGridView.ReadOnly = true;
            }
        }

        private void ПоказатьРецептыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_recipes.fr.ShowForm();
        }
    }
}
