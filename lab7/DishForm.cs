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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantAppDataSet.CategoryDishes". При необходимости она может быть перемещена или удалена.
            this.categoryDishesTableAdapter.Fill(this.restaurantAppDataSet.CategoryDishes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantAppDataSet.Dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill(this.restaurantAppDataSet.Dishes);

        }

        private void onmain_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            this.dishesBindingSource.MoveLast();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            this.dishesBindingSource.MovePrevious();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.dishesBindingSource.MoveNext();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            this.dishesBindingSource.RemoveCurrent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.dishesBindingSource.AddNew();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dishesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantAppDataSet);
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            this.dishesBindingSource.MoveFirst();
        }

        private void listOfCategories_Click(object sender, EventArgs e)
        {
            CategoryDishForm categoryDishForm = new CategoryDishForm();
            if (categoryDishForm.ShowDialog() == DialogResult.OK)
            {
                this.categoryDishesTableAdapter.Fill(this.restaurantAppDataSet.CategoryDishes);
            }
        }
    }
}
