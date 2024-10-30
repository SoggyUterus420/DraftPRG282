using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraftPRG282
{
    public partial class frmLoginForm : Form
    {
        public frmLoginForm()
        {
            InitializeComponent();
        }

        private void frmLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "user" && txtPassword.Text == "password")
            {
                // If successful, open the main form
                new frmStudentManagementForm().Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                //If user information is wrong, this message will show
                //The text boxes will be cleared
                MessageBox.Show("Invalid username or password. Please try again.");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            //Once the exit button is clicked, the application will close
            Application.Exit();
        }
    }
}
