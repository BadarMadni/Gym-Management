namespace Gym_Management
{
    partial class frmRegistration
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
            this.txtId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.txtEntryFee = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPhoneNo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnClear = new MaterialSkin.Controls.MaterialFlatButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dbGymManagemntDataSet1 = new Gym_Management.DbGymManagemntDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFather = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFather = new MaterialSkin.Controls.MaterialLabel();
            this.lblCnic = new MaterialSkin.Controls.MaterialLabel();
            this.txtCnic = new System.Windows.Forms.MaskedTextBox();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnChangeimage = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dbGymManagemntDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Depth = 0;
            this.txtId.Hint = "";
            this.txtId.Location = new System.Drawing.Point(175, 165);
            this.txtId.MaxLength = 32767;
            this.txtId.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.Size = new System.Drawing.Size(201, 23);
            this.txtId.TabIndex = 1;
            this.txtId.TabStop = false;
            this.txtId.UseSystemPasswordChar = false;
            this.txtId.Click += new System.EventHandler(this.txtId_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(40, 165);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(95, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Enter Roll no";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(44, 215);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(49, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Name";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(174, 211);
            this.txtName.MaxLength = 32767;
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(201, 23);
            this.txtName.TabIndex = 2;
            this.txtName.TabStop = false;
            this.txtName.UseSystemPasswordChar = false;
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(171, 382);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(212, 101);
            this.txtAddress.TabIndex = 5;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(40, 400);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(64, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Address";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(48, 512);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(56, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbMale.Location = new System.Drawing.Point(178, 512);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbfemale.Location = new System.Drawing.Point(303, 512);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(59, 17);
            this.rbfemale.TabIndex = 7;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            this.rbfemale.CheckedChanged += new System.EventHandler(this.rbfemale_CheckedChanged);
            // 
            // txtEntryFee
            // 
            this.txtEntryFee.Depth = 0;
            this.txtEntryFee.Hint = "";
            this.txtEntryFee.Location = new System.Drawing.Point(174, 568);
            this.txtEntryFee.MaxLength = 32767;
            this.txtEntryFee.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEntryFee.Name = "txtEntryFee";
            this.txtEntryFee.PasswordChar = '\0';
            this.txtEntryFee.SelectedText = "";
            this.txtEntryFee.SelectionLength = 0;
            this.txtEntryFee.SelectionStart = 0;
            this.txtEntryFee.Size = new System.Drawing.Size(205, 23);
            this.txtEntryFee.TabIndex = 8;
            this.txtEntryFee.TabStop = false;
            this.txtEntryFee.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(44, 568);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(71, 19);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Entry Fee";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 670);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(170, 712);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(76, 36);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save As";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(44, 672);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(93, 19);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "Joining Date";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(44, 619);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(108, 19);
            this.materialLabel7.TabIndex = 14;
            this.materialLabel7.Text = "Phone Number";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Depth = 0;
            this.txtPhoneNo.Hint = "";
            this.txtPhoneNo.Location = new System.Drawing.Point(179, 619);
            this.txtPhoneNo.MaxLength = 32767;
            this.txtPhoneNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.PasswordChar = '\0';
            this.txtPhoneNo.SelectedText = "";
            this.txtPhoneNo.SelectionLength = 0;
            this.txtPhoneNo.SelectionStart = 0;
            this.txtPhoneNo.Size = new System.Drawing.Size(201, 23);
            this.txtPhoneNo.TabIndex = 9;
            this.txtPhoneNo.TabStop = false;
            this.txtPhoneNo.UseSystemPasswordChar = false;
            this.txtPhoneNo.Click += new System.EventHandler(this.materialSingleLineTextField4_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Depth = 0;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(294, 712);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = false;
            this.btnClear.Size = new System.Drawing.Size(104, 36);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(925, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dbGymManagemntDataSet1
            // 
            this.dbGymManagemntDataSet1.DataSetName = "gr";
            this.dbGymManagemntDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gym_Management.Properties.Resources.cards_membership;
            this.pictureBox1.Location = new System.Drawing.Point(408, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 378);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pbPic
            // 
            this.pbPic.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pbPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPic.Location = new System.Drawing.Point(839, 101);
            this.pbPic.Name = "pbPic";
            this.pbPic.Size = new System.Drawing.Size(177, 150);
            this.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPic.TabIndex = 17;
            this.pbPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(292, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 42);
            this.label1.TabIndex = 24;
            this.label1.Text = "Registration Form";
            // 
            // txtFather
            // 
            this.txtFather.Depth = 0;
            this.txtFather.Hint = "";
            this.txtFather.Location = new System.Drawing.Point(175, 263);
            this.txtFather.MaxLength = 32767;
            this.txtFather.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFather.Name = "txtFather";
            this.txtFather.PasswordChar = '\0';
            this.txtFather.SelectedText = "";
            this.txtFather.SelectionLength = 0;
            this.txtFather.SelectionStart = 0;
            this.txtFather.Size = new System.Drawing.Size(199, 23);
            this.txtFather.TabIndex = 3;
            this.txtFather.TabStop = false;
            this.txtFather.UseSystemPasswordChar = false;
            // 
            // lblFather
            // 
            this.lblFather.AutoSize = true;
            this.lblFather.Depth = 0;
            this.lblFather.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFather.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFather.Location = new System.Drawing.Point(27, 268);
            this.lblFather.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFather.Name = "lblFather";
            this.lblFather.Size = new System.Drawing.Size(95, 19);
            this.lblFather.TabIndex = 27;
            this.lblFather.Text = "Father Name";
            // 
            // lblCnic
            // 
            this.lblCnic.AutoSize = true;
            this.lblCnic.Depth = 0;
            this.lblCnic.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCnic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCnic.Location = new System.Drawing.Point(31, 324);
            this.lblCnic.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCnic.Name = "lblCnic";
            this.lblCnic.Size = new System.Drawing.Size(39, 19);
            this.lblCnic.TabIndex = 28;
            this.lblCnic.Text = "Cnic";
            // 
            // txtCnic
            // 
            this.txtCnic.Location = new System.Drawing.Point(171, 323);
            this.txtCnic.Mask = "00000-0000000-0";
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(203, 20);
            this.txtCnic.TabIndex = 4;
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(839, 73);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(177, 20);
            this.txtImagePath.TabIndex = 29;
            this.txtImagePath.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(127, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 20);
            this.txtSearch.TabIndex = 30;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Depth = 0;
            this.lblSearch.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSearch.Location = new System.Drawing.Point(3, 26);
            this.lblSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(91, 19);
            this.lblSearch.TabIndex = 31;
            this.lblSearch.Text = "Search Here";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnChangeimage);
            this.panel1.Controls.Add(this.materialFlatButton1);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(408, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 125);
            this.panel1.TabIndex = 33;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(127, 48);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(168, 36);
            this.materialFlatButton1.TabIndex = 33;
            this.materialFlatButton1.Text = "Delete Registration";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(7, 84);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(134, 36);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update Results";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnChangeimage
            // 
            this.btnChangeimage.AutoSize = true;
            this.btnChangeimage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangeimage.Depth = 0;
            this.btnChangeimage.Icon = null;
            this.btnChangeimage.Location = new System.Drawing.Point(213, 82);
            this.btnChangeimage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChangeimage.Name = "btnChangeimage";
            this.btnChangeimage.Primary = true;
            this.btnChangeimage.Size = new System.Drawing.Size(125, 36);
            this.btnChangeimage.TabIndex = 34;
            this.btnChangeimage.Text = "Change Photo";
            this.btnChangeimage.UseVisualStyleBackColor = true;
            this.btnChangeimage.Click += new System.EventHandler(this.btnChangeimage_Click);
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 772);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.txtCnic);
            this.Controls.Add(this.lblCnic);
            this.Controls.Add(this.lblFather);
            this.Controls.Add(this.txtFather);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbPic);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtEntryFee);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtId);
            this.MaximizeBox = false;
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbGymManagemntDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtId;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbfemale;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEntryFee;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPhoneNo;
        private MaterialSkin.Controls.MaterialFlatButton btnClear;
        private System.Windows.Forms.PictureBox pbPic;
        private System.Windows.Forms.Button button1;
        private DbGymManagemntDataSet dbGymManagemntDataSet1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFather;
        private MaterialSkin.Controls.MaterialLabel lblFather;
        private MaterialSkin.Controls.MaterialLabel lblCnic;
        private System.Windows.Forms.MaskedTextBox txtCnic;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.TextBox txtSearch;
        private MaterialSkin.Controls.MaterialLabel lblSearch;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialRaisedButton btnChangeimage;
    }
}