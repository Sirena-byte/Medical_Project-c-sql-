using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace medicalProject2
{
    public partial class EmployeesForm : Form
    {
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
        public EmployeesForm()
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            exitButtom.Visible = false;
            ClearField();
            
        }

        private void employysButton_Click(object sender, EventArgs e)
        {
            MedicalForm medicalForm = new MedicalForm();
            medicalForm.Show();
            this.Visible = false;
         //   ClearField();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            CreateColumn();//создаем таблицу
           RefreshDataGrid(dataGridView1);//выводим в нее данные из бд
            LoadComboBox("SELECT id_inst, name_inst FROM medical_inst", "name_inst", "id_inst", this.medicalInstField);//
            LoadComboBox("SELECT id_inst, name_inst FROM medical_inst", "name_inst", "id_inst", this.placeOfWorkField);//место работы

            LoadComboBox("SELECT * FROM positions_job", "name_position", "id_position", this.positionJobField);//профессия
            LoadComboBox("SELECT * FROM doctors_profiles", "profile_name", "id_profile", this.profileField);//профиль
            this.ClearField();
            idField.Visible = false;//скрываем поле id в форме изменения записи
           
           
        }

        private void CreateColumn()
        {
            dataGridView1.Columns.Add("id_employee", "id");//первое поле название поля в бд, второе так, как будет выводить таблица
            dataGridView1.Columns.Add("first_name", "ФИО");
            dataGridView1.Columns.Add("name_position", "Должность");
            dataGridView1.Columns.Add("name_specialisation", "Профиль");
            dataGridView1.Columns.Add("name_inst", "Место работы");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 290;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 250;
            dataGridView1.Columns[5].Visible = false;

        }

        protected void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0),
                (record.GetString(1) +" "+ record.GetString(2) + " " + record.GetString(3)) ,record.GetString(4) , record.GetString(5), record.GetString(6)
                , RowState.ModifietedNew);
        }
        //-------------------------------------------------РАБОТАЕТ--------------------------------------------------
        //метод выводит данные в таблицу
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = "SELECT id_employee, first_name, last_name, surname, name_position,profile_name, name_inst FROM employees JOIN positions_job ON employees.position_job = positions_job.id_position JOIN doctors_profiles ON employees.doctor_profile = doctors_profiles.id_profile JOIN medical_inst ON employees.place_of_work = medical_inst.id_inst ";
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

        private void NewsButton_Click(object sender, EventArgs e)
        {
            AddEmployeesForm addEmployeesForm = new AddEmployeesForm();
            addEmployeesForm.Show();
        }
        private void ClearField()
        {
            firstNameField.Text = "";
            lastNameField.Text = "";
            surnameField.Text = "";
            positionJobField.Text = "";
            profileField.Text = "";
            placeOfWorkField.Text = "";
            medicalInstField.Text = "Все организации";
        }

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
                string fio = row.Cells[1].Value.ToString();
                string[] fiO = fio.Split(' ');
                firstNameField.Text = fiO[0];
                if (fiO.Count() > 1)
                {
                    string lastName = fiO[1];
                    lastNameField.Text = lastName;
                    string surname = fiO[2];
                    surnameField.Text = surname;
                }
                positionJobField.Text = row.Cells[2].Value.ToString();
                profileField.Text = row.Cells[3].Value.ToString();
                placeOfWorkField.Text = row.Cells[4].Value.ToString();



            }
        }

        private void positionJobField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (positionJobField.SelectedValue.ToString() == "2")
            {
                profileField.Visible = true;
                label4.Visible = true;
                profileField.Text = "";

            }
            else
            {
                profileField.Visible = false;
                label4.Visible = false;
                //MessageBox.Show(profesionField.SelectedValue.ToString());//выводит индекс
            }
            
        }

        private void restartButtonn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearField();
        }
        //
        private void change()
        {
            var selectedRovIndex = dataGridView1.CurrentCell.RowIndex;//присваиваем значение текущего столбца и текущего индекса
            //var id = selectedRovIndex.ToString();
            var id = idField.Text;
            var firstname = firstNameField.Text + " " + lastNameField.Text + " " + surnameField.Text;
            var profession = positionJobField.Text;
            var profile = profileField.Text;
            var placeOfWork = placeOfWorkField.Text;

            //проверяем не пустая ли строка с определенным индексом в нулевом столбце
            if (dataGridView1.Rows[selectedRovIndex].Cells[0].Value.ToString() != string.Empty)
            {
                //проверяем тип вводимых данных, чтобы не было конфликта с базой данных
                //присваиваются значения текстбоксов нижней формы строке , то есть меняем данные в грид таблице
                dataGridView1.Rows[selectedRovIndex].SetValues(id, firstname, profession, profile,placeOfWork);//потом вернуть
                dataGridView1.Rows[selectedRovIndex].Cells[5].Value = RowState.Modifieted;

            }
        }
        private void changeButton_Click(object sender, EventArgs e)
        {
            change();
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
                //удадение не трогать - работает
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);//передаем значение айдишника
                    var deleteQuery = $"delete from employees where id_employee = {id}";

                    var command = new SqlCommand(deleteQuery, dbM.getConnection());
                    command.ExecuteNonQuery();
                    RefreshDataGrid(dataGridView1);
                }
                //--------------------------------------------------------------
                //------------изменение данных-----------------------
                if (rowState == RowState.Modifieted)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    string[] fullname = name.Split(' ');
                    string firstName = fullname[0];
                    /*var firstName = dataGridView1.Rows[index].Cells[1].Value.ToString();*/
                    string lastName = fullname[1];
                    /*var lastName = dataGridView1.Rows[index].Cells[1].Value.ToString();*/
                    string surname = fullname[2];
                    /*var surname = dataGridView1.Rows[index].Cells[1].Value.ToString();*/
                    var profession = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var profile = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var placeOfWork = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    //заносим измененные данные в базу данных
                    var changeQuery = $" update employees set first_name  = '{firstName}',last_name = '{lastName}', surname = '{surname}' , position_job = (select id_position from positions_job where name_position = '{profession}' ) ,place_of_work = (select id_inst from medical_inst where name_inst = '{placeOfWork}'), doctor_profile = (select id_profile from doctors_profiles where profile_name = '{profile}' ) where id_employee = '{id}'";

                    var command = new SqlCommand(changeQuery, dbM.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Изменения успешно сохранены!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGrid(dataGridView1);
                    ClearField();
                }
            }
            dbM.closeConnection();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            update();
        }
        //-----------------удаление-------------
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
        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        //------------------поиск-----------------------
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            
            string searchString = $"SELECT id_employee,first_name,last_name,surname,name_position,profile_name, name_inst FROM employees JOIN doctors_profiles ON employees.doctor_profile = doctors_profiles.id_profile JOIN positions_job ON employees.position_job = positions_job.id_position JOIN medical_inst ON employees.place_of_work = medical_inst.id_inst where concat(id_employee,first_name,last_name,surname,name_position,profile_name,name_inst)like '%" + searchField.Text + "%'";

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

        private void medicalInstField_SelectedIndexChanged(object sender, EventArgs e)
        {

            SearchMedical(dataGridView1);
            
        }

        private void SearchMedical(DataGridView dgw)
        {
            dgw.Rows.Clear();
            //MessageBox.Show(medicalInstField.Text); ;//выводит индекс
            var medical = medicalInstField.Text;
            string sqlString;
            sqlString = $"SELECT id_employee,first_name,last_name,surname,name_position,profile_name, name_inst FROM employees JOIN doctors_profiles ON employees.doctor_profile = doctors_profiles.id_profile JOIN positions_job ON employees.position_job = positions_job.id_position JOIN medical_inst ON employees.place_of_work = medical_inst.id_inst ";

            if (medical != "Все организации")
            {
                sqlString = $"SELECT id_employee,first_name,last_name,surname,name_position,profile_name, name_inst FROM employees JOIN doctors_profiles ON employees.doctor_profile = doctors_profiles.id_profile JOIN positions_job ON employees.position_job = positions_job.id_position JOIN medical_inst ON employees.place_of_work = medical_inst.id_inst where medical_inst.name_inst = '{medical}'";
            }
            SqlCommand command = new SqlCommand(sqlString, dbM.getConnection());

            dbM.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);//построчно выводим
            }
            reader.Close();
            dbM.closeConnection();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            AutorizMed autoriz = new AutorizMed();
            autoriz.Show();
            
        }
        private void checkRegister(bool register)
        {
            if (register)
            {
                MessageBox.Show("Успешно", "");
               
            }
            else
            {
                MessageBox.Show("не успешно!", "");
            }
        }
    }
}
