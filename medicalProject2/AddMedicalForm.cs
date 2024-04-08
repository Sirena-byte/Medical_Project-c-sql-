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
using ComboBox = System.Windows.Forms.ComboBox;
using System.Xml.Linq;

namespace medicalProject2
{
    public partial class AddMedicalForm : Form
    {

        MedicalDB dbM = new MedicalDB();
        public AddMedicalForm()
        {
         

            // DpiFix();
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddMedicalForm_Load(object sender, EventArgs e)
        {

            //заполнение комбобоксов
            LoadComboBox("SELECT * FROM category", "name_category", "id_category", this.categoryField);
            string queryProvisor;
            if (categoryField.Text == "аптека")
            {
                queryProvisor = "SELECT id_employee,concat_ws(' ',first_name,last_name,surname) as name, name_position FROM employees JOIN positions_job ON employees.position_job = positions_job.id_position WHERE name_position = 'заведующий'";

                LoadComboBox(queryProvisor, "name", "id_employee", this.supervisorField);
            }
            if(categoryField.Text == "больница" || categoryField.Text == "поликлиника")
            {
                queryProvisor = "SELECT id_employee,concat_ws(' ',first_name,last_name,surname) as name, name_position FROM employees JOIN positions_job ON employees.position_job = positions_job.id_position WHERE name_position = 'глав.врач'";
                LoadComboBox(queryProvisor, "name", "id_employee", this.supervisorField);
            }

            this.ClearField();
            

        }
        //вывод значений из бд в комбо бокс
        private void LoadComboBox(string query,string name, string value,ComboBox box)
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


        //метод очищает поля
        private void ClearField()
        {
            categoryField.Text = "";
            nameField.Text = "";
            streetField.Text = "";
            hauseField.Text = "";
            phoneField.Text = "";
            supervisorField.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            dbM.openConnection();

            //объявляем переменные, заполняем значениями из полей
            var name = nameField.Text;
            int category = (int)categoryField.SelectedValue;
            var address = streetField.Text + "-" + hauseField.Text;
            var phone = phoneField.Text;
            int supervisor = (int)supervisorField.SelectedValue;
            

            var addQuery = $"insert into medical_inst (id_category, name_inst,phone_inst, address_inst, employee_id) values ('{category}','{name}','{phone}','{address}','{supervisor}')";
                var command = new SqlCommand(addQuery, dbM.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dbM.closeConnection();
            //данные в таблице сами не обновляются
            //можно добавить окно не успеха
        }

        private void categoryField_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryProvisor;
            if (categoryField.Text == "аптека")
            {
                queryProvisor = "SELECT id_employee,concat_ws(' ',first_name,last_name,surname) as name, name_position FROM employees JOIN positions_job ON employees.position_job = positions_job.id_position WHERE name_position = 'санитар'";

                LoadComboBox(queryProvisor, "name", "id_employee", this.supervisorField);
            }
            if (categoryField.Text == "больница" || categoryField.Text == "поликлиника")
            {
                queryProvisor = "SELECT id_employee,concat_ws(' ',first_name,last_name,surname) as name, name_position FROM employees JOIN positions_job ON employees.position_job = positions_job.id_position WHERE name_position = 'врач'";
                LoadComboBox(queryProvisor, "name", "id_employee", this.supervisorField);
            }
        }
    }
}


