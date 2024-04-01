using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicalProject2
{
    public partial class AdminPanelMedical : Form
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
        public AdminPanelMedical()
        {
            // DpiFix();
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }



        private void AdminPanelMedical_Load(object sender, EventArgs e)
        {
           

            // TODO: данная строка кода позволяет загрузить данные в таблицу "medical_project_DBDataSet.employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.medical_project_DBDataSet.employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medical_project_DBDataSet.category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.medical_project_DBDataSet.category);
            //вывод таблицы
            CreateColumn();
            RefreshDataGrid(dataGridView1);
            this.ClearField();

        }

        private void CreateColumn()
        {
            dataGridView1.Columns.Add("id_inst", "id");//первое поле название поля в бд, второе так, как будет выводить таблица
            dataGridView1.Columns.Add("name_category", "Категория");
            dataGridView1.Columns.Add("name_inst", "Название");
            dataGridView1.Columns.Add("address_inst", "Адрес");
            dataGridView1.Columns.Add("phone_num", "Телефон");
            dataGridView1.Columns.Add("first_name", "Руководитель");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 340;
            dataGridView1.Columns[3].Width = 240;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 300;
            dataGridView1.Columns[6].Visible = false;

        }

        protected void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), record.GetString(5), RowState.ModifietedNew);
        }
        //метод очищает поля
        private void ClearField()
        {
            idMedicalField.Text ="";
            categoryField.Text = "";
            nameField.Text = "";
            addressStreetField.Text = "";
            phoneField.Text = "";
            supervisorField.Text = "";
        }

        //метод выводит данные в таблицу
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"SELECT id_inst,name_category,name_inst,address_inst,phone_inst,first_name FROM medical_inst JOIN category ON medical_inst.id_category = category.id_category " +
            $"JOIN employees ON medical_inst.supervisor_id = employees.id_employee";

            SqlCommand command = new SqlCommand(queryString, dbM.getConnection());
            dbM.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void categoryField_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ClearField();
            //medical_project_DBDataSet mDB = new medical_project_DBDataSet();
            //string cat = categoryField.SelectedValue.ToString();
            //MessageBox.Show(categoryField.SelectedValue.ToString());//выводит сообщение с индексом категории
        }
        //метод для того, чтобы при нажатии на ячейку, данные переносились в форму для изменения
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];//смотрим какой индекс у поля
                //проходим по полям

                //при нажатии на поле заполняются поля
                idMedicalField.Text = row.Cells[0].Value.ToString();
                categoryField.Text = row.Cells[1].Value.ToString();
                nameField.Text = row.Cells[2].Value.ToString();
                addressStreetField.Text = row.Cells[3].Value.ToString();
                phoneField.Text = row.Cells[4].Value.ToString();
                supervisorField.Text = row.Cells[1].Value.ToString();
            }
        }

        private void restartButtonn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearField();
        }

        private void NewsButton_Click(object sender, EventArgs e)
        {
            AddMedicalForm addForm = new AddMedicalForm();
            addForm.Show();
        }
    }
}


























  
