Console.WriteLine("What is your name?");
string name = Console.ReadLine();

int loop = -1;

do
{
    Console.WriteLine("Please enter a number between 1 and 100 or 0 to leave");
    int userNum = int.Parse(Console.ReadLine());

    if (userNum > 100 || userNum < 0)
        break;

    else if (userNum % 2 == 1 && userNum < 60)
    {
        Console.WriteLine($"{name}, your number is odd and less than 60");
    }
    else if (userNum % 2 == 0 && userNum >= 2 && userNum <= 24)
    {
        Console.WriteLine($"{name}, your number is even and less than 25");
    }
    else if (userNum % 2 == 0 && userNum >= 26 && userNum <= 60)
    {
        Console.WriteLine($"{name}, your number is even and between 26 and 60");
    }
    else if (userNum % 2 == 0 && userNum > 60)
    {
        Console.WriteLine($"{name}, your number is even and greater than 60");
    }
    else if (userNum % 2 == 1 && userNum > 60)
    {
        Console.WriteLine($"{name}, your number is odd and greater than 60");
    }
    else if (userNum == 0)
    {
        Console.WriteLine("Goodbye");
        loop++;
    }
}
while (loop != 0);
