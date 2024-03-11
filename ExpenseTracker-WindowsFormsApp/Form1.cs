using ExpenseTracker_WindowsFormsApp.AuthServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        AuthServiceClient authService;
        public Form1()
        {
            InitializeComponent();
            this.authService = new AuthServiceClient();
        }

        public void button2_Click(object sender, EventArgs e)
        {

            var t = new Thread(() => Application.Run(new SignUp()));
            t.Start();
            this.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string email = emailTextboc.Text, password = passwordBox.Text;

            if (email != "" && password != "")
            {

                int userId = authService.SignIn(email, password);

                if(userId != -1)
                {
                    errorLabel.Text = "SignIn successful.";
                    var t = new Thread(() => Application.Run(new MainScreen(1)));
                    t.Start();
                    this.Close();
                }
                else
                {
                    errorLabel.Text = "Invalid credentials... \n Please try again.";
                    emailTextboc.Text = passwordBox.Text = "";
                }
            }
            else
            {
                errorLabel.Text = "Please fill all fields.";
            }
        }
    }
}

/*
 * SignIn functionality ready...
 */

