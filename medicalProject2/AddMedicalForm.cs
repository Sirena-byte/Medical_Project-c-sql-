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
            LoadComboBox("SELECT id_employee,concat_ws(' ',first_name,last_name,surname) as name FROM employees", "name","id_employee",this.supervisorField);
            LoadComboBox("SELECT * FROM category", "name_category", "id_category", this.categoryField);
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


                var addQuery = $"insert into medical_inst (id_category, name_inst,phone_inst, address_inst, supervisor_id) values ('{category}','{name}','{phone}','{address}','{supervisor}')";
                var command = new SqlCommand(addQuery, dbM.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dbM.closeConnection();
            //данные в таблице сами не обновляются
            //можно добавить окно не успеха
        }
    }
}


