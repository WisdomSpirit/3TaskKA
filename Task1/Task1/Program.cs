using System;
using System.Linq;
using System.Text;
using Task1.interaction;

namespace Task1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Cleaner.Clean();
            var raw = Reader.Read();
            var graph = Parser.Parse(raw);
            var result = MinTreeFinder.FindMinTree(graph);
            var str = new StringBuilder();
            foreach (var node in result.Item1)
            {
                foreach (var item in node.OrderBy(i => i))
                {
                    str.Append(item).Append(" ");
                }

                str.Append("0").Append("\r\n");
            }

            str.Append(result.Item2);
            
            Writer.Write(str.ToString());
        }
    }
}