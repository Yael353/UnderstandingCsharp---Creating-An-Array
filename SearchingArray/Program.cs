namespace SearchingArray
{
    internal class Program
    {
        // Lecture 34. Searching an away using loops
        static void Main(string[] args)
        {
            string[] students = new string[] { "Bob", "Ted", "Tom", "Fred" };
            int[] grades = new int[] { 77, 50, 78, 99 }; //Parallel array for each persons grades.
                                                         //Holds the same amount of elements with a different value
                                                         //Could also include age and so on.

            //Searching name in the array
            Console.WriteLine("Enter students name to search for");
            string studentName = Console.ReadLine();

            bool contains = false; // False because we don't know if the students name exists or not. 
            int studentsGrade = 0;

            for (int i = 0; i < students.Length; i++)
            {
                if (studentName == students[i])
                {
                    contains = true;
                    studentsGrade = grades[i];
                    break;
                }
            }

            if (contains == true) // A new if statement so that the loop does not check all the names.
            {
                Console.WriteLine("The student is in the class.");
                Console.WriteLine($"The students grade is {studentsGrade}");
            }
            else
                Console.WriteLine("The student is not in the class.");

            int[] myArray2 = new int[] { 10, 5, 7, 2, 55 };

        }
    }
}