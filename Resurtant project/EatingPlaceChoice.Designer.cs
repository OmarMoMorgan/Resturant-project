
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
            this.OrderDelivery.Location = new System.Drawing.Point(166, 161);
            this.OrderDelivery.Name = "OrderDelivery";
            this.OrderDelivery.Size = new System.Drawing.Size(111, 19);
            this.OrderDelivery.TabIndex = 0;
            this.OrderDelivery.TabStop = true;
            this.OrderDelivery.Text = "Order a delivery ";
            this.OrderDelivery.UseVisualStyleBackColor = true;
            // 
            // BookTable
            // 
            this.BookTable.AutoSize = true;
            this.BookTable.Location = new System.Drawing.Point(166, 208);
            this.BookTable.Name = "BookTable";
            this.BookTable.Size = new System.Drawing.Size(91, 19);
            this.BookTable.TabIndex = 1;
            this.BookTable.TabStop = true;
            this.BookTable.Text = "Book a Table";
            this.BookTable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose where you want to eat";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(293, 296);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(117, 296);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EatingPlaceChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(512, 350);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookTable);
            this.Controls.Add(this.OrderDelivery);
            this.Name = "EatingPlaceChoice";
            this.Text = "EatingPlaceChoice";
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