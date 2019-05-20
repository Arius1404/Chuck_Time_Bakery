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
    public partial class Form_cars : Form
    {
        public Form_cars()
        {
            InitializeComponent();
        }

        private static Form_cars f;
        public static Form_cars fc
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Form_cars();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void VehiclesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.vehiclesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.chuck_TimeDataSet);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void Form_cars_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chuck_TimeDataSet.Vehicles". При необходимости она может быть перемещена или удалена.
            this.vehiclesTableAdapter.Fill(this.chuck_TimeDataSet.Vehicles);

        }
    }
}
