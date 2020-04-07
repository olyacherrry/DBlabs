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
    public partial class CategoryDishForm : Form
    {
        public CategoryDishForm()
        {
            InitializeComponent();
        }

        private void categoryDishesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoryDishesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantAppDataSet);

        }

        private void CategoryDishForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantAppDataSet.CategoryDishes". При необходимости она может быть перемещена или удалена.
            this.categoryDishesTableAdapter.Fill(this.restaurantAppDataSet.CategoryDishes);

        }

        private void onmain_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
