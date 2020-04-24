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

        private const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Labs\\DBlabs\\DBlabs\\RestaurantApp.mdf;" +
            "Integrated Security=True";
        //RestaurantAppDataSet restaurantAppDataSet = new RestaurantAppDataSet();

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
            var restDataSet = new DataSet("Restaurant");
            var dishesTable = new DataTable("Dishes");

            restDataSet.Tables.Add(dishesTable);

            var idColumn = new DataColumn("IdDish", typeof(int))
            {
                //Unique = true,
                AllowDBNull = false,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1
            };

            var nameColumn = new DataColumn("NameDish", typeof(string));
            var priceColumn = new DataColumn("Price", typeof(float));
            var idCategoryColumn = new DataColumn("IdCategory", typeof(int))
            {
                DefaultValue = 1
            };

            dishesTable.Columns.Add(idColumn);
            dishesTable.Columns.Add(nameColumn);
            dishesTable.Columns.Add(priceColumn);
            dishesTable.Columns.Add(idCategoryColumn);

            dishesTable.PrimaryKey = new[] { dishesTable.Columns["IdDish"] };

            dishesTable.Rows.Add(null, "Цезарь", 10, 1);
            dishesTable.Rows.Add(null, "Бонито Ролл", 15, 1);
            dishesTable.Rows.Add(null, "Борщ", 5, 2);

            foreach (DataRow row in dishesTable.Rows)
            {
                var result = row.ItemArray
                    .Aggregate((current, cell) => current + $" [{cell}] ");
                listBox2.Items.Add(result);
            }
        }

        private void btReadTable_Click(object sender, EventArgs e)
        {
            _ = dishesTableAdapter.Fill(restaurantAppDataSet.Dishes);
        }

        private void btAddClient_Click(object sender, EventArgs e)
        {
            DataTable dishesDataTable = restaurantAppDataSet.Dishes;
            var row = dishesDataTable.NewRow();
            row[0] = textBox1.Text;
            row[1]= textBox2.Text;
            row[2] = textBox3.Text;
            row[3] = textBox4.Text;
            dishesDataTable.Rows.Add(row);
            dishesTableAdapter.Update(restaurantAppDataSet.Dishes);
        }
    }
}
