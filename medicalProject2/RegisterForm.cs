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
    public partial class RegisterForm : Form
    {
        DB db = new DB();
       
        
        public RegisterForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
           
            passwordField.MaxLength = 50;
            loginField.MaxLength = 50;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {

            db.openConnection();
            var loginUser = loginField.Text;
            var passwordUser = passwordField.Text;

            if (!checkUser())
            {

                string queryString = $"insert into register(login_user,password_user) values ('{loginUser}', '{passwordUser}')";
                SqlCommand command = new SqlCommand(queryString, db.getConnection());
                
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AutorizForm form = new AutorizForm();
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Аккаунт не был создан!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            db.closeConnection();
        }  
        
        private Boolean checkUser()
        {
            DB db = new DB();
            var loginUser = loginField.Text;
            var passwordUser = passwordField.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"select id_user,login_user,password_user from register where login_user ='{loginUser}'";

            SqlCommand command = new SqlCommand(queryString, db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой аккаунт уже создан!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db.closeConnection();
                return true; 
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
