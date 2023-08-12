// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int [] Array={6,1,33};

Console.Write("[");
for (int i=0;i<Array.Length-1;i++)
{
    Console.Write($"{Array[i]}, ");
}
int index=Array.Length;

Console.Write($"{Array[index-1]}]");