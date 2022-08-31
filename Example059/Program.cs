// Задача 59:
// Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых
// расположен наименьший элемент массива.
Console.Clear();
Console.Write("Задайте количество строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];
int minElement = int.MaxValue;
int indexRowMin = 0;
int indexColumnsMin = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(11);
        Console.Write(matrix[i, j] + "\t");
        if (minElement > matrix[i, j])
        {
            minElement = matrix[i, j];
            indexRowMin = i;
            indexColumnsMin = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine("Минимальный элемент: " + minElement);
for (int i = 0; i < rows; i++)
{
    if (indexRowMin != i)
    {
        for (int j = 0; j < columns; j++)
        {
            if (indexColumnsMin != j)
            {
                Console.Write(matrix[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }
}