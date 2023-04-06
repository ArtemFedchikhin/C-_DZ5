// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


void InputArray(int[] array) 
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-25,  26);
}

int ReleaseArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i+=2)
        count = count + array[i];
        Console.Write(count);
        return count;
}

void PrintArray(int[] array) 
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}


Console.Clear();
Console.WriteLine($"n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
PrintArray(array);
ReleaseArray(array);










