using System;
using MathNet.Numerics.LinearAlgebra;

namespace MOVD_Lab2
{
    internal class Program
    {
        public const int multiplier = 2;
       
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;


            // Задана матриця (Варіант №19)
            int[,] matrixA = new int[5,5] { 
                { -2, -2, 6, -9, 6},
                { 0, 6, 20, -18, 20},
                { -8, 7, -10, -7, -9 },
                { -1, -17, 0, -6, 24},
                { 5, 5, 15, -11, 2},
            };

            //------------------------------------------------------------------------
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
            //TransposeMatrix(matrixA);

            // 6)Операція порівняння матриць
            //bool areEqual = CompareMatrices(matrixA);

            //if (areEqual)
            //{
            //    Console.WriteLine("Matrices are equal because all their corresponding elements are also equal.");
            //}
            //else
            //{
            //    Console.WriteLine("Matrices are not equal !");
            //}

            //TODO
            //7) Реалізувати знаходження визначника матриці 
            //CalculateDeterminant(); 

            //TODO
            //7)Знайти обернену матрицю для невироджених матриць
            //InverseMatrix();
            //------------------------------------------------------------------------
            //Другий рівень : 
            // 1) Розв’язати СЛАР, використовуючи метод Крамера
            double detA = CalculateDeterminant();
            CramerMethod(detA);
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

        static bool CompareMatrices(int[,] mainMatrix)
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
            Console.WriteLine("Matrix we will use for Comprasion operation : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(newMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (mainMatrix[i, j] != newMatrix[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;

        }

        static double CalculateDeterminant()
        {
            var matrix = Matrix<double>.Build.DenseOfArray(new double[,]
            {
                { -2, -2, 6, -9, 6},
                { 0, 6, 20, -18, 20},
                { -8, 7, -10, -7, -9 },
                { -1, -17, 0, -6, 24},
                { 5, 5, 15, -11, 2},
            });

            double determinant = matrix.Determinant();

            Console.WriteLine($"Determinant of the 5x5 matrix: {determinant}");

            return determinant;
        }

        static void InverseMatrix()
        {
            var matrix = Matrix<double>.Build.DenseOfArray(new double[,]
            {
                { -2, -2, 6, -9, 6},
                { 0, 6, 20, -18, 20},
                { -8, 7, -10, -7, -9 },
                { -1, -17, 0, -6, 24},
                { 5, 5, 15, -11, 2},
            });

            double determinant = matrix.Determinant();

            if (determinant != 0)
            {
                Console.WriteLine("Матриця невиродждена");
            }
            else Console.WriteLine("Визначник дорівнює нулю");

            var inverseMatrix = matrix.Inverse();

            // Виводимо результат на екран
            Console.WriteLine("Resulting matrix after inverse operation : ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(inverseMatrix[i, j] + "  ");
                }
                Console.WriteLine();
            }

        }

        //------------------------------------------------------------------------
        //Другий рівень : 
        static void CramerMethod(double detA)
        {
            double[,] a = new double[5, 5];
            double[] b = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter the coefficients of the equation {i + 1}:");
                string[] coefficients = Console.ReadLine().Split(' ');

                for (int j = 0; j < 5; j++)
                {
                    a[i, j] = Convert.ToDouble(coefficients[j]);
                }

                Console.Write("Enter free members : ");
                b[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("\nThe system of equations was successfully entered \n!");

            Matrix<double> matrixA = Matrix<double>.Build.DenseOfArray(a);
            Vector<double> vectorB = Vector<double>.Build.Dense(b);

            if (detA != 0)
            {
                Console.WriteLine($"Matrix A determinant =  {detA}");
            }
            else
            {
                Console.WriteLine("Матриця A вироджена");
            }

            Console.WriteLine("Cramer Method: ");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\nMatrix A{i + 1}");

                Matrix<double> matrixAi = matrixA.Clone();
                matrixAi.SetColumn(i, vectorB);

                double detAi = matrixAi.Determinant();
                double xi = detAi / detA;

                Console.WriteLine($"\nMatrix А determinant{i + 1}: {detAi}");
                Console.WriteLine($"x{i + 1} = {xi}");
            }
        }


        
    }
}