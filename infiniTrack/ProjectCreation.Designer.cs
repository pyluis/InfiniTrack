namespace infiniTrack
{
    partial class frmProjectCreation
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnClock = new System.Windows.Forms.Button();
            this.btnProject = new System.Windows.Forms.Button();
            this.picHorizontalLine = new System.Windows.Forms.PictureBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolTipProject = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMenuDescription = new System.Windows.Forms.Panel();
            this.picVerticalLine = new System.Windows.Forms.PictureBox();
            this.lstMenuDescription = new System.Windows.Forms.ListBox();
            this.txtProjectname = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.dtpDeliverydate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartdate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infinitrackDataSet = new infiniTrack.infinitrackDataSet();
            this.project_teamTableAdapter = new infiniTrack.infinitrackDataSetTableAdapters.project_teamTableAdapter();
            this.team_employeeTableAdapter = new infiniTrack.infinitrackDataSetTableAdapters.team_employeeTableAdapter();
            this.projectTableAdapter = new infiniTrack.infinitrackDataSetTableAdapters.projectTableAdapter();
            this.tableAdapterManager = new infiniTrack.infinitrackDataSetTableAdapters.TableAdapterManager();
            this.customerTableAdapter = new infiniTrack.infinitrackDataSetTableAdapters.customerTableAdapter();
            this.projectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHorizontalLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlMenuDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVerticalLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infinitrackDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnClock);
            this.pnlMenu.Controls.Add(this.btnProject);
            this.pnlMenu.Controls.Add(this.picHorizontalLine);
            this.pnlMenu.Controls.Add(this.btnReport);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.picLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(100, 749);
            this.pnlMenu.TabIndex = 14;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(6, 549);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(87, 62);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.pnlMenu_Click);
            // 
            // btnClock
            // 
            this.btnClock.FlatAppearance.BorderSize = 0;
            this.btnClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClock.Location = new System.Drawing.Point(6, 348);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(87, 62);
            this.btnClock.TabIndex = 2;
            this.btnClock.UseVisualStyleBackColor = true;
            this.btnClock.Click += new System.EventHandler(this.pnlMenu_Click);
            // 
            // btnProject
            // 
            this.btnProject.FlatAppearance.BorderSize = 0;
            this.btnProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProject.Location = new System.Drawing.Point(6, 248);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(87, 62);
            this.btnProject.TabIndex = 1;
            this.btnProject.UseVisualStyleBackColor = true;
            this.btnProject.Click += new System.EventHandler(this.pnlMenu_Click);
            // 
            // picHorizontalLine
            // 
            this.picHorizontalLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picHorizontalLine.ErrorImage = null;
            this.picHorizontalLine.InitialImage = null;
            this.picHorizontalLine.Location = new System.Drawing.Point(3, 68);
            this.picHorizontalLine.Name = "picHorizontalLine";
            this.picHorizontalLine.Size = new System.Drawing.Size(90, 50);
            this.picHorizontalLine.TabIndex = 3;
            this.picHorizontalLine.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Location = new System.Drawing.Point(6, 449);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(87, 62);
            this.btnReport.TabIndex = 3;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.pnlMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(6, 148);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(87, 62);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.pnlMenu_Click);
            // 
            // picLogo
            // 
            this.picLogo.ErrorImage = null;
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(6, 14);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(91, 58);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnMin);
            this.pnlTop.Controls.Add(this.btnMax);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(100, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1021, 23);
            this.pnlTop.TabIndex = 16;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(925, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(22, 17);
            this.btnMin.TabIndex = 0;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.titleBar_Controls);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Location = new System.Drawing.Point(960, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(22, 17);
            this.btnMax.TabIndex = 1;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.titleBar_Controls);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(995, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 17);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.titleBar_Controls);
            // 
            // pnlMenuDescription
            // 
            this.pnlMenuDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenuDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMenuDescription.Controls.Add(this.picVerticalLine);
            this.pnlMenuDescription.Controls.Add(this.lstMenuDescription);
            this.pnlMenuDescription.Location = new System.Drawing.Point(100, 0);
            this.pnlMenuDescription.Name = "pnlMenuDescription";
            this.pnlMenuDescription.Size = new System.Drawing.Size(47, 1016);
            this.pnlMenuDescription.TabIndex = 15;
            // 
            // picVerticalLine
            // 
            this.picVerticalLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picVerticalLine.ErrorImage = null;
            this.picVerticalLine.InitialImage = null;
            this.picVerticalLine.Location = new System.Drawing.Point(0, 0);
            this.picVerticalLine.Name = "picVerticalLine";
            this.picVerticalLine.Size = new System.Drawing.Size(37, 1016);
            this.picVerticalLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVerticalLine.TabIndex = 3;
            this.picVerticalLine.TabStop = false;
            // 
            // lstMenuDescription
            // 
            this.lstMenuDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstMenuDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstMenuDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMenuDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMenuDescription.ForeColor = System.Drawing.Color.White;
            this.lstMenuDescription.FormattingEnabled = true;
            this.lstMenuDescription.ItemHeight = 19;
            this.lstMenuDescription.Location = new System.Drawing.Point(47, 175);
            this.lstMenuDescription.Name = "lstMenuDescription";
            this.lstMenuDescription.Size = new System.Drawing.Size(198, 456);
            this.lstMenuDescription.TabIndex = 0;
            this.lstMenuDescription.SelectedIndexChanged += new System.EventHandler(this.lstMenuDescription_SelectedIndexChanged);
            // 
            // txtProjectname
            // 
            this.txtProjectname.Location = new System.Drawing.Point(341, 122);
            this.txtProjectname.Name = "txtProjectname";
            this.txtProjectname.Size = new System.Drawing.Size(200, 21);
            this.txtProjectname.TabIndex = 0;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(737, 122);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(200, 21);
            this.txtStreet.TabIndex = 6;
            // 
            // dtpDeliverydate
            // 
            this.dtpDeliverydate.Location = new System.Drawing.Point(737, 294);
            this.dtpDeliverydate.Name = "dtpDeliverydate";
            this.dtpDeliverydate.Size = new System.Drawing.Size(227, 21);
            this.dtpDeliverydate.TabIndex = 10;
            // 
            // dtpStartdate
            // 
            this.dtpStartdate.Location = new System.Drawing.Point(737, 251);
            this.dtpStartdate.Name = "dtpStartdate";
            this.dtpStartdate.Size = new System.Drawing.Size(227, 21);
            this.dtpStartdate.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(576, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 18);
            this.label14.TabIndex = 28;
            this.label14.Text = "Delivery Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(576, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Start Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(576, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Project Street:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(171, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 18);
            this.label13.TabIndex = 18;
            this.label13.Text = "Project Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(171, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "CustomerID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(171, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Team Assigned:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(171, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(171, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Project Creation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(576, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Project City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(737, 165);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(83, 21);
            this.txtCity.TabIndex = 7;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CancelKeysCity);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(576, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Project ZIP:";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(737, 208);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(83, 21);
            this.txtZip.TabIndex = 8;
            this.txtZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CancelKeys);
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(483, 396);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(82, 28);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(623, 396);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 28);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(171, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cost Budget:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(171, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Hour Budget:";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(341, 288);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(200, 21);
            this.txtHours.TabIndex = 4;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(341, 328);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(200, 21);
            this.txtCost.TabIndex = 5;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(341, 162);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(200, 23);
            this.cmbCustomer.TabIndex = 1;
            // 
            // cmbTeam
            // 
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Location = new System.Drawing.Point(341, 204);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(200, 23);
            this.cmbTeam.TabIndex = 2;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(341, 246);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 23);
            this.cmbCategory.TabIndex = 3;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "project";
            this.projectBindingSource.DataSource = this.infinitrackDataSet;
            // 
            // infinitrackDataSet
            // 
            this.infinitrackDataSet.DataSetName = "infinitrackDataSet";
            this.infinitrackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // project_teamTableAdapter
            // 
            this.project_teamTableAdapter.ClearBeforeFill = true;
            // 
            // team_employeeTableAdapter
            // 
            this.team_employeeTableAdapter.ClearBeforeFill = true;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.activity_laborTableAdapter = null;
            this.tableAdapterManager.activity_materialTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.infinitrack_userTableAdapter = null;
            this.tableAdapterManager.materialTableAdapter = null;
            this.tableAdapterManager.project_activityTableAdapter = null;
            this.tableAdapterManager.project_phaseTableAdapter = null;
            this.tableAdapterManager.project_teamTableAdapter = this.project_teamTableAdapter;
            this.tableAdapterManager.projectTableAdapter = this.projectTableAdapter;
            this.tableAdapterManager.team_employeeTableAdapter = this.team_employeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = infiniTrack.infinitrackDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // projectDataGridView
            // 
            this.projectDataGridView.AllowUserToAddRows = false;
            this.projectDataGridView.AllowUserToDeleteRows = false;
            this.projectDataGridView.AutoGenerateColumns = false;
            this.projectDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.projectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn13});
            this.projectDataGridView.DataSource = this.projectBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.projectDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.projectDataGridView.EnableHeadersVisualStyles = false;
            this.projectDataGridView.Location = new System.Drawing.Point(175, 487);
            this.projectDataGridView.MultiSelect = false;
            this.projectDataGridView.Name = "projectDataGridView";
            this.projectDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.projectDataGridView.Size = new System.Drawing.Size(762, 220);
            this.projectDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Project_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Project_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Project_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Project_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Customer_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Customer_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn4.HeaderText = "Category";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Project_Street";
            this.dataGridViewTextBoxColumn5.HeaderText = "Project_Street";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Project_City";
            this.dataGridViewTextBoxColumn6.HeaderText = "Project_City";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Project_Zip";
            this.dataGridViewTextBoxColumn7.HeaderText = "Project_Zip";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Start_Date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Start_Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Expected_Delivery_Date";
            this.dataGridViewTextBoxColumn9.HeaderText = "Expected_Delivery_Date";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Hour_Budget";
            this.dataGridViewTextBoxColumn10.HeaderText = "Hour_Budget";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Cost_Budget";
            this.dataGridViewTextBoxColumn11.HeaderText = "Cost_Budget";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Project_Detail";
            this.dataGridViewTextBoxColumn12.HeaderText = "Project_Detail";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Completion_Ind";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Completion_Ind";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Completion_Date";
            this.dataGridViewTextBoxColumn13.HeaderText = "Completion_Date";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(987, 578);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmProjectCreation
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1121, 749);
            this.Controls.Add(this.pnlMenuDescription);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.projectDataGridView);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbTeam);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.txtProjectname);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpDeliverydate);
            this.Controls.Add(this.dtpStartdate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProjectCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Creation";
            this.Load += new System.EventHandler(this.frmProjectCreation_Load);
            this.Click += new System.EventHandler(this.frmProjectCreation_Click);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHorizontalLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlMenuDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVerticalLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infinitrackDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ToolTip toolTipProject;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.PictureBox picHorizontalLine;
        private System.Windows.Forms.Panel pnlMenuDescription;
        private System.Windows.Forms.ListBox lstMenuDescription;
        private System.Windows.Forms.PictureBox picVerticalLine;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnClock;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtProjectname;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.DateTimePicker dtpDeliverydate;
        private System.Windows.Forms.DateTimePicker dtpStartdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private infinitrackDataSetTableAdapters.project_teamTableAdapter project_teamTableAdapter;
        private infinitrackDataSetTableAdapters.team_employeeTableAdapter team_employeeTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private infinitrackDataSetTableAdapters.projectTableAdapter projectTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbTeam;
        private System.Windows.Forms.ComboBox cmbCategory;
        private infinitrackDataSet infinitrackDataSet;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private infinitrackDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private infinitrackDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridView projectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Button btnUpdate;
    }
}

