namespace infiniTrack
{
    partial class frmAddExpense
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProjectName = new System.Windows.Forms.ComboBox();
            this.cmbActivityID = new System.Windows.Forms.ComboBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.infinitrackDataSet = new infiniTrack.infinitrackDataSet();
            this.activity_materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activity_materialTableAdapter = new infiniTrack.infinitrackDataSetTableAdapters.activity_materialTableAdapter();
            this.tableAdapterManager = new infiniTrack.infinitrackDataSetTableAdapters.TableAdapterManager();
            this.project_activityTableAdapter1 = new infiniTrack.infinitrackDataSetTableAdapters.project_activityTableAdapter();
            this.project_phaseTableAdapter1 = new infiniTrack.infinitrackDataSetTableAdapters.project_phaseTableAdapter();
            this.projectTableAdapter1 = new infiniTrack.infinitrackDataSetTableAdapters.projectTableAdapter();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTableAdapter = new infiniTrack.infinitrackDataSetTableAdapters.materialTableAdapter();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infinitrackDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activity_materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add Expense";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Activity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Project";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // cmbProjectName
            // 
            this.cmbProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectName.FormattingEnabled = true;
            this.cmbProjectName.Location = new System.Drawing.Point(103, 41);
            this.cmbProjectName.Name = "cmbProjectName";
            this.cmbProjectName.Size = new System.Drawing.Size(121, 21);
            this.cmbProjectName.TabIndex = 0;
            this.cmbProjectName.SelectedIndexChanged += new System.EventHandler(this.SelectedProjectChanged);
            // 
            // cmbActivityID
            // 
            this.cmbActivityID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivityID.FormattingEnabled = true;
            this.cmbActivityID.Location = new System.Drawing.Point(103, 77);
            this.cmbActivityID.Name = "cmbActivityID";
            this.cmbActivityID.Size = new System.Drawing.Size(121, 21);
            this.cmbActivityID.TabIndex = 1;
            this.cmbActivityID.SelectedIndexChanged += new System.EventHandler(this.cmbActivityID_SelectedIndexChanged);
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(103, 114);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(121, 21);
            this.cmbMaterial.TabIndex = 2;
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(103, 145);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 20);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(34, 225);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Add Expense";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(177, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // infinitrackDataSet
            // 
            this.infinitrackDataSet.DataSetName = "infinitrackDataSet";
            this.infinitrackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activity_materialBindingSource
            // 
            this.activity_materialBindingSource.DataMember = "activity_material";
            this.activity_materialBindingSource.DataSource = this.infinitrackDataSet;
            // 
            // activity_materialTableAdapter
            // 
            this.activity_materialTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.activity_laborTableAdapter = null;
            this.tableAdapterManager.activity_materialTableAdapter = this.activity_materialTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.infinitrack_userTableAdapter = null;
            this.tableAdapterManager.materialTableAdapter = null;
            this.tableAdapterManager.project_activityTableAdapter = this.project_activityTableAdapter1;
            this.tableAdapterManager.project_phaseTableAdapter = this.project_phaseTableAdapter1;
            this.tableAdapterManager.project_teamTableAdapter = null;
            this.tableAdapterManager.projectTableAdapter = this.projectTableAdapter1;
            this.tableAdapterManager.team_employeeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = infiniTrack.infinitrackDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // project_activityTableAdapter1
            // 
            this.project_activityTableAdapter1.ClearBeforeFill = true;
            // 
            // project_phaseTableAdapter1
            // 
            this.project_phaseTableAdapter1.ClearBeforeFill = true;
            // 
            // projectTableAdapter1
            // 
            this.projectTableAdapter1.ClearBeforeFill = true;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "material";
            this.materialBindingSource.DataSource = this.infinitrackDataSet;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(103, 184);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date";
            // 
            // frmAddExpense
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(330, 311);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.cmbActivityID);
            this.Controls.Add(this.cmbProjectName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddExpense";
            this.Text = "Add Expense";
            this.Load += new System.EventHandler(this.frmAddExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infinitrackDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activity_materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProjectName;
        private System.Windows.Forms.ComboBox cmbActivityID;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private infinitrackDataSet infinitrackDataSet;
        private System.Windows.Forms.BindingSource activity_materialBindingSource;
        private infinitrackDataSetTableAdapters.activity_materialTableAdapter activity_materialTableAdapter;
        private infinitrackDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private infinitrackDataSetTableAdapters.project_activityTableAdapter project_activityTableAdapter1;
        private infinitrackDataSetTableAdapters.project_phaseTableAdapter project_phaseTableAdapter1;
        private infinitrackDataSetTableAdapters.projectTableAdapter projectTableAdapter1;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private infinitrackDataSetTableAdapters.materialTableAdapter materialTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label6;
    }
}