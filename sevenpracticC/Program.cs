
/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами от -10,0 до 10,0.

m = 3, n = 4.

0,5 7,0 -2,0 -0,2

1,0 -3,3 8,0 -9,9

8,0 7,8 -7,1 9,0
*/
// Console.WriteLine("enter column:");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("enter string:");
// int n = int.Parse(Console.ReadLine());

// double [,] matrix = new double[n,m];

// void MatrixFilled(int str, int col) //метод заполнения массива случайными числами от -10,0 до 10,0 
// {
//     for (int i = 0; i < str  ; i++)
//     {
//         
//         for (int j = 0; j < col ; j++)
//         {
//            matrix[i,j] = Math.Round (new Random().Next(-10, 10)+ new Random().NextDouble(),1);
//             
//         }
//     }
    
// }


// MatrixFilled(n,m);







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
// int a = 0;
// Console.WriteLine();
// void FindIndexMatrix(int Entered) //поиск числа в массиве
// {
//     for (int i = 0; i < MatrixRows; i++)
//     {
//         for (int j = 0; j < MatrixColumn; j++)
//         {
            
//             if (Matrix[i,j] == Entered)
//             {
//                 Console.WriteLine();
//                 Console.WriteLine( j+","+i);
//                 a ++;
//             }

//         }
//     }
    
// }
// int [,] MatrixFilled(int rowsnt column) //метод заполнения массива случайными числами и распечатка в терминале
// {
//     for (int i = 0; i < rows i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < column ; j++)
//         {
//            Matrix[i,j] = new Random().Next(-10, 10);
//            Console.Write(Matrix[i,j] +"  ");
            
//         }
//     }
//     return Matrix;
// }
// MatrixFilled(MatrixRows, MatrixColumn);
// FindIndexMatrix(EnteredText);
// Console.WriteLine();
// if (a==0)Console.WriteLine("нет искомого числа в массиве");


/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
// Console.WriteLine("Введите количество строк массива:");
// int r = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива:");
// int c = int.Parse(Console.ReadLine());
// int [,] Matrix = new int [r, c];
// double summ = 0;
// void MatrixFilled(int rows, int column) //метод заполнения массива случайными числами и распечатка в терминале
// {
//     for (int i = 0; i < rows; i++)
//     {
//         Console.WriteLine();
//         for (int j = 0; j < column ; j++)
//         {
//            Matrix[i,j] = new Random().Next(1, 10);
//            Console.Write(Matrix[i,j] +"  ");
            
//         }
//     }
    
// }
// MatrixFilled(r,c);
// Console.WriteLine();
// double SummRows (int col) // метод подсчета среднеарифметической суммы элементов столбца двумерного массива
// {
    
//     for (int i = 0, s = Matrix[i,col]; i < r - 1; i++)
//     {
//         s += Matrix[i+1,col];
//         summ = s;
//     }
//     return summ = summ/r;   
    
// }

// for (int x = 0; x < c; x++)
// {
//     SummRows(x);
//     Console.WriteLine("среднеарифм сумма столбца"+x+" = "+summ);
// }




 



