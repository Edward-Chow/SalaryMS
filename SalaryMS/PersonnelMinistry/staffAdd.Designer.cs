namespace SalaryMS
{
    partial class staffAdd
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
            this.cardTextBox = new System.Windows.Forms.TextBox();
            this.jobTitleComboBox = new System.Windows.Forms.ComboBox();
            this.jobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eduComboBox = new System.Windows.Forms.ComboBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.sexLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.staffNumTextBox = new System.Windows.Forms.TextBox();
            this.staffNumLabel = new System.Windows.Forms.Label();
            this.minNumLabel = new System.Windows.Forms.Label();
            this.minNumComboBox = new System.Windows.Forms.ComboBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.eduLabel = new System.Windows.Forms.Label();
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.jobAgeLabel = new System.Windows.Forms.Label();
            this.cardLabel = new System.Windows.Forms.Label();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
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
            this.addStaffGroupBox.Location = new System.Drawing.Point(24, 40);
            this.addStaffGroupBox.Name = "addStaffGroupBox";
            this.addStaffGroupBox.Size = new System.Drawing.Size(890, 364);
            this.addStaffGroupBox.TabIndex = 0;
            this.addStaffGroupBox.TabStop = false;
            this.addStaffGroupBox.Text = "新增员工信息";
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
            this.tableLayoutPanel1.Controls.Add(this.cardTextBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.jobTitleComboBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.jobDateTimePicker, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.eduComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.sexComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.sexLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.staffNumTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.staffNumLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.minNumLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.minNumComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.positionLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.positionComboBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.eduLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.jobTitleLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.birthdayLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.jobAgeLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cardLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.birthdayDateTimePicker, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(667, 314);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cardTextBox
            // 
            this.cardTextBox.Location = new System.Drawing.Point(501, 251);
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.Size = new System.Drawing.Size(158, 35);
            this.cardTextBox.TabIndex = 20;
            // 
            // jobTitleComboBox
            // 
            this.jobTitleComboBox.FormattingEnabled = true;
            this.jobTitleComboBox.Items.AddRange(new object[] {
            "正高",
            "副高",
            "中级",
            "初级",
            "无"});
            this.jobTitleComboBox.Location = new System.Drawing.Point(169, 251);
            this.jobTitleComboBox.Name = "jobTitleComboBox";
            this.jobTitleComboBox.Size = new System.Drawing.Size(158, 32);
            this.jobTitleComboBox.TabIndex = 19;
            // 
            // jobDateTimePicker
            // 
            this.jobDateTimePicker.Location = new System.Drawing.Point(501, 189);
            this.jobDateTimePicker.Name = "jobDateTimePicker";
            this.jobDateTimePicker.Size = new System.Drawing.Size(163, 35);
            this.jobDateTimePicker.TabIndex = 18;
            // 
            // eduComboBox
            // 
            this.eduComboBox.FormattingEnabled = true;
            this.eduComboBox.Items.AddRange(new object[] {
            "大专",
            "本科",
            "硕士",
            "博士"});
            this.eduComboBox.Location = new System.Drawing.Point(169, 189);
            this.eduComboBox.Name = "eduComboBox";
            this.eduComboBox.Size = new System.Drawing.Size(158, 32);
            this.eduComboBox.TabIndex = 17;
            // 
            // sexComboBox
            // 
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sexComboBox.Location = new System.Drawing.Point(169, 127);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(158, 32);
            this.sexComboBox.TabIndex = 14;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(3, 124);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(58, 24);
            this.sexLabel.TabIndex = 8;
            this.sexLabel.Text = "性别";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(501, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(158, 35);
            this.nameTextBox.TabIndex = 7;
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
            this.minNumLabel.Location = new System.Drawing.Point(3, 62);
            this.minNumLabel.Name = "minNumLabel";
            this.minNumLabel.Size = new System.Drawing.Size(106, 24);
            this.minNumLabel.TabIndex = 2;
            this.minNumLabel.Text = "部门编号";
            // 
            // minNumComboBox
            // 
            this.minNumComboBox.FormattingEnabled = true;
            this.minNumComboBox.Items.AddRange(new object[] {
            "1-总经理办公室",
            "2-人事部",
            "3-财务部",
            "4-市场部",
            "5-销售部",
            "6-技术部",
            "7-运维部",
            "8-测试部"});
            this.minNumComboBox.Location = new System.Drawing.Point(169, 65);
            this.minNumComboBox.Name = "minNumComboBox";
            this.minNumComboBox.Size = new System.Drawing.Size(158, 32);
            this.minNumComboBox.TabIndex = 3;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(335, 62);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(58, 24);
            this.positionLabel.TabIndex = 4;
            this.positionLabel.Text = "职务";
            // 
            // positionComboBox
            // 
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Items.AddRange(new object[] {
            "经理",
            "员工"});
            this.positionComboBox.Location = new System.Drawing.Point(501, 65);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(158, 32);
            this.positionComboBox.TabIndex = 5;
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
            // eduLabel
            // 
            this.eduLabel.AutoSize = true;
            this.eduLabel.Location = new System.Drawing.Point(3, 186);
            this.eduLabel.Name = "eduLabel";
            this.eduLabel.Size = new System.Drawing.Size(58, 24);
            this.eduLabel.TabIndex = 9;
            this.eduLabel.Text = "学历";
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Location = new System.Drawing.Point(3, 248);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(58, 24);
            this.jobTitleLabel.TabIndex = 10;
            this.jobTitleLabel.Text = "职称";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(335, 124);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(58, 24);
            this.birthdayLabel.TabIndex = 11;
            this.birthdayLabel.Text = "生日";
            // 
            // jobAgeLabel
            // 
            this.jobAgeLabel.AutoSize = true;
            this.jobAgeLabel.Location = new System.Drawing.Point(335, 186);
            this.jobAgeLabel.Name = "jobAgeLabel";
            this.jobAgeLabel.Size = new System.Drawing.Size(106, 24);
            this.jobAgeLabel.TabIndex = 12;
            this.jobAgeLabel.Text = "入职时间";
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.Location = new System.Drawing.Point(335, 248);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(106, 24);
            this.cardLabel.TabIndex = 13;
            this.cardLabel.Text = "银行卡号";
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(501, 127);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(163, 35);
            this.birthdayDateTimePicker.TabIndex = 16;
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
            // staffAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 437);
            this.Controls.Add(this.addStaffGroupBox);
            this.Name = "staffAdd";
            this.Text = "新增员工";
            this.addStaffGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addStaffGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label staffNumLabel;
        private System.Windows.Forms.TextBox staffNumTextBox;
        private System.Windows.Forms.Label minNumLabel;
        private System.Windows.Forms.TextBox cardTextBox;
        private System.Windows.Forms.ComboBox jobTitleComboBox;
        private System.Windows.Forms.DateTimePicker jobDateTimePicker;
        private System.Windows.Forms.ComboBox eduComboBox;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox minNumComboBox;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label eduLabel;
        private System.Windows.Forms.Label jobTitleLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label jobAgeLabel;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button exitButton;
    }
}