using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student()
            {
                Id = 4,
                Name = "ABC"

            };

            DataClasses1DataContext cdc = new DataClasses1DataContext();
            cdc.Students.InsertOnSubmit(s1);
            cdc.SubmitChanges();

            var q = cdc.GetTable<Student>().Where(i => i.Id == 4).Select(i=>i);

            foreach(var a in q)
            {
                Console.WriteLine(a.Name);

            }
            Console.ReadLine();
        }
    }
}
