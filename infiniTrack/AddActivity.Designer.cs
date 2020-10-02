namespace infiniTrack
{
    partial class frmAddActivity
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
            System.Windows.Forms.Label phase_NameLabel;
            System.Windows.Forms.Label budget_HoursLabel;
            System.Windows.Forms.Label budget_CostLabel;
            System.Windows.Forms.Label start_DateLabel;
            System.Windows.Forms.Label end_DateLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProjectName = new System.Windows.Forms.ComboBox();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infinitrackDataSet = new infiniTrack.infinitrackDataSet();
            this.projectphaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.projectTableAdapter = new infiniTrack.infinitrackDataSetTableAdapters.projectTableAdapter();
            this.tableAdapterManager = new infiniTrack.infinitrackDataSetTableAdapters.TableAdapterManager();
            this.materialTableAdapter = new infiniTrack.infinitrackDataSetTableAdapters.materialTableAdapter();
            this.project_activityTableAdapter = new infiniTrack.infinitrackDataSetTableAdapters.project_activityTableAdapter();
            this.project_phaseTableAdapter = new infiniTrack.infinitrackDataSetTableAdapters.project_phaseTableAdapter();
            this.project_activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_phaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbPhase = new System.Windows.Forms.ComboBox();
            this.projectphaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBudgetHour = new System.Windows.Forms.TextBox();
            this.txtBudgetCost = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            phase_NameLabel = new System.Windows.Forms.Label();
            budget_HoursLabel = new System.Windows.Forms.Label();
            budget_CostLabel = new System.Windows.Forms.Label();
            start_DateLabel = new System.Windows.Forms.Label();
            end_DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infinitrackDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectphaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_phaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectphaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // phase_NameLabel
            // 
            phase_NameLabel.AutoSize = true;
            phase_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phase_NameLabel.ForeColor = System.Drawing.Color.White;
            phase_NameLabel.Location = new System.Drawing.Point(14, 109);
            phase_NameLabel.Name = "phase_NameLabel";
            phase_NameLabel.Size = new System.Drawing.Size(66, 16);
            phase_NameLabel.TabIndex = 9;
            phase_NameLabel.Text = "Phase ID:";
            // 
            // budget_HoursLabel
            // 
            budget_HoursLabel.AutoSize = true;
            budget_HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            budget_HoursLabel.ForeColor = System.Drawing.Color.White;
            budget_HoursLabel.Location = new System.Drawing.Point(14, 166);
            budget_HoursLabel.Name = "budget_HoursLabel";
            budget_HoursLabel.Size = new System.Drawing.Size(93, 16);
            budget_HoursLabel.TabIndex = 10;
            budget_HoursLabel.Text = "Budget Hours:";
            // 
            // budget_CostLabel
            // 
            budget_CostLabel.AutoSize = true;
            budget_CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            budget_CostLabel.ForeColor = System.Drawing.Color.White;
            budget_CostLabel.Location = new System.Drawing.Point(14, 216);
            budget_CostLabel.Name = "budget_CostLabel";
            budget_CostLabel.Size = new System.Drawing.Size(84, 16);
            budget_CostLabel.TabIndex = 11;
            budget_CostLabel.Text = "Budget Cost:";
            // 
            // start_DateLabel
            // 
            start_DateLabel.AutoSize = true;
            start_DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            start_DateLabel.ForeColor = System.Drawing.Color.White;
            start_DateLabel.Location = new System.Drawing.Point(14, 263);
            start_DateLabel.Name = "start_DateLabel";
            start_DateLabel.Size = new System.Drawing.Size(70, 16);
            start_DateLabel.TabIndex = 12;
            start_DateLabel.Text = "Start Date:";
            // 
            // end_DateLabel
            // 
            end_DateLabel.AutoSize = true;
            end_DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            end_DateLabel.ForeColor = System.Drawing.Color.White;
            end_DateLabel.Location = new System.Drawing.Point(14, 313);
            end_DateLabel.Name = "end_DateLabel";
            end_DateLabel.Size = new System.Drawing.Size(67, 16);
            end_DateLabel.TabIndex = 13;
            end_DateLabel.Text = "End Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Add Activity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Project:";
            // 
            // cmbProjectName
            // 
            this.cmbProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectName.FormattingEnabled = true;
            this.cmbProjectName.Location = new System.Drawing.Point(120, 47);
            this.cmbProjectName.Name = "cmbProjectName";
            this.cmbProjectName.Size = new System.Drawing.Size(140, 23);
            this.cmbProjectName.TabIndex = 0;
            this.cmbProjectName.SelectedIndexChanged += new System.EventHandler(this.cmbProjectName_SelectedIndexChanged);
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
            // projectphaseBindingSource1
            // 
            this.projectphaseBindingSource1.DataMember = "project_phase";
            this.projectphaseBindingSource1.DataSource = this.infinitrackDataSet;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(201, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 27);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.tableAdapterManager.materialTableAdapter = this.materialTableAdapter;
            this.tableAdapterManager.project_activityTableAdapter = this.project_activityTableAdapter;
            this.tableAdapterManager.project_phaseTableAdapter = this.project_phaseTableAdapter;
            this.tableAdapterManager.project_teamTableAdapter = null;
            this.tableAdapterManager.projectTableAdapter = this.projectTableAdapter;
            this.tableAdapterManager.team_employeeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = infiniTrack.infinitrackDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // project_activityTableAdapter
            // 
            this.project_activityTableAdapter.ClearBeforeFill = true;
            // 
            // project_phaseTableAdapter
            // 
            this.project_phaseTableAdapter.ClearBeforeFill = true;
            // 
            // project_activityBindingSource
            // 
            this.project_activityBindingSource.DataMember = "project_activity";
            this.project_activityBindingSource.DataSource = this.infinitrackDataSet;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "material";
            this.materialBindingSource.DataSource = this.infinitrackDataSet;
            // 
            // project_phaseBindingSource
            // 
            this.project_phaseBindingSource.DataMember = "project_phase";
            this.project_phaseBindingSource.DataSource = this.infinitrackDataSet;
            // 
            // cmbPhase
            // 
            this.cmbPhase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhase.FormattingEnabled = true;
            this.cmbPhase.Location = new System.Drawing.Point(120, 105);
            this.cmbPhase.Name = "cmbPhase";
            this.cmbPhase.Size = new System.Drawing.Size(140, 23);
            this.cmbPhase.TabIndex = 1;
            // 
            // projectphaseBindingSource
            // 
            this.projectphaseBindingSource.DataMember = "project_phase";
            this.projectphaseBindingSource.DataSource = this.infinitrackDataSet;
            // 
            // txtBudgetHour
            // 
            this.txtBudgetHour.Location = new System.Drawing.Point(120, 166);
            this.txtBudgetHour.Name = "txtBudgetHour";
            this.txtBudgetHour.Size = new System.Drawing.Size(140, 21);
            this.txtBudgetHour.TabIndex = 2;
            this.txtBudgetHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // txtBudgetCost
            // 
            this.txtBudgetCost.Location = new System.Drawing.Point(120, 216);
            this.txtBudgetCost.Name = "txtBudgetCost";
            this.txtBudgetCost.Size = new System.Drawing.Size(140, 21);
            this.txtBudgetCost.TabIndex = 3;
            this.txtBudgetCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.project_activityBindingSource, "Start_Date", true));
            this.dtpStartDate.Location = new System.Drawing.Point(120, 263);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(233, 21);
            this.dtpStartDate.TabIndex = 4;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.project_activityBindingSource, "End_Date", true));
            this.dtpEndDate.Location = new System.Drawing.Point(120, 306);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(233, 21);
            this.dtpEndDate.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(48, 376);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 27);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "&Add Activity";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddActivity
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(420, 576);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(end_DateLabel);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(start_DateLabel);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(budget_CostLabel);
            this.Controls.Add(this.txtBudgetCost);
            this.Controls.Add(budget_HoursLabel);
            this.Controls.Add(this.txtBudgetHour);
            this.Controls.Add(phase_NameLabel);
            this.Controls.Add(this.cmbPhase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbProjectName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmAddActivity";
            this.Text = "Add Activity";
            this.Load += new System.EventHandler(this.frmAddActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infinitrackDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectphaseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_phaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectphaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProjectName;
        private System.Windows.Forms.Button btnCancel;
        private infinitrackDataSet infinitrackDataSet;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private infinitrackDataSetTableAdapters.projectTableAdapter projectTableAdapter;
        private infinitrackDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private infinitrackDataSetTableAdapters.project_activityTableAdapter project_activityTableAdapter;
        private System.Windows.Forms.BindingSource project_activityBindingSource;
        private infinitrackDataSetTableAdapters.materialTableAdapter materialTableAdapter;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private infinitrackDataSetTableAdapters.project_phaseTableAdapter project_phaseTableAdapter;
        private System.Windows.Forms.BindingSource project_phaseBindingSource;
        private System.Windows.Forms.ComboBox cmbPhase;
        private System.Windows.Forms.TextBox txtBudgetHour;
        private System.Windows.Forms.TextBox txtBudgetCost;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource projectphaseBindingSource1;
        private System.Windows.Forms.BindingSource projectphaseBindingSource;
    }
}