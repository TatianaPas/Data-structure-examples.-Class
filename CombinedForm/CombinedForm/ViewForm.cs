using System;
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
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void backToStudentForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1= new Form1();
            form1.Show();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            ReadFile readfile = new ReadFile();
            studentListBox.DataSource = readfile.readStudents();
        }
    }
}
