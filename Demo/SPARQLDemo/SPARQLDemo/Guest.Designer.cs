namespace SPARQLDemo
{
    partial class Guest
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
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.FeedbackRichTextBox = new System.Windows.Forms.RichTextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(23, 40);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(84, 20);
            this.feedbackLabel.TabIndex = 0;
            this.feedbackLabel.Text = "Feedback:";
            // 
            // FeedbackRichTextBox
            // 
            this.FeedbackRichTextBox.Location = new System.Drawing.Point(143, 40);
            this.FeedbackRichTextBox.Name = "FeedbackRichTextBox";
            this.FeedbackRichTextBox.Size = new System.Drawing.Size(307, 282);
            this.FeedbackRichTextBox.TabIndex = 1;
            this.FeedbackRichTextBox.Text = "";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(143, 366);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(307, 60);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.FeedbackRichTextBox);
            this.Controls.Add(this.feedbackLabel);
            this.Name = "Guest";
            this.Text = "Guest";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.RichTextBox FeedbackRichTextBox;
        private System.Windows.Forms.Button submitButton;
    }
}