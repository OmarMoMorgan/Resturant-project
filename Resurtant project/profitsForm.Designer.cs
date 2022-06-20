namespace Resurtant_project
{
    partial class profitsForm
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
            this.totalLabel = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.toDateLabel = new System.Windows.Forms.Label();
            this.fromDateLabel = new System.Windows.Forms.Label();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalLabel.Location = new System.Drawing.Point(138, 335);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(192, 37);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total :";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(176, 115);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(170, 29);
            this.showButton.TabIndex = 11;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // toDateLabel
            // 
            this.toDateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toDateLabel.Location = new System.Drawing.Point(34, 63);
            this.toDateLabel.Name = "toDateLabel";
            this.toDateLabel.Size = new System.Drawing.Size(50, 20);
            this.toDateLabel.TabIndex = 10;
            this.toDateLabel.Text = "To";
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fromDateLabel.Location = new System.Drawing.Point(34, 13);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.Size = new System.Drawing.Size(62, 25);
            this.fromDateLabel.TabIndex = 9;
            this.fromDateLabel.Text = "From";
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(118, 56);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(250, 27);
            this.toDatePicker.TabIndex = 8;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(118, 13);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(250, 27);
            this.fromDatePicker.TabIndex = 7;
            this.fromDatePicker.ValueChanged += new System.EventHandler(this.fromDatePicker_ValueChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(470, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(425, 342);
            this.dataGridView2.TabIndex = 13;
            // 
            // profitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1071, 472);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.toDateLabel);
            this.Controls.Add(this.fromDateLabel);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.totalLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "profitsForm";
            this.Text = "Profits";
            this.Load += new System.EventHandler(this.profitsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label toDateLabel;
        private System.Windows.Forms.Label fromDateLabel;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}