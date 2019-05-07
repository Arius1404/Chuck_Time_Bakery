namespace Chuck_Time_Bakery
{
    partial class Form_cars
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
            System.Windows.Forms.Label plate_numberLabel;
            System.Windows.Forms.Label car_brandLabel;
            System.Windows.Forms.Label car_modelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_cars));
            this.chuck_TimeDataSet = new Chuck_Time_Bakery.Chuck_TimeDataSet();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiclesTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.VehiclesTableAdapter();
            this.tableAdapterManager = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.TableAdapterManager();
            this.vehiclesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.plate_numberTextBox = new System.Windows.Forms.TextBox();
            this.car_brandTextBox = new System.Windows.Forms.TextBox();
            this.car_modelTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.vehiclesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            plate_numberLabel = new System.Windows.Forms.Label();
            car_brandLabel = new System.Windows.Forms.Label();
            car_modelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chuck_TimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingNavigator)).BeginInit();
            this.vehiclesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // chuck_TimeDataSet
            // 
            this.chuck_TimeDataSet.DataSetName = "Chuck_TimeDataSet";
            this.chuck_TimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "Vehicles";
            this.vehiclesBindingSource.DataSource = this.chuck_TimeDataSet;
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Staff_SalesTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = this.vehiclesTableAdapter;
            this.tableAdapterManager.VendorTableAdapter = null;
            // 
            // vehiclesBindingNavigator
            // 
            this.vehiclesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vehiclesBindingNavigator.BindingSource = this.vehiclesBindingSource;
            this.vehiclesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vehiclesBindingNavigator.CountItemFormat = "из {0}";
            this.vehiclesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vehiclesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.vehiclesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vehiclesBindingNavigatorSaveItem});
            this.vehiclesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vehiclesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vehiclesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vehiclesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vehiclesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vehiclesBindingNavigator.Name = "vehiclesBindingNavigator";
            this.vehiclesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vehiclesBindingNavigator.Size = new System.Drawing.Size(416, 27);
            this.vehiclesBindingNavigator.TabIndex = 0;
            this.vehiclesBindingNavigator.Text = "bindingNavigator1";
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
            // plate_numberLabel
            // 
            plate_numberLabel.AutoSize = true;
            plate_numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            plate_numberLabel.Location = new System.Drawing.Point(45, 70);
            plate_numberLabel.Name = "plate_numberLabel";
            plate_numberLabel.Size = new System.Drawing.Size(142, 20);
            plate_numberLabel.TabIndex = 1;
            plate_numberLabel.Text = "Номер машины:";
            // 
            // plate_numberTextBox
            // 
            this.plate_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Plate_number", true));
            this.plate_numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plate_numberTextBox.Location = new System.Drawing.Point(203, 67);
            this.plate_numberTextBox.Name = "plate_numberTextBox";
            this.plate_numberTextBox.Size = new System.Drawing.Size(179, 27);
            this.plate_numberTextBox.TabIndex = 2;
            // 
            // car_brandLabel
            // 
            car_brandLabel.AutoSize = true;
            car_brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            car_brandLabel.Location = new System.Drawing.Point(45, 116);
            car_brandLabel.Name = "car_brandLabel";
            car_brandLabel.Size = new System.Drawing.Size(67, 20);
            car_brandLabel.TabIndex = 3;
            car_brandLabel.Text = "Марка:";
            // 
            // car_brandTextBox
            // 
            this.car_brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Car_brand", true));
            this.car_brandTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.car_brandTextBox.Location = new System.Drawing.Point(203, 113);
            this.car_brandTextBox.Name = "car_brandTextBox";
            this.car_brandTextBox.Size = new System.Drawing.Size(179, 27);
            this.car_brandTextBox.TabIndex = 4;
            // 
            // car_modelLabel
            // 
            car_modelLabel.AutoSize = true;
            car_modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            car_modelLabel.Location = new System.Drawing.Point(45, 165);
            car_modelLabel.Name = "car_modelLabel";
            car_modelLabel.Size = new System.Drawing.Size(80, 20);
            car_modelLabel.TabIndex = 5;
            car_modelLabel.Text = "Модель:";
            // 
            // car_modelTextBox
            // 
            this.car_modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Car_model", true));
            this.car_modelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.car_modelTextBox.Location = new System.Drawing.Point(203, 162);
            this.car_modelTextBox.Name = "car_modelTextBox";
            this.car_modelTextBox.Size = new System.Drawing.Size(179, 27);
            this.car_modelTextBox.TabIndex = 6;
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
            // vehiclesBindingNavigatorSaveItem
            // 
            this.vehiclesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vehiclesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vehiclesBindingNavigatorSaveItem.Image")));
            this.vehiclesBindingNavigatorSaveItem.Name = "vehiclesBindingNavigatorSaveItem";
            this.vehiclesBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.vehiclesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.vehiclesBindingNavigatorSaveItem.Click += new System.EventHandler(this.VehiclesBindingNavigatorSaveItem_Click);
            // 
            // Form_cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 232);
            this.Controls.Add(plate_numberLabel);
            this.Controls.Add(this.plate_numberTextBox);
            this.Controls.Add(car_brandLabel);
            this.Controls.Add(this.car_brandTextBox);
            this.Controls.Add(car_modelLabel);
            this.Controls.Add(this.car_modelTextBox);
            this.Controls.Add(this.vehiclesBindingNavigator);
            this.Name = "Form_cars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автомобили";
            this.Load += new System.EventHandler(this.Form_cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chuck_TimeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingNavigator)).EndInit();
            this.vehiclesBindingNavigator.ResumeLayout(false);
            this.vehiclesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Chuck_TimeDataSet chuck_TimeDataSet;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private Chuck_TimeDataSetTableAdapters.VehiclesTableAdapter vehiclesTableAdapter;
        private Chuck_TimeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vehiclesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vehiclesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox plate_numberTextBox;
        private System.Windows.Forms.TextBox car_brandTextBox;
        private System.Windows.Forms.TextBox car_modelTextBox;
    }
}