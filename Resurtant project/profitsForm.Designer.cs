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
            this.expensesLabel = new System.Windows.Forms.Label();
            this.salariesLabel = new System.Windows.Forms.Label();
            this.materialsLabel = new System.Windows.Forms.Label();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.delieveryLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.toDateLabel = new System.Windows.Forms.Label();
            this.fromDateLabel = new System.Windows.Forms.Label();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.expensesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSoldColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delieveryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // expensesLabel
            // 
            this.expensesLabel.BackColor = System.Drawing.Color.DarkRed;
            this.expensesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.expensesLabel.Location = new System.Drawing.Point(34, 162);
            this.expensesLabel.Name = "expensesLabel";
            this.expensesLabel.Size = new System.Drawing.Size(201, 29);
            this.expensesLabel.TabIndex = 0;
            this.expensesLabel.Text = "Expenses:";
            this.expensesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // salariesLabel
            // 
            this.salariesLabel.BackColor = System.Drawing.Color.DarkRed;
            this.salariesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.salariesLabel.Location = new System.Drawing.Point(34, 204);
            this.salariesLabel.Name = "salariesLabel";
            this.salariesLabel.Size = new System.Drawing.Size(201, 29);
            this.salariesLabel.TabIndex = 1;
            this.salariesLabel.Text = "Salaries:";
            this.salariesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salariesLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // materialsLabel
            // 
            this.materialsLabel.BackColor = System.Drawing.Color.DarkRed;
            this.materialsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.materialsLabel.Location = new System.Drawing.Point(34, 242);
            this.materialsLabel.Name = "materialsLabel";
            this.materialsLabel.Size = new System.Drawing.Size(201, 29);
            this.materialsLabel.TabIndex = 2;
            this.materialsLabel.Text = "Materials:";
            this.materialsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // incomeLabel
            // 
            this.incomeLabel.BackColor = System.Drawing.Color.DarkRed;
            this.incomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.incomeLabel.Location = new System.Drawing.Point(34, 282);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(201, 29);
            this.incomeLabel.TabIndex = 3;
            this.incomeLabel.Text = "Income:";
            this.incomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemsLabel
            // 
            this.itemsLabel.BackColor = System.Drawing.Color.DarkRed;
            this.itemsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.itemsLabel.Location = new System.Drawing.Point(34, 322);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(201, 29);
            this.itemsLabel.TabIndex = 4;
            this.itemsLabel.Text = "Items Sold:";
            this.itemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // delieveryLabel
            // 
            this.delieveryLabel.BackColor = System.Drawing.Color.DarkRed;
            this.delieveryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.delieveryLabel.Location = new System.Drawing.Point(34, 365);
            this.delieveryLabel.Name = "delieveryLabel";
            this.delieveryLabel.Size = new System.Drawing.Size(201, 29);
            this.delieveryLabel.TabIndex = 5;
            this.delieveryLabel.Text = "Delievery:";
            this.delieveryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.Location = new System.Drawing.Point(176, 415);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(192, 29);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expensesColumn,
            this.salariesColumn,
            this.materialsColumn,
            this.incomeColumn,
            this.itemSoldColumn,
            this.delieveryColumn,
            this.totalColumn});
            this.dataGridView1.Location = new System.Drawing.Point(241, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(778, 127);
            this.dataGridView1.TabIndex = 12;
            // 
            // expensesColumn
            // 
            this.expensesColumn.HeaderText = "Expenses";
            this.expensesColumn.MinimumWidth = 6;
            this.expensesColumn.Name = "expensesColumn";
            this.expensesColumn.ReadOnly = true;
            this.expensesColumn.Width = 125;
            // 
            // salariesColumn
            // 
            this.salariesColumn.HeaderText = "Salaries";
            this.salariesColumn.MinimumWidth = 6;
            this.salariesColumn.Name = "salariesColumn";
            this.salariesColumn.ReadOnly = true;
            this.salariesColumn.Width = 125;
            // 
            // materialsColumn
            // 
            this.materialsColumn.HeaderText = "Materials";
            this.materialsColumn.MinimumWidth = 6;
            this.materialsColumn.Name = "materialsColumn";
            this.materialsColumn.ReadOnly = true;
            this.materialsColumn.Width = 125;
            // 
            // incomeColumn
            // 
            this.incomeColumn.HeaderText = "Income";
            this.incomeColumn.MinimumWidth = 6;
            this.incomeColumn.Name = "incomeColumn";
            this.incomeColumn.ReadOnly = true;
            this.incomeColumn.Width = 125;
            // 
            // itemSoldColumn
            // 
            this.itemSoldColumn.HeaderText = "Items Sold";
            this.itemSoldColumn.MinimumWidth = 6;
            this.itemSoldColumn.Name = "itemSoldColumn";
            this.itemSoldColumn.ReadOnly = true;
            this.itemSoldColumn.Width = 125;
            // 
            // delieveryColumn
            // 
            this.delieveryColumn.HeaderText = "Delievery";
            this.delieveryColumn.MinimumWidth = 6;
            this.delieveryColumn.Name = "delieveryColumn";
            this.delieveryColumn.ReadOnly = true;
            this.delieveryColumn.Width = 125;
            // 
            // totalColumn
            // 
            this.totalColumn.HeaderText = "Total";
            this.totalColumn.MinimumWidth = 6;
            this.totalColumn.Name = "totalColumn";
            this.totalColumn.ReadOnly = true;
            this.totalColumn.Width = 125;
            // 
            // profitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1071, 472);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.toDateLabel);
            this.Controls.Add(this.fromDateLabel);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.delieveryLabel);
            this.Controls.Add(this.itemsLabel);
            this.Controls.Add(this.incomeLabel);
            this.Controls.Add(this.materialsLabel);
            this.Controls.Add(this.salariesLabel);
            this.Controls.Add(this.expensesLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "profitsForm";
            this.Text = "Profits";
            this.Load += new System.EventHandler(this.profitsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label expensesLabel;
        private System.Windows.Forms.Label salariesLabel;
        private System.Windows.Forms.Label materialsLabel;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.Label delieveryLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label toDateLabel;
        private System.Windows.Forms.Label fromDateLabel;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemSoldColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delieveryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalColumn;
    }
}