// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void IfElementExists(int[,] array, int x, int y)
{
       for (int i = 0; i < array.GetLength(0);)
    {
        if (i == x - 1)//это для пользователей, которые считают с 1, а не с 0
        {
            for (int j = 0; j < array.GetLength(1);)
            {
                if (j == y - 1)
                {
                    Console.WriteLine($"Находящийся на позиции ({x},{y}) элемент: {array[i, j]}");
                    break;
                }
                else j++;
                Console.WriteLine($"Позиции ({x},{y}) в массиве нет.");
                break;
            }
            break;
        }
        else i++;
        Console.WriteLine($"Позиции ({x},{y}) в массиве нет.");
        break;
    }
    }

void PrintTwoDimensionalArray(int[,] array)
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
int x = GetInput("Введите номер строки массива: ");
int y = GetInput("Введите номер столбца массива: ");
Console.WriteLine("Ищу элемент...");
IfElementExists(array, x, y);