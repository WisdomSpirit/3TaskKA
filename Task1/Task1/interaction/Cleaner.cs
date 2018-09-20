using System.IO;

namespace Task1.interaction
{
    public static class Cleaner
    {
        public static void Clean()
        {
            try
            {    
                File.Delete("out.txt");
            }
            catch (IOException){}
        }
    }
}