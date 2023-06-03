//Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2 

//Console.WriteLine($"Введите размер массива m x n и диапазон случайных значений:");
//int m = InputNumbers("Введите m: ");
//int n = InputNumbers("Введите n: ");
//int range = InputNumbers("Введите диапазон: от 1 до ");

//int[,] array = new int[m, n];
//CreateArray(array);
//WriteArray(array);

//Console.WriteLine($"Отсортированный массив: ");
//OrderArrayLines(array);
//WriteArray(array);

//void OrderArrayLines(int[,] array)
//{
    //for (int i = 0; i < array.GetLength(0); i++)
  //{
    //for (int j = 0; j < array.GetLength(1); j++)
    //{
      //for (int k = 0; k < array.GetLength(1) - 1; k++)
      //{
        //if (array[i, k] < array[i, k + 1])
        //{
          //int temp = array[i, k + 1];
          //array[i, k + 1] = array[i, k];
          //array[i, k] = temp;
        //}
      //}
    //}
  //}
//}

//int InputNumbers(string input)
//{
  //Console.Write(input);
  //int output = Convert.ToInt32(Console.ReadLine());
  //return output;
//}

//void CreateArray(int[,] array)
//{
  //for (int i = 0; i < array.GetLength(0); i++)
  //{
    //for (int j = 0; j < array.GetLength(1); j++)
    //{
      //array[i, j] = new Random().Next(range);
    //}
  //}
//}

//void WriteArray(int[,] array)
//{
  //for (int i = 0; i < array.GetLength(0); i++)
  //{
    //for (int j = 0; j < array.GetLength(1); j++)
    //{
      //Console.Write(array[i, j] + " ");
    //}
    //Console.WriteLine();
  //}
//}

//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт 
//номер строки с наименьшей суммой элементов: 1 строка


//int m = InputNumbers("Введите m: ");
//int n = InputNumbers("Введите n: ");
//int range = InputNumbers("Введите диапазон: от 1 до ");

//int[,] array = new int[m, n];
//CreateArray(array);
//WriteArray(array);

//int minSumLine = 0;
//int sumLine = SumLineElements(array, 0);
//for (int i = 1; i < array.GetLength(0); i++)
//{
  //int tempSumLine = SumLineElements(array, i);
  //if (sumLine > tempSumLine)
  //{
    //sumLine = tempSumLine;
    //minSumLine = i;
  //}
//}

//Console.WriteLine($"{minSumLine+1}-строка  наименьшей суммой ({sumLine}) элементов ");


//int SumLineElements(int[,] array, int i)
//{
  //int sumLine = array[i,0];
  //for (int j = 1; j < array.GetLength(1); j++)
  //{
    //sumLine += array[i,j];
  //}
  //return sumLine;
//}

//int InputNumbers(string input)
//{
  //Console.Write(input);
  //int output = Convert.ToInt32(Console.ReadLine());
  //return output;
//}

//void CreateArray(int[,] array)
//{
  //for (int i = 0; i < array.GetLength(0); i++)
  //{
    //for (int j = 0; j < array.GetLength(1); j++)
    //{
      //array[i, j] = new Random().Next(range);
    //}
  //}
//}

//void WriteArray (int[,] array)
//{
  //for (int i = 0; i < array.GetLength(0); i++)
  //{
    //for (int j = 0; j < array.GetLength(1); j++)
    //{
      //Console.Write(array[i,j] + " ");
    //}
    //Console.WriteLine();
  //}
//}


//Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

//Console.WriteLine($"Введите размеры матриц и диапазон случайных значений:");
//int m = InputNumbers("Введите число строк 1-й матрицы: ");
//int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
//int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
//int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

//int[,] firstMartrix = new int[m, n];
//CreateArray(firstMartrix);
//Console.WriteLine($"Первая матрица:");
//WriteArray(firstMartrix);

//int[,] secomdMartrix = new int[n, p];
//CreateArray(secomdMartrix);
//Console.WriteLine($"Вторая матрица:");
//WriteArray(secomdMartrix);

//int[,] resultMatrix = new int[m,p];

//MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
//Console.WriteLine($"Произведение первой и второй матриц:");
//WriteArray(resultMatrix);

//void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
//{
  //for (int i = 0; i < resultMatrix.GetLength(0); i++)
  //{
    //for (int j = 0; j < resultMatrix.GetLength(1); j++)
    //{
      //int sum = 0;
      //for (int k = 0; k < firstMartrix.GetLength(1); k++)
      //{
        //sum += firstMartrix[i,k] * secomdMartrix[k,j];
      //}
      //resultMatrix[i,j] = sum;
    //}
  //}
//}

//int InputNumbers(string input)
//{
  //Console.Write(input);
  //int output = Convert.ToInt32(Console.ReadLine());
  //return output;
//}

//void CreateArray(int[,] array)
//{
  //for (int i = 0; i < array.GetLength(0); i++)
  //{
    //for (int j = 0; j < array.GetLength(1); j++)
    //{
      //array[i, j] = new Random().Next(range);
    //}
  //}
//}

//void WriteArray (int[,] array)
//{
  //for (int i = 0; i < array.GetLength(0); i++)
  //{
    //for (int j = 0; j < array.GetLength(1); j++)
    //{
      //Console.Write(array[i,j] + " ");
    //}
    //Console.WriteLine();
  //}
//}


//Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07


int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
