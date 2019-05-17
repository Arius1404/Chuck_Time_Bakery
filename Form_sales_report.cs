using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuck_Time_Bakery
{
    public partial class Form_sales_report : Form
    {
        public Form_sales_report()
        {
            InitializeComponent();
        }

        private static Form_sales_report f;
        public static Form_sales_report fsr
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Form_sales_report();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void Button_sales_report_Click(object sender, EventArgs e)
        {
            // ГЕНЕРАТОР ОТЧЕТА
        }
    }
}
