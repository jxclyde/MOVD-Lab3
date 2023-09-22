using System;

namespace MOVD_Lab2
{
    internal class Program
    {
        public const int multiplier = 2;
       
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;


            // Задана матриця (Варіант №6)
            int[,] matrixA = new int[5,5] { 
                { 1, 19, 19, 12, 15 },
                { -1, -10, -8, -16, -14 },
                { 3, -3, 3, 1, 3 },
                { 9, 1, 4, -20, -18 },
                { 16, -18, 11, -7, 15 },
            };

            //Перший рівень : 
            // 1) Множення матриці на число
            //MultiplyMatrixByNumber(matrixA);

            // 2) Додавання матриць
            //MatricesAddition(matrixA);

            // 3) Різниця матриць
            //MatricesSubtraction(matrixA);

            // 4) Добуток матриць 
            //MatrixMultiplication(matrixA);

            // 5) Транспонування матриці
            TransposeMatrix(matrixA);
        }

        static void MultiplyMatrixByNumber(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            int[,] resultMatrix = new int[rows, col];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    resultMatrix[i, j] = matrix[i, j] * multiplier;
                }
            }

            Console.WriteLine($"Resulting matrix after multiplying by a number (multiplier={multiplier}):");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void MatricesAddition(int[,] matrix)
        {
            int rows = 5;
            int col = 5;
            Random randomMatrixElemenents = new Random();
            int[,] newMatrix = new int[rows, col];

            // Заповнуюємо матрицю рандомними числами (randomMatrixElemenents < 20)
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    int randomNumber = randomMatrixElemenents.Next(20);
                    newMatrix[i, j] = randomNumber;
                }
            }

            // Виводимо матрицю на екран
            Console.WriteLine("Matrix we will use for Addition operation : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(newMatrix[i, j] + " ");
                }
                Console.WriteLine(); 
            }

            int[,] resultMatrix = new int[rows, col];

            // Додаємо дві матриці
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    resultMatrix[i, j] = matrix[i, j] + newMatrix[i, j];
                }
            }

            // Виводимо результат на екран
            Console.WriteLine("Resulting matrix after addition operation : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        static void MatricesSubtraction(int[,] matrix)
        {
            int rows = 5;
            int col = 5;
            Random randomMatrixElemenents = new Random();
            int[,] newMatrix = new int[rows, col];

            // Заповнуюємо матрицю рандомними числами (randomMatrixElemenents < 20)
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    int randomNumber = randomMatrixElemenents.Next(20);
                    newMatrix[i, j] = randomNumber;
                }
            }

            // Виводимо матрицю на екран
            Console.WriteLine("Matrix we will use for Subtraction operation : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(newMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] resultMatrix = new int[rows, col];

            // Віднімаємо дві матриці
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    resultMatrix[i, j] = matrix[i, j] - newMatrix[i, j];
                }
            }

            // Виводимо результат на екран
            Console.WriteLine("Resulting matrix after subtraction operation : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        static void MatrixMultiplication(int[,] matrix)
        {
            int rows = 5;
            int col = 5;
            Random randomMatrixElemenents = new Random();
            int[,] newMatrix = new int[rows, col];

            // Заповнуюємо матрицю рандомними числами (randomMatrixElemenents < 20)
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    int randomNumber = randomMatrixElemenents.Next(20);
                    newMatrix[i, j] = randomNumber;
                }
            }

            // Виводимо матрицю на екран
            Console.WriteLine("Matrix we will use for Multiplication operation : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(newMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] resultMatrix = new int[rows, col];

            // Додаємо дві матриці
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < rows; k++)
                    {
                        sum += matrix[i, k] * newMatrix[k, j];
                    }
                    resultMatrix[i, j] = sum;
                }
            }

            // Виводимо результат на екран
            Console.WriteLine("Resulting matrix after subtraction operation : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        static void TransposeMatrix(int[,] matrix)
        {
            int rows = 5;
            int col = 5;
            int[,] resultMatrix = new int[5, 5];

            // Транспонуємо матрицю
            for (int i = 0; i < rows; i++)
            {
                for (int j = i; j < col; j++)
                {
                    resultMatrix[i, j] = matrix[j, i];
                    resultMatrix[j, i] = matrix[i, j];
                }
            }

            // Виводимо результат на екран
            Console.WriteLine("Resulting matrix after transpose operation : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(resultMatrix[i, j] + "  ");
                }
                Console.WriteLine();
            }

        }


    }
}