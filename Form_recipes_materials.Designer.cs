namespace Chuck_Time_Bakery
{
    partial class Form_recipes_materials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_recipes_materials));
            System.Windows.Forms.Label title_RecipeLabel;
            System.Windows.Forms.Label title_MaterialLabel;
            this.chuck_TimeDataSet = new Chuck_Time_Bakery.Chuck_TimeDataSet();
            this.recipes_MaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipes_MaterialsTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.Recipes_MaterialsTableAdapter();
            this.tableAdapterManager = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.TableAdapterManager();
            this.recipes_MaterialsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.recipes_MaterialsDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.recipes_MaterialsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipesTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.RecipesTableAdapter();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.MaterialsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title_RecipeComboBox = new System.Windows.Forms.ComboBox();
            this.title_MaterialComboBox = new System.Windows.Forms.ComboBox();
            title_RecipeLabel = new System.Windows.Forms.Label();
            title_MaterialLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chuck_TimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipes_MaterialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipes_MaterialsBindingNavigator)).BeginInit();
            this.recipes_MaterialsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipes_MaterialsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chuck_TimeDataSet
            // 
            this.chuck_TimeDataSet.DataSetName = "Chuck_TimeDataSet";
            this.chuck_TimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipes_MaterialsBindingSource
            // 
            this.recipes_MaterialsBindingSource.DataMember = "Recipes_Materials";
            this.recipes_MaterialsBindingSource.DataSource = this.chuck_TimeDataSet;
            // 
            // recipes_MaterialsTableAdapter
            // 
            this.recipes_MaterialsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.Discount_cardsTableAdapter = null;
            this.tableAdapterManager.GoodsTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = this.materialsTableAdapter;
            this.tableAdapterManager.Recipes_MaterialsTableAdapter = this.recipes_MaterialsTableAdapter;
            this.tableAdapterManager.RecipesTableAdapter = this.recipesTableAdapter;
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
            // recipes_MaterialsBindingNavigator
            // 
            this.recipes_MaterialsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.recipes_MaterialsBindingNavigator.BindingSource = this.recipes_MaterialsBindingSource;
            this.recipes_MaterialsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.recipes_MaterialsBindingNavigator.CountItemFormat = "из {0}";
            this.recipes_MaterialsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.recipes_MaterialsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.recipes_MaterialsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.recipes_MaterialsBindingNavigatorSaveItem});
            this.recipes_MaterialsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.recipes_MaterialsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.recipes_MaterialsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.recipes_MaterialsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.recipes_MaterialsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.recipes_MaterialsBindingNavigator.Name = "recipes_MaterialsBindingNavigator";
            this.recipes_MaterialsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.recipes_MaterialsBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.recipes_MaterialsBindingNavigator.TabIndex = 0;
            this.recipes_MaterialsBindingNavigator.Text = "bindingNavigator1";
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
            // recipes_MaterialsDataGridView
            // 
            this.recipes_MaterialsDataGridView.AutoGenerateColumns = false;
            this.recipes_MaterialsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipes_MaterialsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.recipes_MaterialsDataGridView.DataSource = this.recipes_MaterialsBindingSource;
            this.recipes_MaterialsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.recipes_MaterialsDataGridView.Location = new System.Drawing.Point(0, 66);
            this.recipes_MaterialsDataGridView.Name = "recipes_MaterialsDataGridView";
            this.recipes_MaterialsDataGridView.RowTemplate.Height = 24;
            this.recipes_MaterialsDataGridView.Size = new System.Drawing.Size(800, 430);
            this.recipes_MaterialsDataGridView.TabIndex = 1;
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
            // recipes_MaterialsBindingNavigatorSaveItem
            // 
            this.recipes_MaterialsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.recipes_MaterialsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("recipes_MaterialsBindingNavigatorSaveItem.Image")));
            this.recipes_MaterialsBindingNavigatorSaveItem.Name = "recipes_MaterialsBindingNavigatorSaveItem";
            this.recipes_MaterialsBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.recipes_MaterialsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.recipes_MaterialsBindingNavigatorSaveItem.Click += new System.EventHandler(this.Recipes_MaterialsBindingNavigatorSaveItem_Click);
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
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.chuck_TimeDataSet;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title_Recipe";
            this.dataGridViewTextBoxColumn2.DataSource = this.recipesBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Title_Recipe";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название рецепта";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Title_Material";
            this.dataGridViewTextBoxColumn3.DataSource = this.materialsBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Title_Material";
            this.dataGridViewTextBoxColumn3.HeaderText = "Материал";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // title_RecipeLabel
            // 
            title_RecipeLabel.AutoSize = true;
            title_RecipeLabel.Location = new System.Drawing.Point(12, 35);
            title_RecipeLabel.Name = "title_RecipeLabel";
            title_RecipeLabel.Size = new System.Drawing.Size(135, 17);
            title_RecipeLabel.TabIndex = 2;
            title_RecipeLabel.Text = "Название рецепта:";
            // 
            // title_RecipeComboBox
            // 
            this.title_RecipeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipes_MaterialsBindingSource, "Title_Recipe", true));
            this.title_RecipeComboBox.DataSource = this.recipesBindingSource;
            this.title_RecipeComboBox.DisplayMember = "Title_Recipe";
            this.title_RecipeComboBox.FormattingEnabled = true;
            this.title_RecipeComboBox.Location = new System.Drawing.Point(153, 32);
            this.title_RecipeComboBox.Name = "title_RecipeComboBox";
            this.title_RecipeComboBox.Size = new System.Drawing.Size(191, 24);
            this.title_RecipeComboBox.TabIndex = 3;
            this.title_RecipeComboBox.TextChanged += new System.EventHandler(this.Title_RecipeComboBox_TextChanged);
            // 
            // title_MaterialLabel
            // 
            title_MaterialLabel.AutoSize = true;
            title_MaterialLabel.Location = new System.Drawing.Point(356, 35);
            title_MaterialLabel.Name = "title_MaterialLabel";
            title_MaterialLabel.Size = new System.Drawing.Size(78, 17);
            title_MaterialLabel.TabIndex = 4;
            title_MaterialLabel.Text = "Материал:";
            // 
            // title_MaterialComboBox
            // 
            this.title_MaterialComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "Title_Material", true));
            this.title_MaterialComboBox.DataSource = this.recipes_MaterialsBindingSource;
            this.title_MaterialComboBox.DisplayMember = "Title_Material";
            this.title_MaterialComboBox.FormattingEnabled = true;
            this.title_MaterialComboBox.Location = new System.Drawing.Point(440, 32);
            this.title_MaterialComboBox.Name = "title_MaterialComboBox";
            this.title_MaterialComboBox.Size = new System.Drawing.Size(191, 24);
            this.title_MaterialComboBox.TabIndex = 5;
            this.title_MaterialComboBox.TextChanged += new System.EventHandler(this.Title_MaterialComboBox_TextChanged);
            // 
            // Form_recipes_materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(title_MaterialLabel);
            this.Controls.Add(this.title_MaterialComboBox);
            this.Controls.Add(title_RecipeLabel);
            this.Controls.Add(this.title_RecipeComboBox);
            this.Controls.Add(this.recipes_MaterialsDataGridView);
            this.Controls.Add(this.recipes_MaterialsBindingNavigator);
            this.Name = "Form_recipes_materials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Состав";
            this.Load += new System.EventHandler(this.Form_recipes_materials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chuck_TimeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipes_MaterialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipes_MaterialsBindingNavigator)).EndInit();
            this.recipes_MaterialsBindingNavigator.ResumeLayout(false);
            this.recipes_MaterialsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipes_MaterialsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Chuck_TimeDataSet chuck_TimeDataSet;
        private System.Windows.Forms.BindingSource recipes_MaterialsBindingSource;
        private Chuck_TimeDataSetTableAdapters.Recipes_MaterialsTableAdapter recipes_MaterialsTableAdapter;
        private Chuck_TimeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator recipes_MaterialsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton recipes_MaterialsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView recipes_MaterialsDataGridView;
        private Chuck_TimeDataSetTableAdapters.RecipesTableAdapter recipesTableAdapter;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private Chuck_TimeDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox title_RecipeComboBox;
        private System.Windows.Forms.ComboBox title_MaterialComboBox;
    }
}