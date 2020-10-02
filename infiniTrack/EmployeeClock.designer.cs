namespace infiniTrack
{
    partial class frmEmployeeClock
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
            this.toolTipClock = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMenuDescription = new System.Windows.Forms.Panel();
            this.picVerticalLine = new System.Windows.Forms.PictureBox();
            this.lstMenuDescription = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Project = new System.Windows.Forms.Label();
            this.dtpClockedOut = new System.Windows.Forms.DateTimePicker();
            this.dtpClockedIn = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveTime = new System.Windows.Forms.Button();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.cmbPhase = new System.Windows.Forms.ComboBox();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.projectTableAdapter = new infiniTrack.infinitrackDataSetTableAdapters.projectTableAdapter();
            this.activity_laborTableAdapter = new infiniTrack.infinitrackDataSetTableAdapters.activity_laborTableAdapter();
            this.infinitrackDataSet = new infiniTrack.infinitrackDataSet();
            this.activity_laborBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new infiniTrack.infinitrackDataSetTableAdapters.TableAdapterManager();
            this.activity_laborDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHorizontalLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlMenuDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVerticalLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infinitrackDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activity_laborBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activity_laborDataGridView)).BeginInit();
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
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(115, 655);
            this.pnlMenu.TabIndex = 9;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(7, 545);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 83);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.pnlMenu_Click);
            // 
            // btnClock
            // 
            this.btnClock.FlatAppearance.BorderSize = 0;
            this.btnClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClock.Location = new System.Drawing.Point(7, 369);
            this.btnClock.Margin = new System.Windows.Forms.Padding(4);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(100, 83);
            this.btnClock.TabIndex = 2;
            this.btnClock.UseVisualStyleBackColor = true;
            this.btnClock.Click += new System.EventHandler(this.pnlMenu_Click);
            // 
            // btnProject
            // 
            this.btnProject.FlatAppearance.BorderSize = 0;
            this.btnProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProject.Location = new System.Drawing.Point(7, 281);
            this.btnProject.Margin = new System.Windows.Forms.Padding(4);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(100, 83);
            this.btnProject.TabIndex = 1;
            this.btnProject.UseVisualStyleBackColor = true;
            this.btnProject.Click += new System.EventHandler(this.pnlMenu_Click);
            // 
            // picHorizontalLine
            // 
            this.picHorizontalLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picHorizontalLine.ErrorImage = null;
            this.picHorizontalLine.InitialImage = null;
            this.picHorizontalLine.Location = new System.Drawing.Point(4, 91);
            this.picHorizontalLine.Margin = new System.Windows.Forms.Padding(4);
            this.picHorizontalLine.Name = "picHorizontalLine";
            this.picHorizontalLine.Size = new System.Drawing.Size(103, 67);
            this.picHorizontalLine.TabIndex = 3;
            this.picHorizontalLine.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Location = new System.Drawing.Point(7, 457);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 83);
            this.btnReport.TabIndex = 3;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.pnlMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(7, 193);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 83);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.pnlMenu_Click);
            // 
            // picLogo
            // 
            this.picLogo.ErrorImage = null;
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(7, 19);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(104, 77);
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
            this.pnlTop.Location = new System.Drawing.Point(115, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(966, 31);
            this.pnlTop.TabIndex = 11;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(856, 4);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 23);
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
            this.btnMax.Location = new System.Drawing.Point(896, 4);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(25, 23);
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
            this.btnClose.Location = new System.Drawing.Point(936, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 23);
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
            this.pnlMenuDescription.Location = new System.Drawing.Point(115, 0);
            this.pnlMenuDescription.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenuDescription.Name = "pnlMenuDescription";
            this.pnlMenuDescription.Size = new System.Drawing.Size(53, 1079);
            this.pnlMenuDescription.TabIndex = 10;
            // 
            // picVerticalLine
            // 
            this.picVerticalLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picVerticalLine.ErrorImage = null;
            this.picVerticalLine.InitialImage = null;
            this.picVerticalLine.Location = new System.Drawing.Point(0, 0);
            this.picVerticalLine.Margin = new System.Windows.Forms.Padding(4);
            this.picVerticalLine.Name = "picVerticalLine";
            this.picVerticalLine.Size = new System.Drawing.Size(43, 1079);
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
            this.lstMenuDescription.Location = new System.Drawing.Point(53, 233);
            this.lstMenuDescription.Margin = new System.Windows.Forms.Padding(4);
            this.lstMenuDescription.Name = "lstMenuDescription";
            this.lstMenuDescription.Size = new System.Drawing.Size(227, 209);
            this.lstMenuDescription.TabIndex = 0;
            this.lstMenuDescription.SelectedIndexChanged += new System.EventHandler(this.lstMenuDescription_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(199, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Employee Clock";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(710, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Activity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(512, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Phase:";
            // 
            // Project
            // 
            this.Project.AutoSize = true;
            this.Project.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Project.ForeColor = System.Drawing.Color.White;
            this.Project.Location = new System.Drawing.Point(299, 138);
            this.Project.Name = "Project";
            this.Project.Size = new System.Drawing.Size(47, 15);
            this.Project.TabIndex = 13;
            this.Project.Text = "Project:";
            // 
            // dtpClockedOut
            // 
            this.dtpClockedOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpClockedOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpClockedOut.Location = new System.Drawing.Point(682, 273);
            this.dtpClockedOut.Margin = new System.Windows.Forms.Padding(4);
            this.dtpClockedOut.Name = "dtpClockedOut";
            this.dtpClockedOut.ShowUpDown = true;
            this.dtpClockedOut.Size = new System.Drawing.Size(152, 23);
            this.dtpClockedOut.TabIndex = 5;
            // 
            // dtpClockedIn
            // 
            this.dtpClockedIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpClockedIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpClockedIn.Location = new System.Drawing.Point(682, 228);
            this.dtpClockedIn.Margin = new System.Windows.Forms.Padding(4);
            this.dtpClockedIn.Name = "dtpClockedIn";
            this.dtpClockedIn.ShowUpDown = true;
            this.dtpClockedIn.Size = new System.Drawing.Size(152, 23);
            this.dtpClockedIn.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(554, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Clock-out Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(554, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Clock-in Time:";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(587, 332);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(208, 33);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveTime
            // 
            this.btnSaveTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTime.ForeColor = System.Drawing.Color.White;
            this.btnSaveTime.Location = new System.Drawing.Point(363, 332);
            this.btnSaveTime.Name = "btnSaveTime";
            this.btnSaveTime.Size = new System.Drawing.Size(203, 33);
            this.btnSaveTime.TabIndex = 6;
            this.btnSaveTime.Text = "&Save Time";
            this.btnSaveTime.UseVisualStyleBackColor = true;
            this.btnSaveTime.Click += new System.EventHandler(this.btnSaveTime_Click);
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(303, 162);
            this.cmbProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(167, 23);
            this.cmbProject.TabIndex = 0;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            // 
            // cmbPhase
            // 
            this.cmbPhase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhase.FormattingEnabled = true;
            this.cmbPhase.Location = new System.Drawing.Point(515, 162);
            this.cmbPhase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPhase.Name = "cmbPhase";
            this.cmbPhase.Size = new System.Drawing.Size(153, 23);
            this.cmbPhase.TabIndex = 1;
            this.cmbPhase.SelectedIndexChanged += new System.EventHandler(this.cmbPhase_SelectedIndexChanged);
            // 
            // cmbActivity
            // 
            this.cmbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivity.FormattingEnabled = true;
            this.cmbActivity.Location = new System.Drawing.Point(713, 162);
            this.cmbActivity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(121, 23);
            this.cmbActivity.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(299, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(303, 257);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 23);
            this.dtpDate.TabIndex = 3;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // activity_laborTableAdapter
            // 
            this.activity_laborTableAdapter.ClearBeforeFill = true;
            // 
            // infinitrackDataSet
            // 
            this.infinitrackDataSet.DataSetName = "infinitrackDataSet";
            this.infinitrackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activity_laborBindingSource
            // 
            this.activity_laborBindingSource.DataMember = "activity_labor";
            this.activity_laborBindingSource.DataSource = this.infinitrackDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.activity_laborTableAdapter = this.activity_laborTableAdapter;
            this.tableAdapterManager.activity_materialTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.infinitrack_userTableAdapter = null;
            this.tableAdapterManager.materialTableAdapter = null;
            this.tableAdapterManager.project_activityTableAdapter = null;
            this.tableAdapterManager.project_phaseTableAdapter = null;
            this.tableAdapterManager.project_teamTableAdapter = null;
            this.tableAdapterManager.projectTableAdapter = this.projectTableAdapter;
            this.tableAdapterManager.team_employeeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = infiniTrack.infinitrackDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // activity_laborDataGridView
            // 
            this.activity_laborDataGridView.AutoGenerateColumns = false;
            this.activity_laborDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activity_laborDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.activity_laborDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activity_laborDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.activity_laborDataGridView.DataSource = this.activity_laborBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.activity_laborDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.activity_laborDataGridView.EnableHeadersVisualStyles = false;
            this.activity_laborDataGridView.Location = new System.Drawing.Point(253, 411);
            this.activity_laborDataGridView.MultiSelect = false;
            this.activity_laborDataGridView.Name = "activity_laborDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activity_laborDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.activity_laborDataGridView.Size = new System.Drawing.Size(645, 220);
            this.activity_laborDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tran_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tran_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Activity_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Activity_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Employee_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Employee_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Clock_IN";
            this.dataGridViewTextBoxColumn5.HeaderText = "Clock_IN";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Clock_Out";
            this.dataGridViewTextBoxColumn6.HeaderText = "Clock_Out";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(949, 505);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmEmployeeClock
            // 
            this.AcceptButton = this.btnSaveTime;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1081, 655);
            this.Controls.Add(this.pnlMenuDescription);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.activity_laborDataGridView);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbActivity);
            this.Controls.Add(this.cmbPhase);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveTime);
            this.Controls.Add(this.dtpClockedOut);
            this.Controls.Add(this.dtpClockedIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Project);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmployeeClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Clock";
            this.Load += new System.EventHandler(this.frmEmployeeClock_Load);
            this.Click += new System.EventHandler(this.frmEmployeeClock_Click);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHorizontalLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlMenuDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVerticalLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infinitrackDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activity_laborBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activity_laborDataGridView)).EndInit();
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
        private System.Windows.Forms.ToolTip toolTipClock;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.PictureBox picHorizontalLine;
        private System.Windows.Forms.Panel pnlMenuDescription;
        private System.Windows.Forms.ListBox lstMenuDescription;
        private System.Windows.Forms.PictureBox picVerticalLine;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnClock;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Project;
        private System.Windows.Forms.DateTimePicker dtpClockedOut;
        private System.Windows.Forms.DateTimePicker dtpClockedIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveTime;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.ComboBox cmbPhase;
        private infinitrackDataSetTableAdapters.projectTableAdapter projectTableAdapter;
        private System.Windows.Forms.ComboBox cmbActivity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private infinitrackDataSetTableAdapters.activity_laborTableAdapter activity_laborTableAdapter;
        private infinitrackDataSet infinitrackDataSet;
        private System.Windows.Forms.BindingSource activity_laborBindingSource;
        private infinitrackDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView activity_laborDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnDelete;
    }
}

