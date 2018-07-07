using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management
{
    public partial class frmSearchRecords : MaterialForm
    {
        public frmSearchRecords()
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
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        string c = "Data Source=DELL;Initial Catalog = DbGymManagemnt; Integrated Security = True";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try

            {

                
                /////////////////////////////////////////////////////////////////////////////
                string comand = "select * from REGISTERTION where Id LIKE '%" + textBox1.Text + "%'ORDER BY ID ASC";
                con = new SqlConnection(c);
                cmd = new SqlCommand(comand);
                da = new SqlDataAdapter(cmd.CommandText, con);
                ds = new DataSet();
                da.Fill(ds, "tbl");
                dataGridView1.DataSource = ds.Tables["tbl"].DefaultView;
                ////////////////////////////////////////////////////////
                string comand2 = "select * from fees where Id LIKE '%" + textBox1.Text + "%'";
                con = new SqlConnection(c);
                cmd = new SqlCommand(comand2);
                da = new SqlDataAdapter(cmd.CommandText, con);
                ds = new DataSet();
                da.Fill(ds, "tbl");
                dataGridView2.DataSource = ds.Tables["tbl"].DefaultView;
                ////////////////////////////////////////////////////////
                string comand3 = "select * from Defaulters where Id LIKE '%" + textBox1.Text + "%'";
                con = new SqlConnection(c);
                cmd = new SqlCommand(comand3);
                da = new SqlDataAdapter(cmd.CommandText, con);
                ds = new DataSet();
                da.Fill(ds, "tbl");
                dataGridView3.DataSource = ds.Tables["tbl"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Plz Enter roll no for Getting Records");

                }
                con.Open();
                SqlCommand cmg = new SqlCommand("select IMG_PIC From REGISTERTION where Id = '" + textBox1.Text + "'",con );
                da = new SqlDataAdapter(cmg);
                ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms
                        = new MemoryStream((byte[])ds.Tables[0].Rows[0]["IMG_PIC"]);
                    pictureBox1.Image = new Bitmap(ms);
                }
                else
                {
                    MessageBox.Show("Image not found");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            pictureBox1.Image = null;
        }

        private void frmSearchRecords_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(c);
                con.Open();
                cmd = new SqlCommand("select * from REGISTERTION ORDER BY ID ASC ", con);

                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                
                ds = new DataSet();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                //dataGridView1.DataSource = ds.Tables["tbl"].DefaultView;////////////
                ///////////////////////////////////////////////
                cmd = new SqlCommand("select * from fees ORDER BY ID ASC", con);

                da = new SqlDataAdapter(cmd.CommandText, con);
                ds = new DataSet();
                da.Fill(ds, "tbl");
                dataGridView2.DataSource = ds.Tables["tbl"].DefaultView;////////////////
                                                                        ///////////////////////////////////////////////////////////////////////////
                con = new SqlConnection(c);
                con.Open();
                cmd = new SqlCommand("select * from Defaulters ORDER BY ID ASC ", con);

                da = new SqlDataAdapter(cmd.CommandText, con);
                ds = new DataSet();
                da.Fill(ds, "tbl");
                dataGridView3.DataSource = ds.Tables["tbl"].DefaultView;////////////


                cmd.Parameters.Clear();


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);




            }

        }
    }
}
