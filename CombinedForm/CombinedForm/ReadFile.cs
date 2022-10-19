using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinedForm
{
    internal class ReadFile
    {
        static public List<Student> Students = new List<Student>();
        public List<Student> readStudents()
        {
            StreamReader reader = new StreamReader("Data.txt");
            string line = "";
            while((line=reader.ReadLine()) != null)
            {
                string[]words = line.Split(',');
                Student st = new Student();
                st.Id = int.Parse(words[0]);
                st.Name=words[1];
                st.Address=words[2];
                st.Gender = words[3];
                st.Course = words[4];
                st.Quarter=words[5];
            }
            return Students;
        }
    }
}
