// Задача 1: Задайте массив из 10 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите суммы отрицательных 
// и положительных элементов массива.








// Задача 2: Задайте массив из 10 элементов из промежутка [-9, 9] и 
// положительные элементы замените на соответствующие отрицательные,
//  и наоборот.




/*
Задача 34: Задайте массив заполненный 
случайными положительными трёхзначными 
числами (длина массива 5 элементов). 
Напишите программу, которая покажет 
количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

*/


// int[] newArray = new int[5];
// int any = 0;
// for (int i = 0; i < newArray.Length; i++)
// {
//       int randomNum = new Random().Next(100, 999);
//       newArray[i] = randomNum;
//       if (newArray[i]%2 == 0)
//       {
//       any ++;
//       } 
// }

// // Console.Write(newArray[0]+"  ");
// // Console.Write(newArray[1]+"  ");
// // Console.Write(newArray[2]+"  ");
// // Console.Write(newArray[3]+"  ");
// // Console.Write(newArray[4]+"  ");
// Console.Write($"количество четных чисел в массиве: "+any);







/*
Задача 36: Задайте одномерный массив, 
заполненный случайными числами (длина массива 5 элементов).
 Найдите сумму элементов, стоящих на нечётных индексах 
 (индексы с нуля).

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
// int[] addArray(int length, int nMin, int nMax)
// {
// int[] newArray = new int[length];
//   for (int i = 0; i < newArray.Length; i++)
//   {
//       int randomNum = new Random().Next(nMin, nMax);
//       newArray[i] = randomNum;
//   }
//   return newArray;
// }

// int enterUser(string enter)
// {
//   Console.WriteLine(enter);
//   string t = Console.ReadLine();
//   int UserEnter = int.Parse(t);
//   return UserEnter;
// }

// int length = enterUser("длинна");
// int nMin = enterUser("минимальное");
// int nMax = enterUser("максимальное");
// int[] array = addArray(length,nMin,nMax);
// Console.Write(array[0]+"  ");
// Console.Write(array[1]+"  ");
// Console.Write(array[2]+"  ");
// Console.Write(array[3]+"  ");
// Console.Write(array[4]+"  ");
// Console.WriteLine("Сумма элементов на нечетных индексах : ");
// Console.Write(array[1]+array[3]);

/*
Задача 38: Задайте массив вещественных чисел от -100 до 100 
(длина массива 5 элементов). Найдите разницу между максимальным 
и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
// int[] addArray(int length, int nMin, int nMax)
// {
// int[] newArray = new int[length];
//   for (int i = 0; i < newArray.Length; i++)
//   {
//       int randomNum = new Random().Next(nMin, nMax);
//       newArray[i] = randomNum;
//   }
//   return newArray;
// }
// int enterUser(string enter)
// {
//   Console.WriteLine(enter);
//   string t = Console.ReadLine();
//   int UserEnter = int.Parse(t);
//   return UserEnter;
// }



// int length = enterUser("введите длинну массива :");
// int nMin = enterUser("введите минимальное число массива :");
// int nMax = enterUser("введите максимальное число массива :");
// int[]array = addArray(length,nMin,nMax);

// int maxnum = array[0];

//   for (int i = 0; i < array.Length; i++)
//   {
//     if(array[i] > maxnum)
//     {
//       maxnum = array[i];
//     }
    
//   }
// int minimum = array[0];
//   for (int i = 0; i < array.Length; i++)
//   {
//     if(array[i] < minimum)
//     {
//       minimum = array[i];
//     }
    
//   }
// Console.WriteLine("разница между максимальным и минимальным элементом массива:"+(maxnum - minimum));  

// Console.Write(array[0]+"  ");
// Console.Write(array[1]+"  ");
// Console.Write(array[2]+"  ");
// Console.Write(array[3]+"  ");
// Console.WriteLine($"+>"+maxnum);
// Console.WriteLine($"->"+minimum);

