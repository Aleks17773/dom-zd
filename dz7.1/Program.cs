//Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

//double[,] array = new double[3,4];

//for (int i = 0; i < array.GetLength(0); i++)
//{
    //for (int j = 0; j < array.GetLength(1); j++)
    //{
        //array[i, j] = Convert.ToDouble(new Random().Next(-100,100)) /10;
        //Console.Write(array[i, j] + " ");
    //}
    //Console.WriteLine();
//}

//Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или 
//же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

//Console.WriteLine("введите число строк");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("введите число столбцов");
//int m = Convert.ToInt32(Console.ReadLine());
//int[,] array = new int[n,m];

//for (int i = 0; i < array.GetLength(0); i++)
//{
    //for (int j = 0; j < array.GetLength(1); j++)
    //{
        //array[i, j] = new Random().Next(1,10);
        //Console.Write(array[i, j] + " ");
    //}
    //Console.WriteLine();
//}

//Console.WriteLine("введите координаты");
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//if (a > n && b > m)
//Console.WriteLine("такого элемента нет");
//else
//{
    //object c = array.GetValue(a,b);
    //Console.WriteLine(c);
//}

//Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("введите число строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n,m];
FillArrayRandomNumbers(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i,j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + ";");
}
Console.WriteLine();
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0,10);
    }  
  }
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");  
    }
    Console.WriteLine("");
  }  
}
