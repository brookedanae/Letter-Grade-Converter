using System;

namespace Letter_Grade_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter!" + "\n");

            string answer;
            do
            {
                Console.Write("Enter a numerical grade: ");
                var grade = int.Parse(Console.ReadLine());
                Console.WriteLine(LetterGrade(grade));

                Console.Write("Continue? (y/n): ");
                answer = Console.ReadLine();
            } while (answer == "y" || answer == "Y");

            Console.WriteLine("Goodbye!");
        }

        
        public static string LetterGrade(int grade)
        {
            string end = "";
            if (grade >= 88 && grade <= 100)
            {
                Console.WriteLine("Letter Grade: A");
            }
            else if (grade >= 80 && grade <= 87)
            {
                end = "Letter Grade: B";
            }
            else if (grade >= 67 && grade <= 79)
            {
                end = "Letter Grade: C";
            }
            else if (grade >= 60 && grade <= 66)
            {
                end = "Letter Grade: D";
            }
            else if (grade < 60)
            {
                end = "Letter Grade: F";
            }
            return end;
        }

        
    }

}

