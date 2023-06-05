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

// 2й вариант с циклом while

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = 1;
if (b < 1)
Console.Write("Число B должно быть натуральным\n");
else
{
while (b!=0)
{
c = c * a;
b = b — 1;
}
Console.Write($"Число A в натуральной степени B равно {c}");
}