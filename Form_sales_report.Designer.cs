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
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отсчетная дата:";
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Location = new System.Drawing.Point(148, 37);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_start.TabIndex = 1;
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(516, 37);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_end.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Конечная дата:";
            // 
            // button_sales_report
            // 
            this.button_sales_report.Location = new System.Drawing.Point(516, 91);
            this.button_sales_report.Name = "button_sales_report";
            this.button_sales_report.Size = new System.Drawing.Size(200, 27);
            this.button_sales_report.TabIndex = 4;
            this.button_sales_report.Text = "Создать отчет";
            this.button_sales_report.UseVisualStyleBackColor = true;
            this.button_sales_report.Click += new System.EventHandler(this.Button_sales_report_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Подпись:";
            // 
            // textBox_sign
            // 
            this.textBox_sign.Location = new System.Drawing.Point(149, 95);
            this.textBox_sign.Name = "textBox_sign";
            this.textBox_sign.Size = new System.Drawing.Size(325, 22);
            this.textBox_sign.TabIndex = 6;
            // 
            // Form_sales_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 150);
            this.Controls.Add(this.textBox_sign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_sales_report);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_sales_report;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_sign;
    }
}