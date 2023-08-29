using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Con10.Program;
using System.Xml.Linq;

namespace Con10
{
    internal class Teacher : Person
    { 
        public Teacher(string name, int age) : base(name, age) { }

        public override void HavetoFollowLaw()
        {
            
        }

        public override void HavetoPayTax()
        {
            
        }

        public override void Work()
        {
            Teach();
        }

        private void Teach()
        {
             Console.WriteLine($"{Name} is teaching.");
        }

       



    }
}
