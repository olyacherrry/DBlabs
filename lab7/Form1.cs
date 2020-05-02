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
    public partial class Form1 : Form
    {
        WaitersForm waitersForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void waitersbutton_Click(object sender, EventArgs e)
        {
            if (waitersForm == null || waitersForm.IsDisposed) //Если Форма отсутствует или не определена, 
                waitersForm = new WaitersForm();  // то создать форму
            waitersForm.Show();              //открыть форму
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

        private void button1_Click(object sender, EventArgs e)
        {
            connectedTables form2 = new connectedTables();
            form2.ShowDialog();
        }
    }
}
