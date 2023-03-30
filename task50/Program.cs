﻿
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

int rowValue = Prompt($"Введите номер строки  ");
int colValue = Prompt($"Введите номер колонки : ");

int[,] array = CreateMatrixRndInt();

Console.WriteLine("В массиве: ");

PrintMatrix(array);

Console.WriteLine(FindValueInMatrix(array, rowValue, colValue) 
    ? $"По координатам [{rowValue}, {colValue}] -> обноружено значение {GetValueFromMatrix(array, rowValue, colValue)}"
    : $"По координатам [{rowValue}, {colValue}] -> значение не обнаружено");

int GetValueFromMatrix(int[,] matrix, int row, int column)
{
    return matrix[row - 1, column - 1];
}

bool FindValueInMatrix(int[,] matrix, int row, int column)
{
    return (row - 1) < matrix.GetLength(0) && (column - 1) < matrix.GetLength(1) ? true : false;
}

int[,] CreateMatrixRndInt()
{
    Random rnd = new Random();
    int row = rnd.Next(1, 10);
    int column = rnd.Next(1, 10);

    int[,] arr = new int[row, column];
    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = rnd.Next(1, 10);
        }
    }

    return arr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine();
    }
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}