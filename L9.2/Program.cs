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

int GetNumbers(int m, int n)
{
    int sum = m;
    if(m == n) return 0;
    else
    {
        m++;
        sum = m + GetNumbers(m, n);
        return sum;    
    }
}

void GetSum(int m, int n)
{
    Console.WriteLine(GetNumbers(m - 1, n));
}

int m = GetNumber("От:");
int n = GetNumber("До:");

GetSum(m, n);

