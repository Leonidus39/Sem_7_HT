//Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//1,7->такого элемента в массиве нет

Console.WriteLine("Введите координату строки ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату столбца ");
int column = Convert.ToInt32(Console.ReadLine());
int [,] Matrix(int rows, int columns)
        {
            int[,] arr = new int[rows, columns];
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(1, 10);
                }
            } return arr;
           
        }

        void PrintMatrix (int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.Write("[");
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                   if(j<mat.GetLength(1)-1) Console.Write(mat[i, j]+",");
                   else Console.Write(mat[i, j]+"]");
            
                }Console.WriteLine();
            }
        }
        void Chek(int[,] mat, int rows, int columns)
{   PrintMatrix(mat);
    Console.WriteLine();
    if (rows < mat.GetLength(0) && columns < mat.GetLength(1) && rows >= 0 && columns >= 0) 
        Console.WriteLine($"{rows},{columns} -> {mat[rows, columns]}");
    else Console.WriteLine($"{rows},{columns} -> такого элемента в массиве нет");
    }

      Chek(Matrix(3, 4), row, column) ;