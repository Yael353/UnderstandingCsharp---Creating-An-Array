namespace MultiDimensionalArrays
{
    internal class Program
    {
        //Lecture 36. Multidimensional Arrays.
        static void Main(string[] args)
        {
            //recanuglar array 
            int[,] myArray = new int[3, 4];
            myArray[0, 0] = 5;
            myArray[0, 1] = 6;
            myArray[0, 2] = 7;
            myArray[0, 3] = 8;

            myArray[1, 0] = 5;
            myArray[1, 1] = 6;
            myArray[1, 2] = 7;
            myArray[1, 3] = 8;

            myArray[2, 0] = 5;
            myArray[2, 1] = 6;
            myArray[2, 2] = 7;
            myArray[2, 3] = 8;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myArray[i, j]);
                }
                Console.WriteLine();
            }

            //Short way
            //int[,] myArrayShort = { {5,6,7,8},
            //                        {5,6,7,8},
            //                        {5,6,7,8};

            //Jagged Array
            int[][] myArray2 = new int[3][];
            myArray2[0] = new int[4] {5,6,7,8};
            myArray2[1] = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 70 };
            myArray2[2] = new int[2] {1,2};

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < myArray2[i].Length; j++)
                {
                    Console.Write(myArray2[i][j]);
                }
                Console.WriteLine();
            }
  
        }
    }
}