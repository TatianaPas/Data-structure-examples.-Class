namespace CombinedForm
{
    partial class HashForm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.roomListBox = new System.Windows.Forms.ListBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(568, 388);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(190, 36);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back to data structures";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(63, 25);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(141, 31);
            this.showBtn.TabIndex = 1;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(63, 210);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(141, 31);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // roomListBox
            // 
            this.roomListBox.FormattingEnabled = true;
            this.roomListBox.ItemHeight = 15;
            this.roomListBox.Location = new System.Drawing.Point(221, 25);
            this.roomListBox.Name = "roomListBox";
            this.roomListBox.Size = new System.Drawing.Size(239, 154);
            this.roomListBox.TabIndex = 3;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(221, 215);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(239, 23);
            this.searchTextBox.TabIndex = 4;
            // 
            // HashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.roomListBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "HashForm";
            this.Text = "HashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backBtn;
        private Button showBtn;
        private Button searchBtn;
        private ListBox roomListBox;
        private TextBox searchTextBox;
    }
}