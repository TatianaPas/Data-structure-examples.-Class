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
    public partial class QueueForm : Form
    {
        Appointment appointments = new Appointment();
        public QueueForm()
        {
            InitializeComponent();
        }

        private void addPatientBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            string gender = genderComboBox.SelectedItem.ToString();
            Patient p = new Patient(name, address, gender);

            appointments.addPatient(p);
            waitingListBox.DataSource = appointments.getAllWaitingPatients().ToList();

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Patient p = appointments.seeDoctor();
            waitingListBox.DataSource = appointments.getAllWaitingPatients().ToList();
            doctorViewBox.Items.Add(p);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllForms allForm = new AllForms();
            allForm.Show();
        }
    }
}
