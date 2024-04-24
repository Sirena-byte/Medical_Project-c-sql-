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

            String querystr = "";
            try
            {


                if (loginUser != "" && passwordUser != "")
                {
                    querystr = $"select id_empl from register where login_user = '{loginUser}' and password_user =  '{passwordUser}' ";
                    SqlCommand command;

                    command = new SqlCommand(querystr, dbM.getConnection());
                    //считываем данные в ридер
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)//если ридер содержит строки
                    {
                        Object id_user = reader[0].ToString();
                        DataBank.id_user = int.Parse(id_user.ToString());

                        reader.Close();

                        querystr = $"select concat_ws(' ', first_name,last_name,surname) as fullname, position_job, doctor_profile,place_of_work, profile_name, name_position from employees join doctors_profiles on id_profile = doctor_profile join positions_job on id_position = position_job where id_employee = '{DataBank.id_user}'";

                        command = new SqlCommand(querystr, dbM.getConnection());
                        //считываем данные в ридер
                        SqlDataReader reader2 = command.ExecuteReader();
                        reader2.Read();


                        if (reader2.HasRows)//если ридер содержит строки
                        {
                            Object allNameUser = reader2[0].ToString();//фио пользователя
                            Object id_profession = reader2[1].ToString();//профессия сотрудника
                            Object profile = reader2[2].ToString();//профиль врача
                            Object id_med = reader2[3].ToString();//ид учреждения
                           
                            Object name_profil = reader2[4].ToString();//профиль
                            Object name_profes = reader2[5].ToString();//должность

                            DataBank.id_profession_user = int.Parse(id_profession.ToString());
                            DataBank.id_profile_user = int.Parse(profile.ToString());
                            DataBank.full_name_user = allNameUser.ToString();
                            DataBank.id_medical = int.Parse(id_med.ToString());
                            DataBank.profession_user = name_profes.ToString();
                            DataBank.profile_user = name_profil.ToString();

                        }
                        reader2.Close();


                        querystr = $"select id_category, name_inst from medical_inst where id_inst = '{DataBank.id_medical}'";
                        command = new SqlCommand(querystr, dbM.getConnection());
                        //считываем данные в ридер
                        SqlDataReader reader3 = command.ExecuteReader();
                        reader3.Read();

                        if (reader3.HasRows)//если ридер содержит строки
                        {
                            Object id_category_med = reader3[0].ToString();//ид категории учреждения
                            Object name_inst = reader3[1].ToString();//название учреждения
                            DataBank.id_category_inst = int.Parse(id_category_med.ToString());
                            DataBank.name_medical = name_inst.ToString();
                        }
                        reader3.Close();
                        if (DataBank.id_profession_user == 12)
                        {
                            querystr = $"  select id_department_hospital, name_department from hospital_department_workers join departments on id_department = id_department_hospital  where id_employee = '{DataBank.id_user}'";
                            command = new SqlCommand(querystr, dbM.getConnection());
                            //считываем данные в ридер
                            SqlDataReader reader4 = command.ExecuteReader();
                            reader4.Read();
                            try
                            {
                                if (reader4.HasRows)//если ридер содержит строки
                                {
                                    Object id_department = reader4[0].ToString();
                                    Object name_department = reader4[1];
                                    DataBank.id_department = int.Parse(id_department.ToString());
                                    DataBank.department_name = name_department.ToString();
                                }
                            }
                            finally
                            {
                                reader4.Close();
                            }
                            //MessageBox.Show("профессия = " + DataBank.id_profession_user + " ,вошел  пользователь " + DataBank.full_name_user + " ,ид отделения = "+ DataBank.id_department + " ,id категории = "+ DataBank.id_category_inst + " ,название учреждения = "+DataBank.name_medical + ", id учреждения = "+ DataBank.id_medical );
                        }
                        switch (DataBank.id_profession_user)
                        {
                            case 11:/*усли директор*/
                                {
                                    EmForm em = new EmForm();
                                    em.Text = (DataBank.name_medical).ToUpper();
                                    this.Hide();
                                    em.ShowDialog();
                                    this.Show();
                                    break;
                                }
                            case 12:/*если заведующий*/
                                {
                                    {
                                        HospitalForm hs = new HospitalForm();

                                        hs.Text = (DataBank.name_medical).ToUpper();
                                        this.Hide();
                                        hs.ShowDialog();
                                        this.Show();
                                        break;
                                    }

                                }
                            case 2:/*если врач*/
                                {
                                    DocForm doc = new DocForm();
                                    doc.Text = (DataBank.name_medical).ToUpper();
                                    this.Hide();
                                    doc.ShowDialog();
                                    this.Show();
                                    break;
                                }
                            case 13:/*если регистратор*/
                                {

                                    PatientsForm1 patients = new PatientsForm1();
                                    patients.Text = (DataBank.name_medical).ToUpper();
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
                        reader.Close();

                    }



                }
            }
            catch
            {
                if (loginUser == "admin" && passwordUser == "admin")
                {
                    MedForm med = new MedForm();

                    this.Hide();
                    med.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Введите логин и пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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
