namespace CombinedForm
{
    partial class ViewForm
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
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.backToStudentForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.ItemHeight = 15;
            this.studentListBox.Location = new System.Drawing.Point(68, 48);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(550, 184);
            this.studentListBox.TabIndex = 0;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(83, 282);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(145, 41);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // backToStudentForm
            // 
            this.backToStudentForm.Location = new System.Drawing.Point(582, 362);
            this.backToStudentForm.Name = "backToStudentForm";
            this.backToStudentForm.Size = new System.Drawing.Size(175, 67);
            this.backToStudentForm.TabIndex = 2;
            this.backToStudentForm.Text = "Back to Student form";
            this.backToStudentForm.UseVisualStyleBackColor = true;
            this.backToStudentForm.Click += new System.EventHandler(this.backToStudentForm_Click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backToStudentForm);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.studentListBox);
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox studentListBox;
        private Button loadButton;
        private Button backToStudentForm;
    }
}