using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Con10.Program;

namespace Con10
{
    internal class Student : Person
    {
        public Student(string name, int age) : base(name, age) { }

        public override void HavetoFollowLaw()
        {
           
        }

        public override void HavetoPayTax()
        {
            
        }

        public override void Work()
        {
           
        }
    }
}
