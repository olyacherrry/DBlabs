using Microsoft.Reporting.WinForms;
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
    public partial class ReportViewWaiter : Form
    {
        private string LastName;
        private string FirstName;
        public ReportViewWaiter(string lastName, string firstName)
        {
            InitializeComponent();
            LastName = lastName;
            FirstName = firstName;
        }

        private void ReportViewWaiter_Load(object sender, EventArgs e)
        {
            List<ReportParameter> parameters = new List<ReportParameter>();
            parameters.Add(new ReportParameter("LastName", LastName));
            parameters.Add(new ReportParameter("FirstName", FirstName));
            reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
