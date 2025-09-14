using System.ComponentModel.Design;

Console.WriteLine("write score: ");
string input = Console.ReadLine();
if (!int.TryParse(input, out int score))
{
    Console.WriteLine("not that");
}
else
{
    if (score <= 60)
    {
        Console.WriteLine("not passed");
    }
    else
    {
        Console.WriteLine("passed)");
    }

}
//Done.
