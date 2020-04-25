using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class JournalForm : Form
    {
        public JournalForm()
        {
            InitializeComponent();
        }

        private void journalSalesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.journalSalesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantAppDataSet);

        }

        private void JournalForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantAppDataSet.Dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill(this.restaurantAppDataSet.Dishes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantAppDataSet.Waiters". При необходимости она может быть перемещена или удалена.
            this.waitersTableAdapter.Fill(this.restaurantAppDataSet.Waiters);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantAppDataSet.RestaurantLogs". При необходимости она может быть перемещена или удалена.
            this.restaurantLogsTableAdapter.Fill(this.restaurantAppDataSet.RestaurantLogs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantAppDataSet.JournalSales". При необходимости она может быть перемещена или удалена.
            this.journalSalesTableAdapter.Fill(this.restaurantAppDataSet.JournalSales);

        }

        private void onmain_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
