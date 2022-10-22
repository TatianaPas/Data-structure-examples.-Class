namespace CombinedForm
{
    partial class LinkedListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.displayBox = new System.Windows.Forms.ListBox();
            this.airlineTextBox = new System.Windows.Forms.TextBox();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.insertFirstBtn = new System.Windows.Forms.Button();
            this.insertLastBtn = new System.Windows.Forms.Button();
            this.deleteFirstBtn = new System.Windows.Forms.Button();
            this.deleteLastBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(208, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Airline Schedule Program";
            // 
            // displayBox
            // 
            this.displayBox.FormattingEnabled = true;
            this.displayBox.ItemHeight = 15;
            this.displayBox.Location = new System.Drawing.Point(551, 88);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(162, 169);
            this.displayBox.TabIndex = 1;
            // 
            // airlineTextBox
            // 
            this.airlineTextBox.Location = new System.Drawing.Point(234, 97);
            this.airlineTextBox.Name = "airlineTextBox";
            this.airlineTextBox.Size = new System.Drawing.Size(184, 23);
            this.airlineTextBox.TabIndex = 2;
            // 
            // addNewBtn
            // 
            this.addNewBtn.Location = new System.Drawing.Point(49, 77);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(126, 43);
            this.addNewBtn.TabIndex = 3;
            this.addNewBtn.Text = "Load Data";
            this.addNewBtn.UseVisualStyleBackColor = true;
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // insertFirstBtn
            // 
            this.insertFirstBtn.Location = new System.Drawing.Point(49, 143);
            this.insertFirstBtn.Name = "insertFirstBtn";
            this.insertFirstBtn.Size = new System.Drawing.Size(126, 43);
            this.insertFirstBtn.TabIndex = 4;
            this.insertFirstBtn.Text = "Insert First";
            this.insertFirstBtn.UseVisualStyleBackColor = true;
            this.insertFirstBtn.Click += new System.EventHandler(this.insertFirstBtn_Click);
            // 
            // insertLastBtn
            // 
            this.insertLastBtn.Location = new System.Drawing.Point(49, 202);
            this.insertLastBtn.Name = "insertLastBtn";
            this.insertLastBtn.Size = new System.Drawing.Size(126, 43);
            this.insertLastBtn.TabIndex = 5;
            this.insertLastBtn.Text = "Insert Last";
            this.insertLastBtn.UseVisualStyleBackColor = true;
            this.insertLastBtn.Click += new System.EventHandler(this.insertLastBtn_Click);
            // 
            // deleteFirstBtn
            // 
            this.deleteFirstBtn.Location = new System.Drawing.Point(49, 264);
            this.deleteFirstBtn.Name = "deleteFirstBtn";
            this.deleteFirstBtn.Size = new System.Drawing.Size(126, 43);
            this.deleteFirstBtn.TabIndex = 6;
            this.deleteFirstBtn.Text = "Delete First";
            this.deleteFirstBtn.UseVisualStyleBackColor = true;
            this.deleteFirstBtn.Click += new System.EventHandler(this.deleteFirstBtn_Click);
            // 
            // deleteLastBtn
            // 
            this.deleteLastBtn.Location = new System.Drawing.Point(49, 313);
            this.deleteLastBtn.Name = "deleteLastBtn";
            this.deleteLastBtn.Size = new System.Drawing.Size(126, 43);
            this.deleteLastBtn.TabIndex = 7;
            this.deleteLastBtn.Text = "DeleteLast";
            this.deleteLastBtn.UseVisualStyleBackColor = true;
            this.deleteLastBtn.Click += new System.EventHandler(this.deleteLastBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Insert Airline Name";
            // 
            // LinkedListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteLastBtn);
            this.Controls.Add(this.deleteFirstBtn);
            this.Controls.Add(this.insertLastBtn);
            this.Controls.Add(this.insertFirstBtn);
            this.Controls.Add(this.addNewBtn);
            this.Controls.Add(this.airlineTextBox);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.label1);
            this.Name = "LinkedListForm";
            this.Text = "LinkedListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox displayBox;
        private TextBox airlineTextBox;
        private Button addNewBtn;
        private Button insertFirstBtn;
        private Button insertLastBtn;
        private Button deleteFirstBtn;
        private Button deleteLastBtn;
        private Label label2;
    }
}