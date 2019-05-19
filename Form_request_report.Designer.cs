namespace Chuck_Time_Bakery
{
    partial class Form_request_report
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
            System.Windows.Forms.Label request_IDLabel;
            System.Windows.Forms.Label raw_titleLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label create_dateLabel;
            System.Windows.Forms.Label vendor_TitleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_request_report));
            this.chuck_TimeDataSet = new Chuck_Time_Bakery.Chuck_TimeDataSet();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestsTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.RequestsTableAdapter();
            this.tableAdapterManager = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.TableAdapterManager();
            this.materialsTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.MaterialsTableAdapter();
            this.vendorTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.VendorTableAdapter();
            this.request_IDTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.requestsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raw_titleTextBox = new System.Windows.Forms.TextBox();
            this.vendor_TitleTextBox = new System.Windows.Forms.TextBox();
            this.button_request_report = new System.Windows.Forms.Button();
            this.request_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_path_req = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_name_req = new System.Windows.Forms.TextBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            request_IDLabel = new System.Windows.Forms.Label();
            raw_titleLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            create_dateLabel = new System.Windows.Forms.Label();
            vendor_TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chuck_TimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingNavigator)).BeginInit();
            this.requestsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // request_IDLabel
            // 
            request_IDLabel.AutoSize = true;
            request_IDLabel.Location = new System.Drawing.Point(13, 43);
            request_IDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            request_IDLabel.Name = "request_IDLabel";
            request_IDLabel.Size = new System.Drawing.Size(66, 13);
            request_IDLabel.TabIndex = 1;
            request_IDLabel.Text = "№ запроса:";
            // 
            // raw_titleLabel
            // 
            raw_titleLabel.AutoSize = true;
            raw_titleLabel.Location = new System.Drawing.Point(13, 67);
            raw_titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            raw_titleLabel.Name = "raw_titleLabel";
            raw_titleLabel.Size = new System.Drawing.Size(60, 13);
            raw_titleLabel.TabIndex = 3;
            raw_titleLabel.Text = "Материал:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(13, 90);
            quantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(69, 13);
            quantityLabel.TabIndex = 5;
            quantityLabel.Text = "Количество:";
            // 
            // create_dateLabel
            // 
            create_dateLabel.AutoSize = true;
            create_dateLabel.Location = new System.Drawing.Point(13, 114);
            create_dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            create_dateLabel.Name = "create_dateLabel";
            create_dateLabel.Size = new System.Drawing.Size(87, 13);
            create_dateLabel.TabIndex = 7;
            create_dateLabel.Text = "Дата создания:";
            // 
            // vendor_TitleLabel
            // 
            vendor_TitleLabel.AutoSize = true;
            vendor_TitleLabel.Location = new System.Drawing.Point(13, 137);
            vendor_TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            vendor_TitleLabel.Name = "vendor_TitleLabel";
            vendor_TitleLabel.Size = new System.Drawing.Size(68, 13);
            vendor_TitleLabel.TabIndex = 9;
            vendor_TitleLabel.Text = "Поставщик:";
            // 
            // chuck_TimeDataSet
            // 
            this.chuck_TimeDataSet.DataSetName = "Chuck_TimeDataSet";
            this.chuck_TimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataMember = "Requests";
            this.requestsBindingSource.DataSource = this.chuck_TimeDataSet;
            // 
            // requestsTableAdapter
            // 
            this.requestsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.Discount_cardsTableAdapter = null;
            this.tableAdapterManager.GoodsTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = this.materialsTableAdapter;
            this.tableAdapterManager.Recipes_MaterialsTableAdapter = null;
            this.tableAdapterManager.RecipesTableAdapter = null;
            this.tableAdapterManager.Request_MaterialsTableAdapter = null;
            this.tableAdapterManager.Requested_goodsTableAdapter = null;
            this.tableAdapterManager.RequestsTableAdapter = this.requestsTableAdapter;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.Staff_SalesTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = null;
            this.tableAdapterManager.VendorTableAdapter = this.vendorTableAdapter;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // request_IDTextBox
            // 
            this.request_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestsBindingSource, "Request_ID", true));
            this.request_IDTextBox.Location = new System.Drawing.Point(98, 39);
            this.request_IDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.request_IDTextBox.Name = "request_IDTextBox";
            this.request_IDTextBox.ReadOnly = true;
            this.request_IDTextBox.Size = new System.Drawing.Size(151, 20);
            this.request_IDTextBox.TabIndex = 2;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestsBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(98, 87);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.ReadOnly = true;
            this.quantityTextBox.Size = new System.Drawing.Size(151, 20);
            this.quantityTextBox.TabIndex = 6;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 24);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // requestsBindingNavigator
            // 
            this.requestsBindingNavigator.AddNewItem = null;
            this.requestsBindingNavigator.BindingSource = this.requestsBindingSource;
            this.requestsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.requestsBindingNavigator.CountItemFormat = "из {0}";
            this.requestsBindingNavigator.DeleteItem = null;
            this.requestsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.requestsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.requestsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.requestsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.requestsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.requestsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.requestsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.requestsBindingNavigator.Name = "requestsBindingNavigator";
            this.requestsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.requestsBindingNavigator.Size = new System.Drawing.Size(319, 27);
            this.requestsBindingNavigator.TabIndex = 0;
            this.requestsBindingNavigator.Text = "bindingNavigator1";
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.chuck_TimeDataSet;
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.chuck_TimeDataSet;
            // 
            // raw_titleTextBox
            // 
            this.raw_titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestsBindingSource, "Raw_title", true));
            this.raw_titleTextBox.Location = new System.Drawing.Point(98, 63);
            this.raw_titleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.raw_titleTextBox.Name = "raw_titleTextBox";
            this.raw_titleTextBox.ReadOnly = true;
            this.raw_titleTextBox.Size = new System.Drawing.Size(151, 20);
            this.raw_titleTextBox.TabIndex = 10;
            // 
            // vendor_TitleTextBox
            // 
            this.vendor_TitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestsBindingSource, "Vendor_Title", true));
            this.vendor_TitleTextBox.Location = new System.Drawing.Point(98, 135);
            this.vendor_TitleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.vendor_TitleTextBox.Name = "vendor_TitleTextBox";
            this.vendor_TitleTextBox.ReadOnly = true;
            this.vendor_TitleTextBox.Size = new System.Drawing.Size(151, 20);
            this.vendor_TitleTextBox.TabIndex = 12;
            // 
            // button_request_report
            // 
            this.button_request_report.Location = new System.Drawing.Point(146, 177);
            this.button_request_report.Margin = new System.Windows.Forms.Padding(2);
            this.button_request_report.Name = "button_request_report";
            this.button_request_report.Size = new System.Drawing.Size(103, 27);
            this.button_request_report.TabIndex = 13;
            this.button_request_report.Text = "Создать запрос";
            this.button_request_report.UseVisualStyleBackColor = true;
            this.button_request_report.Click += new System.EventHandler(this.Button_request_report_Click);
            // 
            // request_dateTimePicker
            // 
            this.request_dateTimePicker.Location = new System.Drawing.Point(98, 110);
            this.request_dateTimePicker.Name = "request_dateTimePicker";
            this.request_dateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.request_dateTimePicker.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Путь сохранения отчета";
            // 
            // textBox_path_req
            // 
            this.textBox_path_req.Location = new System.Drawing.Point(146, 216);
            this.textBox_path_req.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_path_req.Name = "textBox_path_req";
            this.textBox_path_req.Size = new System.Drawing.Size(168, 20);
            this.textBox_path_req.TabIndex = 16;
            this.textBox_path_req.Text = "C:\\Users\\Arius\\Desktop\\";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Имя файла";
            // 
            // textBox_name_req
            // 
            this.textBox_name_req.Location = new System.Drawing.Point(146, 243);
            this.textBox_name_req.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_name_req.Name = "textBox_name_req";
            this.textBox_name_req.Size = new System.Drawing.Size(168, 20);
            this.textBox_name_req.TabIndex = 18;
            this.textBox_name_req.Text = "Запрос на поставку.docx";
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
            // Form_request_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(319, 268);
            this.Controls.Add(this.textBox_name_req);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_path_req);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.request_dateTimePicker);
            this.Controls.Add(this.button_request_report);
            this.Controls.Add(this.vendor_TitleTextBox);
            this.Controls.Add(this.raw_titleTextBox);
            this.Controls.Add(request_IDLabel);
            this.Controls.Add(this.request_IDTextBox);
            this.Controls.Add(raw_titleLabel);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(create_dateLabel);
            this.Controls.Add(vendor_TitleLabel);
            this.Controls.Add(this.requestsBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_request_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Формирование запроса";
            this.Load += new System.EventHandler(this.Form_request_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chuck_TimeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingNavigator)).EndInit();
            this.requestsBindingNavigator.ResumeLayout(false);
            this.requestsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Chuck_TimeDataSet chuck_TimeDataSet;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private Chuck_TimeDataSetTableAdapters.RequestsTableAdapter requestsTableAdapter;
        private Chuck_TimeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Chuck_TimeDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.TextBox request_IDTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.BindingNavigator requestsBindingNavigator;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private Chuck_TimeDataSetTableAdapters.VendorTableAdapter vendorTableAdapter;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private System.Windows.Forms.TextBox raw_titleTextBox;
        private System.Windows.Forms.TextBox vendor_TitleTextBox;
        private System.Windows.Forms.Button button_request_report;
        private System.Windows.Forms.DateTimePicker request_dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_path_req;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_name_req;
    }
}