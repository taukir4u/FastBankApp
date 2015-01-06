namespace FastBankApp
{
    partial class FastBankAppUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.emailEntryTextBox = new System.Windows.Forms.TextBox();
            this.openingDateEntryTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberEntryTextBox = new System.Windows.Forms.TextBox();
            this.customerNameEntryTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showAllButton = new System.Windows.Forms.Button();
            this.emailDisplayTextBox = new System.Windows.Forms.TextBox();
            this.balanceDisplayTextBox = new System.Windows.Forms.TextBox();
            this.openingDateDisplayTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.accontNumberDisplayTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.customerNameDisplayTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.amountEntryTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.emailEntryTextBox);
            this.groupBox1.Controls.Add(this.openingDateEntryTextBox);
            this.groupBox1.Controls.Add(this.accountNumberEntryTextBox);
            this.groupBox1.Controls.Add(this.customerNameEntryTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer && Account Info Entry";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(240, 210);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // emailEntryTextBox
            // 
            this.emailEntryTextBox.Location = new System.Drawing.Point(104, 76);
            this.emailEntryTextBox.Name = "emailEntryTextBox";
            this.emailEntryTextBox.Size = new System.Drawing.Size(211, 20);
            this.emailEntryTextBox.TabIndex = 7;
            // 
            // openingDateEntryTextBox
            // 
            this.openingDateEntryTextBox.Location = new System.Drawing.Point(104, 164);
            this.openingDateEntryTextBox.Name = "openingDateEntryTextBox";
            this.openingDateEntryTextBox.Size = new System.Drawing.Size(211, 20);
            this.openingDateEntryTextBox.TabIndex = 6;
            // 
            // accountNumberEntryTextBox
            // 
            this.accountNumberEntryTextBox.Location = new System.Drawing.Point(104, 133);
            this.accountNumberEntryTextBox.Name = "accountNumberEntryTextBox";
            this.accountNumberEntryTextBox.Size = new System.Drawing.Size(211, 20);
            this.accountNumberEntryTextBox.TabIndex = 5;
            // 
            // customerNameEntryTextBox
            // 
            this.customerNameEntryTextBox.Location = new System.Drawing.Point(104, 47);
            this.customerNameEntryTextBox.Name = "customerNameEntryTextBox";
            this.customerNameEntryTextBox.Size = new System.Drawing.Size(211, 20);
            this.customerNameEntryTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Opening Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showAllButton);
            this.groupBox2.Controls.Add(this.emailDisplayTextBox);
            this.groupBox2.Controls.Add(this.balanceDisplayTextBox);
            this.groupBox2.Controls.Add(this.openingDateDisplayTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.accontNumberDisplayTextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.customerNameDisplayTextBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(355, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 251);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer && Account Info Entry";
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(252, 37);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 15;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // emailDisplayTextBox
            // 
            this.emailDisplayTextBox.Location = new System.Drawing.Point(116, 106);
            this.emailDisplayTextBox.Name = "emailDisplayTextBox";
            this.emailDisplayTextBox.Size = new System.Drawing.Size(211, 20);
            this.emailDisplayTextBox.TabIndex = 15;
            // 
            // balanceDisplayTextBox
            // 
            this.balanceDisplayTextBox.Location = new System.Drawing.Point(116, 194);
            this.balanceDisplayTextBox.Name = "balanceDisplayTextBox";
            this.balanceDisplayTextBox.Size = new System.Drawing.Size(211, 20);
            this.balanceDisplayTextBox.TabIndex = 8;
            // 
            // openingDateDisplayTextBox
            // 
            this.openingDateDisplayTextBox.Location = new System.Drawing.Point(116, 164);
            this.openingDateDisplayTextBox.Name = "openingDateDisplayTextBox";
            this.openingDateDisplayTextBox.Size = new System.Drawing.Size(211, 20);
            this.openingDateDisplayTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // accontNumberDisplayTextBox
            // 
            this.accontNumberDisplayTextBox.Location = new System.Drawing.Point(116, 133);
            this.accontNumberDisplayTextBox.Name = "accontNumberDisplayTextBox";
            this.accontNumberDisplayTextBox.Size = new System.Drawing.Size(211, 20);
            this.accontNumberDisplayTextBox.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Balance";
            // 
            // customerNameDisplayTextBox
            // 
            this.customerNameDisplayTextBox.Location = new System.Drawing.Point(116, 77);
            this.customerNameDisplayTextBox.Name = "customerNameDisplayTextBox";
            this.customerNameDisplayTextBox.Size = new System.Drawing.Size(211, 20);
            this.customerNameDisplayTextBox.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Customer Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Opening Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Account Number";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.withdrawButton);
            this.groupBox3.Controls.Add(this.depositButton);
            this.groupBox3.Controls.Add(this.amountEntryTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(13, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 82);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(240, 50);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 14;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(240, 22);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 9;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // amountEntryTextBox
            // 
            this.amountEntryTextBox.Location = new System.Drawing.Point(60, 24);
            this.amountEntryTextBox.Name = "amountEntryTextBox";
            this.amountEntryTextBox.Size = new System.Drawing.Size(161, 20);
            this.amountEntryTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label12.Location = new System.Drawing.Point(428, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(224, 24);
            this.label12.TabIndex = 3;
            this.label12.Text = "Fast Banking Solution";
            // 
            // FastBankAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 361);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FastBankAppUI";
            this.Text = "FastBankAppUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailEntryTextBox;
        private System.Windows.Forms.TextBox openingDateEntryTextBox;
        private System.Windows.Forms.TextBox accountNumberEntryTextBox;
        private System.Windows.Forms.TextBox customerNameEntryTextBox;
        private System.Windows.Forms.TextBox balanceDisplayTextBox;
        private System.Windows.Forms.TextBox amountEntryTextBox;
        private System.Windows.Forms.TextBox emailDisplayTextBox;
        private System.Windows.Forms.TextBox openingDateDisplayTextBox;
        private System.Windows.Forms.TextBox accontNumberDisplayTextBox;
        private System.Windows.Forms.TextBox customerNameDisplayTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Label label12;
    }
}

