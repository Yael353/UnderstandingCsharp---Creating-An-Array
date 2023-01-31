namespace LoopsWithArrays
{
    internal class Program
    {
        //lecture 33, loops with arrays
        static void Main(string[] args)
        {
            int[] grades = { 66, 88, 95, 90, 100, 87 };
            grades[0] += 3;
            grades[1] += 3;
            grades[2] += 3;
            grades[3] += 3;
            grades[4] += 3;
            grades[5] += 3;

            //for loop more powerful
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] += 3;
                Console.WriteLine(grades[i]);
            }

            Console.WriteLine("-------------------------------------------");

            //for loop backwards
            for (int i = grades.Length -1; i >= 0; i--)
            {
                Console.WriteLine(grades[i]);
            }

            Console.WriteLine("-------------------------------------------");

            //Good for displaying value accessing values
            foreach (var item in grades)
            {
                
                Console.WriteLine(item);
            }

            
        }
    }
}