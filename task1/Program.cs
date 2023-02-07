// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int A = Readint("введите число A");
int B = Readint("введите число B");
int result = 1;
for (int i = 0; i < B; i++)
{
   result = result * A;
}
System.Console.WriteLine(result);















int Readint(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}