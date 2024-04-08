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
            MedicalDB dbM = new MedicalDB();
            var loginUser = loginField.Text;
            var passwordUser = passwordField.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querySrting = $"select id_user,login_user,password_user from register where login_user = '{loginUser}' and password_user ='{passwordUser}'";

            SqlCommand command = new SqlCommand(querySrting, dbM.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //GridForm form = new GridForm();
                EmployeesForm form = new EmployeesForm();
                this.Hide();
                form.ShowDialog();
                this.Show();
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
    }
}
