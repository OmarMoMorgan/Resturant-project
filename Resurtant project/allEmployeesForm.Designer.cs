namespace Resurtant_project
{
    partial class allEmployeesForm
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
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(429, 391);
            this.addEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(171, 47);
            this.addEmployeeButton.TabIndex = 5;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(269, 391);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(99, 47);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeColumn,
            this.dateColumn,
            this.jobColumn,
            this.salaryColumn});
            this.dataGridView1.Location = new System.Drawing.Point(46, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 348);
            this.dataGridView1.TabIndex = 3;
            // 
            // employeeColumn
            // 
            this.employeeColumn.HeaderText = "Employee";
            this.employeeColumn.MinimumWidth = 6;
            this.employeeColumn.Name = "employeeColumn";
            this.employeeColumn.ReadOnly = true;
            this.employeeColumn.Width = 125;
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "Date";
            this.dateColumn.MinimumWidth = 6;
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            this.dateColumn.Width = 125;
            // 
            // jobColumn
            // 
            this.jobColumn.HeaderText = "Job";
            this.jobColumn.MinimumWidth = 6;
            this.jobColumn.Name = "jobColumn";
            this.jobColumn.ReadOnly = true;
            this.jobColumn.Width = 125;
            // 
            // salaryColumn
            // 
            this.salaryColumn.HeaderText = "Salary";
            this.salaryColumn.MinimumWidth = 6;
            this.salaryColumn.Name = "salaryColumn";
            this.salaryColumn.ReadOnly = true;
            this.salaryColumn.Width = 125;
            // 
            // allEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(656, 451);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "allEmployeesForm";
            this.Text = "allEmployeesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryColumn;
    }
}