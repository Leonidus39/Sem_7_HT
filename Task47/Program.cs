/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
 */

 double [,] MatrixArray (int rows, int columns, Double min, Double max)
 {
    double [,] mat = new double [rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat [i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
        }
    }
    return mat;
 }

 void ShowMatrix (double [,] matrix)
 {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j< matrix.GetLength(1)-1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write($"{matrix[i, j]}");
        }
         Console.WriteLine("]");
    }
 }

 ShowMatrix(MatrixArray(3, 4, 10, 20));