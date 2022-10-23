namespace CombinedForm
{
    partial class AllForms
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
            this.listBtn = new System.Windows.Forms.Button();
            this.linkedListBtn = new System.Windows.Forms.Button();
            this.stackBtn = new System.Windows.Forms.Button();
            this.queueBtn = new System.Windows.Forms.Button();
            this.backToStudentsBtn = new System.Windows.Forms.Button();
            this.dictionaryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBtn
            // 
            this.listBtn.Location = new System.Drawing.Point(69, 60);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(125, 46);
            this.listBtn.TabIndex = 0;
            this.listBtn.Text = "List";
            this.listBtn.UseVisualStyleBackColor = true;
            // 
            // linkedListBtn
            // 
            this.linkedListBtn.Location = new System.Drawing.Point(232, 60);
            this.linkedListBtn.Name = "linkedListBtn";
            this.linkedListBtn.Size = new System.Drawing.Size(125, 46);
            this.linkedListBtn.TabIndex = 1;
            this.linkedListBtn.Text = "LinkedList";
            this.linkedListBtn.UseVisualStyleBackColor = true;
            this.linkedListBtn.Click += new System.EventHandler(this.linkedListBtn_Click);
            // 
            // stackBtn
            // 
            this.stackBtn.Location = new System.Drawing.Point(385, 60);
            this.stackBtn.Name = "stackBtn";
            this.stackBtn.Size = new System.Drawing.Size(125, 46);
            this.stackBtn.TabIndex = 2;
            this.stackBtn.Text = "Stack";
            this.stackBtn.UseVisualStyleBackColor = true;
            this.stackBtn.Click += new System.EventHandler(this.stackBtn_Click);
            // 
            // queueBtn
            // 
            this.queueBtn.Location = new System.Drawing.Point(536, 60);
            this.queueBtn.Name = "queueBtn";
            this.queueBtn.Size = new System.Drawing.Size(125, 46);
            this.queueBtn.TabIndex = 3;
            this.queueBtn.Text = "Queue";
            this.queueBtn.UseVisualStyleBackColor = true;
            this.queueBtn.Click += new System.EventHandler(this.queueBtn_Click);
            // 
            // backToStudentsBtn
            // 
            this.backToStudentsBtn.Location = new System.Drawing.Point(557, 369);
            this.backToStudentsBtn.Name = "backToStudentsBtn";
            this.backToStudentsBtn.Size = new System.Drawing.Size(189, 46);
            this.backToStudentsBtn.TabIndex = 4;
            this.backToStudentsBtn.Text = "Back to Student Form";
            this.backToStudentsBtn.UseVisualStyleBackColor = true;
            this.backToStudentsBtn.Click += new System.EventHandler(this.backToStudentsBtn_Click);
            // 
            // dictionaryBtn
            // 
            this.dictionaryBtn.Location = new System.Drawing.Point(69, 141);
            this.dictionaryBtn.Name = "dictionaryBtn";
            this.dictionaryBtn.Size = new System.Drawing.Size(125, 46);
            this.dictionaryBtn.TabIndex = 5;
            this.dictionaryBtn.Text = "Dictionary";
            this.dictionaryBtn.UseVisualStyleBackColor = true;
            this.dictionaryBtn.Click += new System.EventHandler(this.dictionaryBtn_Click);
            // 
            // AllForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dictionaryBtn);
            this.Controls.Add(this.backToStudentsBtn);
            this.Controls.Add(this.queueBtn);
            this.Controls.Add(this.stackBtn);
            this.Controls.Add(this.linkedListBtn);
            this.Controls.Add(this.listBtn);
            this.Name = "AllForms";
            this.Text = "AllForms";
            this.ResumeLayout(false);

        }

        #endregion

        private Button listBtn;
        private Button linkedListBtn;
        private Button stackBtn;
        private Button queueBtn;
        private Button backToStudentsBtn;
        private Button dictionaryBtn;
    }
}