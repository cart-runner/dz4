// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;
int num1 = num;
for (int i = 1; num > 0; i++)
{
    num /= 10;
    result = i; 
     
}
int sum = 0;
for (int j = 0; j <= result; j++)
{
    sum = sum + num1 % 10;
    num1 = num1 / 10;
}
Console.WriteLine(sum);   
  