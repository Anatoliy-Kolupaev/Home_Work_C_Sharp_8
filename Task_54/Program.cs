// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] Array (int row, int column)
{
    int [,] result = new int [row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result [i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}
void FormattingArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(1) -1; n++)
            {
                if (array[i, n] < array[i, n + 1])
                {
                    int cheng = array[i, n + 1];
                    array [i, n + 1] = array [i, n];
                    array [i, n] = cheng;
                }
            }
        }
    }
}

void PrintArray (int [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задайте массив, введите 2 числа: 1е кол-во строк, 2е кол-во столбцов: ");
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());
Console.WriteLine();
int [,] array = Array (row, column);
PrintArray (array);
Console.WriteLine("Упорядоченный массив");
FormattingArray (array);
PrintArray (array);

