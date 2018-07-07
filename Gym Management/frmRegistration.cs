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
using System.IO;

namespace Gym_Management
{
    public partial class frmRegistration :MaterialForm
    {
        public frmRegistration()
        {
            #region MaterialSkin
            InitializeComponent();
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            #endregion
 
        }
        string gender;
        SqlConnection con;
        SqlCommand cmd, cmd2, cmd3;
        SqlDataReader mdr;
        SqlDataAdapter da;
        DataSet ds;
        string c = "Data Source=DELL;Initial Catalog = DbGymManagemnt; Integrated Security = True";
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPG|*.jpg|PNG|*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImagePath.Text = ofd.FileName;
                    pbPic.Image = new Bitmap(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error in Uploading image is");

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string imgpath = txtImagePath.Text;
                string id = txtId.Text;
                string Name = txtName.Text;
                string Address = txtAddress.Text;
                string entryfee = txtEntryFee.Text;
                string phoneNo = txtPhoneNo.Text;
                string Cnic = txtCnic.Text;
                string FName = txtFather.Text;
                //////////////////////////// 
                
                if (id == "" || Name == "" || Address == "" || entryfee == "" || phoneNo == "" ||FName==""|| Cnic==""||pictureBox1.Image==null)
                    MessageBox.Show("Please Enter Complete Data First");
                else if (id != "" || Name != "" || Address != "" || entryfee != "" || phoneNo != "" || FName != "" || Cnic != "")
                {
                    FileStream fs;
                    fs = new FileStream(@imgpath, FileMode.Open, FileAccess.Read);
                    byte[] picbyte = new byte[fs.Length];
                    fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
                    fs.Close();


                    con = new SqlConnection(c);
                    con.Open();
                    cmd = new SqlCommand("INSERT into REGISTERTION (Id,Name,FatherName,Cnic,Address,DateAdmission,entryfee,phoneNumber,gender,IMG_PATH,IMG_PIC)VALUES('" + id + "','" + Name + "','" + FName + "','" + Cnic + "','" + Address + "','" + dateTimePicker1.Text + "','" + entryfee + "','" + phoneNo + "','" + gender + "','"+txtImagePath.Text+"',@pic)", con);
                    SqlParameter picpara = new SqlParameter();
                    picpara.SqlDbType = SqlDbType.Image;
                    picpara.ParameterName = "pic";
                    picpara.Value = picbyte;
                    cmd.Parameters.Add(picpara);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmd.Parameters.Clear();
                    cmd2 = new SqlCommand("INSERT into Defaulters(Id,Name,Address,DateAdmission,entryfee)VALUES('" + id + "','" + Name + "','" + Address + "','" + dateTimePicker1.Text + "','" + entryfee + "')",con);
        
                    

                    cmd2.ExecuteNonQuery();
                    cmd2.Parameters.Clear();
                    MessageBox.Show("Data Has Been Save", "S A V E", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    


                    ///objda = new SqlDataAdapter(objcmd);
                    ///objds = new DataSet();
                    //objds.Clear();
                    ///objda.Fill(objds, "Register");

                    txtId.Clear();
                    txtName.Clear();
                    txtPhoneNo.Clear();
                    txtEntryFee.Clear();
                    txtAddress.Clear();
                    rbMale.Checked = false;
                    rbfemale.Checked = false;
                    txtFather.Clear();
                    txtCnic.Clear();
                    pictureBox1.Image = null;

                    dateTimePicker1.Text = DateTime.Now.ToString();


                    MessageBox.Show("Registration Complete Successfully");
                }
                else
                    MessageBox.Show("wrong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in registration due to"+ex);
            }
            //finally{
            //    if (con.State==ConnectionState.Open)
            //    {
            //        con.Close();
            //    }



            //}

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtImagePath.Clear();
            pbPic.Image = null;
            txtId.Clear();
            txtName.Clear();
            txtPhoneNo.Clear();
            txtEntryFee.Clear();
            txtAddress.Clear();
            rbMale.Checked = false;
            rbfemale.Checked = false;
            txtCnic.Clear();
            txtFather.Clear();

            dateTimePicker1.Text = DateTime.Now.ToString();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtId_Click(object sender, EventArgs e)
        {
            
        }

        private void rbfemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text=="")
                {
                    txtId.Clear();
                    txtName.Clear();
                    txtFather.Clear();
                    txtCnic.Clear();
                    txtAddress.Clear();
                    txtEntryFee.Clear();
                    txtPhoneNo.Clear();
                }

                string comand = "select * from REGISTERTION where Id LIKE '%" + txtSearch.Text + "%' or Name LIKE'%" + txtSearch.Text + "%'";
                con = new SqlConnection(c);
                con.Open();
                cmd = new SqlCommand(comand, con);
                mdr = cmd.ExecuteReader();
                da = new SqlDataAdapter(cmd.CommandText, con);
                ds = new DataSet();
                if (mdr.Read())
                {
                    txtId.Text= mdr["ID"].ToString();
                    txtName.Text = mdr["Name"].ToString();
                    txtFather.Text = mdr["FatherName"].ToString();
                    txtCnic.Text = mdr["Cnic"].ToString();
                    txtAddress.Text = mdr["Address"].ToString();
                    txtEntryFee.Text = mdr["entryfee"].ToString();
                    txtPhoneNo.Text = mdr["phoneNumber"].ToString();

                }
                else
                {

                    MessageBox.Show("Record Not Found " , "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                }
                con.Close();


            }
            catch (Exception exe)
            {

                MessageBox.Show(exe.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text=="")
            {
                MessageBox.Show("Plz Enter Roll No here " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }

            else
            {
                try
                {

                    con = new SqlConnection(c);

                    cmd = new SqlCommand("update REGISTERTION set Id='" + txtId.Text + "', Name='" + txtName.Text + "',FatherName='" + txtFather.Text + "',Cnic='" + txtCnic.Text + "',Address='" + txtAddress.Text + "',entryfee='" + txtEntryFee.Text + "',phoneNumber='" + txtPhoneNo.Text + "' where Id=" + txtId.Text, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ds.Clear();
                    da.Fill(ds, "tbl");
                    MessageBox.Show("data successfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception e1)
                {
                    MessageBox.Show("Your error is " + e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text=="")
                {
                    MessageBox.Show("Enter roll no for deleting " , "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    var query = "Delete REGISTERTION where Id='" + txtSearch.Text + "'";
                    con = new SqlConnection(c);
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();//////////////
                    var query2 = "Delete Defaulters where Id='" + txtSearch.Text + "'";
                    
                    cmd = new SqlCommand(query2, con);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    MessageBox.Show("Record Has Been Deleted", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                    this.Close();
                    Menu m = new Menu();
                    m.Show();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnChangeimage_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != null)
                {
                    string imgpath = txtImagePath.Text;
                    FileStream fs;
                    fs = new FileStream(@imgpath, FileMode.Open, FileAccess.Read);
                    byte[] picbyte = new byte[fs.Length];
                    fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
                    fs.Close();

                    con = new SqlConnection(c);
                    con.Open();
                    cmd = new SqlCommand("Update REGISTERTION set IMG_PATH ='" + txtImagePath.Text + "',IMG_PIC= @pic where Id='" + txtId.Text + "'", con);
                    SqlParameter picpara = new SqlParameter();
                    picpara.SqlDbType = SqlDbType.Image;
                    picpara.ParameterName = "pic";
                    picpara.Value = picbyte;
                    cmd.Parameters.Add(picpara);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmd.Parameters.Clear();
                    MessageBox.Show("Picture Has Been Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(txtId.Text=="")
                {
                    MessageBox.Show("Enter Roll No Plz", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error is", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            


        }

        private void materialSingleLineTextField4_Click(object sender, EventArgs e)
        {

        }
    }
}
