// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (палиндром - число читается слева направо и справа налево одинаково)
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
string num = Console.ReadLine();
int i = num.Length;


if ( i < 5 )
{
    Console.WriteLine("мало чисел");    
}

if ( i > 5 )
{
    Console.WriteLine("много чисел");
}
int a = num[0];
int b = num[1];
int c = num[3];
int d = num[4];

if ( a == d && b==c )
{
        Console.WriteLine( "палиндром" );
}    
if (i == 5)
{
Console.WriteLine( "не палиндром" );
}