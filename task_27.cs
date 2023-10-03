// Задача 27:
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число  :" );
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
int res = 0;
while ( i <= n)
{
   res = (n%10) + res;
   n = n/10;
   i++;
}
Console.WriteLine(res);
