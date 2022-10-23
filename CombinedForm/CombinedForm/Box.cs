using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinedForm
{
    //class for Stack
    internal class Box
    {
        public int ID { get; set; }
        public string SearialNo { get; set; }
        public Box(int iD, string searialNo)
        {
            ID = iD;
            SearialNo = searialNo;
        }
        public override string ToString()
        {
            return ID+ " "+ SearialNo;
        }
    }
}
