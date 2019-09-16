namespace SalaryMS
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.messageLab = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.departmentComboBox);
            this.panel1.Controls.Add(this.departmentLabel);
            this.panel1.Controls.Add(this.messageLab);
            this.panel1.Controls.Add(this.messageLabel);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.passwordTextbox);
            this.panel1.Controls.Add(this.idTextbox);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.welcomeLabel);
            this.panel1.ForeColor = System.Drawing.Color.AliceBlue;
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 609);
            this.panel1.TabIndex = 0;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Items.AddRange(new object[] {
            "总经理办公室",
            "人事部",
            "财务部",
            "技术部"});
            this.departmentComboBox.Location = new System.Drawing.Point(423, 440);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(195, 26);
            this.departmentComboBox.TabIndex = 11;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("方正舒体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.departmentLabel.Image = ((System.Drawing.Image)(resources.GetObject("departmentLabel.Image")));
            this.departmentLabel.Location = new System.Drawing.Point(270, 432);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(125, 38);
            this.departmentLabel.TabIndex = 10;
            this.departmentLabel.Text = " 部  门 ";
            // 
            // messageLab
            // 
            this.messageLab.AutoSize = true;
            this.messageLab.Font = new System.Drawing.Font("宋体", 12F);
            this.messageLab.ForeColor = System.Drawing.Color.AliceBlue;
            this.messageLab.Image = ((System.Drawing.Image)(resources.GetObject("messageLab.Image")));
            this.messageLab.Location = new System.Drawing.Point(6, 590);
            this.messageLab.Name = "messageLab";
            this.messageLab.Size = new System.Drawing.Size(0, 24);
            this.messageLab.TabIndex = 9;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.ForeColor = System.Drawing.Color.Red;
            this.messageLabel.Location = new System.Drawing.Point(475, 539);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 18);
            this.messageLabel.TabIndex = 8;
            this.messageLabel.Visible = false;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("方正舒体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(711, 390);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(123, 60);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "关闭";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("方正舒体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginButton.Image = ((System.Drawing.Image)(resources.GetObject("loginButton.Image")));
            this.loginButton.Location = new System.Drawing.Point(711, 307);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(123, 60);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "登陆";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordTextbox.Location = new System.Drawing.Point(423, 362);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(195, 39);
            this.passwordTextbox.TabIndex = 4;
            // 
            // idTextbox
            // 
            this.idTextbox.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.idTextbox.Location = new System.Drawing.Point(423, 297);
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(195, 39);
            this.idTextbox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("方正舒体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordLabel.Image = ((System.Drawing.Image)(resources.GetObject("passwordLabel.Image")));
            this.passwordLabel.Location = new System.Drawing.Point(270, 363);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(125, 38);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = " 密  码 ";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("方正舒体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.idLabel.Image = ((System.Drawing.Image)(resources.GetObject("idLabel.Image")));
            this.idLabel.Location = new System.Drawing.Point(270, 298);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(125, 38);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "用户名";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.welcomeLabel.Font = new System.Drawing.Font("方正舒体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welcomeLabel.Image = ((System.Drawing.Image)(resources.GetObject("welcomeLabel.Image")));
            this.welcomeLabel.Location = new System.Drawing.Point(143, 97);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(753, 76);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "欢迎使用工资管理系统";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 613);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "工资管理系统";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label messageLab;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label departmentLabel;
    }
}

