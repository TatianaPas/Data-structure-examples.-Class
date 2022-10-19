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
    public partial class HashForm : Form
    {
        Dictionary<int,Room> rooms = new Dictionary<int,Room>();
        public HashForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllForms forms = new AllForms();
            forms.Show();

        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            Room room1 = new Room()
            {
                Number = 101,
                Name = "Room Uno",
                Floor = "First",
                Size = "Family",
                View = "Garden"
            };
            Room room2 = new Room()
            {
                Number = 102,
                Name = "Room Duo",
                Floor = "First",
                Size = "Single",
                View = "Sea View"
            };
            Room room3 = new Room()
            {
                Number = 201,
                Name = "Room Lovebird",
                Floor = "Second",
                Size = "Dobule",
                View = "Patio"
            };
            Room room4 = new Room()
            {
                Number = 301,
                Name = "Room Three",
                Floor = "Third",
                Size = "Studio",
                View = "Garden"
            };
            rooms.Add(room1.Number, room1);
            rooms.Add(room2.Number, room2);
            rooms.Add(room3.Number, room3); 
            rooms.Add(room4.Number, room4);
            roomListBox.DataSource = rooms.ToList();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            int value = int.Parse(searchTextBox.Text);
            if (rooms.ContainsKey(value))
            {
                roomListBox.DataSource = rooms.Where(r=>r.Key==value).ToList();
            }
            else
            {
                MessageBox.Show("Room not exists");
            }
        }
    }
}
