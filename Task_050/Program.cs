// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же
// указание, что такого элемента нет.
Console.Clear();

Random rand = new Random();

void FillMatrix (int[,] matr) //Функция заполнения массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(-15, 15); //ограничение значеий для заполнения
        }
    }
}

void PrintArray(int[,] arr) //Функция вывода массива
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



int[,] matrix = new int[4, 4]; //Ограничение размера массива

FillMatrix(matrix); //Запуск функции заполнения
PrintArray(matrix); //Запуск функции печати

System.Console.WriteLine("Введите номер строки: ");
int posLine = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите номер колонки: ");
int posColumn = int.Parse(Console.ReadLine());


if(posLine >= matrix.GetLength(0) | posColumn >= matrix.GetLength(1))
{

   System.Console.WriteLine($"Элемента с позициями [{posLine}, {posColumn}] в данном массиве нет ");
}
else
{
   System.Console.WriteLine($"Элемент [{posLine}, {posColumn}] равен {matrix[posLine, posColumn]} "); 
}
   

