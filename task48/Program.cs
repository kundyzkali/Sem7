﻿//Задача 48.

int[,] CreateMatrixSumIndexes(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        {
            for (int j = 0; j < matrix.GetLength(1); j++)

            {
                Console.Write($"{matrix[i, j], 4}");
            }
            Console.WriteLine();
        }
    }
}

int[,] array2d = CreateMatrixSumIndexes(3, 4);
PrintMatrix(array2d);