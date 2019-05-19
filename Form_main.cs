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
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        public static string status;
        public int prog_exit;

        private static Form_main f;
        public static Form_main fm
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Form_main();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void СменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prog_exit = 0;
            Application.Restart();           
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (prog_exit != 0)
                    Environment.Exit(0);
            }
            else               
                e.Cancel = true;
        }

        string fileImage = "";

        private void Button_image_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.Title = "Укажите файл для фото";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPhoto.FileName;
                try
                {
                    photoPictureBox.Image = new Bitmap(openFileDialogPhoto.FileName);
                }
                catch
                {
                    MessageBox.Show("Выбран не тот формат файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else fileImage = "";
        }

        private void GoodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.goodsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);

        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.chuck_TimeDataSet.Staff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Recipes". При необходимости она может быть перемещена или удалена.
            this.recipesTableAdapter.Fill(this.chuck_TimeDataSet.Recipes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.chuck_TimeDataSet.Goods);
            prog_exit = 1;
            toolStripSplitButton_change_user.Text = status;
            if (status == "Вы вошли как гость!")//покупатель
            {
                title_GoodTextBox.ReadOnly = true;
                weightTextBox.ReadOnly = true;
                priceTextBox.ReadOnly = true;
                descriptionRichTextBox.ReadOnly = true;

                таблицыToolStripMenuItem.Visible = false;
                goodsBindingNavigatorSaveItem.Visible = false;
                bindingNavigatorAddNewItem.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;
                button_image.Visible = false;
                tabControl_main.TabPages.Remove(tabPage_seller);
                tabControl_main.TabPages.Remove(tabPage_admin);
                tabControl_main.TabPages.Remove(tabPage_cook);
                tabControl_main.TabPages.Remove(tabPage_delivery);
                tabControl_main.TabPages.Remove(tabPage_director);
                tabControl_main.TabPages.Remove(tabPage_hr);
                tabControl_main.TabPages.Remove(tabPage_tech);
            }
            else
                if (status == "Директор") // админ
            {
                tabControl_main.TabPages.Remove(tabPage_seller);
                tabControl_main.TabPages.Remove(tabPage_admin);
                tabControl_main.TabPages.Remove(tabPage_cook);
                tabControl_main.TabPages.Remove(tabPage_delivery);
                tabControl_main.TabPages.Remove(tabPage_hr);
                tabControl_main.TabPages.Remove(tabPage_tech);
                tabControl_main.TabPages.Remove(tabPage_customer);
            }
            else
                if (status == "Администратор") // админ
            {
                рецептыToolStripMenuItem.Visible = false;
                tabControl_main.TabPages.Remove(tabPage_customer);
                tabControl_main.TabPages.Remove(tabPage_seller);
                tabControl_main.TabPages.Remove(tabPage_cook);
                tabControl_main.TabPages.Remove(tabPage_delivery);
                tabControl_main.TabPages.Remove(tabPage_director);
                tabControl_main.TabPages.Remove(tabPage_hr);
                tabControl_main.TabPages.Remove(tabPage_tech);
            }
            else
                if (status == "Покупатель") // админ
            {
                title_GoodTextBox.ReadOnly = true;
                weightTextBox.ReadOnly = true;
                priceTextBox.ReadOnly = true;
                descriptionRichTextBox.ReadOnly = true;

                таблицыToolStripMenuItem.Visible = false;
                goodsBindingNavigatorSaveItem.Visible = false;
                bindingNavigatorAddNewItem.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;
                button_image.Visible = false;
                tabControl_main.TabPages.Remove(tabPage_seller);
                tabControl_main.TabPages.Remove(tabPage_cook);
                tabControl_main.TabPages.Remove(tabPage_delivery);
                tabControl_main.TabPages.Remove(tabPage_director);
                tabControl_main.TabPages.Remove(tabPage_hr);
                tabControl_main.TabPages.Remove(tabPage_tech);
                tabControl_main.TabPages.Remove(tabPage_admin);
            }
            else
                if (status == "Технолог") // админ
            {
                автомобилиToolStripMenuItem.Visible = false;
                дисконтныеКартыToolStripMenuItem.Visible = false;
                продажиToolStripMenuItem.Visible = false;
                запросыНаПоставкуСырьяToolStripMenuItem.Visible = false;
                персоналToolStripMenuItem.Visible = false;
                покупателиToolStripMenuItem.Visible = false;
                поставщикиToolStripMenuItem.Visible = false;
                рецептыToolStripMenuItem.Visible = false;

                tabControl_main.TabPages.Remove(tabPage_customer);
                tabControl_main.TabPages.Remove(tabPage_seller);
                tabControl_main.TabPages.Remove(tabPage_cook);
                tabControl_main.TabPages.Remove(tabPage_delivery);
                tabControl_main.TabPages.Remove(tabPage_director);
                tabControl_main.TabPages.Remove(tabPage_hr);
                tabControl_main.TabPages.Remove(tabPage_admin);
            }
            else
                if (status == "Доставщик") // админ
            {
                дисконтныеКартыToolStripMenuItem.Visible = true;
                покупателиToolStripMenuItem.Visible = true;

                продажиToolStripMenuItem.Visible = false;
                автомобилиToolStripMenuItem.Visible = false;
                продажиToolStripMenuItem.Visible = false;
                персоналToolStripMenuItem.Visible = false;
                запросыНаПоставкуСырьяToolStripMenuItem.Visible = false;
                поставщикиToolStripMenuItem.Visible = false;
                рецептыToolStripMenuItem.Visible = false;
                сырьеToolStripMenuItem.Visible = false;
                товарыToolStripMenuItem.Visible = false;
                
                tabControl_main.TabPages.Remove(tabPage_customer);
                tabControl_main.TabPages.Remove(tabPage_seller);
                tabControl_main.TabPages.Remove(tabPage_cook);
                tabControl_main.TabPages.Remove(tabPage_director);
                tabControl_main.TabPages.Remove(tabPage_hr);
                tabControl_main.TabPages.Remove(tabPage_admin);
                tabControl_main.TabPages.Remove(tabPage_tech);
            }
            else
                if (status == "Пекарь") // админ
            {
                дисконтныеКартыToolStripMenuItem.Visible = false;
                покупателиToolStripMenuItem.Visible = false;
                продажиToolStripMenuItem.Visible = false;
                автомобилиToolStripMenuItem.Visible = false;
                продажиToolStripMenuItem.Visible = false;
                персоналToolStripMenuItem.Visible = false;
                запросыНаПоставкуСырьяToolStripMenuItem.Visible = false;
                поставщикиToolStripMenuItem.Visible = false;

                рецептыToolStripMenuItem.Visible = true;
                сырьеToolStripMenuItem.Visible = true;
                товарыToolStripMenuItem.Visible = true;

                tabControl_main.TabPages.Remove(tabPage_customer);
                tabControl_main.TabPages.Remove(tabPage_seller);
                tabControl_main.TabPages.Remove(tabPage_director);
                tabControl_main.TabPages.Remove(tabPage_hr);
                tabControl_main.TabPages.Remove(tabPage_admin);
                tabControl_main.TabPages.Remove(tabPage_tech);
                tabControl_main.TabPages.Remove(tabPage_delivery);
            }
            else
                if (status == "Продавец-кассир") // продавец-кассир
            {
                дисконтныеКартыToolStripMenuItem.Visible = true;//
                покупателиToolStripMenuItem.Visible = false;
                продажиToolStripMenuItem.Visible = false;
                автомобилиToolStripMenuItem.Visible = false;
                продажиToolStripMenuItem.Visible = true;//
                персоналToolStripMenuItem.Visible = false;
                запросыНаПоставкуСырьяToolStripMenuItem.Visible = false;
                поставщикиToolStripMenuItem.Visible = false;
                рецептыToolStripMenuItem.Visible = false;
                сырьеToolStripMenuItem.Visible = false;
                товарыToolStripMenuItem.Visible = true;//

                tabControl_main.TabPages.Remove(tabPage_customer);
                tabControl_main.TabPages.Remove(tabPage_director);
                tabControl_main.TabPages.Remove(tabPage_hr);
                tabControl_main.TabPages.Remove(tabPage_admin);
                tabControl_main.TabPages.Remove(tabPage_tech);
                tabControl_main.TabPages.Remove(tabPage_delivery);
                tabControl_main.TabPages.Remove(tabPage_cook);
            }                     
            else
                if (status == "Кадровый отдел") // админ
            {
                таблицыToolStripMenuItem.Visible = false;
                tabControl_main.TabPages.Remove(tabPage_customer);
                tabControl_main.TabPages.Remove(tabPage_seller);
                tabControl_main.TabPages.Remove(tabPage_admin);
                tabControl_main.TabPages.Remove(tabPage_tech);
                tabControl_main.TabPages.Remove(tabPage_delivery);
                tabControl_main.TabPages.Remove(tabPage_cook);
                tabControl_main.TabPages.Remove(tabPage_director);
            }
        }

        private void Button_sales_Click(object sender, EventArgs e)
        {
            Form_seller.fs.Show();
        }

        private void Button_discount_cards_Click(object sender, EventArgs e)
        {
            Form_discount_cards.fdc.Show();
        }

        private void Button_goods_Click(object sender, EventArgs e)
        {
            Form_goods.fg.Show();
        }

        private void Button_cars_adm_Click(object sender, EventArgs e)
        {
            Form_cars.fc.Show();
        }

        private void Button_requests_adm_Click(object sender, EventArgs e)
        {
            Form_requests.fr.Show();
        }

        private void Button_staff_adm_Click(object sender, EventArgs e)
        {
            Form_staff.fs.Show();
        }

        private void Button_customers_adm_Click(object sender, EventArgs e)
        {
            Form_customers.fc.Show();
        }

        private void Button_vendor_adm_Click(object sender, EventArgs e)
        {
            Form_vendor.fv.Show();
        }

        private void Button_recipes_adm_Click(object sender, EventArgs e)
        {
            Form_recipes.fr.Show();
        }

        private void Button_materials_adm_Click(object sender, EventArgs e)
        {
            Form_materials.fm.Show();
        }

        private void РедактироватьУчетнуюЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_login_edit.fle.ShowForm();
        }

        private void ToolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.recipesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);
        }

        private void ToolStripButton14_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);
        }

        private void ToolStripMenuItem_materials_Click(object sender, EventArgs e)
        {
            Form_recipes_materials.frm.ShowForm();
        }

        private void ИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данный проект выполнен учащимися гр. 716 в качестве КР по БСБД\nDevelopers: Тахтеев Илья\nСеменков Алексей", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
