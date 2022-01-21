using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sistem_Administrasi.Controller
{
    class LoginController
    {
        Model.LoginModel model;
        View.LoginWindow login;

        public LoginController(View.LoginWindow login)
        {
            model = new Model.LoginModel();
            this.login = login;
        }

        public void Login()
        {
            model.username = login.txtUsername.Text;
            model.password = login.txtPassword.Password;

            if (model.LoginCheck())
            {
                View.MainWindow main = new View.MainWindow();

                main.Show();
                login.Close();
            }
            else
            {
                MessageBox.Show("Username/password yang anda masukkan salah.");
            }
        }

        public void ForgotPassword()
        {

        }
    }
}
