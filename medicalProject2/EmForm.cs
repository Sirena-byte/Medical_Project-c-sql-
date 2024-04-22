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
using static System.Net.Mime.MediaTypeNames;

namespace medicalProject2
{
   
    public partial class EmForm : Form
    {
        

        enum RowState
        {
            Existed,
            New,
            Modifieted,
            ModifietedNew,
            Deleted
        }
      
       
  
        
        int selectedRow;
        static int ID = 0;
        MedicalDB dbM;
        public EmForm()
        {
            

            
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            //ClearField();
        }

        private void EmForm_Load(object sender, EventArgs e)
        {
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            dbM = new MedicalDB();
            medicalAncor.Text = DataBank.name_medical;

            labellogin.Visible = false;
            labelpass.Visible = false;
            loginField.Visible = false;
            passField.Visible = false;
            aloginField.Visible = false;
            apassField.Visible = false;
            apasslabel.Visible = false;
            aloginlabel.Visible = false;

            CreateColumn();//создаем таблицу
            RefreshDataGrid(dataGridViewEmpl);
            //получаем категорию и выводим комбобоксы согласно категории
            string category = DataBank.category_inst;
            string queryString = "";
            //выбираем профессии только нужных категорий
            if(category == "аптека")
            {
                queryString = "SELECT * FROM positions_job where name_position = 'водитель' or  name_position = 'заведующий' or name_position = 'провизор'";
            }
            else if (category == "больница")
            {
                queryString = "SELECT * FROM positions_job where name_position != 'провизор' and  name_position != 'регистратор'";
            }
            else if (category == "поликлиника")
            {
                queryString = "SELECT * FROM positions_job where name_position != 'провизор'";
            }
            else
            {
                queryString = "SELECT * FROM positions_job ";//все профессии на случай тех предприятий, где нет еще должности(лаборатории и пр)
            }
            
            
           
            LoadComboBox(queryString, "name_position", "id_position", this.uProfessionField);//профессия
            LoadComboBox("SELECT * FROM doctors_profiles where profile_name != ''", "profile_name", "id_profile", this.uProfileField);//профиль
            //LoadComboBox("SELECT * FROM doctors_profiles", "profile_name", "id_profile", this.aProfileField);
            LoadComboBox(queryString, "name_position", "id_position", this.aProfessionField);

            this.ClearField();
            this.aClearField();
            idField.Visible = false;//скрываем поле id в форме изменения записи
            label8.Visible = false;
            uProfileField.Visible = false;
            aProfileField.Visible = false;
            label10.Visible = false;

            if(DataBank.id_medical != 16)//id_medical=16 все организации для суперадмина
            {
                //allMedicalButton.Visible = false;
            }
        }
        private void CreateColumn()
        {
            dataGridViewEmpl.Columns.Add("id_employee", "id");//первое поле название поля в бд, второе так, как будет выводить таблица
            dataGridViewEmpl.Columns.Add("first_name", "ФИО");
            dataGridViewEmpl.Columns.Add("name_position", "Должность");
            dataGridViewEmpl.Columns.Add("name_specialisation", "Профиль");
            dataGridViewEmpl.Columns.Add("name_inst", "Место работы");
            dataGridViewEmpl.Columns.Add("IsNew", String.Empty);
            dataGridViewEmpl.Columns[0].Visible = false;
            dataGridViewEmpl.Columns[1].Width = 290;
            dataGridViewEmpl.Columns[2].Width = 250;
            dataGridViewEmpl.Columns[3].Width = 220;
            dataGridViewEmpl.Columns[4].Width = 350;
            dataGridViewEmpl.Columns[5].Visible = false;

        }

        protected void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0),
                (record.GetString(1) + " " + record.GetString(2) + " " + record.GetString(3)), record.GetString(4), record.GetString(5), record.GetString(6)
                , RowState.ModifietedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString;
            if (DataBank.id_medical != 16) {
               queryString = $"SELECT id_employee, first_name, last_name, surname, name_position,profile_name, name_inst FROM employees JOIN positions_job ON employees.position_job = positions_job.id_position JOIN doctors_profiles ON employees.doctor_profile = doctors_profiles.id_profile JOIN medical_inst ON employees.place_of_work = medical_inst.id_inst WHERE name_inst ='{medicalAncor.Text}'";
            }
            else
            {
                queryString = $"SELECT id_employee, first_name, last_name, surname, name_position,profile_name, name_inst FROM employees JOIN positions_job ON employees.position_job = positions_job.id_position JOIN doctors_profiles ON employees.doctor_profile = doctors_profiles.id_profile JOIN medical_inst ON employees.place_of_work = medical_inst.id_inst";
            }
            
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
        private void ClearField()
        {
            uFirstNameField.Text = "";
            uLastNameField.Text = "";
            uSurnameField.Text = "";
            uProfessionField.Text = "";
            uProfileField.Text = "";
        }
        private void aClearField()
         {
             aFirstNameField.Text = string.Empty;
             aLastNameField.Text = string.Empty;
             aSurnameField.Text = string.Empty;
             aProfessionField.Text = string.Empty;
             aProfileField.Text = string.Empty;
            aloginField.Text = string.Empty;
            aloginField.Visible = false;
            aloginlabel.Visible = false;
            apassField.Text = string.Empty;
            apassField.Visible = false;
            apasslabel.Visible = false;
         }


        private void uProfessionField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uProfessionField.SelectedValue.ToString() == "2")
            {
                uProfileField.Visible = true;
                label8.Visible = true;
                uProfileField.Text = "";

            }
            else
            {
                uProfileField.Visible = false;
                label8.Visible = false;
            }
        }

        private void aProfessionField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aProfessionField.SelectedValue.ToString() == "2")
            {
                aProfileField.Visible = true;
                label10.Visible = true;
                aProfileField.Text = "";


            }
            else
            {
                aProfileField.Visible = false;
                label10.Visible = false;
            }
            //MessageBox.Show(aProfessionField.SelectedValue.ToString());
            //если выбрана специальность врач, регистратор или провизор, то задаем логин и пароль( для простоты тестирования заданы значения по умолчанию для логина)
            if(aProfessionField.SelectedValue.ToString()=="2"|| aProfessionField.SelectedValue.ToString()=="13"|| aProfessionField.SelectedValue.ToString() == "14")
            {
                loginField.Visible = true;
                passField.Visible = true;
                labellogin.Visible = true;
                passField.Visible = true;
                switch (aProfessionField.SelectedValue)
                {
                    case 13:
                        loginField.Text = "reg";
                        break;
                    case 2:
                        loginField.Text = "doc";
                        break;
                    case 14:
                        loginField.Text = "prov";
                        break;
                    default:
                        break;

                }
            }
            else
            {
                loginField.Visible = false;
                passField.Visible = false;
                labellogin.Visible = false;
                passField.Visible = false;
                loginField.Text = "";
            }
        }

        private void dataGridViewEmpl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            aloginField.Text = string.Empty;
            aloginField.Visible = false;
            aloginlabel.Visible = false;
            apassField.Text = string.Empty;
            apassField.Visible = false;
            apasslabel.Visible = false;
            
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DataGridViewRow row = dataGridViewEmpl.Rows[selectedRow];//смотрим какой индекс у поля
                //проходим по полям

                //при нажатии на поле заполняются поля
                var selectedRovIndex = dataGridViewEmpl.CurrentCell.RowIndex;//присваиваем значение текущего столбца и текущего индекса
                                                                          // MessageBox.Show(upositionJobField.SelectedValue.ToString() + "=" + upositionJobField.Text );//выводит индекс
                idField.Text = row.Cells[0].Value.ToString();
                string fio = row.Cells[1].Value.ToString();
                string[] fiO = fio.Split(' ');
                uFirstNameField.Text = fiO[0];
                if (fiO.Count() > 1)
                {
                    string lastName = fiO[1];
                    uLastNameField.Text = lastName;
                    string surname = fiO[2];
                    uSurnameField.Text = surname;
                }

                uProfessionField.Text = row.Cells[2].Value.ToString();
                uProfileField.Text = row.Cells[3].Value.ToString();
               
                    if (uProfessionField.Text == "врач" || uProfessionField.Text == "регистратор") 
                {
                    if (uProfessionField.Text == "врач")
                    {
                        uProfileField.Visible = true;
                        label8.Visible = true;
                    }
                    dbM.openConnection();
                    string queryStr = $"select id_user from register where id_empl = '{int.Parse(idField.Text)}'";
                    SqlCommand command = new SqlCommand(queryStr, dbM.getConnection());
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();

                    if (reader.HasRows)
                    {
                        reader.Close();
                    }
                   
                    else
                    {
                        DialogResult dialog = MessageBox.Show("это " + uProfessionField.Text + " и у него нет аккаунта. Хотите создать аккаунт?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.Yes)
                        {
                            try
                            {
                                MessageBox.Show("хорошо, задаем пароль");
                                aloginField.Visible = true;
                                apassField.Visible = true;
                                aloginlabel.Visible = true;
                                apasslabel.Visible = true;


                            }
                            catch
                            {

                            }
                        }
                        else
                        {
                            MessageBox.Show("ну как хочешь...");
                        }
                    }
                    reader.Close();
                    dbM.closeConnection();
                }
                else
                {
                    uProfileField.Visible = false;
                    label8.Visible = false;
                }
            }
        }


        private void restartButtonn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewEmpl);
            ClearField();
        }
        //
        private void change()
        {
            var selectedRovIndex = dataGridViewEmpl.CurrentCell.RowIndex;//присваиваем значение текущего столбца и текущего индекса
            //var id = selectedRovIndex.ToString();
            var id = idField.Text;
            var firstname = uFirstNameField.Text + " " + uLastNameField.Text + " " + uSurnameField.Text;
            var profession = uProfessionField.Text;
            var profile = uProfileField.Text;
            var placeOfWork = medicalAncor.Text;

            //проверяем не пустая ли строка с определенным индексом в нулевом столбце
            if (dataGridViewEmpl.Rows[selectedRovIndex].Cells[0].Value.ToString() != string.Empty)
            {
                //проверяем тип вводимых данных, чтобы не было конфликта с базой данных
                //присваиваются значения текстбоксов нижней формы строке , то есть меняем данные в грид таблице
                dataGridViewEmpl.Rows[selectedRovIndex].SetValues(id, firstname, profession, profile, placeOfWork);//потом вернуть
                dataGridViewEmpl.Rows[selectedRovIndex].Cells[5].Value = RowState.Modifieted;

            }
        }

        private void update()//метод в котором проверяем состояние строки
        {
            dbM.openConnection();

            for (int index = 0; index < dataGridViewEmpl.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridViewEmpl.Rows[index].Cells[5].Value;//передаем поле, где находится индекс

                if (rowState == RowState.Existed)
                    continue;
                //------------------------------------------------------------
                //удадение не трогать - работает
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridViewEmpl.Rows[index].Cells[0].Value);//передаем значение айдишника
                   
                    DialogResult dialog = MessageBox.Show("Вы уверенычто хотите удалить запись?", "", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        try
                        {
                            var deleteQuery = $"delete from employees where id_employee = {id}";
                            var command = new SqlCommand(deleteQuery, dbM.getConnection());
                            command.ExecuteNonQuery();

                        }
                        catch
                        {//если удаляем пользователя, у которого есть акк, то удаляем и акк
                            var deleteQuery = $"delete from register where id_empl = {id}";
                            var command = new SqlCommand(deleteQuery, dbM.getConnection());
                            deleteQuery = $"delete from employees where id_employee = {id}";
                            var command2 = new SqlCommand(deleteQuery, dbM.getConnection());
                            command.ExecuteNonQuery();
                            command2.ExecuteNonQuery();

                        }
                       
                    }

                    dbM.closeConnection();
                    RefreshDataGrid(dataGridViewEmpl);
                }
                //--------------------------------------------------------------
                //------------изменение данных-----------------------
                if (rowState == RowState.Modifieted)
                {
                    var id = dataGridViewEmpl.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridViewEmpl.Rows[index].Cells[1].Value.ToString();
                    string[] fullname = name.Split(' ');
                    string firstName = fullname[0];
                    string lastName = fullname[1];
                    string surname = fullname[2];
                    var profession = dataGridViewEmpl.Rows[index].Cells[2].Value.ToString();
                    var profile = dataGridViewEmpl.Rows[index].Cells[3].Value.ToString();
                    var placeOfWork = dataGridViewEmpl.Rows[index].Cells[4].Value.ToString();
                    

                    //заносим измененные данные в базу данных
                    var changeQuery = $" update employees set first_name  = '{firstName}',last_name = '{lastName}', surname = '{surname}' , position_job = (select id_position from positions_job where name_position = '{profession}' ) ,place_of_work = (select id_inst from medical_inst where name_inst = '{placeOfWork}'), doctor_profile = (select id_profile from doctors_profiles where profile_name = '{profile}' ) where id_employee = '{id}'";

                    var command = new SqlCommand(changeQuery, dbM.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Изменения успешно сохранены!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGrid(dataGridViewEmpl);
                    ClearField();
                }
            }
            dbM.closeConnection();
        }

        private void uSaveButton_Click(object sender, EventArgs e)
        {
          
            if(apassField.Visible == true && aloginField.Visible == true)
            {
                if(apassField.Text == "" || aloginField.Text == "")
                {
                    MessageBox.Show("вы не ввели пароль или логин. попробуйте еще раз");
                }
                else
                {
                    var pass = apassField.Text;
                    var log = aloginField.Text;
                    try
                    {
                        dbM.openConnection();
                        string queryStr = $"insert into register (login_user,password_user,id_empl) values ('{log}','{pass}','{int.Parse(idField.Text)}')";
                        var command = new SqlCommand(queryStr, dbM.getConnection());
                        command.ExecuteNonQuery();

                        MessageBox.Show("Аккаунт успешно создан!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        aloginField.Text = string.Empty;
                        aloginField.Visible = false;
                        aloginlabel.Visible = false;
                        apassField.Text = string.Empty;
                        apassField.Visible = false;
                        apasslabel.Visible = false;
                        update();
                        
                    }
                    catch
                    {
                        MessageBox.Show("Придумайте другой пароль!");
                    }
                }
            }
            else
            {
                
                change();
                update();
                MessageBox.Show("я во втором если");
                //если не заполнены данные, то сюда не заходит
            }
            dbM.closeConnection();
        }

        //-----------------удаление-------------
        private void deleteRow()
        {
            int index = dataGridViewEmpl.CurrentCell.RowIndex;//передаем строку на которой находимся
            dataGridViewEmpl.Rows[index].Visible = false;//скрываем поле


            if (dataGridViewEmpl.Rows[index].Cells[0].Value.ToString() != string.Empty)//есла ячейка нулевая, значит это айдишник и мы берем это значение, тогда
            {
                dataGridViewEmpl.Rows[index].Cells[5].Value = RowState.Deleted;//присваиваем индекс, который находится в крайней ячейке( и если он не нулевой, то сть есть что удалять)
            }
            return;
        }

        private void deliteButton_Click(object sender, EventArgs e)
        {
            deleteRow();
            update();
        }

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
            Search(dataGridViewEmpl);
        }

        private void aSaveButton_Click(object sender, EventArgs e)
        {
            dbM.openConnection();

            //объявляем переменные, заполняем значениями из полей
            if (aFirstNameField.Text != string.Empty || aLastNameField.Text != string.Empty || aSurnameField.Text != string.Empty)//если поля не пустые
            {
                var firstName = aFirstNameField.Text;
                var lastName = aLastNameField.Text;
                var surname = aSurnameField.Text;
                int profession = (int)aProfessionField.SelectedValue;
                int profile;
                if (profession != 2)
                {
                    profile = 11;//если не врач, то профиля нет и не выводим
                }

                else { 
                    profile = (int)aProfileField.SelectedValue;
                }
                if (profession == 2 || profession == 13 || profession == 14)//если это врач или регистратор или провизор, то задаем логин и пароль
                {
                    if (loginField.Text != "" && passField.Text != "")//если логин и пароль заполнены
                    {
                        if (ID == 0)
                        {
                            //то отправляем запрос на добавление работника
                            int placeOfWork = DataBank.id_medical;
                            var addQuery = $"insert into employees(first_name,last_name,surname, position_job, doctor_profile,place_of_work) OUTPUT Inserted.id_employee  values ('{firstName}','{lastName}','{surname}','{profession}','{profile}','{placeOfWork}')";
                            var command = new SqlCommand(addQuery, dbM.getConnection());

                            string idS = command.ExecuteScalar().ToString();//получаем ид только что добавленной строки
                            ID = int.Parse(idS);
                            //command.ExecuteNonQuery();
                        }
                        try
                        {
                            var addQuery = $"insert into register (login_user,password_user,id_empl) values ('{loginField.Text}','{passField.Text}','{ID}')";
                            var command2 = new SqlCommand(addQuery, dbM.getConnection());
                            command2.ExecuteNonQuery();
                            //MessageBox.Show("id=" + ID);
                            //OUTPUT Inserted.id_employee 
                            MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ID = 0;
                            passField.Text = "";
                            aClearField();
                            RefreshDataGrid(dataGridViewEmpl);
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка! Придумайте другой пароль...","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните логин и пароль", "");
                    }
                }
                else if(profession != 2 || profession != 13 || profession != 14)
                {
                    int placeOfWork = DataBank.id_medical;
                    var addQuery = $"insert into employees(first_name,last_name,surname, position_job, doctor_profile,place_of_work) values ('{firstName}','{lastName}','{surname}','{profession}','{profile}','{placeOfWork}')";
                    var command = new SqlCommand(addQuery, dbM.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    aClearField();
                    RefreshDataGrid(dataGridViewEmpl);
                }
                
            }

            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            dbM.closeConnection();
        }

        private void allMedicalButton_Click(object sender, EventArgs e)
        {
            MedForm medical = new MedForm();
            this.Hide();
            medical.ShowDialog();
            this.Show();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void aProfileField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
