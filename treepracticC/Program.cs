// **вторая задача**


// Console.WriteLine("введте число a:");
// string text = Console.ReadLine();
// int a = Convert.ToInt32(text);
// Console.WriteLine("введте число b:");
// string text2 = Console.ReadLine();
// int b = Convert.ToInt32(text2);

// if (a > b) 
//     Console.WriteLine("a higer");
// else
// Console.WriteLine("b higer");

// **четвертая задача**


// Console.WriteLine("Enter a");

// string entera = Console.ReadLine();
// int a = Convert.ToInt32(entera);

// Console.WriteLine("Enter b");

// string enterb = Console.ReadLine();
// int b = Convert.ToInt32(enterb);

// Console.WriteLine("Enter c");

// string enterc = Console.ReadLine();
// int c = Convert.ToInt32(enterc);
// int max = a;
// if (b>a) max = b;
// if (c>b) max = c;

// Console.WriteLine("максимальное число:");
// Console.Write(max);

// **шестая задача**

// Console.WriteLine("введте число:");
// string text = Console.ReadLine();
// int a = Convert.ToInt32(text);
// double x = a%2;
//     if (x == 1)
//     {
//     Console.WriteLine("нечетное");
//     }
//     else
//     {
//     Console.WriteLine("четное");
//     }

// **восьмая задача**

Console.WriteLine("введте число:");
string text = Console.ReadLine();
int a = Convert.ToInt32(text);
int index = 2;
if(a > 0)    
    {
    while (index <= a)
    {
    Console.WriteLine(index);
    index = index + 2;
    }
    }
else 
    {
    index = -2;
    

    while (index >= a)
    {
    Console.WriteLine(index);
    index = index - 2;

    }
    }