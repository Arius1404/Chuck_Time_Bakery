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
    public partial class Form_materials : Form
    {
        public Form_materials()
        {
            InitializeComponent();
        }

        private static Form_materials f;
        public static Form_materials fm
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Form_materials();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void MaterialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.materialsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void Form_materials_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Materials". При необходимости она может быть перемещена или удалена.
            this.materialsTableAdapter.Fill(this.chuck_TimeDataSet.Materials);
            if (Form_main.status == "Пекарь")
            {
                bindingNavigatorDeleteItem.Visible = false;
                bindingNavigatorAddNewItem.Visible = false;
                materialsBindingNavigatorSaveItem.Visible = false;
                materialsDataGridView.ReadOnly = true;
            }
        }
    }
}
