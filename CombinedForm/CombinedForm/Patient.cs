using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinedForm
{

    //class for Queue
    internal class Patient
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }


        public Patient(string name, string address, string gender )
        {
            this.Name = name;
            this.Address = address;
            this.Gender = gender;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
