namespace Chuck_Time_Bakery
{
    partial class Form_recipes
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
            System.Windows.Forms.Label full_nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_recipes));
            this.chuck_TimeDataSet = new Chuck_Time_Bakery.Chuck_TimeDataSet();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipesTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.RecipesTableAdapter();
            this.tableAdapterManager = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.TableAdapterManager();
            this.staffTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.StaffTableAdapter();
            this.recipesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.recipesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.recipesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip_recipes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_materials = new System.Windows.Forms.ToolStripMenuItem();
            this.full_nameComboBox = new System.Windows.Forms.ComboBox();
            full_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chuck_TimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingNavigator)).BeginInit();
            this.recipesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.contextMenuStrip_recipes.SuspendLayout();
            this.SuspendLayout();
            // 
            // full_nameLabel
            // 
            full_nameLabel.AutoSize = true;
            full_nameLabel.Location = new System.Drawing.Point(7, 32);
            full_nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            full_nameLabel.Name = "full_nameLabel";
            full_nameLabel.Size = new System.Drawing.Size(57, 13);
            full_nameLabel.TabIndex = 3;
            full_nameLabel.Text = "Технолог:";
            // 
            // chuck_TimeDataSet
            // 
            this.chuck_TimeDataSet.DataSetName = "Chuck_TimeDataSet";
            this.chuck_TimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipesBindingSource
            // 
            this.recipesBindingSource.DataMember = "Recipes";
            this.recipesBindingSource.DataSource = this.chuck_TimeDataSet;
            // 
            // recipesTableAdapter
            // 
            this.recipesTableAdapter.ClearBeforeFill = true;
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
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // recipesBindingNavigator
            // 
            this.recipesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.recipesBindingNavigator.BindingSource = this.recipesBindingSource;
            this.recipesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.recipesBindingNavigator.CountItemFormat = "из {0}";
            this.recipesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.recipesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.recipesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.recipesBindingNavigatorSaveItem});
            this.recipesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.recipesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.recipesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.recipesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.recipesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.recipesBindingNavigator.Name = "recipesBindingNavigator";
            this.recipesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.recipesBindingNavigator.Size = new System.Drawing.Size(776, 27);
            this.recipesBindingNavigator.TabIndex = 0;
            this.recipesBindingNavigator.Text = "bindingNavigator1";
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
            // recipesBindingNavigatorSaveItem
            // 
            this.recipesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.recipesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("recipesBindingNavigatorSaveItem.Image")));
            this.recipesBindingNavigatorSaveItem.Name = "recipesBindingNavigatorSaveItem";
            this.recipesBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.recipesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.recipesBindingNavigatorSaveItem.Click += new System.EventHandler(this.RecipesBindingNavigatorSaveItem_Click);
            // 
            // recipesDataGridView
            // 
            this.recipesDataGridView.AutoGenerateColumns = false;
            this.recipesDataGridView.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.recipesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.recipesDataGridView.ContextMenuStrip = this.contextMenuStrip_recipes;
            this.recipesDataGridView.DataSource = this.recipesBindingSource;
            this.recipesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.recipesDataGridView.GridColor = System.Drawing.Color.PeachPuff;
            this.recipesDataGridView.Location = new System.Drawing.Point(0, 57);
            this.recipesDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recipesDataGridView.Name = "recipesDataGridView";
            this.recipesDataGridView.RowTemplate.Height = 24;
            this.recipesDataGridView.Size = new System.Drawing.Size(776, 327);
            this.recipesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Title_Recipe";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cooking_time";
            this.dataGridViewTextBoxColumn2.HeaderText = "Время приготовления";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
            this.ToolStripMenuItem_materials.Click += new System.EventHandler(this.СоставПродуктовToolStripMenuItem_Click);
            // 
            // full_nameComboBox
            // 
            this.full_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Full_name", true));
            this.full_nameComboBox.DataSource = this.staffBindingSource;
            this.full_nameComboBox.DisplayMember = "Full_name";
            this.full_nameComboBox.FormattingEnabled = true;
            this.full_nameComboBox.Location = new System.Drawing.Point(66, 30);
            this.full_nameComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.full_nameComboBox.Name = "full_nameComboBox";
            this.full_nameComboBox.Size = new System.Drawing.Size(182, 21);
            this.full_nameComboBox.TabIndex = 4;
            this.full_nameComboBox.TextChanged += new System.EventHandler(this.Full_nameComboBox_TextChanged);
            // 
            // Form_recipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(776, 384);
            this.Controls.Add(full_nameLabel);
            this.Controls.Add(this.full_nameComboBox);
            this.Controls.Add(this.recipesDataGridView);
            this.Controls.Add(this.recipesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_recipes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рецепты";
            this.Load += new System.EventHandler(this.Form_recipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chuck_TimeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingNavigator)).EndInit();
            this.recipesBindingNavigator.ResumeLayout(false);
            this.recipesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.contextMenuStrip_recipes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Chuck_TimeDataSet chuck_TimeDataSet;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private Chuck_TimeDataSetTableAdapters.RecipesTableAdapter recipesTableAdapter;
        private Chuck_TimeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator recipesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton recipesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView recipesDataGridView;
        private Chuck_TimeDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_recipes;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_materials;
        private System.Windows.Forms.ComboBox full_nameComboBox;
    }
}