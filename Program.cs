class Program
{

    public static int[] MyInt;
    public static int limit;

    static void Main(string[] args)
    {
        Program.limit = 0;
        bool isLimitValid = false;
        while (!isLimitValid)
        {
            Console.Write("How many numbers do you want to enter? ");
            string input = Console.ReadLine() ?? "";
            if (int.TryParse(input, out int result) && result > 0)
            {
                isLimitValid = true;
                Program.limit = result;
                Program.MyInt = new int[Program.limit];
            }
            else
            {
                Console.WriteLine("\nInvalid input\n");
            }
        }
        
        for (int i = 0; i < Program.limit; i++)
        {
            bool isNumberValid = false;
            while (!isNumberValid)
            {
                Console.Write($"Enter a positive number ({i+1}): ");
                string input = Console.ReadLine() ?? "";
                if (int.TryParse(input, out int result) && result > 0)
                {
                    isNumberValid = true;
                    Program.MyInt[i] = result;
                }
                else
                {
                    Console.WriteLine("\nInvalid input\n");
                }
            }
        }

        int sum = 0;
        foreach (var summ in Program.MyInt)
        {
            sum += summ;            
        }
        Console.WriteLine($"Sum of all the numbers: {sum}\nAvarage of the numbers: {sum / Program.MyInt.Length}");
    }
}