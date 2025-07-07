// See https://aka.ms/new-console-template for more information
using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // starting project from satr website course C# 101
            Console.WriteLine("how much student?: ");
            int studentCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Enter student name: ");
                string studentName = Console.ReadLine();
                Console.WriteLine("Enter student grade: ");
                int studentGrade = int.Parse(Console.ReadLine());

                studentInfo(studentName, studentGrade);
                PassOrFailed(studentGrade);
            }
        }
        static void studentInfo(string studenteName, int studentGrade)
            {
                Console.WriteLine("Hello " + studenteName + " your grade are " + studentGrade);
            }
        static void PassOrFailed(int studentGrade)
            {
                if (studentGrade >= 60)
                {
                    Console.WriteLine("You passed the course!");
                }
                else
                {
                    Console.WriteLine("You failed the course.");
            }
        }
        
    }
}