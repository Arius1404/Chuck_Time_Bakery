using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Word = Microsoft.Office.Interop.Word;

namespace Chuck_Time_Bakery
{
    public partial class Form_request_report : Form
    {
        public Form_request_report()
        {
            InitializeComponent();
        }

        private static Form_request_report f;
        public static Form_request_report frr
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Form_request_report();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void RequestsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requestsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);

        }

        private void Form_request_report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Vendor". При необходимости она может быть перемещена или удалена.
            this.vendorTableAdapter.Fill(this.chuck_TimeDataSet.Vendor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Materials". При необходимости она может быть перемещена или удалена.
            this.materialsTableAdapter.Fill(this.chuck_TimeDataSet.Materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.chuck_TimeDataSet.Requests);

        }

        private readonly string TemplateFileName_req = Application.StartupPath + @"\Template_request.docx";

        private void Button_request_report_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection("Data Source=Arius;Initial Catalog=Chuck_Time;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter adapter_req = new SqlDataAdapter("select Request_ID from Requests where Request_ID = '" + request_IDTextBox.Text + "'", con2);
            DataTable dt2 = new System.Data.DataTable();
            adapter_req.Fill(dt2);
            string request_number;
            request_number = dt2.Rows[0][0].ToString();
            dt2.Clear();
            con2.Close();
            var vendor = vendor_TitleTextBox.Text;
            var material = raw_titleTextBox.Text;
            var quantity = quantityTextBox.Text;
            var request_date = request_dateTimePicker.Value.ToShortDateString();

            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                var wordDocument = wordApp.Documents.Open(TemplateFileName_req);
                ReplaceWordStub("{number}", request_number, wordDocument);
                ReplaceWordStub("{vendor}", vendor, wordDocument);
                ReplaceWordStub("{material}", material, wordDocument);
                ReplaceWordStub("{quantity}", quantity, wordDocument);
                ReplaceWordStub("{reqdate}", request_date, wordDocument);

                wordDocument.SaveAs(textBox_path_req.Text + textBox_name_req.Text);
                wordApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("Во время генерации отчета произошла непредвиденная ошибка!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
    }
}
