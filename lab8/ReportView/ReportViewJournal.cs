using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8.ReportView
{
    public partial class ReportViewJournal : Form
    {
        public ReportViewJournal()
        {
            InitializeComponent();
        }

        private void ReportViewJournal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantAppDataSet.JournalSales". При необходимости она может быть перемещена или удалена.
            this.journalSalesTableAdapter.Fill(this.restaurantAppDataSet.JournalSales);

            this.reportViewer1.RefreshReport();
        }
    }
}
