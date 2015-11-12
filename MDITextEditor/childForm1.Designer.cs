namespace MDITextEditor
{
    partial class childForm1
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
            this.childRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // childRichTextBox
            // 
            this.childRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.childRichTextBox.Name = "childRichTextBox";
            this.childRichTextBox.Size = new System.Drawing.Size(629, 431);
            this.childRichTextBox.TabIndex = 0;
            this.childRichTextBox.Text = "";
            // 
            // childForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 455);
            this.Controls.Add(this.childRichTextBox);
            this.Name = "childForm1";
            this.Text = "Text Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox childRichTextBox;
    }
}