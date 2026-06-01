using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LINQ
{
    public class StudentClass
    {
        // Grade Level is common for every Student
       protected enum gradeLevel { FirstYear = 1, SecondYear = 2, ThirdYear = 3, ForuthYear = 4 }; // Protected that can be used within class and within child class
        //1- mean by default value of every student is one 
        // Whenever we want to bound user then we use enum
       protected class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int ID { get; set; }
            public gradeLevel Year;
            public List<int> ExamScores;

        }
        protected static List<Student> students = new List<Student>
        {
            new Student {FirstName = "Abdul", LastName = "Rehman", ID = 009, Year = gradeLevel.ThirdYear, ExamScores = new List<int>{5, 70, 66, 45}},
            new Student {FirstName = "Haroon", LastName = "Ijaz", ID = 003, Year = gradeLevel.ThirdYear, ExamScores = new List<int>{95, 75, 63, 49}},
            new Student {FirstName = "Obaid", LastName = "Ullah", ID = 054, Year = gradeLevel.ThirdYear, ExamScores = new List<int>{88, 89, 90, 91}},
            new Student {FirstName = "Zeeshan", LastName = "Afzal", ID = 040, Year = gradeLevel.ThirdYear, ExamScores = new List<int>{55, 65, 34, 43}},
            new Student {FirstName = "Ahmed", LastName = "Hassan", ID = 013, Year = gradeLevel.ThirdYear, ExamScores = new List<int>{12, 33, 44, 77}}
           
        };

        protected static int GetPercentile(Student s)
        {
            double avg = s.ExamScores.Average();
            return avg > 0 ? (int)avg/10: 0; // If student pass then lie in percentile and if fails 2nd condition 0
        }
        public void QueryHighScores(int exam, int score)
        {
            var highScore = from student in students
                            where student.ExamScores[exam] < score
                            select new
                            {
                                Name = student.FirstName,
                                Score = student.ExamScores[exam]
                            };
            foreach (var hs in highScore)
            {
                Console.WriteLine("{0,-15}{1}", hs.Name, hs.Score);

            }
        }
    internal class Program
    {
            static void Main(string[] args)
            {
                StudentClass student = new StudentClass();
                //student.QueryHighScores(1, 88);  // go to one(2nd Column) and check which one has 88 higher
                student.QueryHighScores(0, 60);
                Console.ReadKey();
            }

        }
    }
}
