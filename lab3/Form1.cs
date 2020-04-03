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

namespace lab3
{
    public partial class Form1 : Form
    {

        private const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\LearningBNTU\\6сем\\БазыДанных\\DBlabs\\DBlabs\\RestaurantApp.mdf;" +
            "Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantAppDataSet.Dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill(this.restaurantAppDataSet.Dishes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantAppDataSet.Waiters". При необходимости она может быть перемещена или удалена.
            this.waitersTableAdapter.Fill(this.restaurantAppDataSet.Waiters);

        }

        private void btFill_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection(ConnectionString);
            const string command = "SELECT * FROM Dishes";
            var adapter = new SqlDataAdapter(command, con);

            var dataSet = new DataSet();
            adapter.Fill(dataSet, "Dishes");

            listBox1.Items.Clear();

            foreach (DataRow row in dataSet.Tables["Dishes"].Rows)
            {
                var result = "" +
                             $"{row[0]}:  " +
                             $"[{row[1]}]  " +
                             $"[{row[2]}]  " +
                             $"[{row[3]}]  " ;
                listBox1.Items.Add(result);
            }

        }

        public void btProgramFill_Click(object sender, EventArgs e)
        {
            var restDataSet = new DataSet("RestaurentApp");
            var clientsTable = new DataTable("Dishes2");

            restDataSet.Tables.Add(clientsTable);

            var idColumn = new DataColumn("IdDish", typeof(int))
            {
                Unique = true,
                AllowDBNull = false,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1
            };

            var nameColumn = new DataColumn("NameDish", typeof(string));
            var priceColumn = new DataColumn("Price", typeof(decimal));
            var idCategoryColumn = new DataColumn("IdCategory", typeof(int))
            {
                DefaultValue = 1
            };

            clientsTable.Columns.Add(idColumn);
            clientsTable.Columns.Add(nameColumn);
            clientsTable.Columns.Add(priceColumn);
            clientsTable.Columns.Add(idCategoryColumn);

            clientsTable.PrimaryKey = new[] { clientsTable.Columns["IdDish"] };

            clientsTable.Rows.Add(null, "Цезарь", 10, 1);
            clientsTable.Rows.Add(null, "Бонито Ролл", 15, 1);
            clientsTable.Rows.Add(null, "Борщ", 5, 2);

            foreach (DataRow row in clientsTable.Rows)
            {
                var result = row.ItemArray
                    .Aggregate((current, cell) => current + $" [{cell}] ");
                listBox2.Items.Add(result);
            }
        }

        private void btReadTable_Click(object sender, EventArgs e)
        {
            dishesTableAdapter.Fill(RestaurantAppDataSet.Clients);
        }

        private void btAddClient_Click(object sender, EventArgs e)
        {
            DataTable dishesDataTable = RestaurantAppDataSet.Dishes;
            var row = dishesDataTable.NewRow();
            row[1] = textBox1.Text;
            row[2] = textBox2.Text;
            row[3] = textBox3.Text;
            row[4] = textBox4.Text;
            dishesDataTable.Rows.Add(row);
            dishesTableAdapter.Update(RestaurantAppDataSet.DishesRow);
        }
    }
}
