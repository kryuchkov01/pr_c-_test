// Задача №7. Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает последнюю 
//цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N >= 100 && N < 1000) //проверка на 3-хзначное число
{
    int a = N % 10;
    Console.Write(a);
}
else
{
    Console.WriteLine("Введите 3-хзначное число.");
}



