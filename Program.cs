class Task5
{
    public static void Main()
    {
        string name = Console.ReadLine();
        string input = Console.ReadLine();
        bool isSuccsess = int.TryParse(input, out int numberInput);
        string name2 = Console.ReadLine();
        string input2 = Console.ReadLine();
        bool isSuccsess2 = int.TryParse(input2, out int numberInput2);
        string name3 = Console.ReadLine();
        string input3 = Console.ReadLine();
        bool isSuccsess3 = int.TryParse(input3, out int numberInput3);
        if (numberInput > 100 || numberInput < 0)
        {
            Console.WriteLine("Invalid score");
        }
        else if (numberInput >= 95)
        {
            Console.WriteLine("Student - " + name + " - A");
        }
        else if (numberInput >= 85)
        {
            Console.WriteLine("Student - " + name + " - B");
        }
        else if (numberInput >= 75)
        {
            Console.WriteLine("Student - " + name + " - C");
        }
        else if (numberInput >= 65)
        {
            Console.WriteLine("Student - " + name + " - D");
        }
        else if (numberInput >= 55)
        {
            Console.WriteLine("Student - " + name + " - E");
        }
        else if (numberInput < 55)
        {
            Console.WriteLine("Student - " + name + " - F");
        }
        else if (numberInput2 > 100 || numberInput2 < 0)
        {
            Console.WriteLine("Invalid score");
        }
        else if (numberInput2 >= 95)
        {
            Console.WriteLine("Student2 - " + name2 + " - A");
        }
        else if (numberInput2 >= 85)
        {
            Console.WriteLine("Student2 - " + name2 + " - B");
        }
        else if (numberInput2 >= 75)
        {
            Console.WriteLine("Student2 - " + name2 + " - C");
        }
        else if (numberInput2 >= 65)
        {
            Console.WriteLine("Student2 - " + name2 + " - D");
        }
        else if (numberInput2 >= 55)
        {
            Console.WriteLine("Student2 - " + name2 + " - E");
        }
        else if (numberInput2 < 55)
        {
            Console.WriteLine("Student2 - " + name2 + " - F");
        }
        else if (numberInput3 > 100 || numberInput3 < 0)
        {
            Console.WriteLine("Invalid score");
        }
        else if (numberInput3 >= 95)
        {
            Console.WriteLine("Student3 - " + name3 + " - A");
        }
        else if (numberInput3 >= 85)
        {
            Console.WriteLine("Student3 - " + name3 + " - B");
        }
        else if (numberInput3 >= 75)
        {
            Console.WriteLine("Student3 - " + name3 + " - C");
        }
        else if (numberInput3 >= 65)
        {
            Console.WriteLine("Student3 - " + name3 + " - D");
        }
        else if (numberInput3 >= 55)
        {
            Console.WriteLine("Student3 - " + name3 + " - E");
        }
        else if (numberInput3 < 55)
        {
            Console.WriteLine("Student3 - " + name3 + " - F");
        }   
    }
}