using MaterialSkin;
using MaterialSkin.Controls;
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
using System.Configuration;

namespace Gym_Management
{
    public partial class Frmlogin : MaterialForm
    {
        public Frmlogin()
        {
            #region MaterialSkin
            InitializeComponent();
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            #endregion


        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField4_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string passwords = txtPassword.Text;
            if (username == "" || passwords == "")
            {
                MessageBox.Show("Username or passowr empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            else if (username== "admin" && passwords == "admin")
            {

                this.Hide();
                Menu m = new Menu();
                m.Show();

            }
            else
            {
                MessageBox.Show("Password Not Match", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string passwords = txtPassword.Text;
                if (username == "" || passwords == "")
                {
                    MessageBox.Show("Username or passowrd empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                else if (username == "admin" && passwords == "admin")
                {

                    this.Hide();
                    Menu m = new Menu();
                    m.Show();

                }
                else
                {
                    MessageBox.Show("Password Not Match", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }
    }

}
