// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

//$"\nВведите элемент массива под индексом {i}:\t"
//"[{0}]", string.Join(", ", array)

int[] CreateArray()
{
    Console.Write("Введите колличество элементов массива:\t");

int element = int.Parse(Console.ReadLine());
int[] array = new int[element];
for (int i = 0; i < array.Length; i++)
{
Console.Write($"\nВведите элемент массива под индексом {i}:\t");
 array[i]= int.Parse(Console.ReadLine());

}
Console.WriteLine("[{0}]", string.Join(", ", array));
return array;
}
int[] result = CreateArray();
Console.WriteLine("[{0}]", string.Join(", ", result));
Console.WriteLine($"Напишите массив{result}:\t");
