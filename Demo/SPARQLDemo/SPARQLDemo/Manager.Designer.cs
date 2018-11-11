namespace SPARQLDemo
{
    partial class Manager
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.subClassTextBox = new System.Windows.Forms.TextBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.subClassLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.commentTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(28, 48);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(94, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Class Name";
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(187, 48);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(174, 26);
            this.classTextBox.TabIndex = 1;
            // 
            // subClassTextBox
            // 
            this.subClassTextBox.Location = new System.Drawing.Point(187, 117);
            this.subClassTextBox.Name = "subClassTextBox";
            this.subClassTextBox.Size = new System.Drawing.Size(174, 26);
            this.subClassTextBox.TabIndex = 2;
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(28, 179);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(86, 20);
            this.commentLabel.TabIndex = 3;
            this.commentLabel.Text = "Comments";
            // 
            // subClassLabel
            // 
            this.subClassLabel.AutoSize = true;
            this.subClassLabel.Location = new System.Drawing.Point(28, 117);
            this.subClassLabel.Name = "subClassLabel";
            this.subClassLabel.Size = new System.Drawing.Size(94, 20);
            this.subClassLabel.TabIndex = 4;
            this.subClassLabel.Text = "SubClassOf";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(187, 332);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(174, 61);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(187, 179);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(174, 112);
            this.commentTextBox.TabIndex = 7;
            this.commentTextBox.Text = "";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 416);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.subClassLabel);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.subClassTextBox);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "Manager";
            this.Text = "Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.TextBox subClassTextBox;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Label subClassLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.RichTextBox commentTextBox;
    }
}