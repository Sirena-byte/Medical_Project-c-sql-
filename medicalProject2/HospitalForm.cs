using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicalProject2
{
    public partial class HospitalForm : Form
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
        int AddPatientWard = 0;
        MedicalDB dbM;
        public HospitalForm()
        {
           
            InitializeComponent();
            dbM = new MedicalDB();
        }
        private void HospitalForm_Load(object sender, EventArgs e)
        {
            label2.Text = DataBank.name_medical.ToUpper();
            if(DataBank.id_profession_user == 12)
            {
                label1.Visible = true;
                label1.Text = (DataBank.department_name + " отделение").ToUpper();
               
            }
            else
            {
                label1.Visible = false;
            }
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;

           
            CreateColumn(dataGridView1);
            CreateColumn(dataGridView2);
            CreateColumn(dataGridView3);
            CreateColumn(dataGridView4);
            CreateColumn(dataGridView5);
            CreateColumn(dataGridView6);
            CreateColumn(dataGridView7);
            CreateColumn(dataGridView8);
            CreateColumn(dataGridView9);
            CreateColumn(dataGridView10);
            CreateColumn(dataGridView11);
            CreateColumn(dataGridView12);
            CreateColumn(dataGridView13);
            CreateColumn(dataGridView14);
            CreateColumn(dataGridView15);
            CreateColumn(dataGridView16);
            refreshWards();
            groupBoxAddPatient.Visible = false;

        }
//--------------------------ОТРИСОВКА ПАЛАТ И ЗАПОЛНЕНИЕ--------------------------
        private void CreateColumn(DataGridView dgw)
        {
            dgw.Columns.Add("id_place", "id");//первое поле название поля в бд, второе так, как будет выводить таблица
            dgw.Columns.Add("fio_patient", "ФИО ПАЦИЕНТА");
            dgw.Columns.Add("IsNew", String.Empty);
            dgw.Columns[0].Visible = false;
            dgw.Columns[2].Visible = false;
        }


        protected void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0),
                (record.GetString(1))
                , RowState.ModifietedNew);
        }
        private void RefreshDataGrid(DataGridView dgw,int ward)
        {
           
            dgw.Rows.Clear();
            string queryString;
            
                queryString = $"select id_ward , concat_ws(' ',first_name,last_name,surname) as patient from wards  join patients on patients.id_patient = wards.id_patient where id_department_hospital = '1' and ward = {ward}";

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
        //------------------------ВЫПИСКА ПАЦИЕНТА----------------------------------

        private void deleteRow(DataGridView dgw)
        {
            int index = dgw.CurrentCell.RowIndex;//передаем строку на которой находимся
            dgw.Rows[index].Visible = false;//скрываем поле
            for (int i = 0; i < dgw.Rows.Count; i++)
            {
                var rowState = (RowState)dgw.Rows[i].Cells[2].Value;//передаем поле, где находится индекс

                if (rowState == RowState.Existed)
                    continue;

                if (dgw.Rows[index].Cells[0].Value.ToString() != string.Empty)//есла ячейка нулевая, значит это айдишник и мы берем это значение, тогда
                {
                    dgw.Rows[index].Cells[2].Value = RowState.Deleted;//присваиваем индекс, который находится в крайней ячейке( и если он не нулевой, то сть есть что удалять)
                    rowState = RowState.Deleted;
                }
                if (rowState == RowState.Deleted)
                {
                    dbM.openConnection();
                    var id = Convert.ToInt32(dgw.Rows[index].Cells[0].Value);//передаем значение айдишника

                    MessageBox.Show(id.ToString());

                    var deleteQuery = $"delete from wards where id_ward = {id}";
                    var command = new SqlCommand(deleteQuery, dbM.getConnection());
                    command.ExecuteNonQuery();
                    dbM.closeConnection();
                }
                return;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    deleteRow(dataGridView1);
                    RefreshDataGrid(dataGridView1, 1);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    deleteRow(dataGridView2);
                    RefreshDataGrid(dataGridView2, 2);
                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    deleteRow(dataGridView3);
                    RefreshDataGrid(dataGridView3, 3);
                }
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    deleteRow(dataGridView4);
                    RefreshDataGrid(dataGridView4, 4);
                }
            }
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    deleteRow(dataGridView5);
                    RefreshDataGrid(dataGridView5, 5);
                }
            }
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    deleteRow(dataGridView6);
                    RefreshDataGrid(dataGridView6, 6);
                }
            }
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    deleteRow(dataGridView7);
                    RefreshDataGrid(dataGridView7, 7);
                }
            }
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    deleteRow(dataGridView8);
                    RefreshDataGrid(dataGridView8, 8);
                }
            }
        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    deleteRow(dataGridView9);
                    RefreshDataGrid(dataGridView9, 9);

                    
                }
            }
        }

        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    deleteRow(dataGridView10);
                    RefreshDataGrid(dataGridView10, 10);
                }
            }
        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    deleteRow(dataGridView11);
                    RefreshDataGrid(dataGridView11, 11);
                }
            }
        }

        private void dataGridView12_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    deleteRow(dataGridView12);
                    RefreshDataGrid(dataGridView12, 12);
                }
            }
        }

        private void dataGridView13_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    deleteRow(dataGridView13);
                    RefreshDataGrid(dataGridView13, 13);
                }
            }
        }

        private void dataGridView14_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    deleteRow(dataGridView14);
                    RefreshDataGrid(dataGridView14, 14);
                }
            }
        }

        private void dataGridView15_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    deleteRow(dataGridView15);
                    RefreshDataGrid(dataGridView15, 15);
                }
            }
        }

        private void dataGridView16_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)//если поле есть в таблице
            {
                DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить запись?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    deleteRow(dataGridView16);
                    RefreshDataGrid(dataGridView16, 16);
                }
            }
        }


        //-------------------------ДОБАВЛЕНИЕ ПАЦИЕНТА--------------------------------------------
        private void ClearFielda()
        {
            aFirstNameField.Text = string.Empty;
            aLastNameField.Text = string.Empty;
            aSurnameField.Text = string.Empty;
            aDateBField.Text = string.Empty;
            aPhoneField.Text = string.Empty;
            aStreetField.Text = string.Empty;
            aHomeField.Text = string.Empty;
            aEpartFeild.Text = string.Empty;
            aPasportField.Text = string.Empty;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            addPatient(AddPatientWard);
   
            groupBoxAddPatient.Visible = false;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                string result = Microsoft.VisualBasic.Interaction.InputBox("ВВЕДИТЕ НОМЕР ПАЛАТЫ:");
                if (result != " ")
                {
                    AddPatientWard = int.Parse(result);
                    if (AddPatientWard < 1)
                    {
                        MessageBox.Show("Введите номер палаты корректно", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    if (AddPatientWard > 16)
                    {
                        MessageBox.Show("Палаты с таким номером в отделении нет!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        int rows = 0;
                        switch (AddPatientWard)
                        {
                            case 1:
                                {
                                    rows = dataGridView1.Rows.Count;
                                    break;
                                }
                            case 2:
                                {
                                    rows = dataGridView2.Rows.Count;
                                    break;
                                }
                            case 3:
                                {
                                    rows = dataGridView3.Rows.Count;
                                    break;
                                }
                            case 4:
                                {
                                    rows = dataGridView4.Rows.Count;
                                    break;
                                }
                            case 5:
                                {
                                    rows = dataGridView5.Rows.Count;
                                    break;
                                }
                            case 6:
                                {
                                    rows = dataGridView6.Rows.Count;
                                    break;
                                }
                            case 7:
                                {
                                    rows = dataGridView7.Rows.Count;
                                    break;
                                }
                            case 8:
                                {
                                    rows = dataGridView8.Rows.Count;
                                    break;
                                }
                            case 9:
                                {
                                    rows = dataGridView9.Rows.Count;
                                    break;
                                }
                            case 10:
                                {
                                    rows = dataGridView10.Rows.Count;
                                    break;
                                }
                            case 11:
                                {
                                    rows = dataGridView11.Rows.Count;
                                    break;
                                }
                            case 12:
                                {
                                    rows = dataGridView12.Rows.Count;
                                    break;
                                }
                            case 13:
                                {
                                    rows = dataGridView13.Rows.Count;
                                    break;
                                }
                            case 14:
                                {
                                    rows = dataGridView14.Rows.Count;
                                    break;
                                }
                            case 15:
                                {
                                    rows = dataGridView15.Rows.Count;
                                    break;
                                }
                            case 16:
                                {
                                    rows = dataGridView16.Rows.Count;
                                    break;
                                }
                        }
                        if (rows < 4)
                        {

                            MessageBox.Show("добавляем пациента . количество занятых мест в палате = " + rows);

                            button1.Visible = false;
                            groupBoxAddPatient.Visible = true;


                        }
                        else
                        {
                            MessageBox.Show("палата занята. в ней количество пациентов = " + rows);
                        }



                    }

                }
            }
            catch { }
            

        }

        private void refreshWards()
        {
            RefreshDataGrid(dataGridView1, 1);
            RefreshDataGrid(dataGridView2, 2);
            RefreshDataGrid(dataGridView3, 3);
            RefreshDataGrid(dataGridView4, 4);
            RefreshDataGrid(dataGridView5, 5);
            RefreshDataGrid(dataGridView6, 6);
            RefreshDataGrid(dataGridView7, 7);
            RefreshDataGrid(dataGridView8, 8);
            RefreshDataGrid(dataGridView9, 9);
            RefreshDataGrid(dataGridView10, 10);
            RefreshDataGrid(dataGridView11, 11);
            RefreshDataGrid(dataGridView12, 12);
            RefreshDataGrid(dataGridView13, 13);
            RefreshDataGrid(dataGridView14, 14);
            RefreshDataGrid(dataGridView15, 15);
            RefreshDataGrid(dataGridView16, 16);
           
        }

        private void addPatient(int ward)
        {
            dbM.openConnection();

            //объявляем переменные, заполняем значениями из полей
            var firstName = aFirstNameField.Text;
            var lastName = aLastNameField.Text;
            var surname = aSurnameField.Text;
            var phoneNum = aPhoneField.Text;
            var address = "";
            if (aEpartFeild.Text != "")
            {
                address = aStreetField.Text + " " + aHomeField.Text + "-" + aEpartFeild.Text;
            }
            else
            {
                address = aStreetField.Text + " " + aHomeField.Text;
            }

            var pasport = aPasportField.Text;
            var dateB = "";
            DateTime date = new DateTime();

            if (DateTime.TryParse(aDateBField.Text, out date))
            {
                dateB = aDateBField.Text;
                try
                {
                    var addQuery = $"insert into patients(first_name,last_name,surname, date_of_birth,phone_num,home_address,pasport) OUTPUT Inserted.id_patient values ('{firstName}','{lastName}','{surname}','{dateB}','{phoneNum}','{address}','{pasport}')";
                    var command = new SqlCommand(addQuery, dbM.getConnection());
             
                    string idS = command.ExecuteScalar().ToString();//получаем ид только что добавленной строки
                    int idPatient = int.Parse(idS);

                    addQuery = $"insert into wards(id_department_hospital,id_patient,ward) values ('{DataBank.id_department}','{idPatient}','{ward}')";
                    var command2 = new SqlCommand(addQuery, dbM.getConnection());
                    command2.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFielda();
                    refreshWards();
                    button1.Visible = false;
                }
                catch
                {
                    MessageBox.Show("Пациент с таким номером паспорта уже есть в базе!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
           
            dbM.closeConnection();
        }
    }
    
}
