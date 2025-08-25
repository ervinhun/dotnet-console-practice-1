class Program
{

    public int MyInt { get; set; }

    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name);
    }
}