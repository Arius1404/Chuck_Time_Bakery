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
    public partial class Form_recipes_materials : Form
    {
        public Form_recipes_materials()
        {
            InitializeComponent();
        }

        private void Recipes_MaterialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.recipes_MaterialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);

        }

        private void Form_recipes_materials_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Materials". При необходимости она может быть перемещена или удалена.
            this.materialsTableAdapter.Fill(this.chuck_TimeDataSet.Materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Recipes". При необходимости она может быть перемещена или удалена.
            this.recipesTableAdapter.Fill(this.chuck_TimeDataSet.Recipes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Recipes_Materials". При необходимости она может быть перемещена или удалена.
            this.recipes_MaterialsTableAdapter.Fill(this.chuck_TimeDataSet.Recipes_Materials);

        }

        private void Title_RecipeComboBox_TextChanged(object sender, EventArgs e)
        {
            //ТУТ ЗАПРОС НА РЕЦЕПТ В ГРИД
        }

        private void Title_MaterialComboBox_TextChanged(object sender, EventArgs e)
        {
            //ТУТ ЗАПРОС НА МАТЕРИАЛ В ГРИД
        }


        private static Form_recipes_materials f;
        public static Form_recipes_materials frm
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Form_recipes_materials();
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
