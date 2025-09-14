using System.ComponentModel.Design;
using System.Threading.Tasks.Sources;

class Task5
{
    public static void Main()
    {
        string name = Console.ReadLine();
        string input = Console.ReadLine();
        bool isNumber = int.TryParse(input, out int numberInput);
        string name2 = Console.ReadLine();
        string input2 = Console.ReadLine();
        bool isNumber2 = int.TryParse(input2, out int numberInput2);
        string name3 = Console.ReadLine();
        string input3 = Console.ReadLine();
        bool isNumber3 = int.TryParse(input3, out int numberInput3);
        string grade = "x";
        string grade2 = "x";
        string grade3 = "x";
        if (isNumber)
        {
            grade = calculateGrade(numberInput);
        }
        if (isNumber2)
        {
            grade2 = calculateGrade(numberInput2);
        }
        if (isNumber3)
        {
            grade3 = calculateGrade(numberInput3);
        }
        if (numberInput > 100 || numberInput < 0)
        {
            Console.WriteLine("Invalid score");
        }
        else if (numberInput2 > 100 || numberInput2 < 0)
        {
            Console.WriteLine("Invalid score");
        }
        else if (numberInput3 > 100 || numberInput3 < 0)
        {
            Console.WriteLine("Invalid score");
        }
        else if (numberInput == numberInput2 && numberInput2 == numberInput3)
        {
            Console.WriteLine("All students have the same score." + " -- " + input + " -- " + grade);
        }
        else if (numberInput == numberInput2 && numberInput > numberInput3)
        {
            Console.WriteLine(name + " and " + name2 + " have the same score" + " -- " + input + " -- " + grade);
        }
        else if (numberInput == numberInput3 && numberInput > numberInput2)
        {
            Console.WriteLine(name + " and " + name3 + " have the same score." + " -- " + input + " -- " + grade);
        }
        else if (numberInput2 == numberInput3 && numberInput2 > numberInput)
        {
            Console.WriteLine(name2 + " and " + name3 + " have the same score." + " -- " + input2 + " -- " + grade2);
        }
        else if (numberInput > numberInput2 && numberInput > numberInput3)
        {
            Console.WriteLine(name + " has the highest score." + " -- " + input + " -- " + grade);
        }
        else if (numberInput2 > numberInput && numberInput2 > numberInput3)
        {
            Console.WriteLine(name2 + " has the highest score." + " -- " + input2 + " -- " + grade2);
        }
        else if (numberInput3 > numberInput && numberInput3 > numberInput2)
        {
            Console.WriteLine(name3 + " has the highest score." + " -- " + input3 + " -- " + grade3);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
    private static string calculateGrade(int score)
    {
        if (score >= 90 && score <= 100)
        {
            return "A";
        }
        else if (score >= 80 && score < 90)
        {
            return "B";
        }
        else if (score >= 70 && score < 80)
        {
            return "C";
        }
        else if (score >= 60 && score < 70)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
}
//Done.