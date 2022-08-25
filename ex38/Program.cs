//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76




int[] d = { 3, 7, 22, 2, 78 };
int size = d.Length;
int max = 0; 
int min = 2;
for (int i = 0; i < d.Length; i++);
for (int i = 0; i < d.Length; i++)
{
    if (d[i] > max) max = d[i];
    if (d[i] < min) min = d[i];
}

Console.WriteLine();
Console.WriteLine("max:  " + max);
Console.WriteLine("min  " + min);
Console.WriteLine("Разница максимального и минимального:  " + (max - min));
Console.ReadKey();
Console.WriteLine();
