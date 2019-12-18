using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix =
            {
                new int[] {1, 2, 3}, //0 row
                new int[] {4, 5, 6}, //1 row
                new int[] {7, 8, 9}, //2 row

            };
            
            Console.WriteLine(matrix[1][1]);
            
            //main diagonaal 1, 5,9
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(matrix[i][i]);
            }
            
            //secondary diagonal 3,5,7
            for (int i = 0; i < matrix.Length; i++)
            {
                var index = matrix.Length - 1 -i;
                Console.WriteLine(matrix[i][index]);
            }

            Console.WriteLine("---");
            // diagonaal 7,5,3 
            for (int i = matrix.Length; i > 0; i--)
            {
                var index = matrix.Length-i;
                Console.WriteLine(matrix[i-1][index]);
            }
            
            //7,5,3 variant 2
            for (int i = 0; i < matrix.Length; i++)
            {
                
                Console.WriteLine(matrix[matrix.Length-1-i][i]);
            }
            
            // diagonaal 9,5,1
            
            for (int i = matrix.Length; i > 0; i--)
            {
                var index = i-1;
                Console.WriteLine(matrix[i-1][index]);
            }
            
            Console.WriteLine("---");
            // ülevalt alla 1,4,7
            for (int i = 0; i < matrix.Length; i++)
            {
                
                Console.WriteLine(matrix[i][0]);
            }
            
            // vasakult paremale 
            for (int i = 0; i < matrix.Length; i++)
            {
                
                Console.WriteLine(matrix[1][i]);
            }
            
            Console.ReadKey();
        }
    }
}