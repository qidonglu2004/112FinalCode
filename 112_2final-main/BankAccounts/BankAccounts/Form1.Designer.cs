namespace BankAccounts
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.balanceTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.accountListbox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showRadioButton = new System.Windows.Forms.RadioButton();
            this.withdrawRadioButton = new System.Windows.Forms.RadioButton();
            this.depositRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.balanceTextbox);
            this.groupBox1.Controls.Add(this.nameTextbox);
            this.groupBox1.Controls.Add(this.idTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(43, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Information";
            // 
            // balanceTextbox
            // 
            this.balanceTextbox.Location = new System.Drawing.Point(98, 153);
            this.balanceTextbox.Name = "balanceTextbox";
            this.balanceTextbox.Size = new System.Drawing.Size(122, 29);
            this.balanceTextbox.TabIndex = 5;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(98, 99);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(122, 29);
            this.nameTextbox.TabIndex = 4;
            // 
            // idTextbox
            // 
            this.idTextbox.Location = new System.Drawing.Point(98, 38);
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(122, 29);
            this.idTextbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "餘額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號";
            // 
            // addAccountButton
            // 
            this.addAccountButton.Location = new System.Drawing.Point(132, 280);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(131, 29);
            this.addAccountButton.TabIndex = 1;
            this.addAccountButton.Text = "新增帳號";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // accountListbox
            // 
            this.accountListbox.FormattingEnabled = true;
            this.accountListbox.ItemHeight = 18;
            this.accountListbox.Location = new System.Drawing.Point(322, 35);
            this.accountListbox.Name = "accountListbox";
            this.accountListbox.Size = new System.Drawing.Size(233, 274);
            this.accountListbox.TabIndex = 2;
            this.accountListbox.SelectedIndexChanged += new System.EventHandler(this.accountListbox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showRadioButton);
            this.groupBox2.Controls.Add(this.withdrawRadioButton);
            this.groupBox2.Controls.Add(this.depositRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(623, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 125);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "存/提款";
            // 
            // showRadioButton
            // 
            this.showRadioButton.AutoSize = true;
            this.showRadioButton.Checked = true;
            this.showRadioButton.Location = new System.Drawing.Point(6, 97);
            this.showRadioButton.Name = "showRadioButton";
            this.showRadioButton.Size = new System.Drawing.Size(105, 22);
            this.showRadioButton.TabIndex = 2;
            this.showRadioButton.TabStop = true;
            this.showRadioButton.Text = "顯示餘額";
            this.showRadioButton.UseVisualStyleBackColor = true;
            // 
            // withdrawRadioButton
            // 
            this.withdrawRadioButton.AutoSize = true;
            this.withdrawRadioButton.Location = new System.Drawing.Point(6, 67);
            this.withdrawRadioButton.Name = "withdrawRadioButton";
            this.withdrawRadioButton.Size = new System.Drawing.Size(69, 22);
            this.withdrawRadioButton.TabIndex = 1;
            this.withdrawRadioButton.Text = "提款";
            this.withdrawRadioButton.UseVisualStyleBackColor = true;
            // 
            // depositRadioButton
            // 
            this.depositRadioButton.AutoSize = true;
            this.depositRadioButton.Location = new System.Drawing.Point(6, 39);
            this.depositRadioButton.Name = "depositRadioButton";
            this.depositRadioButton.Size = new System.Drawing.Size(69, 22);
            this.depositRadioButton.TabIndex = 0;
            this.depositRadioButton.Text = "存款";
            this.depositRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "金額";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(626, 231);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(143, 29);
            this.amountTextBox.TabIndex = 5;
            this.amountTextBox.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 378);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.accountListbox);
            this.Controls.Add(this.addAccountButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox balanceTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.ListBox accountListbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton withdrawRadioButton;
        private System.Windows.Forms.RadioButton depositRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton showRadioButton;
        private System.Windows.Forms.TextBox amountTextBox;
    }
}

