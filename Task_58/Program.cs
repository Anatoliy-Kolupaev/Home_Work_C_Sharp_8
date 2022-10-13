// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] CreateMatrix (int row, int column)
{
    int [,] result = new int [row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}
void PrintMatrix (int [,] matrix)
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
void WorkMatrix (int [,] firstMatrix, int [,] secondMatrix, int [,] workMatrix)
{
    for (int i = 0; i < workMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < workMatrix.GetLength(1); j++)
        {
            int summ = 0;
            for (int x = 0; x < firstMatrix.GetLength(1); x++)
            {
                summ += firstMatrix[i, x] * secondMatrix [x, j];
            }
            workMatrix [i, j] = summ;
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
int [,] firstMatrix = CreateMatrix (rowFirstMatrix, columnFirsMatrix);
Console.WriteLine();
Console.WriteLine("Первая матрица:");
PrintMatrix (firstMatrix);
int [,] secondMatrix = CreateMatrix (rowSecondMatrix, columnSecondMatrix);
Console.WriteLine("Вторая матрица:");
PrintMatrix (secondMatrix);
int [,] workMatrix = new int [rowFirstMatrix, columnSecondMatrix];
WorkMatrix(firstMatrix, secondMatrix, workMatrix);
Console.WriteLine("Произведение двух матриц:");
PrintMatrix (workMatrix);