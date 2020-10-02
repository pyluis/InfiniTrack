namespace infiniTrack
{
    partial class frmUserDashboard
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
            this.toolTipUserDashboard = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMenuDescription = new System.Windows.Forms.Panel();
            this.picVerticalLine = new System.Windows.Forms.PictureBox();
            this.lstMenuDescription = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.projectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completion_Ind = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Completion_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infinitrackDataSet = new infiniTrack.infinitrackDataSet();
            this.btnAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnOnGoing = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbProjectName = new System.Windows.Forms.RadioButton();
            this.rdbCategory = new System.Windows.Forms.RadioButton();
            this.txtProjectSearch = new System.Windows.Forms.TextBox();
            this.projectTableAdapter = new infiniTrack.infinitrackDataSetTableAdapters.projectTableAdapter();
            this.tableAdapterManager = new infiniTrack.infinitrackDataSetTableAdapters.TableAdapterManager();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHorizontalLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlMenuDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVerticalLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infinitrackDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.pnlMenu.Size = new System.Drawing.Size(86, 685);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(5, 476);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 54);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.pnlMenu_Click);
            // 
            // btnClock
            // 
            this.btnClock.FlatAppearance.BorderSize = 0;
            this.btnClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClock.Location = new System.Drawing.Point(5, 302);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(75, 54);
            this.btnClock.TabIndex = 2;
            this.btnClock.UseVisualStyleBackColor = true;
            this.btnClock.Click += new System.EventHandler(this.pnlMenu_Click);
            // 
            // btnProject
            // 
            this.btnProject.FlatAppearance.BorderSize = 0;
            this.btnProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProject.Location = new System.Drawing.Point(5, 215);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(75, 54);
            this.btnProject.TabIndex = 1;
            this.btnProject.UseVisualStyleBackColor = true;
            this.btnProject.Click += new System.EventHandler(this.pnlMenu_Click);
            // 
            // picHorizontalLine
            // 
            this.picHorizontalLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picHorizontalLine.ErrorImage = null;
            this.picHorizontalLine.InitialImage = null;
            this.picHorizontalLine.Location = new System.Drawing.Point(3, 59);
            this.picHorizontalLine.Name = "picHorizontalLine";
            this.picHorizontalLine.Size = new System.Drawing.Size(77, 43);
            this.picHorizontalLine.TabIndex = 3;
            this.picHorizontalLine.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Location = new System.Drawing.Point(5, 389);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 54);
            this.btnReport.TabIndex = 3;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.pnlMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(5, 128);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 54);
            this.btnHome.TabIndex = 0;
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            this.picLogo.ErrorImage = null;
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(5, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(78, 50);
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
            this.pnlTop.Location = new System.Drawing.Point(86, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(815, 20);
            this.pnlTop.TabIndex = 4;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(733, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(19, 15);
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
            this.btnMax.Location = new System.Drawing.Point(763, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(19, 15);
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
            this.btnClose.Location = new System.Drawing.Point(793, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(19, 15);
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
            this.pnlMenuDescription.Location = new System.Drawing.Point(86, 0);
            this.pnlMenuDescription.Name = "pnlMenuDescription";
            this.pnlMenuDescription.Size = new System.Drawing.Size(40, 685);
            this.pnlMenuDescription.TabIndex = 3;
            // 
            // picVerticalLine
            // 
            this.picVerticalLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picVerticalLine.ErrorImage = null;
            this.picVerticalLine.InitialImage = null;
            this.picVerticalLine.Location = new System.Drawing.Point(0, 0);
            this.picVerticalLine.Name = "picVerticalLine";
            this.picVerticalLine.Size = new System.Drawing.Size(32, 685);
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
            this.lstMenuDescription.Location = new System.Drawing.Point(40, 152);
            this.lstMenuDescription.Name = "lstMenuDescription";
            this.lstMenuDescription.Size = new System.Drawing.Size(170, 209);
            this.lstMenuDescription.TabIndex = 0;
            this.lstMenuDescription.SelectedIndexChanged += new System.EventHandler(this.lstMenuDescription_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(149, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "User Dashboard";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectDataGridView
            // 
            this.projectDataGridView.AllowUserToAddRows = false;
            this.projectDataGridView.AllowUserToDeleteRows = false;
            this.projectDataGridView.AutoGenerateColumns = false;
            this.projectDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.projectDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Completion_Ind,
            this.Completion_Date});
            this.projectDataGridView.DataSource = this.projectBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.projectDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.projectDataGridView.EnableHeadersVisualStyles = false;
            this.projectDataGridView.Location = new System.Drawing.Point(132, 80);
            this.projectDataGridView.MultiSelect = false;
            this.projectDataGridView.Name = "projectDataGridView";
            this.projectDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.projectDataGridView.Size = new System.Drawing.Size(757, 220);
            this.projectDataGridView.TabIndex = 5;
            this.projectDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectDataGridView_CellClick);
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
            // Completion_Ind
            // 
            this.Completion_Ind.DataPropertyName = "Completion_Ind";
            this.Completion_Ind.HeaderText = "Completion_Ind";
            this.Completion_Ind.Name = "Completion_Ind";
            this.Completion_Ind.ReadOnly = true;
            // 
            // Completion_Date
            // 
            this.Completion_Date.DataPropertyName = "Completion_Date";
            this.Completion_Date.HeaderText = "Completion_Date";
            this.Completion_Date.Name = "Completion_Date";
            this.Completion_Date.ReadOnly = true;
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
            // btnAll
            // 
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Location = new System.Drawing.Point(62, 30);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 36);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "&All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCompleted);
            this.groupBox1.Controls.Add(this.btnOnGoing);
            this.groupBox1.Controls.Add(this.btnAll);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(204, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By Completion";
            // 
            // btnCompleted
            // 
            this.btnCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleted.ForeColor = System.Drawing.Color.White;
            this.btnCompleted.Location = new System.Drawing.Point(62, 142);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(74, 36);
            this.btnCompleted.TabIndex = 2;
            this.btnCompleted.Text = "&Completed";
            this.btnCompleted.UseVisualStyleBackColor = true;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnOnGoing
            // 
            this.btnOnGoing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnGoing.ForeColor = System.Drawing.Color.White;
            this.btnOnGoing.Location = new System.Drawing.Point(62, 87);
            this.btnOnGoing.Name = "btnOnGoing";
            this.btnOnGoing.Size = new System.Drawing.Size(75, 36);
            this.btnOnGoing.TabIndex = 1;
            this.btnOnGoing.Text = "&On Going";
            this.btnOnGoing.UseVisualStyleBackColor = true;
            this.btnOnGoing.Click += new System.EventHandler(this.btnOnGoing_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(129, 106);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 35);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(246, 106);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbProjectName);
            this.groupBox2.Controls.Add(this.rdbCategory);
            this.groupBox2.Controls.Add(this.txtProjectSearch);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(468, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search By Keyword";
            // 
            // rdbProjectName
            // 
            this.rdbProjectName.AutoSize = true;
            this.rdbProjectName.Location = new System.Drawing.Point(77, 28);
            this.rdbProjectName.Name = "rdbProjectName";
            this.rdbProjectName.Size = new System.Drawing.Size(89, 17);
            this.rdbProjectName.TabIndex = 0;
            this.rdbProjectName.TabStop = true;
            this.rdbProjectName.Text = "Project Name";
            this.rdbProjectName.UseVisualStyleBackColor = true;
            // 
            // rdbCategory
            // 
            this.rdbCategory.AutoSize = true;
            this.rdbCategory.Location = new System.Drawing.Point(213, 28);
            this.rdbCategory.Name = "rdbCategory";
            this.rdbCategory.Size = new System.Drawing.Size(67, 17);
            this.rdbCategory.TabIndex = 1;
            this.rdbCategory.TabStop = true;
            this.rdbCategory.Text = "Category";
            this.rdbCategory.UseVisualStyleBackColor = true;
            // 
            // txtProjectSearch
            // 
            this.txtProjectSearch.Location = new System.Drawing.Point(33, 61);
            this.txtProjectSearch.Name = "txtProjectSearch";
            this.txtProjectSearch.Size = new System.Drawing.Size(295, 20);
            this.txtProjectSearch.TabIndex = 2;
            this.txtProjectSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProjectSearch_KeyPress);
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
            this.tableAdapterManager.project_teamTableAdapter = null;
            this.tableAdapterManager.projectTableAdapter = this.projectTableAdapter;
            this.tableAdapterManager.team_employeeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = infiniTrack.infinitrackDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmUserDashboard
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(901, 685);
            this.Controls.Add(this.pnlMenuDescription);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.projectDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard";
            this.Load += new System.EventHandler(this.frmUserDashboard_Load);
            this.Click += new System.EventHandler(this.frmUserDashboard_Click);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHorizontalLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlMenuDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVerticalLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infinitrackDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.ToolTip toolTipUserDashboard;
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
        private infinitrackDataSet infinitrackDataSet;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private infinitrackDataSetTableAdapters.projectTableAdapter projectTableAdapter;
        private infinitrackDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView projectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnOnGoing;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProjectSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Completion_Ind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Completion_Date;
        private System.Windows.Forms.RadioButton rdbProjectName;
        private System.Windows.Forms.RadioButton rdbCategory;
    }
}

