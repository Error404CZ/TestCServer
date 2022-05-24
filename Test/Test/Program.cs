using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
             var TestCalss = new TestCalss();
            
            Console.WriteLine("Hello World");
            string testString = Console.ReadLine();
            try
            {
                TestCalss.test = Convert.ToInt32(testString);
            }
            catch
            {
                Console.WriteLine("FuckOF");
            }
            
            Console.ReadLine();
        }
    }
}
