// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Random rand = new Random();

void FillMatrix (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
            Console.Write($"{arr[i, j]}\t");
       } 
       System.Console.WriteLine();
    }
}



int[,] matrix = new int[3, 4];

FillMatrix(matrix);
PrintArray(matrix);
Console.WriteLine($"Среднее арифметическое каждого столбца: ");
for (int j = 0; j < matrix.GetLength(1); j++) //Начинаем с колонок, так как по ним надо посчитать сред.арифм.
{
  double arithMeanColumn = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    arithMeanColumn += matrix[i, j];
  }
    arithMeanColumn = Math.Round(arithMeanColumn / matrix.GetLength(0), 2);// "2" - количество знаков после запятой.
    Console.Write($"{arithMeanColumn};\t");
}
