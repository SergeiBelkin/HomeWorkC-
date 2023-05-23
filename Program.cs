// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

// Функция рекурсии

string LineGenRec(int num)
{
    if (num == 0)
    {
        return string.Empty;
    }
    else
    {
        //return LineGenRec(num - 1) + " " + num ;
        return num + " " + LineGenRec (num - 1);
    }
}

int number = ReadData("Введите число N: ");
string resultLine = LineGenRec(number);
PrintResult(resultLine);








// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Метод рекурсии вычисляет сумму чисел от M до N
 int GetSum(int m, int n)
{
    if (n > m)
        return n + GetSum(m, n - 1);
    return m;
}

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод выводит результат пользователю
void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}

// Основной код программы
// 1  Вводим данные
int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");

// 2 Считаем сумму
int sum = GetSum(m,n);

// Выводим результат
PrintData("Сумма элементов от М до N равна: ",sum);


System.Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

int SumNumbers(int numStart, int numEnd) 
{
    if (numEnd < numStart)
    {
        System.Console.WriteLine("Неверное условие");
        return -1;
    }
    if (numStart == numEnd)
    {
        return numStart;
    }
    else
    {
        return numStart + SumNumbers(numStart + 1, numEnd);
    }
}

int sum = SumNumbers(m, n);
Console.WriteLine($"Сумма чисел от {m} до {n} равна {sum}");



// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.

Console.Write("Введите N: ");
int n = 3;// int.Parse(Console.ReadLine());

Console.WriteLine(PrintNumbers(1, n));

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}

// Что происходит в PrintNumbers:
// 1. 
    // start == 1, end == 3
    // в if не заходим
    // в return "1 " + результат функции PrintNumbers(2, 3)
    // "1 " + "2 3"
    // "1 2 3"

// 2.
    // start == 2, end == 3
    // в if не заходим
    // в return "2 " + результат функции PrintNumbers(3, 3)
    // "2 " + "3" == "2 3"

// 3. 
    // start == 3, end == 3
    // в if заходим и возвращаем "3"
