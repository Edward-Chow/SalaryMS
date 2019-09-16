namespace SalaryMS
{
    partial class personnelLogin
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.staffGroupBox = new System.Windows.Forms.GroupBox();
            this.inputAttendancebutton = new System.Windows.Forms.Button();
            this.deleteStaffButton = new System.Windows.Forms.Button();
            this.staffListButton = new System.Windows.Forms.Button();
            this.queryButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.jobNumberLabel = new System.Windows.Forms.Label();
            this.addStaffButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.staffGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.welcomeLabel);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Font = new System.Drawing.Font("宋体", 12F);
            this.panel1.Location = new System.Drawing.Point(193, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 75);
            this.panel1.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(315, 21);
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
            this.staffGroupBox.Controls.Add(this.inputAttendancebutton);
            this.staffGroupBox.Controls.Add(this.deleteStaffButton);
            this.staffGroupBox.Controls.Add(this.staffListButton);
            this.staffGroupBox.Controls.Add(this.queryButton);
            this.staffGroupBox.Controls.Add(this.textBox1);
            this.staffGroupBox.Controls.Add(this.jobNumberLabel);
            this.staffGroupBox.Controls.Add(this.addStaffButton);
            this.staffGroupBox.Font = new System.Drawing.Font("宋体", 12F);
            this.staffGroupBox.Location = new System.Drawing.Point(48, 108);
            this.staffGroupBox.Name = "staffGroupBox";
            this.staffGroupBox.Size = new System.Drawing.Size(585, 302);
            this.staffGroupBox.TabIndex = 1;
            this.staffGroupBox.TabStop = false;
            this.staffGroupBox.Text = "员工管理";
            // 
            // inputAttendancebutton
            // 
            this.inputAttendancebutton.Font = new System.Drawing.Font("宋体", 12F);
            this.inputAttendancebutton.Location = new System.Drawing.Point(332, 136);
            this.inputAttendancebutton.Name = "inputAttendancebutton";
            this.inputAttendancebutton.Size = new System.Drawing.Size(189, 59);
            this.inputAttendancebutton.TabIndex = 9;
            this.inputAttendancebutton.Text = "录入考勤信息";
            this.inputAttendancebutton.UseVisualStyleBackColor = true;
            this.inputAttendancebutton.Click += new System.EventHandler(this.inputAttendancebutton_Click);
            // 
            // deleteStaffButton
            // 
            this.deleteStaffButton.Font = new System.Drawing.Font("宋体", 12F);
            this.deleteStaffButton.Location = new System.Drawing.Point(49, 224);
            this.deleteStaffButton.Name = "deleteStaffButton";
            this.deleteStaffButton.Size = new System.Drawing.Size(151, 60);
            this.deleteStaffButton.TabIndex = 7;
            this.deleteStaffButton.Text = "删除员工";
            this.deleteStaffButton.UseVisualStyleBackColor = true;
            this.deleteStaffButton.Click += new System.EventHandler(this.deleteStaffButton_Click);
            // 
            // staffListButton
            // 
            this.staffListButton.Font = new System.Drawing.Font("宋体", 12F);
            this.staffListButton.Location = new System.Drawing.Point(332, 222);
            this.staffListButton.Name = "staffListButton";
            this.staffListButton.Size = new System.Drawing.Size(189, 62);
            this.staffListButton.TabIndex = 4;
            this.staffListButton.Text = "员工列表";
            this.staffListButton.UseVisualStyleBackColor = true;
            this.staffListButton.Click += new System.EventHandler(this.staffListButton_Click);
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(344, 47);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(189, 59);
            this.queryButton.TabIndex = 2;
            this.queryButton.Text = "查询员工信息";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 35);
            this.textBox1.TabIndex = 1;
            // 
            // jobNumberLabel
            // 
            this.jobNumberLabel.AutoSize = true;
            this.jobNumberLabel.Location = new System.Drawing.Point(45, 64);
            this.jobNumberLabel.Name = "jobNumberLabel";
            this.jobNumberLabel.Size = new System.Drawing.Size(58, 24);
            this.jobNumberLabel.TabIndex = 0;
            this.jobNumberLabel.Text = "工号";
            this.jobNumberLabel.Click += new System.EventHandler(this.jobNumberLabel_Click);
            // 
            // addStaffButton
            // 
            this.addStaffButton.Font = new System.Drawing.Font("宋体", 12F);
            this.addStaffButton.Location = new System.Drawing.Point(49, 136);
            this.addStaffButton.Name = "addStaffButton";
            this.addStaffButton.Size = new System.Drawing.Size(151, 59);
            this.addStaffButton.TabIndex = 3;
            this.addStaffButton.Text = "新增员工";
            this.addStaffButton.UseVisualStyleBackColor = true;
            this.addStaffButton.Click += new System.EventHandler(this.addStaffButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("宋体", 12F);
            this.exitButton.Location = new System.Drawing.Point(1107, 445);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(152, 49);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "退出登录";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.Location = new System.Drawing.Point(674, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 302);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "系统用户管理";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F);
            this.button1.Location = new System.Drawing.Point(344, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "删除系统用户";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(344, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 59);
            this.button4.TabIndex = 2;
            this.button4.Text = "查询用户权限";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 35);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 12F);
            this.button5.Location = new System.Drawing.Point(73, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 59);
            this.button5.TabIndex = 3;
            this.button5.Text = "新增系统用户";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // personnelLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.staffGroupBox);
            this.Controls.Add(this.panel1);
            this.Name = "personnelLogin";
            this.Text = "工资管理系统";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.staffGroupBox.ResumeLayout(false);
            this.staffGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.GroupBox staffGroupBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button addStaffButton;
        private System.Windows.Forms.Button staffListButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button deleteStaffButton;
        private System.Windows.Forms.Button inputAttendancebutton;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label jobNumberLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
    }
}