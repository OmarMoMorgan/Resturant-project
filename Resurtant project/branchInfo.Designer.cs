
namespace Resurtant_project
{
    partial class branchInfo
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
            this.supervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfEmployees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProfits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supervisor,
            this.supSalary,
            this.capacity,
            this.numOfEmployees,
            this.totalProfits});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.InfoText;
            this.dataGridView1.Location = new System.Drawing.Point(70, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(854, 317);
            this.dataGridView1.TabIndex = 0;
            // 
            // supervisor
            // 
            this.supervisor.HeaderText = "supervisor";
            this.supervisor.MinimumWidth = 6;
            this.supervisor.Name = "supervisor";
            this.supervisor.ReadOnly = true;
            this.supervisor.Width = 125;
            // 
            // supSalary
            // 
            this.supSalary.HeaderText = "sup salary";
            this.supSalary.MinimumWidth = 6;
            this.supSalary.Name = "supSalary";
            this.supSalary.ReadOnly = true;
            this.supSalary.Width = 125;
            // 
            // capacity
            // 
            this.capacity.HeaderText = "capacity";
            this.capacity.MinimumWidth = 6;
            this.capacity.Name = "capacity";
            this.capacity.ReadOnly = true;
            this.capacity.Width = 125;
            // 
            // numOfEmployees
            // 
            this.numOfEmployees.HeaderText = "num of employees";
            this.numOfEmployees.MinimumWidth = 6;
            this.numOfEmployees.Name = "numOfEmployees";
            this.numOfEmployees.ReadOnly = true;
            this.numOfEmployees.Width = 125;
            // 
            // totalProfits
            // 
            this.totalProfits.HeaderText = "total profits";
            this.totalProfits.MinimumWidth = 6;
            this.totalProfits.Name = "totalProfits";
            this.totalProfits.ReadOnly = true;
            this.totalProfits.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(250, 453);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "add branch";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(472, 453);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "remove branch";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(694, 453);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "view branch";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(56, 464);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(86, 31);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // branchInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1010, 604);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "branchInfo";
            this.Text = "branchInfo";
            this.Load += new System.EventHandler(this.branchInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn supSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProfits;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BackButton;
    }
}