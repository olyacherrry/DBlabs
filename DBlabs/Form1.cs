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
using static System.String;

namespace lab2
{
    public partial class Form1 : Form

    {

        private const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\LearningBNTU\\6сем\\БазыДанных\\DBlabs\\DBlabs\\RestaurantApp.mdf;" +
            "Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            // Создание строки подключения
            var con = new SqlConnection(ConnectionString);

            // Создание команды
            var command = new SqlCommand
            {
                Connection = con,
                CommandType = CommandType.Text,
                CommandText = "SELECT * FROM Waiters"
            };

            con.Open();
            var reader = command.ExecuteReader();
            // Проход в цикле по записям 
            while (reader.Read())
            {
                var result = "" +
                             $"{reader.GetValue(0),4} " +
                             $"{reader.GetValue(1),20} " +
                             $"{reader.GetValue(2),20} " +
                             $"{reader.GetValue(3),20} " +
                             $"{reader.GetValue(4),20} ";
                listBox1.Items.Add(result);
            }

            // Закрытие DataReader
            reader.Close();
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btSum_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection(ConnectionString);
            // Создать команду
            var command = new SqlCommand("SELECT COUNT (*) FROM Waiters", con);
            con.Open();
            // Получить значение COUNT
            var countResult = (int)command.ExecuteScalar();

            label1.Text = @"Общее число офицантов: " + countResult;
            con.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            // название процедуры
            string sqlExpression = "InsertWaiter";
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "")
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlExpression, connection) { CommandType = CommandType.StoredProcedure };
                    
                    // параметр для ввода параметров официантов

                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@LastName", Value = textBox1.Text });
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@FirstName", Value = textBox2.Text });
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@Phone", Value = textBox4.Text });
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@Password", Value = textBox3.Text });

                    var result = cmd.ExecuteScalar();
                    // если нам не надо возвращать id
                    //var result = command.ExecuteNonQuery();

                    label3.Text = @"Новому сотруднику присвоен ID: " + result;
                }
            else
                MessageBox.Show("Заполните все поля");
        }
    }
}

