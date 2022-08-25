//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void Print (int[] col)
{
    int size = col.Length;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"col[{i}]: {col [i]}");
    }
} 
int [] arr = {345, 897, 568, 234};
int k = 0;
Print(arr);
foreach(int element in arr)
            {
                Console.Write("{0} ", element);
                if (element % 2 == 0)
                {
                    k++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество четных элементов {0}", k);
