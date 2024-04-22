using Microsoft.Win32;
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


namespace medicalProject2
{
    
    public partial class AutorizMed : Form
    {

     
        MedicalDB dbM = new MedicalDB();
        public AutorizMed()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AutorizMed_Load(object sender, EventArgs e)
        {

            closePass.Visible = false;
            passwordField.MaxLength = 50;
            loginField.MaxLength = 50;

        }
       

        private void autorizButton_Click(object sender, EventArgs e)
        {
            dbM.openConnection();
            var loginUser = loginField.Text;
            var passwordUser = passwordField.Text;

            //выбрать название и ид
            /*string querySrting = $"select name_inst, id_inst,name_category from register join medical_inst on id_med = id_inst and login_user= '{loginUser}' and password_user ='{passwordUser}'join category on category.id_category = medical_inst.id_category";*/
            //выбираем название учреждения, ид учреждения, название категории, ФИО пользователя, ид пользователя, должность пользователя
            string querySQLstring = $"select id_inst, name_category, name_inst, concat_ws(' ',first_name,last_name,surname) as fullname ,id_employee,name_position, profile_name from medical_inst join category on category.id_category = medical_inst.id_category join employees on place_of_work = id_inst\r\njoin positions_job on id_position = position_job join doctors_profiles on id_profile = doctor_profile join register on  login_user = '{loginUser}' and password_user = '{passwordUser}' and id_empl = id_employee";
           
            SqlCommand command = new SqlCommand(querySQLstring, dbM.getConnection());
          //считываем данные в ридер
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)//если ридер содержит строки
            {
                Object med = reader[2].ToString();//название учреждения
                Object id_med = reader[0].ToString();//ид учреждения
                Object cat = reader[1].ToString();//категория
                Object allNameUser = reader[3].ToString();//фио пользователя
                Object id_user = reader[4].ToString();//ид пользователя
                Object profession = reader[5].ToString();//профессия
                Object profile = reader[6].ToString();//профиль
               // MessageBox.Show("значение= " + med + " id= " + id_med);
                reader.Close();//закрываем ридер

                if (med != null)
                {
                    
                    DataBank.name_medical = med.ToString();//получаем пользователя организации и передаем полученные данные в класс
                    DataBank.id_medical = int.Parse(id_med.ToString());//получаем ид организации
                    DataBank.category_inst = cat.ToString();//получаем категорию учреждения
                    DataBank.full_name_user = allNameUser.ToString();
                    DataBank.id_user = int.Parse(id_user.ToString());
                    DataBank.profession_user = profession.ToString();
                    DataBank.profile_user = profile.ToString();

                    
                }
                switch (DataBank.profession_user)
                {
                    case "директор":
                        {
                            EmForm em = new EmForm();
                            this.Hide();
                            em.ShowDialog();
                            this.Show();
                            break;
                        }
                    case "заведующий":
                        {
                            EmForm em = new EmForm();
                            this.Hide();
                            em.ShowDialog();
                            this.Show();
                            break;
                        }
                    case "врач":
                        {
                            DocForm doc = new DocForm();
                            this.Hide();
                            doc.ShowDialog();
                            this.Show();
                            break;
                        }
                    case "регистратор":
                        {
                            PatientsForm1 patients = new PatientsForm1();
                            this.Hide();
                            patients.ShowDialog();
                            this.Show();
                            break;
                        }
                }

                
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dbM.closeConnection();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            passwordField.Text = "";
            loginField.Text = "";
        }

        private void closePass_Click(object sender, EventArgs e)
        {
            passwordField.UseSystemPasswordChar = false;
            openPass.Visible = true;
            closePass.Visible = false;
        }

        private void openPass_Click(object sender, EventArgs e)
        {
            passwordField.UseSystemPasswordChar = true;
            openPass.Visible = false;
            closePass.Visible = true;
        }

        private void medicalField_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(medicalField.Text + "=" + medicalField.SelectedValue);

        }
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
    }
}
