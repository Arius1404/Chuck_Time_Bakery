namespace Chuck_Time_Bakery
{
    partial class Form_staff_sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_staff_sales));
            this.chuck_TimeDataSet = new Chuck_Time_Bakery.Chuck_TimeDataSet();
            this.staff_SalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staff_SalesTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.Staff_SalesTableAdapter();
            this.tableAdapterManager = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.TableAdapterManager();
            this.staff_SalesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.staff_SalesDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.staff_SalesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.StaffTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chuck_TimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_SalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_SalesBindingNavigator)).BeginInit();
            this.staff_SalesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staff_SalesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chuck_TimeDataSet
            // 
            this.chuck_TimeDataSet.DataSetName = "Chuck_TimeDataSet";
            this.chuck_TimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staff_SalesBindingSource
            // 
            this.staff_SalesBindingSource.DataMember = "Staff_Sales";
            this.staff_SalesBindingSource.DataSource = this.chuck_TimeDataSet;
            // 
            // staff_SalesTableAdapter
            // 
            this.staff_SalesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Request_MaterialsTableAdapter = null;
            this.tableAdapterManager.Requested_goodsTableAdapter = null;
            this.tableAdapterManager.RequestsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.Staff_SalesTableAdapter = this.staff_SalesTableAdapter;
            this.tableAdapterManager.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.UpdateOrder = Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = null;
            this.tableAdapterManager.VendorTableAdapter = null;
            // 
            // staff_SalesBindingNavigator
            // 
            this.staff_SalesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.staff_SalesBindingNavigator.BindingSource = this.staff_SalesBindingSource;
            this.staff_SalesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.staff_SalesBindingNavigator.CountItemFormat = "из {0}";
            this.staff_SalesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.staff_SalesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.staff_SalesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.staff_SalesBindingNavigatorSaveItem});
            this.staff_SalesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.staff_SalesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.staff_SalesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.staff_SalesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.staff_SalesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.staff_SalesBindingNavigator.Name = "staff_SalesBindingNavigator";
            this.staff_SalesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.staff_SalesBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.staff_SalesBindingNavigator.TabIndex = 0;
            this.staff_SalesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(47, 24);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // staff_SalesDataGridView
            // 
            this.staff_SalesDataGridView.AutoGenerateColumns = false;
            this.staff_SalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staff_SalesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.staff_SalesDataGridView.DataSource = this.staff_SalesBindingSource;
            this.staff_SalesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staff_SalesDataGridView.Location = new System.Drawing.Point(0, 27);
            this.staff_SalesDataGridView.Name = "staff_SalesDataGridView";
            this.staff_SalesDataGridView.RowTemplate.Height = 24;
            this.staff_SalesDataGridView.Size = new System.Drawing.Size(800, 423);
            this.staff_SalesDataGridView.TabIndex = 1;
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
            // staff_SalesBindingNavigatorSaveItem
            // 
            this.staff_SalesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.staff_SalesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("staff_SalesBindingNavigatorSaveItem.Image")));
            this.staff_SalesBindingNavigatorSaveItem.Name = "staff_SalesBindingNavigatorSaveItem";
            this.staff_SalesBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.staff_SalesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.staff_SalesBindingNavigatorSaveItem.Click += new System.EventHandler(this.Staff_SalesBindingNavigatorSaveItem_Click);
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.chuck_TimeDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Sale_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер заказа";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Staff_ID";
            this.dataGridViewTextBoxColumn3.DataSource = this.staffBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Full_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Продавец";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Staff_ID";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // Form_staff_sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.staff_SalesDataGridView);
            this.Controls.Add(this.staff_SalesBindingNavigator);
            this.Name = "Form_staff_sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажи продавцов";
            this.Load += new System.EventHandler(this.Form_staff_sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chuck_TimeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_SalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_SalesBindingNavigator)).EndInit();
            this.staff_SalesBindingNavigator.ResumeLayout(false);
            this.staff_SalesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staff_SalesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Chuck_TimeDataSet chuck_TimeDataSet;
        private System.Windows.Forms.BindingSource staff_SalesBindingSource;
        private Chuck_TimeDataSetTableAdapters.Staff_SalesTableAdapter staff_SalesTableAdapter;
        private Chuck_TimeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator staff_SalesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton staff_SalesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView staff_SalesDataGridView;
        private Chuck_TimeDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}