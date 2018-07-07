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

namespace Gym_Management
{
    public partial class frmDefaulters : MaterialForm
    {
        public frmDefaulters()
        {
            #region MaterialSkin
            InitializeComponent();
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            #endregion
        }
        SqlConnection con;
        SqlCommand cmd, cmd2;
        DataSet ds;
        SqlDataAdapter da;
        string c = "Data Source=DELL;Initial Catalog = DbGymManagemnt; Integrated Security = True";

        private void frmDefaulters_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(c);
                con.Open();
                cmd = new SqlCommand("select * from Defaulters ORDER BY ID ASC", con);

                da = new SqlDataAdapter(cmd.CommandText, con);
                ds = new DataSet();
                da.Fill(ds, "tbl");
                dataGridView1.DataSource = ds.Tables["tbl"].DefaultView;////////////
                cmd.Parameters.Clear();


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);




            }
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRollNo_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string comand = "select * from Defaulters where Id LIKE '%" + txtRollNo.Text + "%' or Name LIKE'%" + txtRollNo.Text + "%' ORDER BY ID ASC";
                con = new SqlConnection(c);
                cmd = new SqlCommand(comand);
                da = new SqlDataAdapter(cmd.CommandText, con);
                ds = new DataSet();
                da.Fill(ds, "tbl");
                dataGridView1.DataSource = ds.Tables["tbl"].DefaultView;
                ////////////////////////////////////////////////////////



            }
            catch (Exception exe)
            {

                MessageBox.Show(exe.Message);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "" && txtRollNo.Text == "" && cmbMonth.Text == "")
            {
                MessageBox.Show("Already Empty" + MessageBoxButtons.OK);

            }
            else
            {
                txtRollNo.Text = "";
                txtAmount.Text = "";
                cmbMonth.Text = "";
            }
        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {//////////////////Select data from Registration and copy them to Defaulters at every new month/////////////// 
            try
            {
                var query = "INSERT INTO Defaulters (Id,Name,Address, DateAdmission, entryfee) SELECT Id, Name, Address, DateAdmission, entryfee FROM REGISTERTION;";
                con = new SqlConnection(c);
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                MessageBox.Show("New month Defaulters genrate", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                MessageBox.Show("Data Has Been Copied", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                this.Hide();
                Menu m = new Menu();
                m.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message + MessageBoxButtons.OK);
            }

        }

        private void materialFlatButton1_Click_2(object sender, EventArgs e)
        {
            if (txtRollNo.Text == "")
            {
                MessageBox.Show("Enter Roll No plz", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);


            }
            else
            {
                try
                {
                    var query = "Delete Defaulters where Id='" + txtRollNo.Text + "'";
                    con = new SqlConnection(c);
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    MessageBox.Show("Record Has Been Deleted", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                    this.Hide();
                    Menu m = new Menu();
                    m.Show();


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex.Message + MessageBoxButtons.OK);
                }
            }
        }

        private void btnSumit_Click(object sender, EventArgs e)
        {
            if (txtRollNo.Text == "" || txtAmount.Text == "" || cmbMonth.Text == "")

            {

                MessageBox.Show("Something is missing Select Month ,RollNo and fee Amount ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);





            }
            else
            {
                try
                {

                    con = new SqlConnection(c);
                    con.Open();
                    cmd = new SqlCommand("INSERT into Fees (Id,Month,AmountFee,date)VALUES('" + txtRollNo.Text + "','" + cmbMonth.Text + "','" + txtAmount.Text + "','" + dateTimePicker1.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    cmd2 = new SqlCommand("delete from Defaulters where Id =" + txtRollNo.Text + "", con);



                    cmd2.ExecuteNonQuery();
                    cmd2.Parameters.Clear();
                    MessageBox.Show("Data Has Been Save", "S A V E", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    this.Hide();
                    frmDefaulters m = new frmDefaulters();
                    m.Show();
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRollNo.Text == "")
            {
                MessageBox.Show("Enter Roll No plz", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);


            }
            else
            {
                try
                {
                    var query = "Delete * from Defaulters";
                    con = new SqlConnection(c);
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    MessageBox.Show("Record Has Been Deleted", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                    this.Hide();
                    Menu m = new Menu();
                    m.Show();


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex.Message + MessageBoxButtons.OK);
                }
            }


        }
    }
}

