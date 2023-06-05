// Задача 25: Используя определение степени числа, напишите цикл, 
// который принимает на вход два натуральных числа (A и B) 
// и возводит число A в степень B.

Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите степень числа");
int b = Convert.ToInt32(Console.ReadLine());
int degree = a;

for (int i = 1; i < b; i++)
{
degree = degree * a;
}
Console.WriteLine("A в степени B равно: " + degree);
