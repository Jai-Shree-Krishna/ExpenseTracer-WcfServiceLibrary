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
    public partial class SignUp : Form
    {
        AuthServiceClient authService;
        public SignUp()
        {
            InitializeComponent();
            this.authService = new AuthServiceClient();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new Form1()));
            t.Start();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = emaiTB.Text, password = passwordTB.Text, username = usernameTB.Text;
            if(emaiTB.Text != "" && passwordTB.Text != "" && usernameTB.Text != "")
            {
                int userId = authService.SignUp(email, password, username);
                
                if(userId != -1)
                {
                    var t = new Thread(() => Application.Run(new MainScreen(userId)));
                    t.Start();
                    this.Close();
                }
                else
                {
                    errorLabel.Text = "We are having some problem while sigining you.\n PLease try again later !!!";
                }
            }
            else
            {
                errorLabel.Text = "Please fill all the fields...";
                emaiTB.Text = passwordTB.Text = usernameTB.Text = "";
            }
        }
    }
}

/*
 * SignUp done : service , form ...
 */