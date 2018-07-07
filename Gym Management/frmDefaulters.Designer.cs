namespace Gym_Management
{
    partial class frmDefaulters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.lblRollno = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.btnSumit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAmount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnClear = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRollNo
            // 
            this.txtRollNo.Location = new System.Drawing.Point(140, 89);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(126, 20);
            this.txtRollNo.TabIndex = 0;
            this.txtRollNo.TextChanged += new System.EventHandler(this.txtRollNo_TextChanged);
            // 
            // lblRollno
            // 
            this.lblRollno.AutoSize = true;
            this.lblRollno.Depth = 0;
            this.lblRollno.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRollno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRollno.Location = new System.Drawing.Point(12, 88);
            this.lblRollno.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRollno.Name = "lblRollno";
            this.lblRollno.Size = new System.Drawing.Size(59, 19);
            this.lblRollno.TabIndex = 1;
            this.lblRollno.Text = "Roll No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 401);
            this.dataGridView1.TabIndex = 4;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "Feburary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(140, 125);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(126, 21);
            this.cmbMonth.TabIndex = 1;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSumit
            // 
            this.btnSumit.AutoSize = true;
            this.btnSumit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSumit.Depth = 0;
            this.btnSumit.Icon = null;
            this.btnSumit.Location = new System.Drawing.Point(393, 89);
            this.btnSumit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSumit.Name = "btnSumit";
            this.btnSumit.Primary = true;
            this.btnSumit.Size = new System.Drawing.Size(98, 36);
            this.btnSumit.TabIndex = 3;
            this.btnSumit.Text = "Submit Fee";
            this.btnSumit.UseVisualStyleBackColor = true;
            this.btnSumit.Click += new System.EventHandler(this.btnSumit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(11, 125);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 19);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Month";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(15, 163);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(90, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Amount Fee";
            // 
            // txtAmount
            // 
            this.txtAmount.Depth = 0;
            this.txtAmount.Hint = "";
            this.txtAmount.Location = new System.Drawing.Point(140, 163);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.Size = new System.Drawing.Size(188, 23);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TabStop = false;
            this.txtAmount.UseSystemPasswordChar = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 205);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(11, 205);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(121, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Submission date";
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Depth = 0;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(393, 155);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = false;
            this.btnClear.Size = new System.Drawing.Size(63, 36);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gym_Management.Properties.Resources.footer_img_left;
            this.pictureBox1.Location = new System.Drawing.Point(800, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 347);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(383, 205);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(108, 36);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "Next month";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(482, 155);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(69, 36);
            this.materialFlatButton1.TabIndex = 5;
            this.materialFlatButton1.Text = "Delete ";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click_2);
            // 
            // frmDefaulters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 654);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSumit);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblRollno);
            this.Controls.Add(this.txtRollNo);
            this.Name = "frmDefaulters";
            this.Text = "frmDefaulters";
            this.Load += new System.EventHandler(this.frmDefaulters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRollNo;
        private MaterialSkin.Controls.MaterialLabel lblRollno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbMonth;
        private MaterialSkin.Controls.MaterialRaisedButton btnSumit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAmount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton btnClear;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}