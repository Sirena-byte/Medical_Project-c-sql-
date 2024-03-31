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
    public partial class AutorizForm : Form
    {
       
        public AutorizForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AutorizForm_Load(object sender, EventArgs e)
        {
            closePass.Visible = false;
            passwordField.MaxLength = 50;
            loginField.MaxLength = 50;
        }

        private void autorizButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            var loginUser = loginField.Text;
            var passwordUser = passwordField.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querySrting = $"select id_user,login_user,password_user from register where login_user = '{loginUser}' and password_user ='{passwordUser}'";

            SqlCommand command = new SqlCommand(querySrting, db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridForm form = new GridForm();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.closeConnection();
        }
        //переход на форму регистрации
        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            this.Hide();
            regForm.ShowDialog();
            this.Show();
        }
        //очистка формы
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            passwordField.Text = "";
            loginField.Text = "";
        }

        private void openPass_Click(object sender, EventArgs e)
        {
            passwordField.UseSystemPasswordChar = true;
            openPass.Visible = false;
            closePass.Visible = true;
        }

        private void closePass_Click(object sender, EventArgs e)
        {
            passwordField.UseSystemPasswordChar = false;
            openPass.Visible = true;
            closePass.Visible = false;
        }
    }
}
