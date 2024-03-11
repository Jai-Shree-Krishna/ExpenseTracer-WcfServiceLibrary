using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker_WindowsFormsApp
{
    public partial class MainScreen : Form
    {
        public int userId;
        public MainScreen(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
