class Task3
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        string input = Console.ReadLine();
        bool isSuccsess = int.TryParse(input, out int numberInput);
        if (numberInput > 100)
        {
            Console.WriteLine("Invalid score");
            return;
        }
        if (numberInput >= 95)
        {
            Console.WriteLine("Student1:" + name + " Mark: A");
        }
        else if (numberInput >= 85)
        {
            Console.WriteLine("Student1:" + name + " Mark: B");
        }
        else if (numberInput >= 75)
        {
            Console.WriteLine("Student1:" + name + " Mark: C");
        }
        else if (numberInput >= 65)
        {
            Console.WriteLine("Student1:" + name + " Mark: D");
        }
        else if (numberInput >= 60)
        {
            Console.WriteLine("Student1:" + name + " Mark: E");
        }
        else
        {
            Console.WriteLine("Student1:" + name + " Mark: F");
        }
    }
}
//Done.
