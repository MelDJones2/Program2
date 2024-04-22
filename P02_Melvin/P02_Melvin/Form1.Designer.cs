namespace P02_Melvin
{
    partial class Form1
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
            this.listLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.listTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.totalListLabel = new System.Windows.Forms.Label();
            this.totalDiscountLabel = new System.Windows.Forms.Label();
            this.totalTaxLabel = new System.Windows.Forms.Label();
            this.totalNetLabel = new System.Windows.Forms.Label();
            this.outputListLabel = new System.Windows.Forms.Label();
            this.outputDiscountLabel = new System.Windows.Forms.Label();
            this.outputTaxLabel = new System.Windows.Forms.Label();
            this.outputNetLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Location = new System.Drawing.Point(184, 123);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(50, 13);
            this.listLabel.TabIndex = 0;
            this.listLabel.Text = "List Price";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(487, 123);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(60, 13);
            this.discountLabel.TabIndex = 1;
            this.discountLabel.Text = "Discount %";
            // 
            // listTextBox
            // 
            this.listTextBox.Location = new System.Drawing.Point(187, 157);
            this.listTextBox.Name = "listTextBox";
            this.listTextBox.Size = new System.Drawing.Size(100, 20);
            this.listTextBox.TabIndex = 2;
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(490, 157);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(100, 20);
            this.discountTextBox.TabIndex = 3;
            // 
            // totalListLabel
            // 
            this.totalListLabel.AutoSize = true;
            this.totalListLabel.Location = new System.Drawing.Point(97, 219);
            this.totalListLabel.Name = "totalListLabel";
            this.totalListLabel.Size = new System.Drawing.Size(77, 13);
            this.totalListLabel.TabIndex = 4;
            this.totalListLabel.Text = "Total List Price";
            // 
            // totalDiscountLabel
            // 
            this.totalDiscountLabel.AutoSize = true;
            this.totalDiscountLabel.Location = new System.Drawing.Point(262, 219);
            this.totalDiscountLabel.Name = "totalDiscountLabel";
            this.totalDiscountLabel.Size = new System.Drawing.Size(103, 13);
            this.totalDiscountLabel.TabIndex = 5;
            this.totalDiscountLabel.Text = "Total Discount Price";
            // 
            // totalTaxLabel
            // 
            this.totalTaxLabel.AutoSize = true;
            this.totalTaxLabel.Location = new System.Drawing.Point(433, 219);
            this.totalTaxLabel.Name = "totalTaxLabel";
            this.totalTaxLabel.Size = new System.Drawing.Size(52, 13);
            this.totalTaxLabel.TabIndex = 6;
            this.totalTaxLabel.Text = "Total Tax";
            this.totalTaxLabel.Click += new System.EventHandler(this.totalTaxLabel_Click);
            // 
            // totalNetLabel
            // 
            this.totalNetLabel.AutoSize = true;
            this.totalNetLabel.Location = new System.Drawing.Point(555, 219);
            this.totalNetLabel.Name = "totalNetLabel";
            this.totalNetLabel.Size = new System.Drawing.Size(78, 13);
            this.totalNetLabel.TabIndex = 7;
            this.totalNetLabel.Text = "Total Net Price";
            // 
            // outputListLabel
            // 
            this.outputListLabel.AutoSize = true;
            this.outputListLabel.Location = new System.Drawing.Point(116, 250);
            this.outputListLabel.Name = "outputListLabel";
            this.outputListLabel.Size = new System.Drawing.Size(28, 13);
            this.outputListLabel.TabIndex = 8;
            this.outputListLabel.Text = "0.00";
            this.outputListLabel.Click += new System.EventHandler(this.outputListLabel_Click);
            // 
            // outputDiscountLabel
            // 
            this.outputDiscountLabel.AutoSize = true;
            this.outputDiscountLabel.Location = new System.Drawing.Point(300, 250);
            this.outputDiscountLabel.Name = "outputDiscountLabel";
            this.outputDiscountLabel.Size = new System.Drawing.Size(28, 13);
            this.outputDiscountLabel.TabIndex = 9;
            this.outputDiscountLabel.Text = "0.00";
            this.outputDiscountLabel.Click += new System.EventHandler(this.outputDiscountLabel_Click);
            // 
            // outputTaxLabel
            // 
            this.outputTaxLabel.AutoSize = true;
            this.outputTaxLabel.Location = new System.Drawing.Point(450, 250);
            this.outputTaxLabel.Name = "outputTaxLabel";
            this.outputTaxLabel.Size = new System.Drawing.Size(28, 13);
            this.outputTaxLabel.TabIndex = 10;
            this.outputTaxLabel.Text = "0.00";
            this.outputTaxLabel.Click += new System.EventHandler(this.outputTaxLabel_Click);
            // 
            // outputNetLabel
            // 
            this.outputNetLabel.AutoSize = true;
            this.outputNetLabel.Location = new System.Drawing.Point(574, 250);
            this.outputNetLabel.Name = "outputNetLabel";
            this.outputNetLabel.Size = new System.Drawing.Size(28, 13);
            this.outputNetLabel.TabIndex = 11;
            this.outputNetLabel.Text = "0.00";
            this.outputNetLabel.Click += new System.EventHandler(this.outputNetLabel_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(159, 329);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add to Total";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(365, 329);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(604, 329);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.outputNetLabel);
            this.Controls.Add(this.outputTaxLabel);
            this.Controls.Add(this.outputDiscountLabel);
            this.Controls.Add(this.outputListLabel);
            this.Controls.Add(this.totalNetLabel);
            this.Controls.Add(this.totalTaxLabel);
            this.Controls.Add(this.totalDiscountLabel);
            this.Controls.Add(this.totalListLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.listTextBox);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.listLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.TextBox listTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.Label totalListLabel;
        private System.Windows.Forms.Label totalDiscountLabel;
        private System.Windows.Forms.Label totalTaxLabel;
        private System.Windows.Forms.Label totalNetLabel;
        private System.Windows.Forms.Label outputListLabel;
        private System.Windows.Forms.Label outputDiscountLabel;
        private System.Windows.Forms.Label outputTaxLabel;
        private System.Windows.Forms.Label outputNetLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

