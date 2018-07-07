namespace Gym_Management
{
    partial class frmFeePaid
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFee = new System.Windows.Forms.Label();
            this.lblId = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Update = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblMonth = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAmount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtmonth2 = new System.Windows.Forms.TextBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnInsert = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(478, 429);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFee.Location = new System.Drawing.Point(25, 77);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(130, 31);
            this.lblFee.TabIndex = 1;
            this.lblFee.Text = "Fee Paid";
            this.lblFee.Click += new System.EventHandler(this.lblFee_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Depth = 0;
            this.lblId.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblId.Location = new System.Drawing.Point(12, 8);
            this.lblId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(165, 19);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Search Here By Roll No";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gym_Management.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(860, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 386);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btndelete
            // 
            this.btndelete.AutoSize = true;
            this.btndelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btndelete.Depth = 0;
            this.btndelete.Icon = null;
            this.btndelete.Location = new System.Drawing.Point(145, 84);
            this.btndelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btndelete.Name = "btndelete";
            this.btndelete.Primary = true;
            this.btndelete.Size = new System.Drawing.Size(142, 36);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Delete Fee Entry";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Update
            // 
            this.Update.AutoSize = true;
            this.Update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Update.Depth = 0;
            this.Update.Icon = null;
            this.Update.Location = new System.Drawing.Point(418, 250);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Update.MouseState = MaterialSkin.MouseState.HOVER;
            this.Update.Name = "Update";
            this.Update.Primary = false;
            this.Update.Size = new System.Drawing.Size(73, 36);
            this.Update.TabIndex = 4;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(109, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(178, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Depth = 0;
            this.lblMonth.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMonth.Location = new System.Drawing.Point(32, 172);
            this.lblMonth.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(52, 19);
            this.lblMonth.TabIndex = 8;
            this.lblMonth.Text = "Month";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(32, 208);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(90, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Amount Fee";
            // 
            // txtAmount
            // 
            this.txtAmount.Depth = 0;
            this.txtAmount.Hint = "";
            this.txtAmount.Location = new System.Drawing.Point(202, 208);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.Size = new System.Drawing.Size(205, 23);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TabStop = false;
            this.txtAmount.UseSystemPasswordChar = false;
            this.txtAmount.Click += new System.EventHandler(this.txtAmount_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 248);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(32, 250);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(123, 19);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Date Submission";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(32, 135);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(68, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "Edit here";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.txtmonth2);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Location = new System.Drawing.Point(513, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 125);
            this.panel1.TabIndex = 3;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 57);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(91, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Enter Month";
            // 
            // txtmonth2
            // 
            this.txtmonth2.Location = new System.Drawing.Point(109, 56);
            this.txtmonth2.Name = "txtmonth2";
            this.txtmonth2.Size = new System.Drawing.Size(178, 20);
            this.txtmonth2.TabIndex = 1;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(529, 250);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(90, 36);
            this.materialFlatButton1.TabIndex = 5;
            this.materialFlatButton1.Text = "Clear All";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.AutoSize = true;
            this.btnInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsert.Depth = 0;
            this.btnInsert.Icon = null;
            this.btnInsert.Location = new System.Drawing.Point(641, 248);
            this.btnInsert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Primary = true;
            this.btnInsert.Size = new System.Drawing.Size(123, 36);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert Record";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(204, 172);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(200, 20);
            this.txtMonth.TabIndex = 1;
            this.txtMonth.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(418, 195);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(73, 36);
            this.materialRaisedButton1.TabIndex = 16;
            this.materialRaisedButton1.Text = "Search";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(529, 346);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(235, 384);
            this.dataGridView2.TabIndex = 17;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(525, 314);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 19);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name Details";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(632, 314);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // frmFeePaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1185, 729);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFeePaid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFeePaid";
            this.Load += new System.EventHandler(this.frmFeePaid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblFee;
        private MaterialSkin.Controls.MaterialLabel lblId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btndelete;
        private MaterialSkin.Controls.MaterialFlatButton Update;
        private System.Windows.Forms.TextBox txtId;
        private MaterialSkin.Controls.MaterialLabel lblMonth;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAmount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialRaisedButton btnInsert;
        private System.Windows.Forms.TextBox txtMonth;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox txtmonth2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private System.Windows.Forms.TextBox textBox2;
    }
}