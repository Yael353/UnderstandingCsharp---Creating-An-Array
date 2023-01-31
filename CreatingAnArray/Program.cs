namespace CreatingAnArray
{
    internal class Program
    {
        //Lecture 32 creating an Array
        static void Main(string[] args)
        {
            int[] myArray = new int[3];
            myArray[0] = 5; //Element: separate item in the array. index: the number of which we access the element.
            myArray[1] = 7;
            myArray[2] = 10;

            Console.WriteLine(myArray[0]);
            int[] myArray2 = new int[3] { 5, 7, 5};

            int[] myArray3 = new int[] { 5, 7, 5};

            int[] myArray4 = {5, 7, 5}; //Shortest way, works in some examples

        }
    }
}