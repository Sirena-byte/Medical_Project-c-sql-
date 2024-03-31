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
using System.Drawing.Text;

namespace medicalProject2
{
    enum RowState
    {
        Existed,
        New,
        Modifieted,
        ModifietedNew,
        Deleted
    }
    public partial class GridForm : Form
    {
        DB db = new DB();

        int selectedRow;
        public GridForm()
        {
            InitializeComponent();
        }

        private void CreateColumn()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("type_of", "Тип товара");
            dataGridView1.Columns.Add("count_of", "Количество");
            dataGridView1.Columns.Add("postavka", "Поставщик");
            dataGridView1.Columns.Add("price", "Цена");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[5].Visible = false;

        }
        private void ReadSingleRow(DataGridView dgw,IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0),record.GetString(1),record.GetInt32(2),record.GetString(3),record.GetInt32(4),RowState.ModifietedNew);
        }
        //метод выводит данные в таблицу
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from products";

            SqlCommand command = new SqlCommand(queryString, db.getConnection());
            db.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void GridForm_Load(object sender, EventArgs e)
        {
            CreateColumn();
            RefreshDataGrid(dataGridView1);


        }
        //метод для того, чтобы при нажатии на ячейку, данные переносились в форму для изменения
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(e.RowIndex >= 0)//если поле есть в таблице
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];//смотрим какой индекс у поля
                //проходим по полям

                //при нажатии на поле заполняются поля
                idField.Text = row.Cells[0].Value.ToString();
                typeProductField.Text = row.Cells[1].Value.ToString();
                countField.Text = row.Cells[2].Value.ToString();
                postavkaField.Text = row.Cells[3].Value.ToString();
                priceField.Text = row.Cells[4].Value.ToString();

            }
        }
        //метод перезагрузки
        private void restartButtonn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void NewsButton_Click(object sender, EventArgs e)
        {
            AddForm addfrm = new AddForm();
            addfrm.Show();

        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from products where concat (id, type_of,count_of,postavka,price) like '%" + searchField.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, db.getConnection());

            db.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);//построчно выводим
            }
            reader.Close();

        }
        //метод удаления
       private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;//передаем строку на которой находимся
            dataGridView1.Rows[index].Visible = false;//скрываем поле


            if (dataGridView1.Rows[index].Cells[0].Value.ToString() != string.Empty)//есла ячейка нулевая, значит это айдишник и мы берем это значение, тогда
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;//присваиваем индекс, который находится в крайней ячейке( и если он не нулевой, то сть есть что удалять)
            }
            return;
        }


        private void update()
        {
            db.openConnection();

            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;//передаем поле, где находится индекс

                if (rowState == RowState.Existed)
                    continue;

                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);//передаем значение айдишника
                    var deleteQuery = $"delete from products where id = {id}";

                    var command = new SqlCommand(deleteQuery, db.getConnection());
                    command.ExecuteNonQuery();
                }
                if(rowState == RowState.Modifieted)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var type = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var count = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var postav = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var price = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"update products set type_of = '{type}', count_of = '{count}',postavka = '{postav}', price = '{price}' where id = '{id}'";

                    var command = new SqlCommand(changeQuery, db.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            db.closeConnection();
        }
        private void searchField_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

       
        private void saveButton_Click(object sender, EventArgs e)
        {
            update();
        }
        //изменение данных происходит из нижней формы
        private void change()
        {
            var selectedRovIndex = dataGridView1.CurrentCell.RowIndex;//присваиваем значение текущего столбца и текущего индекса
            var id = idField.Text;
            var type = typeProductField.Text;
            var count = countField;
            var postav = postavkaField;
            int price;

            //проверяем не пустая ли строка с определенным индексом в нулевом столбце
            if (dataGridView1.Rows[selectedRovIndex].Cells[0].Value.ToString() != string.Empty)
            {
                //проверяем тип вводимых данных, чтобы не было конфликта с базой данных
                if(int.TryParse(priceField.Text, out price))
                {
                    //присваиваются значения текстовых чекбоксов нижней формы
                    dataGridView1.Rows[selectedRovIndex].SetValues(id, type, count, postav, price);
                    dataGridView1.Rows[selectedRovIndex].Cells[5].Value = RowState.Modifieted;
                }
                else
                {
                    MessageBox.Show("Цена должна иметь цифровой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            change();
        }
    }
}
