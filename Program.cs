class Task_2
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        string input = Console.ReadLine();
        bool isSuccess = int.TryParse(input, out int numberInput);
        if (isSuccess)
        {
            if (numberInput > 60 && numberInput < 101)

            {
                Console.WriteLine(name + " Pass");
            }
            else
            {
                Console.WriteLine(name + " Don't pass");
            }
        }
        else
        {
            Console.WriteLine("not that");
        }
        if (numberInput > 100)
        {
            Console.WriteLine("not that");
        }
;
    }
}