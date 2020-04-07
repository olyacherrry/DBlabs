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
    public partial class DishForm : Form
    {
        public DishForm()
        {
            InitializeComponent();
        }

        private void dishesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dishesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantAppDataSet);

        }

        private void DishForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantAppDataSet.Dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill(this.restaurantAppDataSet.Dishes);

        }

        private void onmain_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
