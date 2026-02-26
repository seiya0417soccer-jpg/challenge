using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string a = Console.ReadLine();
        if (string.IsNullOrEmpty(a)) return;
        int b = int.Parse(a);


        var list = new List<(int Gold, int Silver)>();

        for (int i = 0; i < b; i++)
        {
            var kazu = Console.ReadLine().Split(' ');

            list.Add((int.Parse(kazu[0]), int.Parse(kazu[1])));
        }
        var sorted = list
            .OrderByDescending(x => x.Silver)
            .ThenByDescending(x => x.Gold);


        foreach (var zaisan in sorted)
        {
            Console.WriteLine(zaisan.Gold + " " + zaisan.Silver);
        }
    }
}