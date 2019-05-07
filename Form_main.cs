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

        public string status;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.chuck_TimeDataSet.Goods);
            prog_exit = 1;
            toolStripSplitButton_change_user.Text = status;
            if (status == "Вы вошли как гость!")//покупатель
            {
                title_GoodTextBox.ReadOnly = true;
                weightTextBox.ReadOnly = true;
                quantityNumericUpDown.ReadOnly = true;
                priceTextBox.ReadOnly = true;
                descriptionRichTextBox.ReadOnly = true;

                таблицыToolStripMenuItem.Visible = false;
                goodsBindingNavigatorSaveItem.Visible = false;
                bindingNavigatorAddNewItem.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;
                button_image.Visible = false;
                tabControl_main.TabPages.Remove(tabPage_seller);
                tabControl_main.TabPages.Remove(tabPage_admin);
            }
            else
                if (status == "Продавец-кассир") // продавец-кассир
            {
                покупателиToolStripMenuItem.Visible = false;
                автомобилиToolStripMenuItem.Visible = false;
                рецептыToolStripMenuItem.Visible = false;
                поставщикиToolStripMenuItem.Visible = false;
                запросыНаПоставкуСырьяToolStripMenuItem.Visible = false;
                сырьеToolStripMenuItem.Visible = false;
                tabControl_main.TabPages.Remove(tabPage_customer);
                tabControl_main.TabPages.Remove(tabPage_admin);

            }
            else
                if (status == "Администратор") // админ
            {                
                tabControl_main.TabPages.Remove(tabPage_customer);
                tabControl_main.TabPages.Remove(tabPage_seller);
            }
        }

        private void Button_sales_Click(object sender, EventArgs e)
        {
            Form_Seller.fs.Show();
        }

        private void Button_discount_cards_Click(object sender, EventArgs e)
        {
            Form_discount_cards.fdc.Show();
        }

        private void Button_goods_Click(object sender, EventArgs e)
        {
            Form_goods.fg.Show();
        }

        private void ТаблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
