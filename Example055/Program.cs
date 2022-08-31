// Задача 55:
// Задайте двумерный массив. Напишите программу, которая заменяет
// строки на столбцы. В случае, если это невозможно, программа
// должна вывести сообщение для пользователя.
Console.Clear();
Console.Write("Задайте количество строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());
/// Метод заполнения матрицы GetArray
int[,] GetArray(int m, int n)
{
    int[,] matrix = new int [m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
    return matrix;
}
/// Метод печати матрицы
void PrintArray (int[,] matrix)
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
int[,] ChangeRowsColumns (int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int l = 0; l < matrix.GetLength(0); l++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {           
            result[k, l] = matrix [l, k];
        }
    }
    return result;
}
int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
Console.WriteLine("Модифицированная матрица:");
PrintArray(ChangeRowsColumns(resultMatrix));