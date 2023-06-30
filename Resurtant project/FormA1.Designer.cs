namespace Resurtant_project
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
            this.historyButton = new System.Windows.Forms.Button();
            this.employeesButton = new System.Windows.Forms.Button();
            this.profitsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // branchNameLabel
            // 
            this.branchNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.branchNameLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.branchNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.branchNameLabel.Location = new System.Drawing.Point(115, 32);
            this.branchNameLabel.Name = "branchNameLabel";
            this.branchNameLabel.Size = new System.Drawing.Size(128, 22);
            this.branchNameLabel.TabIndex = 0;
            this.branchNameLabel.Text = "Branch Name";
            this.branchNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // capacityLabel
            // 
            this.capacityLabel.BackColor = System.Drawing.Color.Transparent;
            this.capacityLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.capacityLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.capacityLabel.Location = new System.Drawing.Point(115, 75);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(128, 31);
            this.capacityLabel.TabIndex = 1;
            this.capacityLabel.Text = "Capacity";
            this.capacityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(60, 152);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(97, 33);
            this.historyButton.TabIndex = 3;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // employeesButton
            // 
            this.employeesButton.Location = new System.Drawing.Point(215, 152);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(97, 33);
            this.employeesButton.TabIndex = 4;
            this.employeesButton.Text = "Emolyees";
            this.employeesButton.UseVisualStyleBackColor = true;
            this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // profitsButton
            // 
            this.profitsButton.Location = new System.Drawing.Point(140, 200);
            this.profitsButton.Name = "profitsButton";
            this.profitsButton.Size = new System.Drawing.Size(97, 33);
            this.profitsButton.TabIndex = 5;
            this.profitsButton.Text = "Expenses";
            this.profitsButton.UseVisualStyleBackColor = true;
            this.profitsButton.Click += new System.EventHandler(this.profitsButton_Click);
            // 
            // FormA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::Resurtant_project.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(377, 270);
            this.Controls.Add(this.profitsButton);
            this.Controls.Add(this.employeesButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.capacityLabel);
            this.Controls.Add(this.branchNameLabel);
            this.Name = "FormA1";
            this.Text = "Branch Managment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label branchNameLabel;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button employeesButton;
        private System.Windows.Forms.Button profitsButton;
    }
}