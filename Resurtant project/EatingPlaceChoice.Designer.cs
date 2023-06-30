
namespace Resurtant_project
{
    partial class EatingPlaceChoice
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
            this.OrderDelivery = new System.Windows.Forms.RadioButton();
            this.BookTable = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderDelivery
            // 
            this.OrderDelivery.AutoSize = true;
            this.OrderDelivery.BackColor = System.Drawing.Color.Transparent;
            this.OrderDelivery.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderDelivery.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OrderDelivery.Location = new System.Drawing.Point(181, 187);
            this.OrderDelivery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderDelivery.Name = "OrderDelivery";
            this.OrderDelivery.Size = new System.Drawing.Size(158, 26);
            this.OrderDelivery.TabIndex = 0;
            this.OrderDelivery.TabStop = true;
            this.OrderDelivery.Text = "Order Delivery ";
            this.OrderDelivery.UseVisualStyleBackColor = false;
            // 
            // BookTable
            // 
            this.BookTable.AutoSize = true;
            this.BookTable.BackColor = System.Drawing.Color.Transparent;
            this.BookTable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BookTable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BookTable.Location = new System.Drawing.Point(181, 239);
            this.BookTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BookTable.Name = "BookTable";
            this.BookTable.Size = new System.Drawing.Size(137, 26);
            this.BookTable.TabIndex = 1;
            this.BookTable.TabStop = true;
            this.BookTable.Text = "Book a Table";
            this.BookTable.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(104, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose an Option:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(326, 348);
            this.NextButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(86, 31);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(125, 348);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(86, 31);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EatingPlaceChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::Resurtant_project.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(527, 446);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookTable);
            this.Controls.Add(this.OrderDelivery);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EatingPlaceChoice";
            this.Text = "EatingPlaceChoice";
            this.Load += new System.EventHandler(this.EatingPlaceChoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton OrderDelivery;
        private System.Windows.Forms.RadioButton BookTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
    }
}