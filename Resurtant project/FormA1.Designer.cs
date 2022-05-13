namespace Resturant
{
    partial class FormA1
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
            this.branchNameLabel = new System.Windows.Forms.Label();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.numofEmployeesLabel = new System.Windows.Forms.Label();
            this.historyButton = new System.Windows.Forms.Button();
            this.employeesButton = new System.Windows.Forms.Button();
            this.profitsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // branchNameLabel
            // 
            this.branchNameLabel.Location = new System.Drawing.Point(131, 34);
            this.branchNameLabel.Name = "branchNameLabel";
            this.branchNameLabel.Size = new System.Drawing.Size(146, 23);
            this.branchNameLabel.TabIndex = 0;
            this.branchNameLabel.Text = "Branch Name";
            this.branchNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // capacityLabel
            // 
            this.capacityLabel.Location = new System.Drawing.Point(131, 74);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(146, 23);
            this.capacityLabel.TabIndex = 1;
            this.capacityLabel.Text = "Capacity";
            this.capacityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numofEmployeesLabel
            // 
            this.numofEmployeesLabel.Location = new System.Drawing.Point(131, 109);
            this.numofEmployeesLabel.Name = "numofEmployeesLabel";
            this.numofEmployeesLabel.Size = new System.Drawing.Size(146, 23);
            this.numofEmployeesLabel.TabIndex = 2;
            this.numofEmployeesLabel.Text = "#Employees";
            this.numofEmployeesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(61, 155);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(111, 35);
            this.historyButton.TabIndex = 3;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = true;
            // 
            // employeesButton
            // 
            this.employeesButton.Location = new System.Drawing.Point(239, 155);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(111, 35);
            this.employeesButton.TabIndex = 4;
            this.employeesButton.Text = "Emolyees";
            this.employeesButton.UseVisualStyleBackColor = true;
            // 
            // profitsButton
            // 
            this.profitsButton.Location = new System.Drawing.Point(153, 205);
            this.profitsButton.Name = "profitsButton";
            this.profitsButton.Size = new System.Drawing.Size(111, 35);
            this.profitsButton.TabIndex = 5;
            this.profitsButton.Text = "Profits";
            this.profitsButton.UseVisualStyleBackColor = true;
            // 
            // FormA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 252);
            this.Controls.Add(this.profitsButton);
            this.Controls.Add(this.employeesButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.numofEmployeesLabel);
            this.Controls.Add(this.capacityLabel);
            this.Controls.Add(this.branchNameLabel);
            this.Name = "FormA1";
            this.Text = "FormA1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label branchNameLabel;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Label numofEmployeesLabel;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button employeesButton;
        private System.Windows.Forms.Button profitsButton;
    }
}

