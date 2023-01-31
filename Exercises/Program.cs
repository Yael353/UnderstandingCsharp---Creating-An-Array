namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercise 1:
            //Create an array that holds 10 zip cods
            //promt user to enter zip code to see if the
            //company deliver to that zip code or not


            //int[] deliverCode = new int[10] { 123, 321, 654, 987, 966, 963, 852, 741, 456, 123 };

            //Console.WriteLine("Enter the zip code for your area, 3 digits");
            //int userZip = int.Parse(Console.ReadLine());

            //for (int i = 0; i < deliverCode.Length; i++)
            //{
            //    if (userZip == deliverCode[i])
            //    {
            //        Console.WriteLine($"Good news, we deliver to {userZip}!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Sorry, we do not deliver to {userZip} at the moment.");
            //        break;
            //    }
            //}

            ////Another solution:
            //string[] zipCodes = new string[10] { "78965", "12365", "78952", "45612", "74125", "88524", "99562", "44147", "99854", "33254" };

            //Console.WriteLine("Enter zip code, 5 digits");
            //string code = Console.ReadLine();
            //bool found = false;

            //for (int i = 0; i < zipCodes.Length; i++)
            //{
            //    if (code == zipCodes[i])
            //    {
            //        found = true;
            //        break;
            //    }

            //}
            //if (found == true)
            //{
            //    Console.WriteLine("We make deliveries to the given {0}", code);

            //}
            //else
            //{
            //    Console.WriteLine($"At the moment we unfortunately do not make deliveries to the following area {code}");

            //}


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
                Console.WriteLine($"Enter student #{i+1} name", amountOfStudents);
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
            

            Console.WriteLine("Average Score is {0} and {1} got the highest score with {2}",averageGrade, highestGradeName, highestGrade);

        }
    }
}