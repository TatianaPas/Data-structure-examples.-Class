﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombinedForm
{
    public partial class AllForms : Form
    {
        public AllForms()
        {
            InitializeComponent();
        }

        private void backToStudentsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void dictionaryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HashForm hashForm = new HashForm();
            hashForm.Show();
        }
    }
}
