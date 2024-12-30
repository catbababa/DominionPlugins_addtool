namespace 批量添加成员
{
    partial class Form1
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
            this.txtDominionName = new System.Windows.Forms.TextBox();
            this.lblDominionName = new System.Windows.Forms.Label();
            this.lblMembers = new System.Windows.Forms.Label();
            this.btnAddMembers = new System.Windows.Forms.Button();
            this.btnSetAdmins = new System.Windows.Forms.Button();
            this.rtbMembers = new System.Windows.Forms.RichTextBox();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.tmrCommandDelay = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtDominionName
            // 
            this.txtDominionName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDominionName.Location = new System.Drawing.Point(30, 68);
            this.txtDominionName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtDominionName.Name = "txtDominionName";
            this.txtDominionName.Size = new System.Drawing.Size(444, 47);
            this.txtDominionName.TabIndex = 0;
            // 
            // lblDominionName
            // 
            this.lblDominionName.AutoSize = true;
            this.lblDominionName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDominionName.Location = new System.Drawing.Point(23, 20);
            this.lblDominionName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDominionName.Name = "lblDominionName";
            this.lblDominionName.Size = new System.Drawing.Size(178, 41);
            this.lblDominionName.TabIndex = 1;
            this.lblDominionName.Text = "领地名称：";
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Location = new System.Drawing.Point(23, 122);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(178, 41);
            this.lblMembers.TabIndex = 2;
            this.lblMembers.Text = "成员列表：";
            // 
            // btnAddMembers
            // 
            this.btnAddMembers.Location = new System.Drawing.Point(483, 330);
            this.btnAddMembers.Name = "btnAddMembers";
            this.btnAddMembers.Size = new System.Drawing.Size(283, 138);
            this.btnAddMembers.TabIndex = 4;
            this.btnAddMembers.Text = "批量添加成员";
            this.btnAddMembers.UseVisualStyleBackColor = true;
            // 
            // btnSetAdmins
            // 
            this.btnSetAdmins.Location = new System.Drawing.Point(483, 186);
            this.btnSetAdmins.Name = "btnSetAdmins";
            this.btnSetAdmins.Size = new System.Drawing.Size(283, 138);
            this.btnSetAdmins.TabIndex = 5;
            this.btnSetAdmins.Text = "批量设置管理员";
            this.btnSetAdmins.UseVisualStyleBackColor = true;
            // 
            // rtbMembers
            // 
            this.rtbMembers.Location = new System.Drawing.Point(30, 166);
            this.rtbMembers.Name = "rtbMembers";
            this.rtbMembers.Size = new System.Drawing.Size(444, 302);
            this.rtbMembers.TabIndex = 6;
            this.rtbMembers.Text = "";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.Location = new System.Drawing.Point(477, 29);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(139, 32);
            this.lblCountdown.TabIndex = 7;
            this.lblCountdown.Text = "触发倒计时";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(480, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "填写方法：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(480, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "领地名称输入框中输入你的领地名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(480, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "成员列表中输入你的成员游戏名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(480, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "每行输入一个游戏名 按下回车换行";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.linkLabel1.Location = new System.Drawing.Point(12, 471);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(486, 21);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "源码地址：https://github.com/catbababa/DominionPlugins_addtool";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 494);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.rtbMembers);
            this.Controls.Add(this.btnSetAdmins);
            this.Controls.Add(this.btnAddMembers);
            this.Controls.Add(this.lblMembers);
            this.Controls.Add(this.lblDominionName);
            this.Controls.Add(this.txtDominionName);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Dominion 插件批量添加成员 v1.1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDominionName;
        private System.Windows.Forms.Label lblDominionName;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.Button btnAddMembers;
        private System.Windows.Forms.Button btnSetAdmins;
        private System.Windows.Forms.RichTextBox rtbMembers;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Timer tmrCountdown;
        private System.Windows.Forms.Timer tmrCommandDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

