namespace SalaryMS.PersonnelMinistry
{
    partial class userAdd
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
            this.addStaffGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.staffNumTextBox = new System.Windows.Forms.TextBox();
            this.staffNumLabel = new System.Windows.Forms.Label();
            this.minNumLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.sexLabel = new System.Windows.Forms.Label();
            this.minComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.usernameBox1 = new System.Windows.Forms.TextBox();
            this.passwordBox1 = new System.Windows.Forms.TextBox();
            this.addStaffGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addStaffGroupBox
            // 
            this.addStaffGroupBox.Controls.Add(this.exitButton);
            this.addStaffGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.addStaffGroupBox.Controls.Add(this.addButton);
            this.addStaffGroupBox.Font = new System.Drawing.Font("宋体", 12F);
            this.addStaffGroupBox.Location = new System.Drawing.Point(-13, 40);
            this.addStaffGroupBox.Name = "addStaffGroupBox";
            this.addStaffGroupBox.Size = new System.Drawing.Size(890, 364);
            this.addStaffGroupBox.TabIndex = 1;
            this.addStaffGroupBox.TabStop = false;
            this.addStaffGroupBox.Text = "新增用户信息";
            this.addStaffGroupBox.Enter += new System.EventHandler(this.addStaffGroupBox_Enter);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(727, 291);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(126, 55);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "取消";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.minComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.sexLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.staffNumTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.staffNumLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.minNumLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.positionLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.usernameBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.passwordBox1, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(667, 314);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // staffNumTextBox
            // 
            this.staffNumTextBox.Location = new System.Drawing.Point(169, 3);
            this.staffNumTextBox.Name = "staffNumTextBox";
            this.staffNumTextBox.Size = new System.Drawing.Size(158, 35);
            this.staffNumTextBox.TabIndex = 1;
            // 
            // staffNumLabel
            // 
            this.staffNumLabel.AutoSize = true;
            this.staffNumLabel.Location = new System.Drawing.Point(3, 0);
            this.staffNumLabel.Name = "staffNumLabel";
            this.staffNumLabel.Size = new System.Drawing.Size(82, 24);
            this.staffNumLabel.TabIndex = 1;
            this.staffNumLabel.Text = "职工号";
            // 
            // minNumLabel
            // 
            this.minNumLabel.AutoSize = true;
            this.minNumLabel.Location = new System.Drawing.Point(3, 104);
            this.minNumLabel.Name = "minNumLabel";
            this.minNumLabel.Size = new System.Drawing.Size(82, 24);
            this.minNumLabel.TabIndex = 2;
            this.minNumLabel.Text = "用户名";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(727, 209);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(126, 55);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "确定添加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(3, 208);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(106, 24);
            this.sexLabel.TabIndex = 8;
            this.sexLabel.Text = "部门名称";
            // 
            // minComboBox
            // 
            this.minComboBox.FormattingEnabled = true;
            this.minComboBox.Items.AddRange(new object[] {
            "总经理办公室",
            "人事部",
            "财务部",
            "技术部"});
            this.minComboBox.Location = new System.Drawing.Point(169, 211);
            this.minComboBox.Name = "minComboBox";
            this.minComboBox.Size = new System.Drawing.Size(158, 32);
            this.minComboBox.TabIndex = 14;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(335, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 24);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "姓名";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(335, 104);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(58, 24);
            this.positionLabel.TabIndex = 4;
            this.positionLabel.Text = "密码";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(501, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(158, 35);
            this.nameTextBox.TabIndex = 7;
            // 
            // usernameBox1
            // 
            this.usernameBox1.Location = new System.Drawing.Point(169, 107);
            this.usernameBox1.Name = "usernameBox1";
            this.usernameBox1.Size = new System.Drawing.Size(158, 35);
            this.usernameBox1.TabIndex = 15;
            // 
            // passwordBox1
            // 
            this.passwordBox1.Location = new System.Drawing.Point(501, 107);
            this.passwordBox1.Name = "passwordBox1";
            this.passwordBox1.Size = new System.Drawing.Size(158, 35);
            this.passwordBox1.TabIndex = 16;
            // 
            // userAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 445);
            this.Controls.Add(this.addStaffGroupBox);
            this.Name = "userAdd";
            this.Text = "新增系统用户";
            this.addStaffGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addStaffGroupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox minComboBox;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox staffNumTextBox;
        private System.Windows.Forms.Label staffNumLabel;
        private System.Windows.Forms.Label minNumLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox usernameBox1;
        private System.Windows.Forms.TextBox passwordBox1;
    }
}