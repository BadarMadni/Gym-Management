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
    public partial class frmAttendence :MaterialForm
    {
        public frmAttendence()
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


        private void frmAttendence_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(c);
                con.Open();
                cmd = new SqlCommand("select * from Attendece  where Date='" + dateTimePicker1.Text+ "' ORDER BY RollNo ASC", con);

                da = new SqlDataAdapter(cmd.CommandText, con);
                ds = new DataSet();
                da.Fill(ds, "tbl");
                dataGridView1.DataSource = ds.Tables["tbl"].DefaultView;////////////
                ///////////////////////////////////////////////
                cmd = new SqlCommand("select * from fees ORDER BY ID ASC", con);

                da = new SqlDataAdapter(cmd.CommandText, con);
                ds = new DataSet();
                da.Fill(ds, "tbl");
                dataGridView2.DataSource = ds.Tables["tbl"].DefaultView;

                cmd.Parameters.Clear();

                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);




            }

        }

        private void txtId_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string comand = "select * from Attendece where RollNo LIKE '%" + txtRollNo.Text + "%'";
                con = new SqlConnection(c);
                cmd = new SqlCommand(comand);
                da = new SqlDataAdapter(cmd.CommandText, con);
                ds = new DataSet();
                da.Fill(ds, "tbl");
                dataGridView1.DataSource = ds.Tables["tbl"].DefaultView;
                ////////////////////////////////////////////////////////
                string comand2 = "select * from fees where Id LIKE '%" + txtRollNo.Text + "%'";
                con = new SqlConnection(c);
                cmd = new SqlCommand(comand2);
                da = new SqlDataAdapter(cmd.CommandText, con);
                ds = new DataSet();
                da.Fill(ds, "tbl");
                dataGridView2.DataSource = ds.Tables["tbl"].DefaultView;
                ////////////////////////////////////////////////////////




            }
            catch (Exception exe)
            {

                MessageBox.Show(exe.Message);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (txtRollNo.Text == "")
            {
                MessageBox.Show("Enter Roll No plz", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);


            }
            else
            {
                try
                {
                    var query = "Delete Attendece where RollNo='" + txtRollNo.Text + "'AND Date='" + dateTimePicker1.Text + "'";
                    con = new SqlConnection(c);
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    MessageBox.Show("Record Has Been Deleted", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                    this.Close();
                    Menu m = new Menu();
                    m.Show();


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex.Message + MessageBoxButtons.OK);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRollNo.Text == "" )

            {

                MessageBox.Show("Enter RollNumber ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);





            }
            else
            {
                try
                {

                    con = new SqlConnection(c);
                    con.Open();
                    cmd = new SqlCommand("INSERT into Attendece (RollNo,Date)VALUES('" + txtRollNo.Text + "','" + dateTimePicker1.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    MessageBox.Show("Attendence  Uploaded", "S A V E", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                dataGridView1.DataSource = ds.Tables["tbl"].DefaultView;////////////
                //cmd.parameters.clear();


                    con.Close();
                    this.Hide();
                    frmAttendence a = new frmAttendence();
                    a.Show();
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }
    }
}
