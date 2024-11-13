namespace _1;

class Program
{
    static void Main() => Console.WriteLine(File.ReadLines("input").First().Sum(x => x == 'A' ? 0 : x == 'B' ? 1 : 3));
}
