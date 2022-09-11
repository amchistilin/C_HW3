// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


string squareTable(int num)
{
    string result = $"{num} -> 1";
    for (int i = 2; i <= num; i++)
    {
        result = result + $", {Math.Pow(i,3)}";
    }
    return result;
}

try
{
    Console.WriteLine("Введите число = ");
    int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine(squareTable(num));
}
catch
{
    Console.WriteLine("Вводите целочисленные значения");
}