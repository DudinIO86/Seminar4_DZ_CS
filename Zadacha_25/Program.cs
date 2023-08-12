// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число А: ");
int NumA=int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int NumB=int.Parse(Console.ReadLine());

int num3=NumA;

for (int i=1;i<NumB;i++)
{
    num3=NumA*num3;
}

Console.WriteLine($"Число {NumA} в степени {NumB} равно {num3}");