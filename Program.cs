using StudentResultCalculator.Models;
using StudentResultCalculator.Services;

namespace StudentResultCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            int[] marks = new int[5];

            Console.WriteLine("\nEnter Marks for 5 Subjects:");

            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            Student student = new Student
            {
                Name = name,
                Marks = marks
            };

            ResultService resultService = new ResultService();

            int total = resultService.CalculateTotal(student.Marks);
            double average = resultService.CalculateAverage(student.Marks);
            string grade = resultService.GetGrade(average);

            Console.WriteLine("\n===== RESULT =====");
            Console.WriteLine($"Student Name : {student.Name}");
            Console.WriteLine($"Total Marks  : {total}");
            Console.WriteLine($"Average      : {average:F2}");
            Console.WriteLine($"Grade        : {grade}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
