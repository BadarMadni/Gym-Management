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
    public partial class frmFeePaid : MaterialForm
    {
        public frmFeePaid()
        {
            #region MaterialSkin
            InitializeComponent();
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            #endregion
        }
        SqlDataReader mdr;
        SqlConnection con;
        SqlCommand cmd,cmd2;
        DataSet ds;
        SqlDataAdapter da;
        string c = "Data Source=DELL;Initial Catalog = DbGymManagemnt; Integrated Security = True";

        private void frmFeePaid_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(c);
                con.Open();
                cmd = new SqlCommand("select * from Fees ORDER BY ID ASC", con);
 
                da = new SqlDataAdapter(cmd.CommandText, con);
                ds = new DataSet();
                da.Fill(ds, "tbl");
                dataGridView1.DataSource = ds.Tables["tbl"].DefaultView;////////////
                ////////////////////NamE Of Candidates
                cmd2 = new SqlCommand("select Id,Name from REGISTERTION ORDER BY ID ASC", con);
                da = new SqlDataAdapter(cmd2.CommandText, con);
                ds = new DataSet();
                da.Fill(ds, "tbl");
                dataGridView2.DataSource = ds.Tables["tbl"].DefaultView;////////////////

                cmd.Parameters.Clear();


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);




            }
            ////////////////////////////////////
            ////////////////////////////////////


        }

        private void lblFee_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string comand = "select * from Fees where Id LIKE '%" + txtId.Text + "%'";
                con = new SqlConnection(c);
                cmd = new SqlCommand(comand);
                da = new SqlDataAdapter(cmd.CommandText, con);
                ds = new DataSet();
                da.Fill(ds, "tbl");
                dataGridView1.DataSource = ds.Tables["tbl"].DefaultView;
                ////////////////////////////////////////////////////////


                cmd.Parameters.Clear();


                con.Close();
            }
            catch (Exception exe)
            {

                MessageBox.Show(exe.Message);
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string comand = "select * from Fees where Id LIKE '%" + txtId.Text + "%' or Month LIKE'%" + txtId.Text + "%'ORDER BY ID ASC";
                con = new SqlConnection(c);
                con.Open();
                cmd = new SqlCommand(comand, con);

                da = new SqlDataAdapter(cmd.CommandText, con);
                ds = new DataSet();

                da.Fill(ds, "tbl");
                dataGridView1.DataSource = ds.Tables["tbl"].DefaultView;

                ////////////////////////////////////////////////////////




                cmd.Parameters.Clear();


                con.Close();
            }
            catch (Exception exe)
            {

                MessageBox.Show(exe.Message);
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtmonth2.Text == "")
            {
                MessageBox.Show("Enter Roll No plz And Month", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);


            }
            else
            {
                try
                {
                    var query = "Delete Fees where Id='" + txtId.Text + "'AND Month='" + txtmonth2.Text + "'";
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    txtId.Clear();
                    txtAmount.Clear();
                    txtMonth.Clear();

                }

                string comand = "select * from Fees where Id LIKE '%" + textBox1.Text + "%'";
                con = new SqlConnection(c);
                con.Open();
                cmd = new SqlCommand(comand, con);
                mdr = cmd.ExecuteReader();
                da = new SqlDataAdapter(cmd.CommandText, con);
                ds = new DataSet();
                if (mdr.Read())
                {
                    txtMonth.Text = mdr["Month"].ToString();
                    txtAmount.Text = mdr["AmountFee"].ToString();


                }
                else
                {
                    MessageBox.Show("error");
                }
                con.Close();



            }
            catch (Exception exe)
            {

                MessageBox.Show(exe.Message);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && txtId.Text == "" && txtMonth.Text == "" && txtAmount.Text == "" && dateTimePicker1.Text=="" && textBox2.Text=="")
            {
                
                MessageBox.Show("Fields Are Already Clear", "Sir", MessageBoxButtons.OK, MessageBoxIcon.Hand);


            }
            else
            {
                txtmonth2.Clear();
                textBox2.Clear();
                textBox1.Clear();
                txtId.Clear();
                txtMonth.Clear();
                txtAmount.Clear();

                try
                {
                    con = new SqlConnection(c);
                    con.Open();
                    cmd = new SqlCommand("select * from Fees ORDER BY Month ", con);

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
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (txtMonth.Text==""|| textBox1.Text==""||txtAmount.Text=="")
               
            {
                MessageBox.Show("Plz complete the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else{
                try
                {

                    con = new SqlConnection(c);

                    cmd = new SqlCommand("update Fees set Id='" + textBox1.Text + "', Month='" + txtMonth.Text + "',AmountFee='" + txtAmount.Text + "' where Id=" + textBox1.Text + " AND Month='" + txtMonth.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ds.Clear();
                    da.Fill(ds, "tbl");
                    MessageBox.Show("data successfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Menu m = new Menu();
                    m.Show();
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Your error is " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || txtAmount.Text == "" || txtMonth.Text == "")

            {

                MessageBox.Show("Something is missing Select Month ,RollNo and fee Amount ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);





            }
            else
            {
                try
                {

                    con = new SqlConnection(c);
                    con.Open();
                    cmd = new SqlCommand("INSERT into Fees (Id,Month,AmountFee,date)VALUES('" + textBox1.Text + "','" + txtMonth.Text + "','" + txtAmount.Text + "','" + dateTimePicker1.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    cmd2 = new SqlCommand("delete from Defaulters where Id =" + textBox1.Text + "", con);



                    cmd2.ExecuteNonQuery();
                    cmd2.Parameters.Clear();

                    MessageBox.Show("Data Has Been Save", "S A V E", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    this.Close();
                    Menu m = new Menu();
                    m.Show();
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAmount_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            try

            {


                /////////////////////////////////////////////////////////////////////////////
                string comand = "select Id,Name from REGISTERTION where Id LIKE '%" + textBox2.Text + "%'ORDER BY ID ASC";
                con = new SqlConnection(c);
                cmd = new SqlCommand(comand);
                da = new SqlDataAdapter(cmd.CommandText, con);
                ds = new DataSet();
                da.Fill(ds, "tbl");
                dataGridView2.DataSource = ds.Tables["tbl"].DefaultView;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error is",ex.Message);
            }

            }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            try
            {

                string queery = "select * from Fees where date='" + dateTimePicker1.Text + "'";
                con = new SqlConnection(c);
                cmd = new SqlCommand(queery);
                da = new SqlDataAdapter(cmd.CommandText, con);
                ds = new DataSet();
                da.Fill(ds, "tbl");
                dataGridView1.DataSource = dataGridView1.DataSource = ds.Tables["tbl"].DefaultView;
                ///////////////////////////////////////////////////////////////////////////////////
                


            }
            catch (Exception e1)
            {
                MessageBox.Show("Your error is " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
