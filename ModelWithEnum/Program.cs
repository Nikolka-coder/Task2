using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelWithEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> {
             new Student { Faculty = FacultyEnum.Eng , Marks = MarksEnum.Bad},
             new Student { Faculty = FacultyEnum.Math , Marks = MarksEnum.Good},
             new Student { Faculty = FacultyEnum.Eco , Marks = MarksEnum.Midle},
             new Student { Faculty = FacultyEnum.Eng , Marks = MarksEnum.Good},
             new Student { Faculty = FacultyEnum.Eco , Marks = MarksEnum.Good},
             new Student { Faculty = FacultyEnum.Eco , Marks = MarksEnum.Midle},
             new Student { Faculty = FacultyEnum.Eng , Marks = MarksEnum.Midle},
            };
            var studentGroup = students.GroupBy(s => s.Marks)
                .Select(g => new
                {
                    Faculty = g.Key,
                    Count = g.Count(),
                    Students = g.Select(s => s)
                });
            foreach (var group in studentGroup)
            {
                Console.WriteLine($"{group.Faculty} : {group.Count}");
                foreach (Student s in group.Students)
                    Console.WriteLine(s.Faculty);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
