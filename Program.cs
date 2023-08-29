using LibMenu;
using System;

namespace Con10
{
    internal class Program
    {
        public interface IVietnameRule
        {
            void HavetoPayTax();
            void HavetoFollowLaw();
        }


        public interface IPerson
        {
            string Name { get; set; }
            int Age { get; set; }
            void Introduce();
            void Work(); 
            void Relax(); 
        }


        internal abstract class Person : IPerson , IVietnameRule
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void Introduce()
            {
                Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
            }

            public virtual void Relax()
            {
                Console.WriteLine($"{Name} is relaxing.");
            }

            public abstract void Work(); 
            public abstract void HavetoPayTax();
            public abstract void HavetoFollowLaw();
        }





        static void Main(string[] args)
        {
            string[] mainMenuItems = { "Search Student", "Add Student", "List Student", "Exit" };
            Menu mainMenu = new Menu(mainMenuItems);
            int choice = mainMenu.Display();

            //Console.WriteLine($"You just selected : {c.ToString()}");

            var students = new List<Student>();
            do
            {
                switch (choice)
                {
                    case 1:
                        SearchStudent(students);
                        break;
                    case 2:
                        AddStudent(students);                     
                        break;
                    case 3:
                        ListStudents(students);
                        break;
                    case 4:
                        //"Exit" 
                        break;
                    default:
                        break;
                }

                choice = mainMenu.Display();

            } while (choice != mainMenuItems.Length);



            // string[] mainMenuItems = { "Search Student", "Add Student", "List Student", "Exit" };
            //AdvanceMenu mainMenu = new AdvanceMenu(mainMenuItems,new ConsoleUserInterface(),1);
            //int c = mainMenu.Display();
            //Console.WriteLine($"You just selected : {c.ToString()}");


        }


        private static void AddStudent(List<Student> students)
        {
            Console.WriteLine("Enter student's name:");
            string name = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter student's age:");
            string age = Console.ReadLine() ?? string.Empty;

            var student = new Student(name, Convert.ToInt32(age));
            students.Add(student);

            Console.WriteLine("Student added successfully");
           
        }

        private static void ListStudents(List<Student> students)
        {
            Console.WriteLine("List of Students:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {students[i].Name}, Age: {students[i].Age}");
            }
        }

        private static void SearchStudent(List<Student> students)
        {
            Console.WriteLine("keyword:");
            string keyword = Console.ReadLine()?.ToLower() ?? string.Empty;


            //var m1 = students
            //    .Where(s => s.Name.ToLower().Contains(keyword))
            //    .ToList();



            var mat = students
                .Where(s => s.Name.ToLower().Contains(keyword))
                .ToList();

           

            Console.WriteLine("Matching Students:");
            for (int i = 0; i < mat.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {mat[i].Name}, Age: {mat[i].Age}");
            }

        }



    }
}