using System;


namespace module1
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix myMatrix = new Matrix(3, 3);
            myMatrix.FillMatrixRandom(3, 3, 1, 100);
            Console.WriteLine("Matrix:");
            myMatrix.PrintMatrix();
            Console.ReadKey();
        }
    }
    class Matrix
    {
        private int[][] matrix;

        public Matrix(int rows, int columns)
        {
            matrix = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[columns];
            }
        }
        public void FillMatrixRandom(int rows, int columns, int min, int max)
        {
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i][j] = rand.Next(min, max + 1);
                }
            }
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}