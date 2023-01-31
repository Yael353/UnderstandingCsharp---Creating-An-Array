namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 2:
            //Write a program that allows the teacher to write in an amount of students.
            //for each student ask for name and final score.
            //when done print out the highest and the average score for the class.

            Console.WriteLine("How many students are there in the class?");
            int amountOfStudents = int.Parse(Console.ReadLine());

            double averageGrade;
            double highestGrade = int.MinValue;
            string highestGradeName = string.Empty;

            string[] arrayOfStudents = new string[amountOfStudents];
            double[] scoreOfStudents = new double[amountOfStudents];


            for (int i = 0; i < amountOfStudents; i++)
            {
                Console.WriteLine($"Enter student #{i + 1} name", amountOfStudents);
                arrayOfStudents[i] = Console.ReadLine();
                Console.WriteLine($"Enter student #{i + 1} grade", amountOfStudents);
                scoreOfStudents[i] = double.Parse(Console.ReadLine());

                if (scoreOfStudents[i] > highestGrade)
                {
                    highestGradeName = arrayOfStudents[i];
                }
            }

            averageGrade = scoreOfStudents.Sum() / amountOfStudents;
            highestGrade = scoreOfStudents.Max();


            Console.WriteLine("Average Score is {0} and {1} got the highest score with {2}", averageGrade, highestGradeName, highestGrade);

        }
    }
    
}