using System;
using Tree;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = new Node(null, null, "I");
            var h = new Node(null, null, "H");
            var g = new Node(null, null, "G");
            var f = new Node(h, i, "F");
            var e = new Node(g, null, "E");
            var d = new Node(null, null, "D");
            var b = new Node(d, e, "B");
            var c = new Node(null, f, "C");
            var a = new Node(b, c, "A");

            DfsSearch dfs = new DfsSearch(a);

            Console.WriteLine(dfs[8].Val); // I
            var n = dfs["G"]; // 4
            Console.WriteLine(dfs[4].Val);
        }
    }
}