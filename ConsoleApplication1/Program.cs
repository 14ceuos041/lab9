using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Database1Entities de = new Database1Entities();
            Student s1 = new Student()
            {
                Id = 1,
                Name = "Biren"
            };
            de.Students.Add(s1);
            de.SaveChanges();


            IQueryable<Student> query = from c in de.Students
                        select c;

            foreach(var a in query){
                Console.WriteLine(a.Name);

            }
            Console.ReadLine();

            de.Students.Remove(s1);
            de.SaveChanges();

            foreach (var a in query)
            {
                Console.WriteLine(a.Name);

            }

        }
    }
}
