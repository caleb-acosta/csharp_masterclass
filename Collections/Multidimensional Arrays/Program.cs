namespace Multidimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2D Array
            int[,] array2D = new int[,]
            {
                {11, 12, 13 },
                {21, 22, 23 },
                {31, 32, 33 }
            };

            // Value access
            Console.WriteLine(array2D[1, 2]);


            // 3-D Array
            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001", "002" },
                    {"010", "011", "012" },
                    {"020", "021", "022" }
                },
                {
                    {"100", "101", "102" },
                    {"110", "111", "112" },
                    {"120", "121", "122" }
                },
                {
                    {"200", "201", "202" },
                    {"210", "211", "212" },
                    {"220", "221", "222" }
                },
                {
                    {"Hi", "I", "am" },
                    {"also", "part", "of" },
                    {"the", "3-dimensional", "array" }
                }

            };

            // Value access "201"
            Console.WriteLine(array3D[2, 0, 1]);


            // Get number of dimensions

            int amountDimensions = array3D.Rank;
            Console.WriteLine("The Dimension is {0}", amountDimensions);

            // Shorthand
            string[,] arr2D = { { "00", "01" } };

            Console.WriteLine(arr2D[0, 0]);
        }
    }
}