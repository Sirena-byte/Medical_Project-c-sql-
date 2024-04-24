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
using System.Xml.Linq;

namespace medicalProject2
{
    public partial class MedForm : Form
    {
        //состояние данных в таблице
        enum RowState
        {
            Existed,
            New,
            Modifieted,
            ModifietedNew,
            Deleted
        }
        MedicalDB dbM = new MedicalDB();

        int selectedRow;
        public MedForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            //idField.Visible = false;
        }

        private void MedForm_Load(object sender, EventArgs e)
        {
            CreateColumn();
            RefreshDataGrid(dataGridView1);

            LoadComboBox("SELECT * FROM category ", "name_category", "id_category", this.ucategoryField);
            //LoadComboBox("SELECT * FROM category", "name_category", "id_category", this.acategoryField);

            this.ClearFielda();
            this.ClearFieldu();
            idField.Visible = false;
        }
        private void CreateColumn()
        {
            dataGridView1.Columns.Add("id_inst", "id");//первое поле название поля в бд, второе так, как будет выводить таблица
            dataGridView1.Columns.Add("name_category", "Категория");
            dataGridView1.Columns.Add("name_inst", "Название");
            dataGridView1.Columns.Add("address_inst", "Адрес");
            dataGridView1.Columns.Add("phone_num", "Телефон");
            //dataGridView1.Columns.Add("first_name", "Руководитель");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 170;
            dataGridView1.Columns[2].Width = 400;
            dataGridView1.Columns[3].Width = 250;
            dataGridView1.Columns[4].Width = 250;
            //dataGridView1.Columns[5].Width = 280;
            dataGridView1.Columns[5].Visible = false;

        }

        protected void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState.ModifietedNew);
        }
        //метод очищает поля
        private void ClearFielda()
        {
            acategoryField.Text = "";
            anameField.Text = "";
            astreetField.Text = "";
            ahouseField.Text = "";
            aphoneField.Text = "";
            
        }
        private void ClearFieldu()
        {
            ucategoryField.Text = "";
            unameField.Text = "";
            ustreetField.Text = "";
            uhauseField.Text = "";
            uphoneField.Text = "";

        }

        //метод выводит данные в таблицу
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"SELECT id_inst,name_category,name_inst,address_inst,phone_inst FROM medical_inst JOIN category ON medical_inst.id_category = category.id_category where name_inst != 'Все организации'";

            SqlCommand command = new SqlCommand(queryString, dbM.getConnection());
            dbM.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            dbM.closeConnection();
        }
        //метод для того, чтобы при нажатии на ячейку, данные переносились в форму для изменения
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];//смотрим какой индекс у поля
                //проходим по полям

                //при нажатии на поле заполняются поля
                var selectedRovIndex = dataGridView1.CurrentCell.RowIndex;//присваиваем значение текущего столбца и текущего индекса

                idField.Text = row.Cells[0].Value.ToString();
                ucategoryField.Text = row.Cells[1].Value.ToString();
                unameField.Text = row.Cells[2].Value.ToString();
                //разделяем поле адреса на ячейки улица-дом
                string addr = row.Cells[3].Value.ToString();
                string[] address = addr.Split('-');
                string street = address[0];
                if (address.Count() > 1)
                {
                    string hause = address[1];
                    uhauseField.Text = hause;
                }
                ustreetField.Text = street;

                uphoneField.Text = row.Cells[4].Value.ToString();
                // supervisorField.Text = row.Cells[5].Value.ToString();
            }
        }

        //изменение данных в нижней панели
        private void change()
        {
            var selectedRovIndex = dataGridView1.CurrentCell.RowIndex;//присваиваем значение текущего столбца и текущего индекса
            //var id = selectedRovIndex.ToString();
            var id = idField.Text;
            var name = unameField.Text;
            var category = ucategoryField.Text;
            var address = ustreetField.Text + "-" + uhauseField.Text;
            var phone = uphoneField.Text;
            //var supervisor = supervisorField.Text;

            //проверяем не пустая ли строка с определенным индексом в нулевом столбце
            if (dataGridView1.Rows[selectedRovIndex].Cells[0].Value.ToString() != string.Empty)
            {
                //проверяем тип вводимых данных, чтобы не было конфликта с базой данных
                //присваиваются значения текстбоксов нижней формы строке , то есть меняем данные в грид таблице
                dataGridView1.Rows[selectedRovIndex].SetValues(id, category, name, address, phone);//потом вернуть
                dataGridView1.Rows[selectedRovIndex].Cells[5].Value = RowState.Modifieted;

            }
        }

        //вывод значений из бд в комбо бокс
        private void LoadComboBox(string query, string name, string value, ComboBox box)
        {
            dbM.openConnection();

            var command = new SqlCommand(query, dbM.getConnection());
            command.ExecuteNonQuery();
            command.CommandType = CommandType.Text;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            box.DisplayMember = name;
            box.ValueMember = value;
            box.DataSource = table;

            dbM.closeConnection();

        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $" SELECT id_inst,name_category,name_inst,address_inst,phone_inst FROM medical_inst JOIN category ON medical_inst.id_category = category.id_category where concat(id_inst,name_category,name_inst,address_inst,phone_inst)like '%" + searchField.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, dbM.getConnection());

            dbM.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);//построчно выводим
            }
            reader.Close();
            dbM.closeConnection();
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

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

        private void update()//метод в котором проверяем состояние строки
        {
            dbM.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;//передаем поле, где находится индекс

                if (rowState == RowState.Existed)
                    continue;
                //------------------------------------------------------------
                //удадение 
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);//передаем значение айдишника
                    MessageBox.Show("id= " + id);
                    var deleteQuery = $"delete from medical_inst where id_inst = {id}";

                    var command = new SqlCommand(deleteQuery, dbM.getConnection());
                    command.ExecuteNonQuery();
                    RefreshDataGrid(dataGridView1);
                }
                //--------------------------------------------------------------
                //------------изменение данных -----------------------
                if (rowState == RowState.Modifieted)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var category = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var address = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var phone = dataGridView1.Rows[index].Cells[4].Value.ToString();
                   

                    //заносим измененные данные в базу данных
                    var changeQuery = $"update medical_inst set id_category = (select id_category from  category where name_category = '{category}'),name_inst  = '{name}',address_inst = '{address}', phone_inst = '{phone}' where id_inst = '{id}'";

                    var command = new SqlCommand(changeQuery, dbM.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Изменения успешно сохранены!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGrid(dataGridView1);
                    ClearFieldu();
                    ClearFielda();
                }
            }
            dbM.closeConnection();
        }

        private void usaveButton_Click(object sender, EventArgs e)
        {
            change();
            update();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteRow();
            update();
            ClearFieldu();
        }

        private void asaveButton_Click(object sender, EventArgs e)
        {
            dbM.openConnection();

            //объявляем переменные, заполняем значениями из полей
            if (anameField.Text != string.Empty || acategoryField.Text != string.Empty || aphoneField.Text != string.Empty || astreetField.Text != string.Empty|| ahouseField.Text != string.Empty)
            {
                var id = idField.Text;
                string name = anameField.Text;
                int category = (int)acategoryField.SelectedValue;
                string address = astreetField.Text + "-" + ahouseField.Text;
                string phone = aphoneField.Text;
                
                var addQuery = $"insert into medical_inst(id_category,name_inst,address_inst, phone_inst) values ('{category}','{name}','{address}','{phone}')";
                var command = new SqlCommand(addQuery, dbM.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFielda();
                RefreshDataGrid(dataGridView1);
            }

            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dbM.closeConnection();
        }
    }
}
