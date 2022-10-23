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
    public partial class LinkedListForm : Form
    {
        LinkedList<string> airlines = new LinkedList<string>();
        public LinkedListForm()
        {
            InitializeComponent();
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            airlines.AddFirst("Air New Zealand");
            airlines.AddLast("Quatar");
            airlines.AddLast("Fiji Arways");
            airlines.AddLast("Jet Star");
            displayBox.DataSource= airlines.ToList();
        }

        private void insertFirstBtn_Click(object sender, EventArgs e)
        {
            string airlineName = airlineTextBox.Text;
            airlines.AddFirst(airlineName);
            displayBox.DataSource = airlines.ToList();
        }

        private void insertLastBtn_Click(object sender, EventArgs e)
        {
            string airlineName = airlineTextBox.Text;
            airlines.AddLast(airlineName);
            displayBox.DataSource = airlines.ToList();

        }

        private void deleteFirstBtn_Click(object sender, EventArgs e)
        {
            airlines.RemoveFirst();
            displayBox.DataSource = airlines.ToList();
        }

        private void deleteLastBtn_Click(object sender, EventArgs e)
        {
            airlines.RemoveLast();
            displayBox.DataSource = airlines.ToList();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllForms allForm = new AllForms();
            allForm.Show();
        }
    }
}
