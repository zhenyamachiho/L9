int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

void GetNumbers(int n)
{
    if (n > 0)
    {
        Console.Write("{0} ", n);
        GetNumbers(n - 1);
    }
}

int n = GetNumber("Введите число");
GetNumbers(n); 