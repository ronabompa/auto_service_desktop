using System;
using System.Windows.Forms;
using ServiceAutoDESKTOP.BL;
using ServiceAutoDESKTOP.GUI;

namespace ServiceAutoDESKTOP
{
    public partial class LoginForm : Form
    {
        private static LoginForm _loginFrom = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        //singleton
        public static LoginForm getInstance()
        {
            if (_loginFrom == null)
            {
                _loginFrom = new LoginForm();
            }
            return _loginFrom;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            UserService userService = new UserService();
              bool user = userService.getUser(usernameTextBox.Text, passwordTextBox.Text);


              if (user == false)
              {
                  //usernameTextBox.Clear();
                  //passwordTextBox.Clear();
                  MessageBox.Show("Usernameul sau parola sunt gresite");
              }
              else
              {
                  usernameTextBox.Clear();
                  passwordTextBox.Clear();
                  AppointmentsForm adminForm = new AppointmentsForm();
                  adminForm.Show();
                  this.Hide();
              }
              
            
        }

        // BUTTON EXIT
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  //”this” refers to the form
        }
    }
}
