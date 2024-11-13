using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

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
        for(int i = 0; i < str.Length; i += 3)
        {
            string enemies = str[i..(i + 3)];
            int enemyCount = 3 - enemies.Count(x => x == 'x');
            int add = Math.Max(0, enemyCount - 1) * enemyCount + enemies.Sum(x => dict[x]);
            amount += add;
            Console.WriteLine($"{enemies} - {add}");
        }
        Console.WriteLine(amount);
    }


}
