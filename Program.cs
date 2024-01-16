using MoreCSharpFun;

internal class Program
{
    private static void Main(string[] args)
    {
        PrintStuff ps = new PrintStuff("pt");

        string name = "";

        System.Console.WriteLine("Please write your name: ");

        name = System.Console.ReadLine();

        ps.PrintName(name);
    }
}