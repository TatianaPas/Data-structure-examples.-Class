namespace CombinedForm
{
    partial class StackForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.dipatchListBox = new System.Windows.Forms.ListBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.loadingListBox = new System.Windows.Forms.ListBox();
            this.addPBoxBtn = new System.Windows.Forms.Button();
            this.serialNoTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(529, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 30);
            this.label7.TabIndex = 24;
            this.label7.Text = "Dispatch List";
            // 
            // dipatchListBox
            // 
            this.dipatchListBox.FormattingEnabled = true;
            this.dipatchListBox.ItemHeight = 15;
            this.dipatchListBox.Location = new System.Drawing.Point(529, 282);
            this.dipatchListBox.Name = "dipatchListBox";
            this.dipatchListBox.Size = new System.Drawing.Size(130, 184);
            this.dipatchListBox.TabIndex = 23;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(340, 349);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(132, 23);
            this.nextBtn.TabIndex = 22;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(121, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 30);
            this.label6.TabIndex = 21;
            this.label6.Text = "Loading List";
            // 
            // loadingListBox
            // 
            this.loadingListBox.FormattingEnabled = true;
            this.loadingListBox.ItemHeight = 15;
            this.loadingListBox.Location = new System.Drawing.Point(121, 282);
            this.loadingListBox.Name = "loadingListBox";
            this.loadingListBox.Size = new System.Drawing.Size(176, 184);
            this.loadingListBox.TabIndex = 20;
            // 
            // addPBoxBtn
            // 
            this.addPBoxBtn.Location = new System.Drawing.Point(285, 146);
            this.addPBoxBtn.Name = "addPBoxBtn";
            this.addPBoxBtn.Size = new System.Drawing.Size(106, 23);
            this.addPBoxBtn.TabIndex = 19;
            this.addPBoxBtn.Text = "Add";
            this.addPBoxBtn.UseVisualStyleBackColor = true;
            this.addPBoxBtn.Click += new System.EventHandler(this.addPBoxBtn_Click);
            // 
            // serialNoTextBox
            // 
            this.serialNoTextBox.Location = new System.Drawing.Point(213, 117);
            this.serialNoTextBox.Name = "serialNoTextBox";
            this.serialNoTextBox.Size = new System.Drawing.Size(178, 23);
            this.serialNoTextBox.TabIndex = 16;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(213, 88);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(178, 23);
            this.idTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Box Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Box ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Serial No";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(634, 540);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(126, 23);
            this.backBtn.TabIndex = 27;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // StackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dipatchListBox);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loadingListBox);
            this.Controls.Add(this.addPBoxBtn);
            this.Controls.Add(this.serialNoTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.Name = "StackForm";
            this.Text = "StackForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private ListBox dipatchListBox;
        private Button nextBtn;
        private Label label6;
        private ListBox loadingListBox;
        private Button addPBoxBtn;
        private TextBox serialNoTextBox;
        private TextBox idTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button backBtn;
    }
}