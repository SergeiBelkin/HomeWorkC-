﻿/*
Задача 1: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A?? = m+n. Выведите полученный массив на экран.

m = 3, n = 4.

0 1 2 3

1 2 3 4

2 3 4 5

*/



/*
Задача 2: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
 и замените элементы на их квадраты.

Например, изначально массив выглядел вот так:

1 4 7 2

5 9 2 3

8 3 2 9

Новый массив будет выглядеть вот так:

1 4 49 2

5 9 2 3

64 3 4 9
*/

// int [,] array = new int[x,y];

// List<int> list = new List<int>() {1, 2};

// foreach (var item in list)
// {
//     Console.Write(item + " ");
// }


/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами от -10,0 до 10,0.

m = 3, n = 4.

0,5 7,0 -2,0 -0,2

1,0 -3,3 8,0 -9,9

8,0 7,8 -7,1 9,0
*/
Console.WriteLine("enter column:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("enter string:");
int n = int.Parse(Console.ReadLine());

double [,] matrix = new double[n,m];

double [,] MatrixFilled(int str, int col) //метод заполнения массива случайными числами от -10,0 до 10,0 и распечатка в терминале
{
    for (int i = 0; i < str  ; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < col ; j++)
        {
           matrix[i,j] = Math.Round (new Random().Next(-10, 10)+ new Random().NextDouble(),1);
           Console.Write(matrix[i,j] +"___"); 
        }
    }
    return matrix;
}


MatrixFilled(n,m);







/*
Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/


// Console.WriteLine("Введите искомое число:");
// int EnteredText = int.Parse(Console.ReadLine());
// int MatrixRows = 3;
// int MatrixColumn = 4;
// int[,]Matrix = new int [MatrixRows, MatrixColumn];

// Console.WriteLine();
// void FindIndexMatrix(int Entered)
// {
//     for (int i = 0; i < MatrixRows; i++)
//     {
//         for (int j = 0; j < MatrixColumn; j++)
//         {
            
//             if (Matrix[i,j] == Entered)
//             {
//                 Console.WriteLine(i+","+j);
//             }

//         }
//     }

// }
// int [,] MatrixFilled(int Rows, int Column) //метод заполнения массива случайными числами 
// {
//     for (int i = 0; i < Rows  ; i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < Column ; j++)
//         {
//            Matrix[i,j] = new Random().Next(-10, 10);
//            Console.Write(Matrix[i,j] +"___");
            
//         }
//     }
//     return Matrix;
// }
// MatrixFilled(MatrixRows, MatrixColumn);
// FindIndexMatrix(EnteredText);


/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
