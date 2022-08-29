// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);                    //Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}


double[,] FillArray(int numLine, int numColumns) //Функция заполнения матицы случайными вещественными числами.
{
    double[,] matrix = new double[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)  //Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //Столбец
        {
            matrix[i, j] = new Random().NextDouble() * 20 - 10; // "20-10" - граница мин/макс 
        }
    }
    return matrix;
}


void PrintArray(double[,]matrix)                        //функция печати массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)       //Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   //Столбец
        {
            Console.Write($"{matrix[i, j]:F1}\t");     // "\t" - символ обозначает табуляцию, F1 - кол-во знаков после запятой.
        }
        Console.WriteLine();
    }
}

int numLine = Prompt("Введите количество строк массива ");
int numColumns = Prompt("Введите количество столбцов массива ");

double[,] matrix = FillArray(numLine, numColumns); 
PrintArray(matrix);
