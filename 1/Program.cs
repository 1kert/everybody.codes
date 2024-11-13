using System.Runtime.CompilerServices;

namespace _1;

class Program
{
    static void Main()
    {
        int amount = 0;
        Dictionary<char, int>  dict = new()
        {
            { 'A', 0 },
            { 'B', 1 },
            { 'C', 3 },
            { 'D', 5 },
            { 'x', 0 }
        };
        string str = File.ReadLines("input").First();
        for(int i = 0; i < str.Length; i += 2)
        {
            char c1 = str[i];
            char c2 = str[i + 1];
            amount += c1 == 'x' ? dict[c2] : c2 == 'x' ? dict[c1] : (dict[c1] + dict[c2] + 2);
        }
        Console.WriteLine(amount);
    }
}
