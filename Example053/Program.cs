// Задача 53:
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строки массива.
Console.Clear();
Console.Write("Задайте количество строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());
/// 3 слэша - это summary - описание метода
/// Метод заполнения матрицы GetArray, где входные параметры целочисленные m - строчки, n - столбцы
int[,] GetArray(int m, int n)   // Метод возвращает двумерную целочисленную матрицу (int[,]) с целочисленными параметрами и входными
                                // параметрами m (строки) и n (столбцы)
{   // Начало тела метода GetArray
    int[,] matrix = new int[m, n];                  // Создание двумерной целочисленной матрицы с именем matrix размером m на n
    for (int i = 0; i < matrix.GetLength(0); i++)       // Цикл строчек
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // Цикл столбцов
        {
            matrix[i, j] = new Random().Next(11);       // Заполнение матрицы случайными целыми числами от 1 до 10
        }
    }
    return matrix;  // Метод возвращает заполненную двумерную матрицу
}   // Конец тела метода GetArray
/// Метод вывода матрицы matrix для печати в терминал PrintArray, где входной параметр целочисленная матрица int[,] matrix
void PrintArray(int[,] matrix)  // Тип метода void, т.к он ничего не возвращает. Только принимает параметр в виде матрицы на печать 
{   // Начало тела метода PrintArray
    for (int i = 0; i < matrix.GetLength(0); i++)       // Цикл строчек
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // Цикл столбцов
        {
            Console.Write(matrix[i, j] + "\t"); // здесь литерал "\t" - это табуляция (Tab)
        }
        Console.WriteLine();
    }
}   // Конец тела метода PrintArray
/// Метод замены первой и последней строк ChangeRows, где входной параметр целочисленная матрица int[,] inputMatrix
void ChangeRows(int[,] inputMatrix) // Тип метода void, т.к он ничего не возвращает. Только меняет элементы
{   // Начало тела метода ChangeRows
    int lastRowIndex = inputMatrix.GetLength(0) - 1;    // Получаем индекс последней строки
    for (int i = 0; i < inputMatrix.GetLength(1); i++)  // Цикл столбцов
    {
        int temp = inputMatrix[0, i];                       // Промежуточная переменная приравнивается элементу [0,i] входной матрицы
        inputMatrix[0, i] = inputMatrix[lastRowIndex, i];   // Элемент [0,i] приравнивается элементу [GetLength(0)-1,i] входной матрицы
        inputMatrix[lastRowIndex, i] = temp;                // Элемент входной матрицы [GetLangth(0)-1,i] приравнивается temp
    }
}   // Конец тела метода ChangeRows

int[,] resultMatrix = GetArray(rows, columns);  // Создание заполненной двумерной целочисленной матрицы resultMatrix, которая будет
                                                // результатом вызова метода GetArray из rows строк и m столбцов
PrintArray(resultMatrix);                       // Вызов метода PrintArray для печати матрицы resultMatrix
Console.WriteLine("Результат: ");
ChangeRows(resultMatrix);                       // Вызов метода замены первой и последней строк ChangeRows для замены их в матрице
                                                // resultMatrix
PrintArray(resultMatrix);                       // Вызов метода PrintArray для печати уже измененной матрицы resultMatrix
