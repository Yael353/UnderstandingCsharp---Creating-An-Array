namespace ArrayMethods
{
    internal class Program
    {
        //Lecture 35. Built in functions for arrays. Binary search
        static void Main(string[] args)
        {
            //BiniarySearch
            int[] myArray = { 10, 15, 20, 30, 35, 40, 45 }; // Must be in order for a binary search.
                                                            // Checks from midpoint
                                                            // sequential searches from beginning to the end

            Console.WriteLine("Enter a number to check if it exists");
            int number = int.Parse(Console.ReadLine());


            int answer = Array.BinarySearch(myArray, number);

            if (answer > 0)
            {
                Console.WriteLine("The number does not exist");
            }
            else
            {
                Console.WriteLine($"the numbers position in the array is {answer}.");
            }

            // Sorting the elements within the array
            int[] myArray2 = { 10, 5, 7, 2, 55 };
            Array.Sort(myArray2);

            for (int i = 0; i < myArray2.Length; i++)
            {
                Console.WriteLine(myArray2[i]);
            }

            //Reversing the elements within the array
            int[] myArray3 = { 10, 5, 89, 56, 32, 45, 87, 12 };
            Array.Reverse(myArray3);
            

            for (int i = 0; i < myArray3.Length; i++)
            {
                Console.WriteLine(myArray3[i]);
            }


        }
    }
}