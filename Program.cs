class Task4
{
    public static void Main()
    {
        string name = Console.ReadLine();
        string input = Console.ReadLine();
        bool isSuccsess = int.TryParse(input, out int numberInput);
        string name2 = Console.ReadLine();
        string input2 = Console.ReadLine();
        bool isSuccsess2 = int.TryParse(input2, out int numberInput2);
        if (numberInput > numberInput2)
        {
            Console.WriteLine("Student: " + name + " Top: " + numberInput);
            return;
        }
        else if (numberInput < numberInput2)
        {
            Console.WriteLine("Student: " + name2 + " Top: " + numberInput2);
            return;
        }
        else if (numberInput == numberInput2)
        {
            Console.WriteLine("draw: " + numberInput);
            return;
        }
    }
}