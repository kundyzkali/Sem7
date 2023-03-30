// Задайте двумерный массив размером mxn, заполненный случайными числами.
// m=3, n = 4.




int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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

int[,] array2d = CreateMatrixRndInt(4, 5, -100, 100);
PrintMatrix(array2d);

