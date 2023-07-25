// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
// элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void AverageOfEveryColumn(int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    double average = 0;
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (j < array.GetLength(1) - 1)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum = (sum + array[i, j]);
            }
            average = Math.Round((sum / array.GetLength(1)), 1);
            Console.Write($"{average}; ");
            sum = 0;
        }
        else if (j == array.GetLength(1) - 1)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum = (sum + array[i, j]);
            }
            average = Math.Round((sum / array.GetLength(1)), 1);
            Console.Write($"{average}.");
        }
    }
}

void PrintTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] GenerateTwoDimensionalArray(int row, int column, int min, int max)
{
    int[,] workingArray = new int[row, column];
    for (int i = 0; i < workingArray.GetLength(0); i++)
    {
        for (int j = 0; j < workingArray.GetLength(1); j++)
        {
            workingArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return workingArray;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int row = GetInput("Введите количество строк массива: ");
int column = GetInput("Введите количество столбцов массива: ");
int min = GetInput("Введите минимальное значение для чисел массива: ");
int max = GetInput("Введите максимальное значение для чисел массива: ");
int[,] array = GenerateTwoDimensionalArray(row, column, min, max);
PrintTwoDimensionalArray(array);
AverageOfEveryColumn(array);