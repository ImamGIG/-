Задача 2
System.Console.Write("Введите первое число -> ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число -> ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 >= num1)
{
    System.Console.Write($"Максимальное число -> {num2}");
}
else
{
    System.Console.Write($"Максимальное число -> {num1}");
}

System.Console.Write("Введите первое число -> ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число -> ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число -> ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max) max = b;   
if (c > max) max = c;    
System.Console.Write($"Максимальное число -> {max} ");

задача 6
System.Console.Write("Введите число -> ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    System.Console.Write($" Чётное число -> {a} ");
}
else 
{
    System.Console.WriteLine($" НЕ чётное число -> {a} ");
}

Задача 8
System.Console.Write("Введите число -> ");
int n = Convert.ToInt32(Console.ReadLine());
int current = 1 ;

while (current >= n)    
{
    if(current % 2 == 0)
    {
    System.Console.Write(current + " ");
    current++;
}
 else current++;
    }
   

   Console.Write("Введите число -> ");
int num = Convert.ToInt32(Console.ReadLine());

int numStart = 2;

    while(numStart <= num)
    {
        Console.Write(numStart + " ");
        numStart = numStart + 2;
    }
