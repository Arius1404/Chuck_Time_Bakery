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
            System.Windows.Forms.Label title_GoodLabel;
            System.Windows.Forms.Label weightLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.statusStrip_main = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton_change_user = new System.Windows.Forms.ToolStripSplitButton();
            this.редактироватьУчетнуюЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автомобилиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дисконтныеКартыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыНаПоставкуСырьяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.персоналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сырьеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuck_TimeDataSet = new Chuck_Time_Bakery.Chuck_TimeDataSet();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.GoodsTableAdapter();
            this.tableAdapterManager = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.TableAdapterManager();
            this.recipesTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.RecipesTableAdapter();
            this.staffTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.StaffTableAdapter();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage_director = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_materials_dir = new System.Windows.Forms.Button();
            this.button_recipes_dir = new System.Windows.Forms.Button();
            this.button_vendors_dir = new System.Windows.Forms.Button();
            this.button_cutomers_dir = new System.Windows.Forms.Button();
            this.button_staff_dir = new System.Windows.Forms.Button();
            this.button_requests_dir = new System.Windows.Forms.Button();
            this.button_vehicles_dir = new System.Windows.Forms.Button();
            this.button_disk_cards_dir = new System.Windows.Forms.Button();
            this.button_goods_dir = new System.Windows.Forms.Button();
            this.button_orders_dir = new System.Windows.Forms.Button();
            this.tabPage_admin = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_materials_adm = new System.Windows.Forms.Button();
            this.button_vendor_adm = new System.Windows.Forms.Button();
            this.button_customers_adm = new System.Windows.Forms.Button();
            this.button_staff_adm = new System.Windows.Forms.Button();
            this.button_requests_adm = new System.Windows.Forms.Button();
            this.button_cars_adm = new System.Windows.Forms.Button();
            this.button_discount_cards_adm = new System.Windows.Forms.Button();
            this.button_goods_adm = new System.Windows.Forms.Button();
            this.button_sales_adm = new System.Windows.Forms.Button();
            this.tabPage_customer = new System.Windows.Forms.TabPage();
            this.panel_customer_main = new System.Windows.Forms.Panel();
            this.button_image = new System.Windows.Forms.Button();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.goodsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.goodsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.title_GoodTextBox = new System.Windows.Forms.TextBox();
            this.tabPage_tech = new System.Windows.Forms.TabPage();
            this.bindingNavigator_recipes = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.recipesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip_recipes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_materials = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_delivery = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button_customers = new System.Windows.Forms.Button();
            this.button_disc_cards_delivery = new System.Windows.Forms.Button();
            this.tabPage_cook = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button_materials_cook = new System.Windows.Forms.Button();
            this.button_recipes_cook = new System.Windows.Forms.Button();
            this.button_goods_cook = new System.Windows.Forms.Button();
            this.tabPage_seller = new System.Windows.Forms.TabPage();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.button_discount_cards = new System.Windows.Forms.Button();
            this.button_goods = new System.Windows.Forms.Button();
            this.button_sales = new System.Windows.Forms.Button();
            this.tabPage_hr = new System.Windows.Forms.TabPage();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descriptionLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            title_GoodLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            this.statusStrip_main.SuspendLayout();
            this.menuStrip_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chuck_TimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            this.tabControl_main.SuspendLayout();
            this.tabPage_director.SuspendLayout();
            this.tabPage_admin.SuspendLayout();
            this.tabPage_customer.SuspendLayout();
            this.panel_customer_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingNavigator)).BeginInit();
            this.goodsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.tabPage_tech.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_recipes)).BeginInit();
            this.bindingNavigator_recipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.contextMenuStrip_recipes.SuspendLayout();
            this.tabPage_delivery.SuspendLayout();
            this.tabPage_cook.SuspendLayout();
            this.tabPage_seller.SuspendLayout();
            this.tabPage_hr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(346, 39);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(68, 16);
            descriptionLabel.TabIndex = 16;
            descriptionLabel.Text = "Описание:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            photoLabel.Location = new System.Drawing.Point(195, 138);
            photoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(89, 16);
            photoLabel.TabIndex = 20;
            photoLabel.Text = "Изображение:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceLabel.Location = new System.Drawing.Point(15, 98);
            priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(76, 16);
            priceLabel.TabIndex = 12;
            priceLabel.Text = "Цена за ед.:";
            // 
            // title_GoodLabel
            // 
            title_GoodLabel.AutoSize = true;
            title_GoodLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title_GoodLabel.Location = new System.Drawing.Point(13, 38);
            title_GoodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            title_GoodLabel.Name = "title_GoodLabel";
            title_GoodLabel.Size = new System.Drawing.Size(65, 16);
            title_GoodLabel.TabIndex = 6;
            title_GoodLabel.Text = "Название:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            weightLabel.Location = new System.Drawing.Point(15, 67);
            weightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(32, 16);
            weightLabel.TabIndex = 8;
            weightLabel.Text = "Вес:";
            // 
            // statusStrip_main
            // 
            this.statusStrip_main.BackColor = System.Drawing.Color.PeachPuff;
            this.statusStrip_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton_change_user});
            this.statusStrip_main.Location = new System.Drawing.Point(0, 481);
            this.statusStrip_main.Name = "statusStrip_main";
            this.statusStrip_main.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip_main.Size = new System.Drawing.Size(782, 27);
            this.statusStrip_main.TabIndex = 5;
            this.statusStrip_main.Text = "statusStrip_main";
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
            this.toolStripSplitButton_change_user.Size = new System.Drawing.Size(189, 25);
            this.toolStripSplitButton_change_user.Text = "Сменить пользователя";
            // 
            // редактироватьУчетнуюЗаписьToolStripMenuItem
            // 
            this.редактироватьУчетнуюЗаписьToolStripMenuItem.Name = "редактироватьУчетнуюЗаписьToolStripMenuItem";
            this.редактироватьУчетнуюЗаписьToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.редактироватьУчетнуюЗаписьToolStripMenuItem.Text = "Редактировать учетную запись";
            this.редактироватьУчетнуюЗаписьToolStripMenuItem.Click += new System.EventHandler(this.РедактироватьУчетнуюЗаписьToolStripMenuItem_Click);
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.СменитьПользователяToolStripMenuItem_Click);
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.BackColor = System.Drawing.Color.PeachPuff;
            this.menuStrip_main.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip_main.Size = new System.Drawing.Size(782, 29);
            this.menuStrip_main.TabIndex = 4;
            this.menuStrip_main.Text = "menuStrip_main";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.автомобилиToolStripMenuItem,
            this.дисконтныеКартыToolStripMenuItem,
            this.продажиToolStripMenuItem,
            this.запросыНаПоставкуСырьяToolStripMenuItem,
            this.персоналToolStripMenuItem,
            this.покупателиToolStripMenuItem,
            this.поставщикиToolStripMenuItem,
            this.рецептыToolStripMenuItem,
            this.сырьеToolStripMenuItem,
            this.товарыToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // автомобилиToolStripMenuItem
            // 
            this.автомобилиToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.автомобилиToolStripMenuItem.Image = global::Chuck_Time_Bakery.Properties.Resources.Cars_img;
            this.автомобилиToolStripMenuItem.Name = "автомобилиToolStripMenuItem";
            this.автомобилиToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.автомобилиToolStripMenuItem.Text = "Автомобили";
            this.автомобилиToolStripMenuItem.Click += new System.EventHandler(this.Button_cars_adm_Click);
            // 
            // дисконтныеКартыToolStripMenuItem
            // 
            this.дисконтныеКартыToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.дисконтныеКартыToolStripMenuItem.Image = global::Chuck_Time_Bakery.Properties.Resources.Discount_cards_img;
            this.дисконтныеКартыToolStripMenuItem.Name = "дисконтныеКартыToolStripMenuItem";
            this.дисконтныеКартыToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.дисконтныеКартыToolStripMenuItem.Text = "Дисконтные карты";
            this.дисконтныеКартыToolStripMenuItem.Click += new System.EventHandler(this.Button_discount_cards_Click);
            // 
            // продажиToolStripMenuItem
            // 
            this.продажиToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.продажиToolStripMenuItem.Image = global::Chuck_Time_Bakery.Properties.Resources.Orders_img;
            this.продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
            this.продажиToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.продажиToolStripMenuItem.Text = "Заказы";
            this.продажиToolStripMenuItem.Click += new System.EventHandler(this.Button_sales_Click);
            // 
            // запросыНаПоставкуСырьяToolStripMenuItem
            // 
            this.запросыНаПоставкуСырьяToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.запросыНаПоставкуСырьяToolStripMenuItem.Image = global::Chuck_Time_Bakery.Properties.Resources.Vendor_img;
            this.запросыНаПоставкуСырьяToolStripMenuItem.Name = "запросыНаПоставкуСырьяToolStripMenuItem";
            this.запросыНаПоставкуСырьяToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.запросыНаПоставкуСырьяToolStripMenuItem.Text = "Запросы на поставку сырья";
            this.запросыНаПоставкуСырьяToolStripMenuItem.Click += new System.EventHandler(this.Button_requests_adm_Click);
            // 
            // персоналToolStripMenuItem
            // 
            this.персоналToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.персоналToolStripMenuItem.Image = global::Chuck_Time_Bakery.Properties.Resources.Staff_img;
            this.персоналToolStripMenuItem.Name = "персоналToolStripMenuItem";
            this.персоналToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.персоналToolStripMenuItem.Text = "Персонал";
            this.персоналToolStripMenuItem.Click += new System.EventHandler(this.Button_staff_adm_Click);
            // 
            // покупателиToolStripMenuItem
            // 
            this.покупателиToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.покупателиToolStripMenuItem.Image = global::Chuck_Time_Bakery.Properties.Resources.Customers_img;
            this.покупателиToolStripMenuItem.Name = "покупателиToolStripMenuItem";
            this.покупателиToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.покупателиToolStripMenuItem.Text = "Покупатели";
            this.покупателиToolStripMenuItem.Click += new System.EventHandler(this.Button_customers_adm_Click);
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.поставщикиToolStripMenuItem.Image = global::Chuck_Time_Bakery.Properties.Resources.Vendor_list_img;
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.Button_vendor_adm_Click);
            // 
            // рецептыToolStripMenuItem
            // 
            this.рецептыToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.рецептыToolStripMenuItem.Image = global::Chuck_Time_Bakery.Properties.Resources.Receipe_img;
            this.рецептыToolStripMenuItem.Name = "рецептыToolStripMenuItem";
            this.рецептыToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.рецептыToolStripMenuItem.Text = "Рецепты";
            this.рецептыToolStripMenuItem.Click += new System.EventHandler(this.Button_recipes_adm_Click);
            // 
            // сырьеToolStripMenuItem
            // 
            this.сырьеToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.сырьеToolStripMenuItem.Image = global::Chuck_Time_Bakery.Properties.Resources.Raw_img;
            this.сырьеToolStripMenuItem.Name = "сырьеToolStripMenuItem";
            this.сырьеToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.сырьеToolStripMenuItem.Text = "Сырье";
            this.сырьеToolStripMenuItem.Click += new System.EventHandler(this.Button_materials_adm_Click);
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.товарыToolStripMenuItem.Image = global::Chuck_Time_Bakery.Properties.Resources.Goods_img;
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.товарыToolStripMenuItem.Text = "Товары";
            this.товарыToolStripMenuItem.Click += new System.EventHandler(this.Button_goods_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 25);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.информацияToolStripMenuItem.Image = global::Chuck_Time_Bakery.Properties.Resources.Info;
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.информацияToolStripMenuItem.Text = "Информация";
            this.информацияToolStripMenuItem.Click += new System.EventHandler(this.ИнформацияToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.помощьToolStripMenuItem.Image = global::Chuck_Time_Bakery.Properties.Resources.Help_img;
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.ПомощьToolStripMenuItem_Click);
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
            this.tableAdapterManager.RecipesTableAdapter = this.recipesTableAdapter;
            this.tableAdapterManager.Request_MaterialsTableAdapter = null;
            this.tableAdapterManager.Requested_goodsTableAdapter = null;
            this.tableAdapterManager.RequestsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.Staff_SalesTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.UpdateOrder = Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = null;
            this.tableAdapterManager.VendorTableAdapter = null;
            // 
            // recipesTableAdapter
            // 
            this.recipesTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialog";
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage_director);
            this.tabControl_main.Controls.Add(this.tabPage_admin);
            this.tabControl_main.Controls.Add(this.tabPage_customer);
            this.tabControl_main.Controls.Add(this.tabPage_tech);
            this.tabControl_main.Controls.Add(this.tabPage_delivery);
            this.tabControl_main.Controls.Add(this.tabPage_cook);
            this.tabControl_main.Controls.Add(this.tabPage_seller);
            this.tabControl_main.Controls.Add(this.tabPage_hr);
            this.tabControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_main.Location = new System.Drawing.Point(0, 29);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(782, 452);
            this.tabControl_main.TabIndex = 24;
            // 
            // tabPage_director
            // 
            this.tabPage_director.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage_director.BackgroundImage")));
            this.tabPage_director.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_director.Controls.Add(this.label10);
            this.tabPage_director.Controls.Add(this.label9);
            this.tabPage_director.Controls.Add(this.label8);
            this.tabPage_director.Controls.Add(this.label7);
            this.tabPage_director.Controls.Add(this.label6);
            this.tabPage_director.Controls.Add(this.label5);
            this.tabPage_director.Controls.Add(this.label4);
            this.tabPage_director.Controls.Add(this.label3);
            this.tabPage_director.Controls.Add(this.label2);
            this.tabPage_director.Controls.Add(this.label1);
            this.tabPage_director.Controls.Add(this.button_materials_dir);
            this.tabPage_director.Controls.Add(this.button_recipes_dir);
            this.tabPage_director.Controls.Add(this.button_vendors_dir);
            this.tabPage_director.Controls.Add(this.button_cutomers_dir);
            this.tabPage_director.Controls.Add(this.button_staff_dir);
            this.tabPage_director.Controls.Add(this.button_requests_dir);
            this.tabPage_director.Controls.Add(this.button_vehicles_dir);
            this.tabPage_director.Controls.Add(this.button_disk_cards_dir);
            this.tabPage_director.Controls.Add(this.button_goods_dir);
            this.tabPage_director.Controls.Add(this.button_orders_dir);
            this.tabPage_director.Location = new System.Drawing.Point(4, 22);
            this.tabPage_director.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_director.Name = "tabPage_director";
            this.tabPage_director.Size = new System.Drawing.Size(774, 426);
            this.tabPage_director.TabIndex = 3;
            this.tabPage_director.Text = "Начало работы";
            this.tabPage_director.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label10.Location = new System.Drawing.Point(666, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Товары";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(519, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Сырье";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(360, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Рецепты";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(217, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Заказы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(51, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Поставщики";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(330, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Поставка сырья";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(644, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Покупатели";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(509, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Персонал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(54, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Автомобили";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(183, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Скидочные карты";
            // 
            // button_materials_dir
            // 
            this.button_materials_dir.BackColor = System.Drawing.Color.White;
            this.button_materials_dir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_materials_dir.BackgroundImage")));
            this.button_materials_dir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_materials_dir.Location = new System.Drawing.Point(493, 261);
            this.button_materials_dir.Name = "button_materials_dir";
            this.button_materials_dir.Size = new System.Drawing.Size(105, 72);
            this.button_materials_dir.TabIndex = 22;
            this.button_materials_dir.UseVisualStyleBackColor = false;
            this.button_materials_dir.Click += new System.EventHandler(this.Button_materials_adm_Click);
            // 
            // button_recipes_dir
            // 
            this.button_recipes_dir.BackColor = System.Drawing.Color.White;
            this.button_recipes_dir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_recipes_dir.BackgroundImage")));
            this.button_recipes_dir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_recipes_dir.Location = new System.Drawing.Point(341, 261);
            this.button_recipes_dir.Name = "button_recipes_dir";
            this.button_recipes_dir.Size = new System.Drawing.Size(105, 72);
            this.button_recipes_dir.TabIndex = 21;
            this.button_recipes_dir.UseVisualStyleBackColor = false;
            this.button_recipes_dir.Click += new System.EventHandler(this.Button_recipes_adm_Click);
            // 
            // button_vendors_dir
            // 
            this.button_vendors_dir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_vendors_dir.BackgroundImage")));
            this.button_vendors_dir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_vendors_dir.Location = new System.Drawing.Point(52, 261);
            this.button_vendors_dir.Name = "button_vendors_dir";
            this.button_vendors_dir.Size = new System.Drawing.Size(105, 72);
            this.button_vendors_dir.TabIndex = 20;
            this.button_vendors_dir.UseVisualStyleBackColor = true;
            this.button_vendors_dir.Click += new System.EventHandler(this.Button_vendor_adm_Click);
            // 
            // button_cutomers_dir
            // 
            this.button_cutomers_dir.BackColor = System.Drawing.Color.White;
            this.button_cutomers_dir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_cutomers_dir.BackgroundImage")));
            this.button_cutomers_dir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_cutomers_dir.Location = new System.Drawing.Point(642, 58);
            this.button_cutomers_dir.Name = "button_cutomers_dir";
            this.button_cutomers_dir.Size = new System.Drawing.Size(105, 72);
            this.button_cutomers_dir.TabIndex = 19;
            this.button_cutomers_dir.UseVisualStyleBackColor = false;
            this.button_cutomers_dir.Click += new System.EventHandler(this.Button_customers_adm_Click);
            // 
            // button_staff_dir
            // 
            this.button_staff_dir.BackColor = System.Drawing.Color.White;
            this.button_staff_dir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_staff_dir.BackgroundImage")));
            this.button_staff_dir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_staff_dir.Location = new System.Drawing.Point(493, 58);
            this.button_staff_dir.Name = "button_staff_dir";
            this.button_staff_dir.Size = new System.Drawing.Size(105, 72);
            this.button_staff_dir.TabIndex = 18;
            this.button_staff_dir.UseVisualStyleBackColor = false;
            this.button_staff_dir.Click += new System.EventHandler(this.Button_staff_adm_Click);
            // 
            // button_requests_dir
            // 
            this.button_requests_dir.BackColor = System.Drawing.Color.White;
            this.button_requests_dir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_requests_dir.BackgroundImage")));
            this.button_requests_dir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_requests_dir.Location = new System.Drawing.Point(341, 58);
            this.button_requests_dir.Name = "button_requests_dir";
            this.button_requests_dir.Size = new System.Drawing.Size(105, 72);
            this.button_requests_dir.TabIndex = 17;
            this.button_requests_dir.UseVisualStyleBackColor = false;
            this.button_requests_dir.Click += new System.EventHandler(this.Button_requests_adm_Click);
            // 
            // button_vehicles_dir
            // 
            this.button_vehicles_dir.BackColor = System.Drawing.Color.White;
            this.button_vehicles_dir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_vehicles_dir.BackgroundImage")));
            this.button_vehicles_dir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_vehicles_dir.Location = new System.Drawing.Point(52, 58);
            this.button_vehicles_dir.Name = "button_vehicles_dir";
            this.button_vehicles_dir.Size = new System.Drawing.Size(105, 72);
            this.button_vehicles_dir.TabIndex = 16;
            this.button_vehicles_dir.UseVisualStyleBackColor = false;
            this.button_vehicles_dir.Click += new System.EventHandler(this.Button_cars_adm_Click);
            // 
            // button_disk_cards_dir
            // 
            this.button_disk_cards_dir.BackColor = System.Drawing.Color.White;
            this.button_disk_cards_dir.BackgroundImage = global::Chuck_Time_Bakery.Properties.Resources.Discount_cards_img;
            this.button_disk_cards_dir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_disk_cards_dir.Location = new System.Drawing.Point(196, 58);
            this.button_disk_cards_dir.Name = "button_disk_cards_dir";
            this.button_disk_cards_dir.Size = new System.Drawing.Size(105, 72);
            this.button_disk_cards_dir.TabIndex = 15;
            this.button_disk_cards_dir.UseVisualStyleBackColor = false;
            this.button_disk_cards_dir.Click += new System.EventHandler(this.Button_discount_cards_Click);
            // 
            // button_goods_dir
            // 
            this.button_goods_dir.BackColor = System.Drawing.Color.White;
            this.button_goods_dir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_goods_dir.BackgroundImage")));
            this.button_goods_dir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_goods_dir.Location = new System.Drawing.Point(642, 261);
            this.button_goods_dir.Name = "button_goods_dir";
            this.button_goods_dir.Size = new System.Drawing.Size(105, 72);
            this.button_goods_dir.TabIndex = 14;
            this.button_goods_dir.UseVisualStyleBackColor = false;
            this.button_goods_dir.Click += new System.EventHandler(this.Button_goods_Click);
            // 
            // button_orders_dir
            // 
            this.button_orders_dir.BackColor = System.Drawing.Color.White;
            this.button_orders_dir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_orders_dir.BackgroundImage")));
            this.button_orders_dir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_orders_dir.Location = new System.Drawing.Point(196, 261);
            this.button_orders_dir.Name = "button_orders_dir";
            this.button_orders_dir.Size = new System.Drawing.Size(105, 72);
            this.button_orders_dir.TabIndex = 13;
            this.button_orders_dir.UseVisualStyleBackColor = false;
            this.button_orders_dir.Click += new System.EventHandler(this.Button_sales_Click);
            // 
            // tabPage_admin
            // 
            this.tabPage_admin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage_admin.BackgroundImage")));
            this.tabPage_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_admin.Controls.Add(this.label19);
            this.tabPage_admin.Controls.Add(this.label18);
            this.tabPage_admin.Controls.Add(this.label17);
            this.tabPage_admin.Controls.Add(this.label16);
            this.tabPage_admin.Controls.Add(this.label15);
            this.tabPage_admin.Controls.Add(this.label14);
            this.tabPage_admin.Controls.Add(this.label13);
            this.tabPage_admin.Controls.Add(this.label12);
            this.tabPage_admin.Controls.Add(this.label11);
            this.tabPage_admin.Controls.Add(this.button_materials_adm);
            this.tabPage_admin.Controls.Add(this.button_vendor_adm);
            this.tabPage_admin.Controls.Add(this.button_customers_adm);
            this.tabPage_admin.Controls.Add(this.button_staff_adm);
            this.tabPage_admin.Controls.Add(this.button_requests_adm);
            this.tabPage_admin.Controls.Add(this.button_cars_adm);
            this.tabPage_admin.Controls.Add(this.button_discount_cards_adm);
            this.tabPage_admin.Controls.Add(this.button_goods_adm);
            this.tabPage_admin.Controls.Add(this.button_sales_adm);
            this.tabPage_admin.Location = new System.Drawing.Point(4, 22);
            this.tabPage_admin.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_admin.Name = "tabPage_admin";
            this.tabPage_admin.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_admin.Size = new System.Drawing.Size(774, 426);
            this.tabPage_admin.TabIndex = 2;
            this.tabPage_admin.Text = "Начало работы";
            this.tabPage_admin.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label19.Location = new System.Drawing.Point(364, 240);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 20);
            this.label19.TabIndex = 21;
            this.label19.Text = "Сырье";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label18.Location = new System.Drawing.Point(51, 240);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 20);
            this.label18.TabIndex = 20;
            this.label18.Text = "Поставщики";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label17.Location = new System.Drawing.Point(332, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 20);
            this.label17.TabIndex = 19;
            this.label17.Text = "Поставка сырья";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label16.Location = new System.Drawing.Point(219, 240);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 20);
            this.label16.TabIndex = 18;
            this.label16.Text = "Заказы";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label15.Location = new System.Drawing.Point(515, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "Товары";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label14.Location = new System.Drawing.Point(644, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Покупатели";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label13.Location = new System.Drawing.Point(509, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Персонал";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label12.Location = new System.Drawing.Point(185, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Скидочные карты";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label11.Location = new System.Drawing.Point(54, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Автомобили";
            // 
            // button_materials_adm
            // 
            this.button_materials_adm.BackColor = System.Drawing.Color.White;
            this.button_materials_adm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_materials_adm.BackgroundImage")));
            this.button_materials_adm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_materials_adm.Location = new System.Drawing.Point(341, 261);
            this.button_materials_adm.Name = "button_materials_adm";
            this.button_materials_adm.Size = new System.Drawing.Size(105, 72);
            this.button_materials_adm.TabIndex = 12;
            this.button_materials_adm.UseVisualStyleBackColor = false;
            this.button_materials_adm.Click += new System.EventHandler(this.Button_materials_adm_Click);
            // 
            // button_vendor_adm
            // 
            this.button_vendor_adm.BackColor = System.Drawing.Color.White;
            this.button_vendor_adm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_vendor_adm.BackgroundImage")));
            this.button_vendor_adm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_vendor_adm.Location = new System.Drawing.Point(52, 261);
            this.button_vendor_adm.Name = "button_vendor_adm";
            this.button_vendor_adm.Size = new System.Drawing.Size(105, 72);
            this.button_vendor_adm.TabIndex = 10;
            this.button_vendor_adm.UseVisualStyleBackColor = false;
            this.button_vendor_adm.Click += new System.EventHandler(this.Button_vendor_adm_Click);
            // 
            // button_customers_adm
            // 
            this.button_customers_adm.BackColor = System.Drawing.Color.White;
            this.button_customers_adm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_customers_adm.BackgroundImage")));
            this.button_customers_adm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_customers_adm.Location = new System.Drawing.Point(642, 58);
            this.button_customers_adm.Name = "button_customers_adm";
            this.button_customers_adm.Size = new System.Drawing.Size(105, 72);
            this.button_customers_adm.TabIndex = 9;
            this.button_customers_adm.UseVisualStyleBackColor = false;
            this.button_customers_adm.Click += new System.EventHandler(this.Button_customers_adm_Click);
            // 
            // button_staff_adm
            // 
            this.button_staff_adm.BackColor = System.Drawing.Color.White;
            this.button_staff_adm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_staff_adm.BackgroundImage")));
            this.button_staff_adm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_staff_adm.Location = new System.Drawing.Point(493, 58);
            this.button_staff_adm.Name = "button_staff_adm";
            this.button_staff_adm.Size = new System.Drawing.Size(105, 72);
            this.button_staff_adm.TabIndex = 8;
            this.button_staff_adm.UseVisualStyleBackColor = false;
            this.button_staff_adm.Click += new System.EventHandler(this.Button_staff_adm_Click);
            // 
            // button_requests_adm
            // 
            this.button_requests_adm.BackColor = System.Drawing.Color.White;
            this.button_requests_adm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_requests_adm.BackgroundImage")));
            this.button_requests_adm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_requests_adm.Location = new System.Drawing.Point(341, 58);
            this.button_requests_adm.Name = "button_requests_adm";
            this.button_requests_adm.Size = new System.Drawing.Size(105, 72);
            this.button_requests_adm.TabIndex = 7;
            this.button_requests_adm.UseVisualStyleBackColor = false;
            this.button_requests_adm.Click += new System.EventHandler(this.Button_requests_adm_Click);
            // 
            // button_cars_adm
            // 
            this.button_cars_adm.BackColor = System.Drawing.Color.White;
            this.button_cars_adm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_cars_adm.BackgroundImage")));
            this.button_cars_adm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_cars_adm.Location = new System.Drawing.Point(52, 58);
            this.button_cars_adm.Name = "button_cars_adm";
            this.button_cars_adm.Size = new System.Drawing.Size(105, 72);
            this.button_cars_adm.TabIndex = 6;
            this.button_cars_adm.UseVisualStyleBackColor = false;
            this.button_cars_adm.Click += new System.EventHandler(this.Button_cars_adm_Click);
            // 
            // button_discount_cards_adm
            // 
            this.button_discount_cards_adm.BackColor = System.Drawing.Color.White;
            this.button_discount_cards_adm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_discount_cards_adm.BackgroundImage")));
            this.button_discount_cards_adm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_discount_cards_adm.Location = new System.Drawing.Point(196, 58);
            this.button_discount_cards_adm.Name = "button_discount_cards_adm";
            this.button_discount_cards_adm.Size = new System.Drawing.Size(105, 72);
            this.button_discount_cards_adm.TabIndex = 5;
            this.button_discount_cards_adm.UseVisualStyleBackColor = false;
            this.button_discount_cards_adm.Click += new System.EventHandler(this.Button_discount_cards_Click);
            // 
            // button_goods_adm
            // 
            this.button_goods_adm.BackColor = System.Drawing.Color.White;
            this.button_goods_adm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_goods_adm.BackgroundImage")));
            this.button_goods_adm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_goods_adm.Location = new System.Drawing.Point(493, 261);
            this.button_goods_adm.Name = "button_goods_adm";
            this.button_goods_adm.Size = new System.Drawing.Size(105, 72);
            this.button_goods_adm.TabIndex = 4;
            this.button_goods_adm.UseVisualStyleBackColor = false;
            this.button_goods_adm.Click += new System.EventHandler(this.Button_goods_Click);
            // 
            // button_sales_adm
            // 
            this.button_sales_adm.BackColor = System.Drawing.Color.White;
            this.button_sales_adm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sales_adm.BackgroundImage")));
            this.button_sales_adm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_sales_adm.Location = new System.Drawing.Point(196, 261);
            this.button_sales_adm.Name = "button_sales_adm";
            this.button_sales_adm.Size = new System.Drawing.Size(105, 72);
            this.button_sales_adm.TabIndex = 3;
            this.button_sales_adm.UseVisualStyleBackColor = false;
            this.button_sales_adm.Click += new System.EventHandler(this.Button_sales_Click);
            // 
            // tabPage_customer
            // 
            this.tabPage_customer.Controls.Add(this.panel_customer_main);
            this.tabPage_customer.Location = new System.Drawing.Point(4, 22);
            this.tabPage_customer.Name = "tabPage_customer";
            this.tabPage_customer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_customer.Size = new System.Drawing.Size(774, 426);
            this.tabPage_customer.TabIndex = 0;
            this.tabPage_customer.Text = "Ассортимент";
            this.tabPage_customer.UseVisualStyleBackColor = true;
            // 
            // panel_customer_main
            // 
            this.panel_customer_main.BackColor = System.Drawing.Color.PeachPuff;
            this.panel_customer_main.Controls.Add(this.button_image);
            this.panel_customer_main.Controls.Add(this.descriptionRichTextBox);
            this.panel_customer_main.Controls.Add(descriptionLabel);
            this.panel_customer_main.Controls.Add(photoLabel);
            this.panel_customer_main.Controls.Add(this.goodsBindingNavigator);
            this.panel_customer_main.Controls.Add(this.priceTextBox);
            this.panel_customer_main.Controls.Add(priceLabel);
            this.panel_customer_main.Controls.Add(this.photoPictureBox);
            this.panel_customer_main.Controls.Add(title_GoodLabel);
            this.panel_customer_main.Controls.Add(this.weightTextBox);
            this.panel_customer_main.Controls.Add(this.title_GoodTextBox);
            this.panel_customer_main.Controls.Add(weightLabel);
            this.panel_customer_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_customer_main.Location = new System.Drawing.Point(3, 3);
            this.panel_customer_main.Name = "panel_customer_main";
            this.panel_customer_main.Size = new System.Drawing.Size(768, 420);
            this.panel_customer_main.TabIndex = 22;
            // 
            // button_image
            // 
            this.button_image.Location = new System.Drawing.Point(190, 166);
            this.button_image.Margin = new System.Windows.Forms.Padding(2);
            this.button_image.Name = "button_image";
            this.button_image.Size = new System.Drawing.Size(94, 23);
            this.button_image.TabIndex = 21;
            this.button_image.Text = "Обзор...";
            this.button_image.UseVisualStyleBackColor = true;
            this.button_image.Click += new System.EventHandler(this.Button_image_Click);
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "Description", true));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(418, 36);
            this.descriptionRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(325, 83);
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
            this.goodsBindingNavigator.Size = new System.Drawing.Size(768, 27);
            this.goodsBindingNavigator.TabIndex = 6;
            this.goodsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 24);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "Price", true));
            this.priceTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.Location = new System.Drawing.Point(94, 96);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(216, 23);
            this.priceTextBox.TabIndex = 13;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.photoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.goodsBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(288, 123);
            this.photoPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(455, 295);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 15;
            this.photoPictureBox.TabStop = false;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "Weight", true));
            this.weightTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightTextBox.Location = new System.Drawing.Point(94, 65);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(216, 23);
            this.weightTextBox.TabIndex = 9;
            // 
            // title_GoodTextBox
            // 
            this.title_GoodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "Title_Good", true));
            this.title_GoodTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_GoodTextBox.Location = new System.Drawing.Point(94, 36);
            this.title_GoodTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.title_GoodTextBox.Name = "title_GoodTextBox";
            this.title_GoodTextBox.Size = new System.Drawing.Size(216, 23);
            this.title_GoodTextBox.TabIndex = 7;
            // 
            // tabPage_tech
            // 
            this.tabPage_tech.AutoScroll = true;
            this.tabPage_tech.Controls.Add(this.bindingNavigator_recipes);
            this.tabPage_tech.Controls.Add(this.recipesDataGridView);
            this.tabPage_tech.Location = new System.Drawing.Point(4, 22);
            this.tabPage_tech.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_tech.Name = "tabPage_tech";
            this.tabPage_tech.Size = new System.Drawing.Size(774, 426);
            this.tabPage_tech.TabIndex = 4;
            this.tabPage_tech.Text = "Рецепты";
            this.tabPage_tech.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator_recipes
            // 
            this.bindingNavigator_recipes.AddNewItem = this.toolStripButton1;
            this.bindingNavigator_recipes.BindingSource = this.recipesBindingSource;
            this.bindingNavigator_recipes.CountItem = this.toolStripLabel1;
            this.bindingNavigator_recipes.CountItemFormat = "из {0}";
            this.bindingNavigator_recipes.DeleteItem = this.toolStripButton2;
            this.bindingNavigator_recipes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator_recipes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton7});
            this.bindingNavigator_recipes.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator_recipes.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator_recipes.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator_recipes.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator_recipes.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator_recipes.Name = "bindingNavigator_recipes";
            this.bindingNavigator_recipes.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator_recipes.Size = new System.Drawing.Size(774, 27);
            this.bindingNavigator_recipes.TabIndex = 7;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Добавить";
            // 
            // recipesBindingSource
            // 
            this.recipesBindingSource.DataMember = "Recipes";
            this.recipesBindingSource.DataSource = this.chuck_TimeDataSet;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 24);
            this.toolStripLabel1.Text = "из {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(38, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton7.Text = "Сохранить данные";
            this.toolStripButton7.Click += new System.EventHandler(this.ToolStripButton7_Click);
            // 
            // recipesDataGridView
            // 
            this.recipesDataGridView.AutoGenerateColumns = false;
            this.recipesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.recipesDataGridView.ContextMenuStrip = this.contextMenuStrip_recipes;
            this.recipesDataGridView.DataSource = this.recipesBindingSource;
            this.recipesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.recipesDataGridView.Location = new System.Drawing.Point(0, 146);
            this.recipesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.recipesDataGridView.Name = "recipesDataGridView";
            this.recipesDataGridView.RowTemplate.Height = 24;
            this.recipesDataGridView.Size = new System.Drawing.Size(774, 280);
            this.recipesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Title_Recipe";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название рецепта";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cooking_time";
            this.dataGridViewTextBoxColumn2.HeaderText = "Время приготовления";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Technologist";
            this.dataGridViewTextBoxColumn4.DataSource = this.staffBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Full_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Технолог";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "Staff_ID";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.chuck_TimeDataSet;
            // 
            // contextMenuStrip_recipes
            // 
            this.contextMenuStrip_recipes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_recipes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_materials});
            this.contextMenuStrip_recipes.Name = "contextMenuStrip_recipes";
            this.contextMenuStrip_recipes.Size = new System.Drawing.Size(161, 26);
            // 
            // ToolStripMenuItem_materials
            // 
            this.ToolStripMenuItem_materials.Name = "ToolStripMenuItem_materials";
            this.ToolStripMenuItem_materials.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_materials.Text = "Состав изделий";
            this.ToolStripMenuItem_materials.Click += new System.EventHandler(this.ToolStripMenuItem_materials_Click);
            // 
            // tabPage_delivery
            // 
            this.tabPage_delivery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage_delivery.BackgroundImage")));
            this.tabPage_delivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_delivery.Controls.Add(this.label21);
            this.tabPage_delivery.Controls.Add(this.label20);
            this.tabPage_delivery.Controls.Add(this.button_customers);
            this.tabPage_delivery.Controls.Add(this.button_disc_cards_delivery);
            this.tabPage_delivery.Location = new System.Drawing.Point(4, 22);
            this.tabPage_delivery.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_delivery.Name = "tabPage_delivery";
            this.tabPage_delivery.Size = new System.Drawing.Size(774, 426);
            this.tabPage_delivery.TabIndex = 5;
            this.tabPage_delivery.Text = "Начало работы";
            this.tabPage_delivery.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label21.Location = new System.Drawing.Point(198, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 20);
            this.label21.TabIndex = 13;
            this.label21.Text = "Покупатели";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label20.Location = new System.Drawing.Point(39, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(132, 20);
            this.label20.TabIndex = 12;
            this.label20.Text = "Скидочные карты";
            // 
            // button_customers
            // 
            this.button_customers.BackColor = System.Drawing.Color.White;
            this.button_customers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_customers.BackgroundImage")));
            this.button_customers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_customers.Location = new System.Drawing.Point(196, 55);
            this.button_customers.Name = "button_customers";
            this.button_customers.Size = new System.Drawing.Size(105, 72);
            this.button_customers.TabIndex = 11;
            this.button_customers.UseVisualStyleBackColor = false;
            this.button_customers.Click += new System.EventHandler(this.Button_customers_adm_Click);
            // 
            // button_disc_cards_delivery
            // 
            this.button_disc_cards_delivery.BackColor = System.Drawing.Color.White;
            this.button_disc_cards_delivery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_disc_cards_delivery.BackgroundImage")));
            this.button_disc_cards_delivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_disc_cards_delivery.Location = new System.Drawing.Point(52, 55);
            this.button_disc_cards_delivery.Name = "button_disc_cards_delivery";
            this.button_disc_cards_delivery.Size = new System.Drawing.Size(105, 72);
            this.button_disc_cards_delivery.TabIndex = 10;
            this.button_disc_cards_delivery.UseVisualStyleBackColor = false;
            this.button_disc_cards_delivery.Click += new System.EventHandler(this.Button_discount_cards_Click);
            // 
            // tabPage_cook
            // 
            this.tabPage_cook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage_cook.BackgroundImage")));
            this.tabPage_cook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_cook.Controls.Add(this.label24);
            this.tabPage_cook.Controls.Add(this.label23);
            this.tabPage_cook.Controls.Add(this.label22);
            this.tabPage_cook.Controls.Add(this.button_materials_cook);
            this.tabPage_cook.Controls.Add(this.button_recipes_cook);
            this.tabPage_cook.Controls.Add(this.button_goods_cook);
            this.tabPage_cook.Location = new System.Drawing.Point(4, 22);
            this.tabPage_cook.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_cook.Name = "tabPage_cook";
            this.tabPage_cook.Size = new System.Drawing.Size(774, 426);
            this.tabPage_cook.TabIndex = 6;
            this.tabPage_cook.Text = "Начало работы";
            this.tabPage_cook.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label24.Location = new System.Drawing.Point(357, 35);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 20);
            this.label24.TabIndex = 28;
            this.label24.Text = "Рецепты";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label23.Location = new System.Drawing.Point(223, 35);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 20);
            this.label23.TabIndex = 27;
            this.label23.Text = "Сырье";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label22.Location = new System.Drawing.Point(75, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 20);
            this.label22.TabIndex = 26;
            this.label22.Text = "Товары";
            // 
            // button_materials_cook
            // 
            this.button_materials_cook.BackColor = System.Drawing.Color.White;
            this.button_materials_cook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_materials_cook.BackgroundImage")));
            this.button_materials_cook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_materials_cook.Location = new System.Drawing.Point(197, 56);
            this.button_materials_cook.Name = "button_materials_cook";
            this.button_materials_cook.Size = new System.Drawing.Size(105, 72);
            this.button_materials_cook.TabIndex = 25;
            this.button_materials_cook.UseVisualStyleBackColor = false;
            this.button_materials_cook.Click += new System.EventHandler(this.Button_materials_adm_Click);
            // 
            // button_recipes_cook
            // 
            this.button_recipes_cook.BackColor = System.Drawing.Color.White;
            this.button_recipes_cook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_recipes_cook.BackgroundImage")));
            this.button_recipes_cook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_recipes_cook.Location = new System.Drawing.Point(339, 56);
            this.button_recipes_cook.Name = "button_recipes_cook";
            this.button_recipes_cook.Size = new System.Drawing.Size(105, 72);
            this.button_recipes_cook.TabIndex = 24;
            this.button_recipes_cook.UseVisualStyleBackColor = false;
            this.button_recipes_cook.Click += new System.EventHandler(this.Button_recipes_adm_Click);
            // 
            // button_goods_cook
            // 
            this.button_goods_cook.BackColor = System.Drawing.Color.White;
            this.button_goods_cook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_goods_cook.BackgroundImage")));
            this.button_goods_cook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_goods_cook.Location = new System.Drawing.Point(52, 56);
            this.button_goods_cook.Name = "button_goods_cook";
            this.button_goods_cook.Size = new System.Drawing.Size(105, 72);
            this.button_goods_cook.TabIndex = 23;
            this.button_goods_cook.UseVisualStyleBackColor = false;
            this.button_goods_cook.Click += new System.EventHandler(this.Button_goods_Click);
            // 
            // tabPage_seller
            // 
            this.tabPage_seller.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage_seller.BackgroundImage")));
            this.tabPage_seller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_seller.Controls.Add(this.label27);
            this.tabPage_seller.Controls.Add(this.label26);
            this.tabPage_seller.Controls.Add(this.label25);
            this.tabPage_seller.Controls.Add(this.button_discount_cards);
            this.tabPage_seller.Controls.Add(this.button_goods);
            this.tabPage_seller.Controls.Add(this.button_sales);
            this.tabPage_seller.Location = new System.Drawing.Point(4, 22);
            this.tabPage_seller.Name = "tabPage_seller";
            this.tabPage_seller.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_seller.Size = new System.Drawing.Size(774, 426);
            this.tabPage_seller.TabIndex = 1;
            this.tabPage_seller.Text = "Начало работы";
            this.tabPage_seller.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label27.Location = new System.Drawing.Point(324, 36);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(132, 20);
            this.label27.TabIndex = 5;
            this.label27.Text = "Скидочные карты";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label26.Location = new System.Drawing.Point(217, 36);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(60, 20);
            this.label26.TabIndex = 4;
            this.label26.Text = "Заказы";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label25.Location = new System.Drawing.Point(48, 36);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(114, 20);
            this.label25.TabIndex = 3;
            this.label25.Text = "Ассортимент";
            // 
            // button_discount_cards
            // 
            this.button_discount_cards.BackColor = System.Drawing.Color.White;
            this.button_discount_cards.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_discount_cards.BackgroundImage")));
            this.button_discount_cards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_discount_cards.Location = new System.Drawing.Point(337, 57);
            this.button_discount_cards.Name = "button_discount_cards";
            this.button_discount_cards.Size = new System.Drawing.Size(105, 72);
            this.button_discount_cards.TabIndex = 2;
            this.button_discount_cards.UseVisualStyleBackColor = false;
            this.button_discount_cards.Click += new System.EventHandler(this.Button_discount_cards_Click);
            // 
            // button_goods
            // 
            this.button_goods.BackColor = System.Drawing.Color.White;
            this.button_goods.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_goods.BackgroundImage")));
            this.button_goods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_goods.Location = new System.Drawing.Point(53, 57);
            this.button_goods.Name = "button_goods";
            this.button_goods.Size = new System.Drawing.Size(105, 72);
            this.button_goods.TabIndex = 1;
            this.button_goods.UseVisualStyleBackColor = false;
            this.button_goods.Click += new System.EventHandler(this.Button_goods_Click);
            // 
            // button_sales
            // 
            this.button_sales.BackColor = System.Drawing.Color.White;
            this.button_sales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sales.BackgroundImage")));
            this.button_sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_sales.Location = new System.Drawing.Point(195, 57);
            this.button_sales.Name = "button_sales";
            this.button_sales.Size = new System.Drawing.Size(105, 72);
            this.button_sales.TabIndex = 0;
            this.button_sales.UseVisualStyleBackColor = false;
            this.button_sales.Click += new System.EventHandler(this.Button_sales_Click);
            // 
            // tabPage_hr
            // 
            this.tabPage_hr.AutoScroll = true;
            this.tabPage_hr.Controls.Add(this.bindingNavigator1);
            this.tabPage_hr.Controls.Add(this.staffDataGridView);
            this.tabPage_hr.Location = new System.Drawing.Point(4, 22);
            this.tabPage_hr.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_hr.Name = "tabPage_hr";
            this.tabPage_hr.Size = new System.Drawing.Size(774, 426);
            this.tabPage_hr.TabIndex = 7;
            this.tabPage_hr.Text = "Сотрудники";
            this.tabPage_hr.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton8;
            this.bindingNavigator1.BindingSource = this.staffBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel2;
            this.bindingNavigator1.CountItemFormat = "из {0}";
            this.bindingNavigator1.DeleteItem = this.toolStripButton9;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripSeparator6,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton14});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton10;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton13;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton12;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton11;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox2;
            this.bindingNavigator1.Size = new System.Drawing.Size(774, 27);
            this.bindingNavigator1.TabIndex = 8;
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton8.Text = "Добавить";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(36, 24);
            this.toolStripLabel2.Text = "из {0}";
            this.toolStripLabel2.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton9.Text = "Удалить";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton10.Text = "Переместить в начало";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton11.Text = "Переместить назад";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Положение";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(38, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton12.Text = "Переместить вперед";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton13.Text = "Переместить в конец";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton14.Text = "Сохранить данные";
            this.toolStripButton14.Click += new System.EventHandler(this.ToolStripButton14_Click);
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.AutoGenerateColumns = false;
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.staffDataGridView.DataSource = this.staffBindingSource;
            this.staffDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.staffDataGridView.Location = new System.Drawing.Point(0, 128);
            this.staffDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.RowTemplate.Height = 24;
            this.staffDataGridView.Size = new System.Drawing.Size(774, 298);
            this.staffDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Staff_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "№ сотрудника";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Full_name";
            this.dataGridViewTextBoxColumn6.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 250;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn7.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn8.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Phone_number";
            this.dataGridViewTextBoxColumn9.HeaderText = "Номер телефона";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 508);
            this.Controls.Add(this.tabControl_main);
            this.Controls.Add(this.statusStrip_main);
            this.Controls.Add(this.menuStrip_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.tabPage_director.ResumeLayout(false);
            this.tabPage_director.PerformLayout();
            this.tabPage_admin.ResumeLayout(false);
            this.tabPage_admin.PerformLayout();
            this.tabPage_customer.ResumeLayout(false);
            this.panel_customer_main.ResumeLayout(false);
            this.panel_customer_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingNavigator)).EndInit();
            this.goodsBindingNavigator.ResumeLayout(false);
            this.goodsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.tabPage_tech.ResumeLayout(false);
            this.tabPage_tech.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_recipes)).EndInit();
            this.bindingNavigator_recipes.ResumeLayout(false);
            this.bindingNavigator_recipes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.contextMenuStrip_recipes.ResumeLayout(false);
            this.tabPage_delivery.ResumeLayout(false);
            this.tabPage_delivery.PerformLayout();
            this.tabPage_cook.ResumeLayout(false);
            this.tabPage_cook.PerformLayout();
            this.tabPage_seller.ResumeLayout(false);
            this.tabPage_seller.PerformLayout();
            this.tabPage_hr.ResumeLayout(false);
            this.tabPage_hr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip_main;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton_change_user;
        public System.Windows.Forms.ToolStripMenuItem редактироватьУчетнуюЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
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
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox title_GoodTextBox;
        public System.Windows.Forms.TabPage tabPage_seller;
        public System.Windows.Forms.TabControl tabControl_main;
        public System.Windows.Forms.TabPage tabPage_customer;
        private System.Windows.Forms.Button button_discount_cards;
        private System.Windows.Forms.Button button_goods;
        private System.Windows.Forms.Button button_sales;
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
        public System.Windows.Forms.TabPage tabPage_director;
        private System.Windows.Forms.Button button_materials_dir;
        private System.Windows.Forms.Button button_recipes_dir;
        private System.Windows.Forms.Button button_vendors_dir;
        private System.Windows.Forms.Button button_cutomers_dir;
        private System.Windows.Forms.Button button_staff_dir;
        private System.Windows.Forms.Button button_requests_dir;
        private System.Windows.Forms.Button button_vehicles_dir;
        private System.Windows.Forms.Button button_disk_cards_dir;
        private System.Windows.Forms.Button button_goods_dir;
        private System.Windows.Forms.Button button_orders_dir;
        public System.Windows.Forms.TabPage tabPage_tech;
        public System.Windows.Forms.TabPage tabPage_delivery;
        public System.Windows.Forms.TabPage tabPage_cook;
        public System.Windows.Forms.TabPage tabPage_hr;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private Chuck_TimeDataSetTableAdapters.RecipesTableAdapter recipesTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator_recipes;
        public System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.DataGridView recipesDataGridView;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private Chuck_TimeDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button_customers;
        private System.Windows.Forms.Button button_disc_cards_delivery;
        private System.Windows.Forms.Button button_materials_cook;
        private System.Windows.Forms.Button button_recipes_cook;
        private System.Windows.Forms.Button button_goods_cook;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        public System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        public System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        public System.Windows.Forms.ToolStripMenuItem дисконтныеКартыToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem персоналToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem продажиToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem сырьеToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_recipes;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_materials;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
    }
}