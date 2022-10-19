namespace CombinedForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int iD = int.Parse(idTextBox.Text);
            string name = firstNametextBox.Text;
            string lastName = lastNametextBox.Text;
            string address = addressTextBox.Text;
            string gender = genderComboBox.SelectedItem.ToString();
            string course = courseTextBox.Text;
            string quarter = quarterTextBox.Text;
            if(lastName!=null)
            {
                name = name + " " + lastName;
            }

            string values = iD + "," + name + "," + address + "," + gender + "," + course + "," + quarter;
            //MessageBox.Show(values);

            string FilePath = "C:\\Data Structures\\wekk11 DS\\CombinedForm\\CombinedForm\\bin\\Debug\\Data.txt";
            //MessageBox.Show(FilePath);

            List<string> lines = File.ReadAllLines(FilePath).ToList();
            lines.Add(values);
            File.WriteAllLines(FilePath, lines);
            //MessageBox.Show("Data inserted");
            idTextBox.Clear();
            firstNametextBox.Clear();
            lastNametextBox.Clear();
            addressTextBox.Clear();
            courseTextBox.Clear();
            quarterTextBox.Clear();


        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewForm form2 = new ViewForm();
            form2.Show();
        }

        private void dataStructureBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllForms datastructure = new AllForms();
            datastructure.Show();
        }
    }
}