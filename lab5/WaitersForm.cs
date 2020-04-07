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
    public partial class WaitersForm : Form
    {
        public WaitersForm()
        {
            InitializeComponent();
        }

        private void waitersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.waitersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantAppDataSet);

        }

        private void WaitersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantAppDataSet.Waiters". При необходимости она может быть перемещена или удалена.
            this.waitersTableAdapter.Fill(this.restaurantAppDataSet.Waiters);

        }

        private void onmain_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
