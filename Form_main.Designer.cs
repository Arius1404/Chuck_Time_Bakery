namespace Chuck_Time_Bakery
{
    partial class Form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label title_GoodLabel;
            System.Windows.Forms.Label weightLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.statusStrip_main = new System.Windows.Forms.StatusStrip();
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автомобилиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дисконтныеКартыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыНаПоставкуСырьяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.персоналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сырьеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ифнормацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuck_TimeDataSet = new Chuck_Time_Bakery.Chuck_TimeDataSet();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.GoodsTableAdapter();
            this.tableAdapterManager = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.TableAdapterManager();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage_customer = new System.Windows.Forms.TabPage();
            this.panel_customer_main = new System.Windows.Forms.Panel();
            this.button_image = new System.Windows.Forms.Button();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.goodsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.title_GoodTextBox = new System.Windows.Forms.TextBox();
            this.tabPage_seller = new System.Windows.Forms.TabPage();
            this.button_discount_cards = new System.Windows.Forms.Button();
            this.button_goods = new System.Windows.Forms.Button();
            this.button_sales = new System.Windows.Forms.Button();
            this.tabPage_admin = new System.Windows.Forms.TabPage();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.генерацияОтчетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_discount_cards_adm = new System.Windows.Forms.Button();
            this.button_goods_adm = new System.Windows.Forms.Button();
            this.button_sales_adm = new System.Windows.Forms.Button();
            this.button_cars_adm = new System.Windows.Forms.Button();
            this.button_requests_adm = new System.Windows.Forms.Button();
            this.button_staff_adm = new System.Windows.Forms.Button();
            this.button_customers_adm = new System.Windows.Forms.Button();
            this.button_vendor_adm = new System.Windows.Forms.Button();
            this.button_recipes_adm = new System.Windows.Forms.Button();
            this.button_materials_adm = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.goodsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.toolStripSplitButton_change_user = new System.Windows.Forms.ToolStripSplitButton();
            this.редактироватьУчетнуюЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            descriptionLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            title_GoodLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            this.statusStrip_main.SuspendLayout();
            this.menuStrip_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chuck_TimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            this.tabControl_main.SuspendLayout();
            this.tabPage_customer.SuspendLayout();
            this.panel_customer_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingNavigator)).BeginInit();
            this.goodsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.tabPage_seller.SuspendLayout();
            this.tabPage_admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(17, 193);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(81, 19);
            descriptionLabel.TabIndex = 16;
            descriptionLabel.Text = "Описание:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            photoLabel.Location = new System.Drawing.Point(505, 14);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(109, 19);
            photoLabel.TabIndex = 20;
            photoLabel.Text = "Изображение:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceLabel.Location = new System.Drawing.Point(20, 156);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(92, 19);
            priceLabel.TabIndex = 12;
            priceLabel.Text = "Цена за ед.:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            quantityLabel.Location = new System.Drawing.Point(17, 116);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(98, 19);
            quantityLabel.TabIndex = 10;
            quantityLabel.Text = "Количество:";
            // 
            // title_GoodLabel
            // 
            title_GoodLabel.AutoSize = true;
            title_GoodLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title_GoodLabel.Location = new System.Drawing.Point(17, 47);
            title_GoodLabel.Name = "title_GoodLabel";
            title_GoodLabel.Size = new System.Drawing.Size(79, 19);
            title_GoodLabel.TabIndex = 6;
            title_GoodLabel.Text = "Название:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            weightLabel.Location = new System.Drawing.Point(20, 82);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(41, 19);
            weightLabel.TabIndex = 8;
            weightLabel.Text = "Вес:";
            // 
            // statusStrip_main
            // 
            this.statusStrip_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton_change_user});
            this.statusStrip_main.Location = new System.Drawing.Point(0, 432);
            this.statusStrip_main.Name = "statusStrip_main";
            this.statusStrip_main.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip_main.Size = new System.Drawing.Size(1072, 34);
            this.statusStrip_main.TabIndex = 5;
            this.statusStrip_main.Text = "statusStrip_main";
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.действияToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip_main.Size = new System.Drawing.Size(1072, 36);
            this.menuStrip_main.TabIndex = 4;
            this.menuStrip_main.Text = "menuStrip_main";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.автомобилиToolStripMenuItem,
            this.дисконтныеКартыToolStripMenuItem,
            this.запросыНаПоставкуСырьяToolStripMenuItem,
            this.персоналToolStripMenuItem,
            this.покупателиToolStripMenuItem,
            this.поставщикиToolStripMenuItem,
            this.продажиToolStripMenuItem,
            this.рецептыToolStripMenuItem,
            this.сырьеToolStripMenuItem,
            this.товарыToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(105, 32);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // автомобилиToolStripMenuItem
            // 
            this.автомобилиToolStripMenuItem.Name = "автомобилиToolStripMenuItem";
            this.автомобилиToolStripMenuItem.Size = new System.Drawing.Size(344, 32);
            this.автомобилиToolStripMenuItem.Text = "Автомобили";
            this.автомобилиToolStripMenuItem.Click += new System.EventHandler(this.Button_cars_adm_Click);
            // 
            // дисконтныеКартыToolStripMenuItem
            // 
            this.дисконтныеКартыToolStripMenuItem.Name = "дисконтныеКартыToolStripMenuItem";
            this.дисконтныеКартыToolStripMenuItem.Size = new System.Drawing.Size(344, 32);
            this.дисконтныеКартыToolStripMenuItem.Text = "Дисконтные карты";
            this.дисконтныеКартыToolStripMenuItem.Click += new System.EventHandler(this.Button_discount_cards_Click);
            // 
            // запросыНаПоставкуСырьяToolStripMenuItem
            // 
            this.запросыНаПоставкуСырьяToolStripMenuItem.Name = "запросыНаПоставкуСырьяToolStripMenuItem";
            this.запросыНаПоставкуСырьяToolStripMenuItem.Size = new System.Drawing.Size(344, 32);
            this.запросыНаПоставкуСырьяToolStripMenuItem.Text = "Запросы на поставку сырья";
            this.запросыНаПоставкуСырьяToolStripMenuItem.Click += new System.EventHandler(this.Button_requests_adm_Click);
            // 
            // персоналToolStripMenuItem
            // 
            this.персоналToolStripMenuItem.Name = "персоналToolStripMenuItem";
            this.персоналToolStripMenuItem.Size = new System.Drawing.Size(344, 32);
            this.персоналToolStripMenuItem.Text = "Персонал";
            this.персоналToolStripMenuItem.Click += new System.EventHandler(this.Button_staff_adm_Click);
            // 
            // покупателиToolStripMenuItem
            // 
            this.покупателиToolStripMenuItem.Name = "покупателиToolStripMenuItem";
            this.покупателиToolStripMenuItem.Size = new System.Drawing.Size(344, 32);
            this.покупателиToolStripMenuItem.Text = "Покупатели";
            this.покупателиToolStripMenuItem.Click += new System.EventHandler(this.Button_customers_adm_Click);
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(344, 32);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.Button_vendor_adm_Click);
            // 
            // продажиToolStripMenuItem
            // 
            this.продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
            this.продажиToolStripMenuItem.Size = new System.Drawing.Size(344, 32);
            this.продажиToolStripMenuItem.Text = "Продажи";
            this.продажиToolStripMenuItem.Click += new System.EventHandler(this.Button_sales_Click);
            // 
            // рецептыToolStripMenuItem
            // 
            this.рецептыToolStripMenuItem.Name = "рецептыToolStripMenuItem";
            this.рецептыToolStripMenuItem.Size = new System.Drawing.Size(344, 32);
            this.рецептыToolStripMenuItem.Text = "Рецепты";
            this.рецептыToolStripMenuItem.Click += new System.EventHandler(this.Button_recipes_adm_Click);
            // 
            // сырьеToolStripMenuItem
            // 
            this.сырьеToolStripMenuItem.Name = "сырьеToolStripMenuItem";
            this.сырьеToolStripMenuItem.Size = new System.Drawing.Size(344, 32);
            this.сырьеToolStripMenuItem.Text = "Сырье";
            this.сырьеToolStripMenuItem.Click += new System.EventHandler(this.Button_materials_adm_Click);
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(344, 32);
            this.товарыToolStripMenuItem.Text = "Товары";
            this.товарыToolStripMenuItem.Click += new System.EventHandler(this.Button_goods_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ифнормацияToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(148, 32);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // ифнормацияToolStripMenuItem
            // 
            this.ифнормацияToolStripMenuItem.Name = "ифнормацияToolStripMenuItem";
            this.ифнормацияToolStripMenuItem.Size = new System.Drawing.Size(213, 32);
            this.ифнормацияToolStripMenuItem.Text = "Информация";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(213, 32);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // chuck_TimeDataSet
            // 
            this.chuck_TimeDataSet.DataSetName = "Chuck_TimeDataSet";
            this.chuck_TimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "Goods";
            this.goodsBindingSource.DataSource = this.chuck_TimeDataSet;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.Discount_cardsTableAdapter = null;
            this.tableAdapterManager.GoodsTableAdapter = this.goodsTableAdapter;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.Recipes_MaterialsTableAdapter = null;
            this.tableAdapterManager.RecipesTableAdapter = null;
            this.tableAdapterManager.Request_MaterialsTableAdapter = null;
            this.tableAdapterManager.Requested_goodsTableAdapter = null;
            this.tableAdapterManager.RequestsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.Staff_SalesTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = null;
            this.tableAdapterManager.VendorTableAdapter = null;
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialog";
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage_customer);
            this.tabControl_main.Controls.Add(this.tabPage_seller);
            this.tabControl_main.Controls.Add(this.tabPage_admin);
            this.tabControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_main.Location = new System.Drawing.Point(0, 36);
            this.tabControl_main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(1072, 396);
            this.tabControl_main.TabIndex = 24;
            // 
            // tabPage_customer
            // 
            this.tabPage_customer.Controls.Add(this.panel_customer_main);
            this.tabPage_customer.Location = new System.Drawing.Point(4, 25);
            this.tabPage_customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_customer.Name = "tabPage_customer";
            this.tabPage_customer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_customer.Size = new System.Drawing.Size(1064, 367);
            this.tabPage_customer.TabIndex = 0;
            this.tabPage_customer.Text = "Ассортимент";
            this.tabPage_customer.UseVisualStyleBackColor = true;
            // 
            // panel_customer_main
            // 
            this.panel_customer_main.Controls.Add(this.button_image);
            this.panel_customer_main.Controls.Add(this.descriptionRichTextBox);
            this.panel_customer_main.Controls.Add(descriptionLabel);
            this.panel_customer_main.Controls.Add(photoLabel);
            this.panel_customer_main.Controls.Add(this.goodsBindingNavigator);
            this.panel_customer_main.Controls.Add(this.priceTextBox);
            this.panel_customer_main.Controls.Add(this.quantityNumericUpDown);
            this.panel_customer_main.Controls.Add(priceLabel);
            this.panel_customer_main.Controls.Add(this.photoPictureBox);
            this.panel_customer_main.Controls.Add(quantityLabel);
            this.panel_customer_main.Controls.Add(title_GoodLabel);
            this.panel_customer_main.Controls.Add(this.weightTextBox);
            this.panel_customer_main.Controls.Add(this.title_GoodTextBox);
            this.panel_customer_main.Controls.Add(weightLabel);
            this.panel_customer_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_customer_main.Location = new System.Drawing.Point(4, 4);
            this.panel_customer_main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_customer_main.Name = "panel_customer_main";
            this.panel_customer_main.Size = new System.Drawing.Size(1056, 359);
            this.panel_customer_main.TabIndex = 22;
            // 
            // button_image
            // 
            this.button_image.Location = new System.Drawing.Point(619, 7);
            this.button_image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_image.Name = "button_image";
            this.button_image.Size = new System.Drawing.Size(125, 28);
            this.button_image.TabIndex = 21;
            this.button_image.Text = "Обзор...";
            this.button_image.UseVisualStyleBackColor = true;
            this.button_image.Click += new System.EventHandler(this.Button_image_Click);
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "Description", true));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(125, 193);
            this.descriptionRichTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(287, 148);
            this.descriptionRichTextBox.TabIndex = 20;
            this.descriptionRichTextBox.Text = "";
            // 
            // goodsBindingNavigator
            // 
            this.goodsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.goodsBindingNavigator.BindingSource = this.goodsBindingSource;
            this.goodsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.goodsBindingNavigator.CountItemFormat = "из {0}";
            this.goodsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.goodsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.goodsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.goodsBindingNavigatorSaveItem});
            this.goodsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.goodsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.goodsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.goodsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.goodsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.goodsBindingNavigator.Name = "goodsBindingNavigator";
            this.goodsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.goodsBindingNavigator.Size = new System.Drawing.Size(1056, 27);
            this.goodsBindingNavigator.TabIndex = 6;
            this.goodsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(47, 24);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(49, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "Price", true));
            this.priceTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.Location = new System.Drawing.Point(125, 154);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(287, 27);
            this.priceTextBox.TabIndex = 13;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.goodsBindingSource, "Quantity", true));
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityNumericUpDown.Location = new System.Drawing.Point(125, 116);
            this.quantityNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(287, 27);
            this.quantityNumericUpDown.TabIndex = 19;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "Weight", true));
            this.weightTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightTextBox.Location = new System.Drawing.Point(125, 80);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(287, 27);
            this.weightTextBox.TabIndex = 9;
            // 
            // title_GoodTextBox
            // 
            this.title_GoodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "Title_Good", true));
            this.title_GoodTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_GoodTextBox.Location = new System.Drawing.Point(125, 44);
            this.title_GoodTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.title_GoodTextBox.Name = "title_GoodTextBox";
            this.title_GoodTextBox.Size = new System.Drawing.Size(287, 27);
            this.title_GoodTextBox.TabIndex = 7;
            // 
            // tabPage_seller
            // 
            this.tabPage_seller.Controls.Add(this.button_discount_cards);
            this.tabPage_seller.Controls.Add(this.button_goods);
            this.tabPage_seller.Controls.Add(this.button_sales);
            this.tabPage_seller.Location = new System.Drawing.Point(4, 25);
            this.tabPage_seller.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_seller.Name = "tabPage_seller";
            this.tabPage_seller.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_seller.Size = new System.Drawing.Size(1064, 367);
            this.tabPage_seller.TabIndex = 1;
            this.tabPage_seller.Text = "Начало работы";
            this.tabPage_seller.UseVisualStyleBackColor = true;
            // 
            // button_discount_cards
            // 
            this.button_discount_cards.Location = new System.Drawing.Point(700, 97);
            this.button_discount_cards.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_discount_cards.Name = "button_discount_cards";
            this.button_discount_cards.Size = new System.Drawing.Size(172, 151);
            this.button_discount_cards.TabIndex = 2;
            this.button_discount_cards.Text = "Скидочные карты";
            this.button_discount_cards.UseVisualStyleBackColor = true;
            this.button_discount_cards.Click += new System.EventHandler(this.Button_discount_cards_Click);
            // 
            // button_goods
            // 
            this.button_goods.Location = new System.Drawing.Point(163, 97);
            this.button_goods.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_goods.Name = "button_goods";
            this.button_goods.Size = new System.Drawing.Size(171, 151);
            this.button_goods.TabIndex = 1;
            this.button_goods.Text = "Ассортимент";
            this.button_goods.UseVisualStyleBackColor = true;
            this.button_goods.Click += new System.EventHandler(this.Button_goods_Click);
            // 
            // button_sales
            // 
            this.button_sales.Location = new System.Drawing.Point(433, 97);
            this.button_sales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_sales.Name = "button_sales";
            this.button_sales.Size = new System.Drawing.Size(171, 151);
            this.button_sales.TabIndex = 0;
            this.button_sales.Text = "Продажи";
            this.button_sales.UseVisualStyleBackColor = true;
            this.button_sales.Click += new System.EventHandler(this.Button_sales_Click);
            // 
            // tabPage_admin
            // 
            this.tabPage_admin.Controls.Add(this.button_materials_adm);
            this.tabPage_admin.Controls.Add(this.button_recipes_adm);
            this.tabPage_admin.Controls.Add(this.button_vendor_adm);
            this.tabPage_admin.Controls.Add(this.button_customers_adm);
            this.tabPage_admin.Controls.Add(this.button_staff_adm);
            this.tabPage_admin.Controls.Add(this.button_requests_adm);
            this.tabPage_admin.Controls.Add(this.button_cars_adm);
            this.tabPage_admin.Controls.Add(this.button_discount_cards_adm);
            this.tabPage_admin.Controls.Add(this.button_goods_adm);
            this.tabPage_admin.Controls.Add(this.button_sales_adm);
            this.tabPage_admin.Location = new System.Drawing.Point(4, 25);
            this.tabPage_admin.Name = "tabPage_admin";
            this.tabPage_admin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_admin.Size = new System.Drawing.Size(1064, 367);
            this.tabPage_admin.TabIndex = 2;
            this.tabPage_admin.Text = "Начало работы";
            this.tabPage_admin.UseVisualStyleBackColor = true;
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.генерацияОтчетаToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(110, 32);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // генерацияОтчетаToolStripMenuItem
            // 
            this.генерацияОтчетаToolStripMenuItem.Name = "генерацияОтчетаToolStripMenuItem";
            this.генерацияОтчетаToolStripMenuItem.Size = new System.Drawing.Size(251, 32);
            this.генерацияОтчетаToolStripMenuItem.Text = "Генерация отчета";
            // 
            // button_discount_cards_adm
            // 
            this.button_discount_cards_adm.Location = new System.Drawing.Point(252, 70);
            this.button_discount_cards_adm.Margin = new System.Windows.Forms.Padding(4);
            this.button_discount_cards_adm.Name = "button_discount_cards_adm";
            this.button_discount_cards_adm.Size = new System.Drawing.Size(140, 88);
            this.button_discount_cards_adm.TabIndex = 5;
            this.button_discount_cards_adm.Text = "Дисконтные карты";
            this.button_discount_cards_adm.UseVisualStyleBackColor = true;
            this.button_discount_cards_adm.Click += new System.EventHandler(this.Button_discount_cards_Click);
            // 
            // button_goods_adm
            // 
            this.button_goods_adm.Location = new System.Drawing.Point(847, 206);
            this.button_goods_adm.Margin = new System.Windows.Forms.Padding(4);
            this.button_goods_adm.Name = "button_goods_adm";
            this.button_goods_adm.Size = new System.Drawing.Size(140, 88);
            this.button_goods_adm.TabIndex = 4;
            this.button_goods_adm.Text = "Товары";
            this.button_goods_adm.UseVisualStyleBackColor = true;
            this.button_goods_adm.Click += new System.EventHandler(this.Button_goods_Click);
            // 
            // button_sales_adm
            // 
            this.button_sales_adm.Location = new System.Drawing.Point(252, 206);
            this.button_sales_adm.Margin = new System.Windows.Forms.Padding(4);
            this.button_sales_adm.Name = "button_sales_adm";
            this.button_sales_adm.Size = new System.Drawing.Size(140, 88);
            this.button_sales_adm.TabIndex = 3;
            this.button_sales_adm.Text = "Продажи";
            this.button_sales_adm.UseVisualStyleBackColor = true;
            this.button_sales_adm.Click += new System.EventHandler(this.Button_sales_Click);
            // 
            // button_cars_adm
            // 
            this.button_cars_adm.Location = new System.Drawing.Point(60, 70);
            this.button_cars_adm.Margin = new System.Windows.Forms.Padding(4);
            this.button_cars_adm.Name = "button_cars_adm";
            this.button_cars_adm.Size = new System.Drawing.Size(140, 88);
            this.button_cars_adm.TabIndex = 6;
            this.button_cars_adm.Text = "Автомобили";
            this.button_cars_adm.UseVisualStyleBackColor = true;
            this.button_cars_adm.Click += new System.EventHandler(this.Button_cars_adm_Click);
            // 
            // button_requests_adm
            // 
            this.button_requests_adm.Location = new System.Drawing.Point(446, 70);
            this.button_requests_adm.Margin = new System.Windows.Forms.Padding(4);
            this.button_requests_adm.Name = "button_requests_adm";
            this.button_requests_adm.Size = new System.Drawing.Size(140, 88);
            this.button_requests_adm.TabIndex = 7;
            this.button_requests_adm.Text = "Запросы на поставку сырья";
            this.button_requests_adm.UseVisualStyleBackColor = true;
            this.button_requests_adm.Click += new System.EventHandler(this.Button_requests_adm_Click);
            // 
            // button_staff_adm
            // 
            this.button_staff_adm.Location = new System.Drawing.Point(648, 70);
            this.button_staff_adm.Margin = new System.Windows.Forms.Padding(4);
            this.button_staff_adm.Name = "button_staff_adm";
            this.button_staff_adm.Size = new System.Drawing.Size(140, 88);
            this.button_staff_adm.TabIndex = 8;
            this.button_staff_adm.Text = "Персонал";
            this.button_staff_adm.UseVisualStyleBackColor = true;
            this.button_staff_adm.Click += new System.EventHandler(this.Button_staff_adm_Click);
            // 
            // button_customers_adm
            // 
            this.button_customers_adm.Location = new System.Drawing.Point(847, 70);
            this.button_customers_adm.Margin = new System.Windows.Forms.Padding(4);
            this.button_customers_adm.Name = "button_customers_adm";
            this.button_customers_adm.Size = new System.Drawing.Size(140, 88);
            this.button_customers_adm.TabIndex = 9;
            this.button_customers_adm.Text = "Покупатели";
            this.button_customers_adm.UseVisualStyleBackColor = true;
            this.button_customers_adm.Click += new System.EventHandler(this.Button_customers_adm_Click);
            // 
            // button_vendor_adm
            // 
            this.button_vendor_adm.Location = new System.Drawing.Point(60, 206);
            this.button_vendor_adm.Margin = new System.Windows.Forms.Padding(4);
            this.button_vendor_adm.Name = "button_vendor_adm";
            this.button_vendor_adm.Size = new System.Drawing.Size(140, 88);
            this.button_vendor_adm.TabIndex = 10;
            this.button_vendor_adm.Text = "Поставщики";
            this.button_vendor_adm.UseVisualStyleBackColor = true;
            this.button_vendor_adm.Click += new System.EventHandler(this.Button_vendor_adm_Click);
            // 
            // button_recipes_adm
            // 
            this.button_recipes_adm.Location = new System.Drawing.Point(446, 206);
            this.button_recipes_adm.Margin = new System.Windows.Forms.Padding(4);
            this.button_recipes_adm.Name = "button_recipes_adm";
            this.button_recipes_adm.Size = new System.Drawing.Size(140, 88);
            this.button_recipes_adm.TabIndex = 11;
            this.button_recipes_adm.Text = "Рецепты";
            this.button_recipes_adm.UseVisualStyleBackColor = true;
            this.button_recipes_adm.Click += new System.EventHandler(this.Button_recipes_adm_Click);
            // 
            // button_materials_adm
            // 
            this.button_materials_adm.Location = new System.Drawing.Point(648, 206);
            this.button_materials_adm.Margin = new System.Windows.Forms.Padding(4);
            this.button_materials_adm.Name = "button_materials_adm";
            this.button_materials_adm.Size = new System.Drawing.Size(140, 88);
            this.button_materials_adm.TabIndex = 12;
            this.button_materials_adm.Text = "Сырье";
            this.button_materials_adm.UseVisualStyleBackColor = true;
            this.button_materials_adm.Click += new System.EventHandler(this.Button_materials_adm_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // goodsBindingNavigatorSaveItem
            // 
            this.goodsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goodsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("goodsBindingNavigatorSaveItem.Image")));
            this.goodsBindingNavigatorSaveItem.Name = "goodsBindingNavigatorSaveItem";
            this.goodsBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.goodsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.goodsBindingNavigatorSaveItem.Click += new System.EventHandler(this.GoodsBindingNavigatorSaveItem_Click);
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.photoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.goodsBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(463, 47);
            this.photoPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(569, 295);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 15;
            this.photoPictureBox.TabStop = false;
            // 
            // toolStripSplitButton_change_user
            // 
            this.toolStripSplitButton_change_user.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton_change_user.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьУчетнуюЗаписьToolStripMenuItem,
            this.сменитьПользователяToolStripMenuItem});
            this.toolStripSplitButton_change_user.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripSplitButton_change_user.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton_change_user.Image")));
            this.toolStripSplitButton_change_user.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton_change_user.Name = "toolStripSplitButton_change_user";
            this.toolStripSplitButton_change_user.Size = new System.Drawing.Size(240, 32);
            this.toolStripSplitButton_change_user.Text = "Сменить пользователя";
            // 
            // редактироватьУчетнуюЗаписьToolStripMenuItem
            // 
            this.редактироватьУчетнуюЗаписьToolStripMenuItem.Name = "редактироватьУчетнуюЗаписьToolStripMenuItem";
            this.редактироватьУчетнуюЗаписьToolStripMenuItem.Size = new System.Drawing.Size(374, 32);
            this.редактироватьУчетнуюЗаписьToolStripMenuItem.Text = "Редактировать учетную запись";
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(374, 32);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.СменитьПользователяToolStripMenuItem_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 466);
            this.Controls.Add(this.tabControl_main);
            this.Controls.Add(this.statusStrip_main);
            this.Controls.Add(this.menuStrip_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пекарня \"ЧакТайм\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.statusStrip_main.ResumeLayout(false);
            this.statusStrip_main.PerformLayout();
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chuck_TimeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            this.tabControl_main.ResumeLayout(false);
            this.tabPage_customer.ResumeLayout(false);
            this.panel_customer_main.ResumeLayout(false);
            this.panel_customer_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingNavigator)).EndInit();
            this.goodsBindingNavigator.ResumeLayout(false);
            this.goodsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.tabPage_seller.ResumeLayout(false);
            this.tabPage_admin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip_main;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton_change_user;
        public System.Windows.Forms.ToolStripMenuItem редактироватьУчетнуюЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem дисконтныеКартыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem персоналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сырьеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ифнормацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private Chuck_TimeDataSet chuck_TimeDataSet;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private Chuck_TimeDataSetTableAdapters.GoodsTableAdapter goodsTableAdapter;
        private Chuck_TimeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
        public System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem покупателиToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem автомобилиToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem рецептыToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem запросыНаПоставкуСырьяToolStripMenuItem;
        public System.Windows.Forms.Panel panel_customer_main;
        private System.Windows.Forms.Button button_image;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.BindingNavigator goodsBindingNavigator;
        public System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton goodsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox title_GoodTextBox;
        public System.Windows.Forms.TabPage tabPage_seller;
        public System.Windows.Forms.TabControl tabControl_main;
        public System.Windows.Forms.TabPage tabPage_customer;
        private System.Windows.Forms.Button button_discount_cards;
        private System.Windows.Forms.Button button_goods;
        private System.Windows.Forms.Button button_sales;
        public System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem генерацияОтчетаToolStripMenuItem;
        public System.Windows.Forms.TabPage tabPage_admin;
        private System.Windows.Forms.Button button_discount_cards_adm;
        private System.Windows.Forms.Button button_goods_adm;
        private System.Windows.Forms.Button button_sales_adm;
        private System.Windows.Forms.Button button_vendor_adm;
        private System.Windows.Forms.Button button_customers_adm;
        private System.Windows.Forms.Button button_staff_adm;
        private System.Windows.Forms.Button button_requests_adm;
        private System.Windows.Forms.Button button_cars_adm;
        private System.Windows.Forms.Button button_materials_adm;
        private System.Windows.Forms.Button button_recipes_adm;
    }
}