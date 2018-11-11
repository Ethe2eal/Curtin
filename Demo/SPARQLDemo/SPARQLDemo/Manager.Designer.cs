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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.definitionLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.commentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.submitButton = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 26);
            this.textBox1.TabIndex = 2;
            // 
            // definitionLabel
            // 
            this.definitionLabel.AutoSize = true;
            this.definitionLabel.Location = new System.Drawing.Point(28, 137);
            this.definitionLabel.Name = "definitionLabel";
            this.definitionLabel.Size = new System.Drawing.Size(116, 20);
            this.definitionLabel.TabIndex = 3;
            this.definitionLabel.Text = "Class Definiton";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(32, 210);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(86, 20);
            this.commentLabel.TabIndex = 4;
            this.commentLabel.Text = "Comments";
            // 
            // commentRichTextBox
            // 
            this.commentRichTextBox.Location = new System.Drawing.Point(187, 210);
            this.commentRichTextBox.Name = "commentRichTextBox";
            this.commentRichTextBox.Size = new System.Drawing.Size(174, 96);
            this.commentRichTextBox.TabIndex = 5;
            this.commentRichTextBox.Text = "";
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
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 416);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.commentRichTextBox);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.definitionLabel);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label definitionLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.RichTextBox commentRichTextBox;
        private System.Windows.Forms.Button submitButton;
    }
}