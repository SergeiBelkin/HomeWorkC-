// **Задача 19**
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (палиндром - число читается слева направо и справа налево одинаково)
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число:");
// string num = Console.ReadLine();
// int i = num.Length;


// if ( i < 5 )
// {
//     Console.WriteLine("мало чисел");    
// }

// if ( i > 5 )
// {
//     Console.WriteLine("много чисел");
// }
// int a = num[0];
// int b = num[1];
// int c = num[3];
// int d = num[4];

// if ( a == d && b==c )
// {
//         Console.WriteLine( "палиндром" );
// }    
// if (i == 5)
// {
// Console.WriteLine( "не палиндром" );
// }

// **Задача 21**
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("ВВЕДИТЕ ТОЧКУ X1");
// string xtext = Console.ReadLine();
// double x1 = Convert.ToDouble(xtext);

// Console.WriteLine("ВВЕДИТЕ ТОЧКУ Y1");
// string ytext = Console.ReadLine();
// double y1 = Convert.ToDouble(ytext);

// Console.WriteLine("ВВЕДИТЕ ТОЧКУ Z1");
// string ztext = Console.ReadLine();
// double z1 = Convert.ToDouble(ztext);

// Console.WriteLine("ВВЕДИТЕ ТОЧКУ X2");
// string x2text = Console.ReadLine();
// double x2 = Convert.ToDouble(x2text);

// Console.WriteLine("ВВЕДИТЕ ТОЧКУ Y2");
// string y2text = Console.ReadLine();
// double y2 = Convert.ToDouble(y2text);

// Console.WriteLine("ВВЕДИТЕ ТОЧКУ Z2");
// string z2text = Console.ReadLine();
// double z2 = Convert.ToDouble(z2text);

// double AB = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

// Console.WriteLine("Расстояние между точками равно:" + Math.Round(AB, 3));


// **Задача 23**

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("введите целое число");
int i = Convert.ToInt32(Console.ReadLine());

for (int Q = 1; Q <= i; Console.WriteLine(Math.Pow(Q,  3)), Q++ );

