using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace medicalProject2
{
   
    public partial class AddForm : Form
    {
        DB db = new DB();
        public AddForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            db.openConnection();

            //объявляем переменные, заполняем значениями из полей
            var type = typeProductField.Text;
            var count = countField.Text;
            var postav = postavkaField.Text;
            int price;

            //проверка на тип
            if(int.TryParse(priceField.Text,out price))
            {
                var addQuery = $"insert into products (type_of, count_of,postavka,price) values ('{type}','{count}','{postav}','{price}')";
                var command = new SqlCommand(addQuery, db.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                MessageBox.Show("Цена должна иметь цифровой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.closeConnection();
        }
    }
}
