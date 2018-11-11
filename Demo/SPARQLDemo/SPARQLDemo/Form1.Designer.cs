namespace SPARQLDemo
{
    partial class SPARQLDemo
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
            this.search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.ListBox();
            this.subClass = new System.Windows.Forms.Button();
            this.superClass = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.loginLinkLabel = new System.Windows.Forms.LinkLabel();
            this.userLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(529, 26);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(89, 46);
            this.search.TabIndex = 0;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(424, 26);
            this.textBox1.TabIndex = 2;
            // 
            // resultBox
            // 
            this.resultBox.FormattingEnabled = true;
            this.resultBox.ItemHeight = 20;
            this.resultBox.Location = new System.Drawing.Point(30, 112);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(710, 204);
            this.resultBox.TabIndex = 3;
            // 
            // subClass
            // 
            this.subClass.Location = new System.Drawing.Point(30, 344);
            this.subClass.Name = "subClass";
            this.subClass.Size = new System.Drawing.Size(122, 56);
            this.subClass.TabIndex = 4;
            this.subClass.Text = "SubClass";
            this.subClass.UseVisualStyleBackColor = true;
            this.subClass.Click += new System.EventHandler(this.subClass_Click);
            // 
            // superClass
            // 
            this.superClass.Location = new System.Drawing.Point(182, 344);
            this.superClass.Name = "superClass";
            this.superClass.Size = new System.Drawing.Size(138, 56);
            this.superClass.TabIndex = 5;
            this.superClass.Text = "SuperClass";
            this.superClass.UseVisualStyleBackColor = true;
            this.superClass.Click += new System.EventHandler(this.superClass_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(602, 344);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(138, 56);
            this.insertButton.TabIndex = 6;
            this.insertButton.Text = "Insert New Class Here";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertClass_Click);
            // 
            // loginLinkLabel
            // 
            this.loginLinkLabel.AutoSize = true;
            this.loginLinkLabel.Location = new System.Drawing.Point(723, 9);
            this.loginLinkLabel.Name = "loginLinkLabel";
            this.loginLinkLabel.Size = new System.Drawing.Size(48, 20);
            this.loginLinkLabel.TabIndex = 7;
            this.loginLinkLabel.TabStop = true;
            this.loginLinkLabel.Text = "Login";
            this.loginLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLinkLabel_LinkClicked);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(651, 9);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(53, 20);
            this.userLabel.TabIndex = 8;
            this.userLabel.Text = "Guest";
            // 
            // SPARQLDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.loginLinkLabel);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.superClass);
            this.Controls.Add(this.subClass);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.search);
            this.Name = "SPARQLDemo";
            this.Text = "SPARQLDemo";
            this.Load += new System.EventHandler(this.SPARQLDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox resultBox;
        private System.Windows.Forms.Button subClass;
        private System.Windows.Forms.Button superClass;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.LinkLabel loginLinkLabel;
        private System.Windows.Forms.Label userLabel;
    }
}

