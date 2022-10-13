System.Console.WriteLine("Добрый день!");
int n = 0;
int v = 100;
while (n < v)
{
    Console.Write("Выберите задачу которую хотите проверить 54, 56, 58 или 60:  ");
    int choice = int.Parse(Console.ReadLine());
    while (choice == 54)
    {
        Console.WriteLine();
        Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        Console.WriteLine();
        if (choice == 54) task54();
        if (choice == 54) task54();
        if (choice == 54) task54();
        break;

    }
    while (choice == 56)
    {
        Console.WriteLine();
        Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
        Console.WriteLine();
        if (choice == 56) task56();
        if (choice == 56) task56();
        if (choice == 56) task56();
        break;
    }
    while (choice == 58)
    {
        Console.WriteLine();
        Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
        Console.WriteLine();
        if (choice == 58) task58();
        if (choice == 58) task58();
        if (choice == 58) task58();
        break;
    }
    while (choice == 60)
    {
        Console.WriteLine();
        Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
        Console.WriteLine();
        if (choice == 60) task60();
        if (choice == 60) task60();
        if (choice == 60) task60();
        break;
    }
    n++;
}

void task54()
{
    int[,] Array(int row, int column)
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
    void FormattingArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int n = 0; n < array.GetLength(1) - 1; n++)
                {
                    if (array[i, n] < array[i, n + 1])
                    {
                        int cheng = array[i, n + 1];
                        array[i, n + 1] = array[i, n];
                        array[i, n] = cheng;
                    }
                }
            }
        }
    }

    void PrintArray(int[,] inArray)
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
    int[,] array = Array(row, column);
    PrintArray(array);
    Console.WriteLine("Упорядоченный массив");
    FormattingArray(array);
    PrintArray(array);
}

void task56()
{
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
    int[] SumString(int[,] array, int row, int column)
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
    void PrintSumString(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.WriteLine(array[i] + "\t");
        }
    }
    Console.WriteLine("Задайте массив, введите 2 числа: 1е кол-во строк, 2е кол-во столбцов: ");
    int row = int.Parse(Console.ReadLine());
    int column = int.Parse(Console.ReadLine());
    Console.WriteLine();
    int[,] array = CreateArray(row, column);
    PrintArray(array);
    System.Console.WriteLine("Сумма сторк:");
    int[] newArray = SumString(array, row, column);
    PrintSumString(newArray);
    int stringNumber = IndexMinStrung(newArray);
    Console.Write($"Наименьшая сумма элементов в:  {stringNumber} стоке. ");
}
void task58()
{
    int[,] CreateMatrix(int row, int column)
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
    void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    void WorkMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] workMatrix)
    {
        for (int i = 0; i < workMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < workMatrix.GetLength(1); j++)
            {
                int summ = 0;
                for (int x = 0; x < firstMatrix.GetLength(1); x++)
                {
                    summ += firstMatrix[i, x] * secondMatrix[x, j];
                }
                workMatrix[i, j] = summ;
            }
        }
    }

    System.Console.Write("Введите кол-во строк 1й матрицы: ");
    int rowFirstMatrix = int.Parse(Console.ReadLine());
    System.Console.Write("Введите кол-во столбцов 1й матрицы (это значение будет ко-вом строк 2й матрицы): ");
    int columnFirsMatrix = int.Parse(Console.ReadLine());
    System.Console.Write("Введите кол-во столбцов 2й матрицы: ");
    int columnSecondMatrix = int.Parse(Console.ReadLine());
    int rowSecondMatrix = columnFirsMatrix;
    int[,] firstMatrix = CreateMatrix(rowFirstMatrix, columnFirsMatrix);
    Console.WriteLine();
    Console.WriteLine("Первая матрица:");
    PrintMatrix(firstMatrix);
    int[,] secondMatrix = CreateMatrix(rowSecondMatrix, columnSecondMatrix);
    Console.WriteLine("Вторая матрица:");
    PrintMatrix(secondMatrix);
    int[,] workMatrix = new int[rowFirstMatrix, columnSecondMatrix];
    WorkMatrix(firstMatrix, secondMatrix, workMatrix);
    Console.WriteLine("Произведение двух матриц:");
    PrintMatrix(workMatrix);
}
void task60()
{
    int[,,] Array(int x, int y, int z)
    {
        int[,,] result = new int[x, y, z];
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                int temp = 0;
                for (int k = 0; k < z; k++)
                {
                    result[i, j, k] = new Random().Next(10, 99);
                    if (result[i, j, k] == temp) result[i, j, k] = new Random().Next(10, 99);
                    temp = result[i, j, k];
                }
            }
        }
        return result;
    }
    void PrintArray(int[,,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                for (int k = 0; k < inArray.GetLength(2); k++)
                {
                    Console.Write($"{inArray[i, j, k]} ({i},{j},{k}) {"\t"}");
                }
                Console.WriteLine();
            }
        }
    }
    int[,,] array = Array(2, 2, 2);
    PrintArray(array);
}
