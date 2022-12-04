//Напишите программу, которая принимает на вход два числа (A и B)
// и метод который возводит число A в натуральную степень B.
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
// Не использовать Math.Pow()

int a = InputA();
int b = InputB();
int result = a;
int des = HowToConstruction(a, b);
Console.WriteLine($"{des}");


int InputA()
{
    Console.WriteLine("Введите число А");
    bool uinput = int.TryParse(Console.ReadLine(), out int a);
    if (uinput)
    {
        return a;
    }
    else
    {
        Console.WriteLine("Введено неправильное значение");
        return -1;
    }
}

int InputB()
{
    Console.WriteLine("Введите число B");
    bool uinput2 = int.TryParse(Console.ReadLine(), out int b);
    if (uinput2)
    {
        return b;
    }
    else
    {
        Console.WriteLine("Введено неправильное значение");
        return -1;
    }
}

int HowToConstruction( int a, int b)
{
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    return result;
}
