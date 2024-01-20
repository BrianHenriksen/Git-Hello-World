namespace Git_Hello_World;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Brian");
        Count(num:10);
    }

    static void Count(int num)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }
}

// A question for Craig, should you see it.
// while testing git for a bit, the main branch was always named MAIN.
// but in this case it shows as MASTER.. and i dont know why.