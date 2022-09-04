//Задача 19
Console.Clear();
Console.Write("Введите пятизначное число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(anyNumber);
if (number.Length == 5)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Ваше число {anyNumber} палиндром");
    }
    else
    {
        Console.WriteLine($"Ваше число {anyNumber} не палиндром");
    }
}
else
{
    Console.WriteLine("Это не пятизначное число!!!");
}