namespace Chuck_Time_Bakery
{
    partial class Form_login_edit
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
            System.Windows.Forms.Label loginLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login_edit));
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phone_numberLabel;
            this.chuck_TimeDataSet = new Chuck_Time_Bakery.Chuck_TimeDataSet();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.LoginTableAdapter();
            this.tableAdapterManager = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.TableAdapterManager();
            this.loginBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.CustomersTableAdapter();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.StaffTableAdapter();
            this.full_nameTextBox_staff = new System.Windows.Forms.TextBox();
            this.addressTextBox_staff = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox_staff = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phone_numberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chuck_TimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingNavigator)).BeginInit();
            this.loginBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chuck_TimeDataSet
            // 
            this.chuck_TimeDataSet.DataSetName = "Chuck_TimeDataSet";
            this.chuck_TimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.chuck_TimeDataSet;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.Discount_cardsTableAdapter = null;
            this.tableAdapterManager.GoodsTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = this.loginTableAdapter;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.Recipes_MaterialsTableAdapter = null;
            this.tableAdapterManager.RecipesTableAdapter = null;
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
            // loginBindingNavigator
            // 
            this.loginBindingNavigator.AddNewItem = null;
            this.loginBindingNavigator.BindingSource = this.loginBindingSource;
            this.loginBindingNavigator.CountItem = null;
            this.loginBindingNavigator.DeleteItem = null;
            this.loginBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.loginBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginBindingNavigatorSaveItem});
            this.loginBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.loginBindingNavigator.MoveFirstItem = null;
            this.loginBindingNavigator.MoveLastItem = null;
            this.loginBindingNavigator.MoveNextItem = null;
            this.loginBindingNavigator.MovePreviousItem = null;
            this.loginBindingNavigator.Name = "loginBindingNavigator";
            this.loginBindingNavigator.PositionItem = null;
            this.loginBindingNavigator.Size = new System.Drawing.Size(664, 27);
            this.loginBindingNavigator.TabIndex = 0;
            this.loginBindingNavigator.Text = "bindingNavigator1";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(87, 46);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(51, 17);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Логин:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Login", true));
            this.loginTextBox.Location = new System.Drawing.Point(144, 43);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(188, 22);
            this.loginTextBox.TabIndex = 2;
            // 
            // loginBindingNavigatorSaveItem
            // 
            this.loginBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loginBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("loginBindingNavigatorSaveItem.Image")));
            this.loginBindingNavigatorSaveItem.Name = "loginBindingNavigatorSaveItem";
            this.loginBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.loginBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.loginBindingNavigatorSaveItem.Click += new System.EventHandler(this.LoginBindingNavigatorSaveItem_Click);
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(358, 46);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(61, 17);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Пароль:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(425, 43);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 22);
            this.passwordTextBox.TabIndex = 4;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "FK_Customers_Login";
            this.customersBindingSource.DataSource = this.loginBindingSource;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(92, 103);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(46, 17);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "ФИО:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(144, 100);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(188, 22);
            this.nameTextBox.TabIndex = 6;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(86, 146);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(52, 17);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Адрес:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(144, 143);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(188, 22);
            this.addressTextBox.TabIndex = 8;
            // 
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.Location = new System.Drawing.Point(13, 188);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(125, 17);
            phone_numberLabel.TabIndex = 9;
            phone_numberLabel.Text = "Номер телефона:";
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone_number", true));
            this.phone_numberTextBox.Location = new System.Drawing.Point(144, 185);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(188, 22);
            this.phone_numberTextBox.TabIndex = 10;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "FK_Staff_Login";
            this.staffBindingSource.DataSource = this.loginBindingSource;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // full_nameTextBox_staff
            // 
            this.full_nameTextBox_staff.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Full_name", true));
            this.full_nameTextBox_staff.Location = new System.Drawing.Point(144, 100);
            this.full_nameTextBox_staff.Name = "full_nameTextBox_staff";
            this.full_nameTextBox_staff.Size = new System.Drawing.Size(188, 22);
            this.full_nameTextBox_staff.TabIndex = 12;
            // 
            // addressTextBox_staff
            // 
            this.addressTextBox_staff.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Address", true));
            this.addressTextBox_staff.Location = new System.Drawing.Point(144, 143);
            this.addressTextBox_staff.Name = "addressTextBox_staff";
            this.addressTextBox_staff.Size = new System.Drawing.Size(188, 22);
            this.addressTextBox_staff.TabIndex = 14;
            // 
            // phone_numberTextBox_staff
            // 
            this.phone_numberTextBox_staff.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Phone_number", true));
            this.phone_numberTextBox_staff.Location = new System.Drawing.Point(144, 185);
            this.phone_numberTextBox_staff.Name = "phone_numberTextBox_staff";
            this.phone_numberTextBox_staff.Size = new System.Drawing.Size(188, 22);
            this.phone_numberTextBox_staff.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoginBindingNavigatorSaveItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form_login_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 259);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phone_numberTextBox_staff);
            this.Controls.Add(this.addressTextBox_staff);
            this.Controls.Add(this.full_nameTextBox_staff);
            this.Controls.Add(phone_numberLabel);
            this.Controls.Add(this.phone_numberTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginBindingNavigator);
            this.Name = "Form_login_edit";
            this.Text = "Профиль";
            this.Load += new System.EventHandler(this.Form_login_edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chuck_TimeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingNavigator)).EndInit();
            this.loginBindingNavigator.ResumeLayout(false);
            this.loginBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Chuck_TimeDataSet chuck_TimeDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private Chuck_TimeDataSetTableAdapters.LoginTableAdapter loginTableAdapter;
        private Chuck_TimeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator loginBindingNavigator;
        private System.Windows.Forms.ToolStripButton loginBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox loginTextBox;
        private Chuck_TimeDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Chuck_TimeDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.TextBox full_nameTextBox_staff;
        private System.Windows.Forms.TextBox addressTextBox_staff;
        private System.Windows.Forms.TextBox phone_numberTextBox_staff;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}