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
    public partial class AddEmployeesForm : Form
    {
        MedicalDB dbM = new MedicalDB();
        public AddEmployeesForm()
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ClearField();
            profileField.Visible = false;
            label8.Visible = false;
        }

        private void AddEmployeesForm_Load(object sender, EventArgs e)
        {
            
            LoadComboBox("SELECT id_inst, name_inst FROM medical_inst", "name_inst", "id_inst", this.placeOfWorkField);//место работы
            LoadComboBox("SELECT * FROM doctors_profiles", "profile_name", "id_profile", this.profileField);
            LoadComboBox("SELECT * FROM positions_job", "name_position", "id_position", this.profesionField);
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
            ClearField();
        }

        //метод очищает поля
        private void ClearField()
        {
            firstNameField.Text = "";
            lastNameFieeld.Text = "";
            surnameField.Text = "";
            profesionField.Text = "";
            profileField.Text = "";
            placeOfWorkField.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            dbM.openConnection();

            //объявляем переменные, заполняем значениями из полей
            var firstName = firstNameField.Text;
            var lastName = lastNameFieeld.Text;
            var surname = surnameField.Text;
            int profession = (int)profesionField.SelectedValue;
            int profile;
            
            if (profession != 2)
            
                profile = 11;
            else
            profile = (int)profileField.SelectedValue;
            int placeOfWork = (int)placeOfWorkField.SelectedValue;


            var addQuery = $"insert into employees(first_name,last_name,surname, position_job, doctor_profile,place_of_work) values ('{firstName}','{lastName}','{surname}',{profession},{profile},{placeOfWork})";
            var command = new SqlCommand(addQuery, dbM.getConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearField();
            dbM.closeConnection();
            //данные в таблице сами не обновляются
            //можно добавить окно не успеха
        }

        private void profesionField_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(profesionField.SelectedValue.ToString());//выводит индекс
            if (profesionField.SelectedValue.ToString() == "2")
            {
                profileField.Visible = true;
                label8.Visible = true;
                profileField.Text = "";
            }
            else
            {
                profileField.Visible = false;
                label8.Visible = false;
            }
    }
    }
}
//добавить исключение если не врач