// Программа копирования массива.

Console.Clear();
Console.Write("Введите размер массива: ");
int arrSize = int.Parse(Console.ReadLine()?? "");
int[] array = new int [arrSize];
for(int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1,10);
for(int i = 0; i < array.Length; i++)
    Console.Write($"{array[i] + " "}");
Console.WriteLine();

int[] newArray = new int [array.Length];
for(int j = 0; j < array.Length; j++)
{
    newArray[j] = array[j];
    Console.Write($"{newArray[j]} ");
}    
Console.WriteLine();
