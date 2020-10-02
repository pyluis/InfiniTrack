namespace infiniTrack
{
    partial class frmAddPhase
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbPhaseName = new System.Windows.Forms.ComboBox();
            this.cmbProjectName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.project_phaseTableAdapter1 = new infiniTrack.infinitrackDataSetTableAdapters.project_phaseTableAdapter();
            this.projectTableAdapter1 = new infiniTrack.infinitrackDataSetTableAdapters.projectTableAdapter();
            this.infinitrackDataSet = new infiniTrack.infinitrackDataSet();
            this.project_phaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new infiniTrack.infinitrackDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.infinitrackDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_phaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(171, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(28, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add Phase";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbPhaseName
            // 
            this.cmbPhaseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhaseName.FormattingEnabled = true;
            this.cmbPhaseName.Location = new System.Drawing.Point(116, 81);
            this.cmbPhaseName.Name = "cmbPhaseName";
            this.cmbPhaseName.Size = new System.Drawing.Size(121, 21);
            this.cmbPhaseName.TabIndex = 1;
            this.cmbPhaseName.SelectedIndexChanged += new System.EventHandler(this.cmbPhaseName_SelectedIndexChanged);
            // 
            // cmbProjectName
            // 
            this.cmbProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectName.FormattingEnabled = true;
            this.cmbProjectName.Location = new System.Drawing.Point(116, 44);
            this.cmbProjectName.Name = "cmbProjectName";
            this.cmbProjectName.Size = new System.Drawing.Size(121, 21);
            this.cmbProjectName.TabIndex = 0;
            this.cmbProjectName.SelectedIndexChanged += new System.EventHandler(this.cmbProjectName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Phase";
            // 
            // project_phaseTableAdapter1
            // 
            this.project_phaseTableAdapter1.ClearBeforeFill = true;
            // 
            // projectTableAdapter1
            // 
            this.projectTableAdapter1.ClearBeforeFill = true;
            // 
            // infinitrackDataSet
            // 
            this.infinitrackDataSet.DataSetName = "infinitrackDataSet";
            this.infinitrackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // project_phaseBindingSource
            // 
            this.project_phaseBindingSource.DataMember = "project_phase";
            this.project_phaseBindingSource.DataSource = this.infinitrackDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.activity_laborTableAdapter = null;
            this.tableAdapterManager.activity_materialTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.infinitrack_userTableAdapter = null;
            this.tableAdapterManager.materialTableAdapter = null;
            this.tableAdapterManager.project_activityTableAdapter = null;
            this.tableAdapterManager.project_phaseTableAdapter = null;
            this.tableAdapterManager.project_teamTableAdapter = null;
            this.tableAdapterManager.projectTableAdapter = null;
            this.tableAdapterManager.team_employeeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = infiniTrack.infinitrackDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmAddPhase
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(401, 461);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbPhaseName);
            this.Controls.Add(this.cmbProjectName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddPhase";
            this.Text = "Add Phase";
            this.Load += new System.EventHandler(this.frmAddPhase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infinitrackDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_phaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbPhaseName;
        private System.Windows.Forms.ComboBox cmbProjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private infinitrackDataSetTableAdapters.project_phaseTableAdapter project_phaseTableAdapter1;
        private infinitrackDataSetTableAdapters.projectTableAdapter projectTableAdapter1;
        private infinitrackDataSet infinitrackDataSet;
        private System.Windows.Forms.BindingSource project_phaseBindingSource;
        private infinitrackDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}