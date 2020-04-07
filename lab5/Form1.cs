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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void waitersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.waitersBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.restaurantAppDataSet);

        //}

        private void waitersbutton_Click(object sender, EventArgs e)
        {
            WaitersForm waitersForm = new WaitersForm();
            waitersForm.Show();
        }

        private void dishesbutton_Click(object sender, EventArgs e)
        {
            DishForm dishForm = new DishForm();
            dishForm.Show();
        }

        private void dishcategorybutton_Click(object sender, EventArgs e)
        {
            CategoryDishForm categoryDishForm = new CategoryDishForm();
            categoryDishForm.Show();
        }

        private void sales_button_Click(object sender, EventArgs e)
        {
            JournalForm journalForm = new JournalForm();
            journalForm.Show();
        }
    }
}
