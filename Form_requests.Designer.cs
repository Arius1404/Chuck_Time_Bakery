namespace Chuck_Time_Bakery
{
    partial class Form_requests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_requests));
            this.chuck_TimeDataSet = new Chuck_Time_Bakery.Chuck_TimeDataSet();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestsTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.RequestsTableAdapter();
            this.tableAdapterManager = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.TableAdapterManager();
            this.request_MaterialsTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.Request_MaterialsTableAdapter();
            this.vendorTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.VendorTableAdapter();
            this.requestsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.requestsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.requestsDataGridView = new System.Windows.Forms.DataGridView();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip_requests = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_info = new System.Windows.Forms.ToolStripMenuItem();
            this.fKRequestMaterialsRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.MaterialsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отправитьЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chuck_TimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingNavigator)).BeginInit();
            this.requestsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            this.contextMenuStrip_requests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKRequestMaterialsRequestsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.Recipes_MaterialsTableAdapter = null;
            this.tableAdapterManager.RecipesTableAdapter = null;
            this.tableAdapterManager.Request_MaterialsTableAdapter = this.request_MaterialsTableAdapter;
            this.tableAdapterManager.Requested_goodsTableAdapter = null;
            this.tableAdapterManager.RequestsTableAdapter = this.requestsTableAdapter;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.Staff_SalesTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = null;
            this.tableAdapterManager.VendorTableAdapter = this.vendorTableAdapter;
            // 
            // request_MaterialsTableAdapter
            // 
            this.request_MaterialsTableAdapter.ClearBeforeFill = true;
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // requestsBindingNavigator
            // 
            this.requestsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.requestsBindingNavigator.BindingSource = this.requestsBindingSource;
            this.requestsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.requestsBindingNavigator.CountItemFormat = "из {0}";
            this.requestsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.requestsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.requestsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.requestsBindingNavigatorSaveItem});
            this.requestsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.requestsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.requestsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.requestsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.requestsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.requestsBindingNavigator.Name = "requestsBindingNavigator";
            this.requestsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.requestsBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.requestsBindingNavigator.TabIndex = 0;
            this.requestsBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(47, 24);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
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
            // requestsBindingNavigatorSaveItem
            // 
            this.requestsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.requestsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("requestsBindingNavigatorSaveItem.Image")));
            this.requestsBindingNavigatorSaveItem.Name = "requestsBindingNavigatorSaveItem";
            this.requestsBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.requestsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.requestsBindingNavigatorSaveItem.Click += new System.EventHandler(this.RequestsBindingNavigatorSaveItem_Click);
            // 
            // requestsDataGridView
            // 
            this.requestsDataGridView.AutoGenerateColumns = false;
            this.requestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.requestsDataGridView.ContextMenuStrip = this.contextMenuStrip_requests;
            this.requestsDataGridView.DataSource = this.requestsBindingSource;
            this.requestsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestsDataGridView.Location = new System.Drawing.Point(0, 27);
            this.requestsDataGridView.Name = "requestsDataGridView";
            this.requestsDataGridView.RowTemplate.Height = 24;
            this.requestsDataGridView.Size = new System.Drawing.Size(800, 423);
            this.requestsDataGridView.TabIndex = 1;
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
            // contextMenuStrip_requests
            // 
            this.contextMenuStrip_requests.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_requests.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_info,
            this.отправитьЗаказToolStripMenuItem});
            this.contextMenuStrip_requests.Name = "contextMenuStrip_requests";
            this.contextMenuStrip_requests.Size = new System.Drawing.Size(237, 52);
            // 
            // ToolStripMenuItem_info
            // 
            this.ToolStripMenuItem_info.Name = "ToolStripMenuItem_info";
            this.ToolStripMenuItem_info.Size = new System.Drawing.Size(236, 24);
            this.ToolStripMenuItem_info.Text = "Содержание запросов";
            this.ToolStripMenuItem_info.Click += new System.EventHandler(this.ToolStripMenuItem_info_Click);
            // 
            // fKRequestMaterialsRequestsBindingSource
            // 
            this.fKRequestMaterialsRequestsBindingSource.DataMember = "FK_Request_Materials_Requests";
            this.fKRequestMaterialsRequestsBindingSource.DataSource = this.requestsBindingSource;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Request_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "№ запроса";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Raw_title";
            this.dataGridViewTextBoxColumn2.DataSource = this.materialsBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Title_Material";
            this.dataGridViewTextBoxColumn2.HeaderText = "Сырье";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Title_Material";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Vendor_Title";
            this.dataGridViewTextBoxColumn5.DataSource = this.vendorBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "Vendor_Title";
            this.dataGridViewTextBoxColumn5.HeaderText = "Поставщик";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "Vendor_Title";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Create_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата создания запроса";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // отправитьЗаказToolStripMenuItem
            // 
            this.отправитьЗаказToolStripMenuItem.Name = "отправитьЗаказToolStripMenuItem";
            this.отправитьЗаказToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.отправитьЗаказToolStripMenuItem.Text = "Отправить заказ";
            // 
            // Form_requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.requestsDataGridView);
            this.Controls.Add(this.requestsBindingNavigator);
            this.Name = "Form_requests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запросы на поставку сырья";
            this.Load += new System.EventHandler(this.Form_requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chuck_TimeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingNavigator)).EndInit();
            this.requestsBindingNavigator.ResumeLayout(false);
            this.requestsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            this.contextMenuStrip_requests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fKRequestMaterialsRequestsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Chuck_TimeDataSet chuck_TimeDataSet;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private Chuck_TimeDataSetTableAdapters.RequestsTableAdapter requestsTableAdapter;
        private Chuck_TimeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator requestsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton requestsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView requestsDataGridView;
        private Chuck_TimeDataSetTableAdapters.Request_MaterialsTableAdapter request_MaterialsTableAdapter;
        private System.Windows.Forms.BindingSource fKRequestMaterialsRequestsBindingSource;
        private Chuck_TimeDataSetTableAdapters.VendorTableAdapter vendorTableAdapter;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private Chuck_TimeDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_requests;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripMenuItem отправитьЗаказToolStripMenuItem;
    }
}