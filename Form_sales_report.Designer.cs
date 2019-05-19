namespace Chuck_Time_Bakery
{
    partial class Form_sales_report
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
            this.customersTableAdapter1 = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.CustomersTableAdapter();
            this.customersTableAdapter2 = new Chuck_Time_Bakery.Chuck_TimeDataSetTableAdapters.CustomersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button_sales_report = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_sign = new System.Windows.Forms.TextBox();
            this.saveFileDialog_report = new System.Windows.Forms.SaveFileDialog();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // customersTableAdapter2
            // 
            this.customersTableAdapter2.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отсчетная дата:";
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.CustomFormat = "";
            this.dateTimePicker_start.Location = new System.Drawing.Point(111, 30);
            this.dateTimePicker_start.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker_start.TabIndex = 1;
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(387, 30);
            this.dateTimePicker_end.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker_end.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Конечная дата:";
            // 
            // button_sales_report
            // 
            this.button_sales_report.Location = new System.Drawing.Point(387, 74);
            this.button_sales_report.Margin = new System.Windows.Forms.Padding(2);
            this.button_sales_report.Name = "button_sales_report";
            this.button_sales_report.Size = new System.Drawing.Size(150, 22);
            this.button_sales_report.TabIndex = 4;
            this.button_sales_report.Text = "Создать отчет";
            this.button_sales_report.UseVisualStyleBackColor = true;
            this.button_sales_report.Click += new System.EventHandler(this.Button_sales_report_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Подпись:";
            // 
            // textBox_sign
            // 
            this.textBox_sign.Location = new System.Drawing.Point(112, 77);
            this.textBox_sign.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_sign.Name = "textBox_sign";
            this.textBox_sign.Size = new System.Drawing.Size(245, 20);
            this.textBox_sign.TabIndex = 6;
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(189, 115);
            this.textBox_path.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(168, 20);
            this.textBox_path.TabIndex = 7;
            this.textBox_path.Text = "C:\\Users\\Arius\\Desktop\\";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Путь сохранения отчета";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(189, 150);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(168, 20);
            this.textBox_name.TabIndex = 9;
            this.textBox_name.Text = "Report.docx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Имя файла";
            // 
            // Form_sales_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 181);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.textBox_sign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_sales_report);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_sales_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет по продажам";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Chuck_TimeDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private Chuck_TimeDataSetTableAdapters.CustomersTableAdapter customersTableAdapter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_sales_report;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_sign;
        public System.Windows.Forms.DateTimePicker dateTimePicker_start;
        public System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_report;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label5;
    }
}