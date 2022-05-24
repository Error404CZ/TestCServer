using System;

namespace Test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var DataManager = new DataManager();
            
            Console.WriteLine("Hello World");
            DataManager.SaveData(Console.ReadLine());

            Console.WriteLine(DataManager.LoadData());
            Console.ReadLine();
        }
    }
}
