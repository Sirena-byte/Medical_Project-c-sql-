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
        }

        private void employysButton_Click(object sender, EventArgs e)
        {
            MedicalForm medicalForm = new MedicalForm();
            medicalForm.Show();
            this.Visible = false;

        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            CreateColumn();
            RefreshDataGrid(dataGridView1);

            LoadComboBox("SELECT * FROM specialisations_department", "name_specialisation", "id_specialisation", this.doctorsProfileField);
            LoadComboBox("SELECT * FROM positions_job", "name_position", "id_position", this.positionJobField);
        }

        private void CreateColumn()
        {
            dataGridView1.Columns.Add("id_employee", "id");//первое поле название поля в бд, второе так, как будет выводить таблица
            dataGridView1.Columns.Add("first_name", "ФИО");
            dataGridView1.Columns.Add("name_position", "Должность");
            dataGridView1.Columns.Add("name_specialisation", "Профиль");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Width = 290;
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Visible = true;

        }

        protected void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0),
                (record.GetString(1) +" "+ record.GetString(2) + " " + record.GetString(3)) ,record.GetString(4) , record.GetString(5)
                , RowState.ModifietedNew);
        }

        //метод выводит данные в таблицу
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"SELECT id_employee, first_name, last_name, surname, name_position,name_specialisation FROM employees JOIN positions_job ON employees.position_job = positions_job.id_position JOIN specialisations_department ON employees.doctor_profile = specialisations_department.id_specialisation";

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
    }
}
