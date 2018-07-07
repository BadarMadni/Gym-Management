using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management
{
    public partial class Menu : MaterialForm
    {
        public Menu()
        {
            #region MaterialSkin
            InitializeComponent();
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            #endregion

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Frmlogin l = new Frmlogin();
            l.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            frmRegistration r = new frmRegistration();
            r.Show();
        }

        private void btnAboutus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Badar Madni. version 1.0.1", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDefaulters_Click(object sender, EventArgs e)
        {
            frmDefaulters df = new frmDefaulters();
            df.Show();
        }

        private void btnFeesubmission_Click(object sender, EventArgs e)
        {
            frmFeePaid fp = new frmFeePaid();
            fp.Show();
        }

        private void btnAttendence_Click(object sender, EventArgs e)
        {
            
            frmAttendence attendence = new frmAttendence();
            attendence.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            frmSearchRecords f = new frmSearchRecords();
            f.Show();
        }
    }
}
