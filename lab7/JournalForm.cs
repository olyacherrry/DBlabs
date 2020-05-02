using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantAppDataSet.JournalSales". При необходимости она может быть перемещена или удалена.
            this.journalSalesTableAdapter.Fill(this.restaurantAppDataSet.JournalSales);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantAppDataSet.RestaurantLogs". При необходимости она может быть перемещена или удалена.
            this.restaurantLogsTableAdapter.Fill(this.restaurantAppDataSet.RestaurantLogs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantAppDataSet.Dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill(this.restaurantAppDataSet.Dishes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantAppDataSet.JournalSales". При необходимости она может быть перемещена или удалена.
            this.journalSalesTableAdapter.Fill(this.restaurantAppDataSet.JournalSales);

        }

        private void onmain_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource.EndEdit();
            textBox1.Text = Summa().ToString();
            this.journalSalesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantAppDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.journalSalesBindingSource.AddNew();
            textBox3.Text = DateTime.Now.ToString();
            textBox1.Text = "0,0";  
        }
        private double Summa()
        {
            double summa = 0;
            for(int i = 0; i < restaurantLogsDataGridView.Rows.Count; i++)
            {
                if (restaurantLogsDataGridView[1, i].Value != null)
                {
                    int amount = Convert.ToInt32(restaurantLogsDataGridView[1, i].Value);
                    RestaurantAppDataSet.DishesRow price =  restaurantAppDataSet.Dishes.FirstOrDefault(x => x.IdDish == Convert.ToInt32(restaurantLogsDataGridView[2, i].Value));
                    summa += (price.Price * amount);
                }
            }
            return summa;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.journalSalesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantAppDataSet);
        }
    }
}
