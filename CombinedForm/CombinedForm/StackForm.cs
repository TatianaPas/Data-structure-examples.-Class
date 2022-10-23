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
    public partial class StackForm : Form
    {
        DispatchList trackList = new DispatchList();
        public StackForm()
        {
            InitializeComponent();
        }

        private void addPBoxBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTextBox.Text);
            string seralNo = serialNoTextBox.Text;
            Box box = new Box(id, seralNo);
            trackList.addBox(box);
            loadingListBox.DataSource = trackList.getAllLoadedBoxes().ToList();

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Box b = trackList.removeBox();
            loadingListBox.DataSource = trackList.getAllLoadedBoxes().ToList();
            dipatchListBox.Items.Add(b);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllForms allForms= new AllForms();
            allForms.Show();
        }
    }
}
