//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int sum = 0;
int count = number.ToString().Length;
for (int i = 0; i < count; i++)
{
    int current = number % 10;
    number = number / 10;
    sum=sum + current;
}
Console.WriteLine(sum);