// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число: ");
int Num=int.Parse(Console.ReadLine());

int sum=0;
int Num1=0;
int Num2=Num;

while(Num>0)
{
    Num1=Num%10;
    sum=sum+Num1;
    Num=Num/10;
}

Console.WriteLine($"Сумма числе числа {Num2} равна {sum}");