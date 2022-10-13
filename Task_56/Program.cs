// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArray(int row, int column)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int [] SumString(int [,] array, int row, int column)
{
    int[] newArrray = new int[row];
    for (int i = 0; i < row; i++)
    {
        int sum = 0;
        for (int j = 0; j < column; j++)
        {
            sum = sum + array[i, j];
            newArrray[i] = sum;
        }
    }
    return newArrray;
}
int IndexMinStrung(int[] newArray)
{
    int min = newArray[0];
    int k = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (min > newArray[i])
        {
            min = newArray[i];
            k = i + 1;
        }
    }
    return k;
}
void PrintSumString (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine( array [i] + "\t");
    }
}
Console.WriteLine("Задайте массив, введите 2 числа: 1е кол-во строк, 2е кол-во столбцов: ");
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = CreateArray(row, column);
PrintArray(array);
System.Console.WriteLine("Сумма сторк:");
int [] newArray = SumString(array, row, column);
PrintSumString (newArray);
int stringNumber = IndexMinStrung(newArray);
Console.Write($"Наименьшая сумма элементов в:  {stringNumber} стоке. ");
