using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMemberExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stulist  = new List<Student>();
            for (int i = 0; i < 100; i++)
            {
                Student stu = new Student();
                stu.Age = 24;
                stu.Score = i;

                stulist.Add(stu);

            }
            int totalAge=0;
            int totalScore=0;
            foreach (var stu in stulist)
            {
                totalAge += stu.Age;
                totalScore += stu.Score;
            }
            Student.AverageAge = totalAge / 100;
            Student.AverareScore = totalScore / 100;
            Student.ReportAverageAge();
            Student.ReporAverareScore();

            Student.reportAmount();
            Console.ReadLine();
            
        }
    }
    class Student
    {
        public int  Age;
        public int  Score;

        public static int amount;
        public static int AverageAge;
        public static int AverareScore;

        public Student()
        {
            Student.amount++;

        }
        public static void reportAmount()
        {
            Console.WriteLine(Student .amount);
            
        }
        public static void ReportAverageAge()
        {
            Console.WriteLine(AverageAge);
        
        }
        public static void ReporAverareScore()
        {
            Console.WriteLine(AverareScore);
         
        }
    }
}
