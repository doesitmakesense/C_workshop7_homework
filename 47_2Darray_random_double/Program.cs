// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintTwoDimensionalArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t", -3);
        }
        Console.WriteLine();
    }
}

double[,] GenerateTwoDimensionalArray(int m, int n, int min, int max)
{
    double[,] workingArray = new double[m, n];
    for (int i = 0; i < workingArray.GetLength(0); i++)
    {
        for (int j = 0; j < workingArray.GetLength(1); j++)
        {
            workingArray[i, j] = Math.Round((new Random().Next(min, max) + new Random().NextDouble()), 1);
        }
    }
    return workingArray;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
int min = GetInput("Введите минимальное значение для чисел массива: ");
int max = GetInput("Введите максимальное значение для чисел массива: ");
double[,] array = GenerateTwoDimensionalArray(m, n, min, max);
PrintTwoDimensionalArray(array);