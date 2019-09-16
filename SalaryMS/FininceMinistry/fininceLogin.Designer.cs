namespace SalaryMS
{
    partial class fininceLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.staffGroupBox = new System.Windows.Forms.GroupBox();
            this.staffListButton = new System.Windows.Forms.Button();
            this.queryButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.jobNumberLabel = new System.Windows.Forms.Label();
            this.setButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.wageLevelGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.staffGroupBox.SuspendLayout();
            this.wageLevelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.welcomeLabel);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Font = new System.Drawing.Font("宋体", 12F);
            this.panel1.Location = new System.Drawing.Point(64, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 75);
            this.panel1.TabIndex = 3;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(293, 21);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(346, 24);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "您好，欢迎使用工资管理系统！";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(177, 21);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 24);
            this.usernameLabel.TabIndex = 0;
            // 
            // staffGroupBox
            // 
            this.staffGroupBox.Controls.Add(this.dateTimePicker1);
            this.staffGroupBox.Controls.Add(this.button1);
            this.staffGroupBox.Controls.Add(this.staffListButton);
            this.staffGroupBox.Controls.Add(this.queryButton);
            this.staffGroupBox.Controls.Add(this.textBox1);
            this.staffGroupBox.Controls.Add(this.jobNumberLabel);
            this.staffGroupBox.Font = new System.Drawing.Font("宋体", 12F);
            this.staffGroupBox.Location = new System.Drawing.Point(64, 112);
            this.staffGroupBox.Name = "staffGroupBox";
            this.staffGroupBox.Size = new System.Drawing.Size(505, 339);
            this.staffGroupBox.TabIndex = 7;
            this.staffGroupBox.TabStop = false;
            this.staffGroupBox.Text = "员工工资管理";
            // 
            // staffListButton
            // 
            this.staffListButton.Font = new System.Drawing.Font("宋体", 12F);
            this.staffListButton.Location = new System.Drawing.Point(52, 149);
            this.staffListButton.Name = "staffListButton";
            this.staffListButton.Size = new System.Drawing.Size(436, 47);
            this.staffListButton.TabIndex = 4;
            this.staffListButton.Text = "全体员工工资列表";
            this.staffListButton.UseVisualStyleBackColor = true;
            this.staffListButton.Click += new System.EventHandler(this.staffListButton_Click);
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(317, 75);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(171, 42);
            this.queryButton.TabIndex = 2;
            this.queryButton.Text = "查询员工工资";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 35);
            this.textBox1.TabIndex = 1;
            // 
            // jobNumberLabel
            // 
            this.jobNumberLabel.AutoSize = true;
            this.jobNumberLabel.Location = new System.Drawing.Point(48, 84);
            this.jobNumberLabel.Name = "jobNumberLabel";
            this.jobNumberLabel.Size = new System.Drawing.Size(58, 24);
            this.jobNumberLabel.TabIndex = 0;
            this.jobNumberLabel.Text = "工号";
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(28, 108);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(175, 47);
            this.setButton.TabIndex = 5;
            this.setButton.Text = "设置工资标准";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(28, 46);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(175, 47);
            this.checkButton.TabIndex = 6;
            this.checkButton.Text = "查看工资标准";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // wageLevelGroupBox
            // 
            this.wageLevelGroupBox.Controls.Add(this.checkButton);
            this.wageLevelGroupBox.Controls.Add(this.setButton);
            this.wageLevelGroupBox.Font = new System.Drawing.Font("宋体", 12F);
            this.wageLevelGroupBox.Location = new System.Drawing.Point(607, 112);
            this.wageLevelGroupBox.Name = "wageLevelGroupBox";
            this.wageLevelGroupBox.Size = new System.Drawing.Size(284, 253);
            this.wageLevelGroupBox.TabIndex = 4;
            this.wageLevelGroupBox.TabStop = false;
            this.wageLevelGroupBox.Text = "工资标准";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("宋体", 12F);
            this.exitButton.Location = new System.Drawing.Point(771, 402);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(152, 49);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "退出登录";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "生成该月工资表";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy年MM月";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(52, 236);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // fininceLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 470);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.staffGroupBox);
            this.Controls.Add(this.wageLevelGroupBox);
            this.Controls.Add(this.panel1);
            this.Name = "fininceLogin";
            this.Text = "工资管理系统";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.staffGroupBox.ResumeLayout(false);
            this.staffGroupBox.PerformLayout();
            this.wageLevelGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.GroupBox staffGroupBox;
        private System.Windows.Forms.Button staffListButton;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label jobNumberLabel;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.GroupBox wageLevelGroupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}