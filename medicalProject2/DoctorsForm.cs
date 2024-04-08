using System;
using System.Collections;
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
    public partial class DoctorsForm : Form
    {
        MedicalDB dbM = new MedicalDB();
        public DoctorsForm()
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        

        private void DoctorsForm_Load(object sender, EventArgs e)
        {

            //выводит все больницы
            LoadComboBox($"SELECT id_inst,name_inst FROM medical_inst JOIN category ON medical_inst.id_category = category.id_category where category.name_category = 'больница'", "name_inst", "id_inst", this.medicalField);
            //выводит врачей этой больницы
            LoadComboBox($"SELECT id_employee, concat_ws(' ',first_name,last_name,surname,' [',name_position,'-',profile_name,']') as prof FROM employees JOIN doctors_profiles ON employees.doctor_profile = doctors_profiles.id_profile JOIN positions_job ON employees.position_job = positions_job.id_position JOIN medical_inst ON employees.place_of_work = medical_inst.id_inst where medical_inst.name_inst = '{medicalField.Text}' and positions_job.name_position = 'врач'", "prof", "id_employee", this.doctorNameField);

        }

        private void doctorNameField_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void medicalField_SelectedIndexChanged(object sender, EventArgs e)
        {
      
            //выбираем врачей данной больницы
            LoadComboBox($"SELECT id_employee, concat_ws(' ',first_name,last_name,surname,' [',name_position,'-',profile_name,']') as prof FROM employees JOIN doctors_profiles ON employees.doctor_profile = doctors_profiles.id_profile JOIN positions_job ON employees.position_job = positions_job.id_position JOIN medical_inst ON employees.place_of_work = medical_inst.id_inst where medical_inst.name_inst = '{medicalField.Text}' and positions_job.name_position = 'врач'", "prof", "id_employee", this.doctorNameField);
        }

        private void doctorProfileField_TextChanged(object sender, EventArgs e)
        {
            //readRow();
            
        }
       
    }
}
