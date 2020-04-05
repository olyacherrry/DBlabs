using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {

        private const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\LearningBNTU\\6сем\\БазыДанных\\DBlabs\\DBlabs\\RestaurantApp.mdf;" +
            "Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void page1_btRead_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection(ConnectionString);
            const string cmd = "SELECT TOP 5 * FROM Waiters";
            var adapter = new SqlDataAdapter(cmd, con);

            var dataSet = new DataSet();
            adapter.Fill(dataSet, "Waiters");

            dataGridView1.DataSource = dataSet.Tables["Waiters"];

            var view2 = new DataView(dataSet.Tables["Waiters"]) { Sort = "FirstName" };
            dataGridView2.DataSource = view2;

            var view3 = new DataView(dataSet.Tables["Waiters"]) { Sort = "LastName" };
            dataGridView3.DataSource = view3;
        }

        private void page2_btRead_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection(ConnectionString);

            const string cmd = "SELECT * FROM Waiters";
            var adapter = new SqlDataAdapter(cmd, con);

            var dataSet = new DataSet();
            adapter.Fill(dataSet, "Waiters");

            var rowFilter = string.Empty;

            var item1 = listBox1.SelectedItem;
            var item2 = listBox2.SelectedItem;

            if (item1 != null) { rowFilter += $"({item1})"; }

            if (item2 != null)
            {
                if (item1 != null) { rowFilter += " and "; }
                rowFilter += $"({item2})";
            }

            var view1 = new DataView(dataSet.Tables["Waiters"])
            {
                RowFilter = rowFilter
            };
            dataGridView4.DataSource = view1;
        }

        private void page3_btRead_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection(ConnectionString);

            const string cmd = "SELECT * FROM Waiters";

            var adapter = new SqlDataAdapter(cmd, con);
            var dataSet = new DataSet();
            adapter.Fill(dataSet, "Waiters");

            var fullName = new DataColumn(
                "FullName", typeof(string), "FirstName+' '+LastName" );

            dataSet.Tables["Waiters"].Columns.Add(fullName);

            dataGridView5.DataSource = dataSet.Tables["Waiters"];

        }
    }
}
