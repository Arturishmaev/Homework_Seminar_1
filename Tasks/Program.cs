// Задача №2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

System.Console.WriteLine("введите первое число :");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите второе число :");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (num2 > num1)
{
    max = num2;
}
System.Console.Write("Ваше максимальное число :");
System.Console.WriteLine(max);

// Задача №4:Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("введите первое число :");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите второе число :");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите третье число :");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if(num2 > num1)
{
    max = num2;
}

if (num3 > max)
{
    max = num3;
}
System.Console.Write("Ваше максимальное число :");
System.Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

System.Console.WriteLine("введите Ваше число :");
int num1 = Convert.ToInt32(Console.ReadLine());

if(num1 % 2 == 0)
{
    System.Console.WriteLine("Ваше число четное");
}
else
{
    System.Console.WriteLine("Ваше число нечетное");
}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int index = 1;
System.Console.WriteLine("Введите Ваше число : ");
int N = Convert.ToInt32(Console.ReadLine());

while (index <= N)
{
    if(index % 2 ==0)
    {
        System.Console.WriteLine("Четные числа: " + index);
    }
    index++;
}
