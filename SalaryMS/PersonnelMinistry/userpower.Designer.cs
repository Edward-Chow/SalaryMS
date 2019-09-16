namespace SalaryMS.PersonnelMinistry
{
    partial class userpower
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
            this.labelusername = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.labelpower = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("宋体", 12F);
            this.labelusername.Location = new System.Drawing.Point(53, 50);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(106, 24);
            this.labelusername.TabIndex = 2;
            this.labelusername.Text = "用户名：";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("宋体", 12F);
            this.username.Location = new System.Drawing.Point(159, 50);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 24);
            this.username.TabIndex = 3;
            // 
            // labelpower
            // 
            this.labelpower.AutoSize = true;
            this.labelpower.Font = new System.Drawing.Font("宋体", 12F);
            this.labelpower.Location = new System.Drawing.Point(47, 111);
            this.labelpower.Name = "labelpower";
            this.labelpower.Size = new System.Drawing.Size(130, 24);
            this.labelpower.TabIndex = 4;
            this.labelpower.Text = "访问权限：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "总经理办公室",
            "人事部",
            "财务部",
            "技术部"});
            this.comboBox1.Location = new System.Drawing.Point(183, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 26);
            this.comboBox1.TabIndex = 5;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonUpdate.Location = new System.Drawing.Point(116, 175);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(111, 49);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "修改";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(159, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 7;
            // 
            // userpower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 252);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelpower);
            this.Controls.Add(this.username);
            this.Controls.Add(this.labelusername);
            this.Name = "userpower";
            this.Text = "用户权限";
            this.Load += new System.EventHandler(this.userpower_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label labelpower;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label1;
    }
}