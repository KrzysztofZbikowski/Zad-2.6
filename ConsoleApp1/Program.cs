class Zad
{
    static void Main(string[] args)
    {
        int x, y = 4;
        x = (y -= 2);
        Console.WriteLine("x: " + x);
        Console.WriteLine("y: " + y);
        x = y++;
        Console.WriteLine("x: " + x);
        Console.WriteLine("y: " + y);
        x = y--;
        Console.WriteLine("x: " + x);
        Console.WriteLine("y: " + y);
        Console.ReadKey();
    }
}