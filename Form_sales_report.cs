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
        
        private readonly string TemplateFileName = Application.StartupPath + @"\Template.docx";

        private void Button_sales_report_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source=Arius;Initial Catalog=Chuck_Time;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter adapter = new SqlDataAdapter("select sum(Price) from Sales where Order_date between '" + dateTimePicker_start.Value.ToString("yyyy/MM/dd") + "' and '" + dateTimePicker_end.Value.ToString("yyyy/MM/dd") + "'", con1);
            DataTable dt1 = new System.Data.DataTable();
            adapter.Fill(dt1);
            string income_external;
            income_external = dt1.Rows[0][0].ToString();
            dt1.Clear();
            con1.Close();
            var startDate = dateTimePicker_start.Value.ToShortDateString();
            var endDate = dateTimePicker_end.Value.ToShortDateString();
            var income = income_external;
            string fao = "Мелякова А.Ю.";
            string ceo1 = "Тахтеев И.А.";
            string ceo2 = "Семенков А.А.";
            DateTime signdate = new DateTime();
            signdate = DateTime.Now;

            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{startdate}", startDate, wordDocument);
                ReplaceWordStub("{enddate}", endDate, wordDocument);
                ReplaceWordStub("{income}", income, wordDocument);
                ReplaceWordStub("{FAO}", fao, wordDocument);
                ReplaceWordStub("{CEO1}", ceo1, wordDocument);
                ReplaceWordStub("{CEO2}", ceo2, wordDocument);
                ReplaceWordStub("{signdate}", signdate.ToString(), wordDocument);
                /*saveFileDialog_report.Title = "Сохранение отчета";
                saveFileDialog_report.InitialDirectory = @"C:\Users\Arius\Desktop\";
                saveFileDialog_report.FileName = "Отчет.docx";
                saveFileDialog_report.Filter = "Document File|*.doc, *.docx";
                if (saveFileDialog_report.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog_report.FileName;
                    wordApp.Documents.Save();
                }*/
                wordDocument.SaveAs(textBox_path.Text+textBox_name.Text);
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
