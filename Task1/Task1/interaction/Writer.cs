using System.IO;

namespace Task1.interaction
{
    public static class Writer
    {
        public static void Write(string message)
        {
            var writer = new StreamWriter("out.txt",true);
            writer.WriteLine(message);
            writer.Close();
        }
    }
}