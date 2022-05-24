using System;
using System.IO;

namespace Test
{
    public class DataManager
    {

        public void SaveData(string text)
        {
            text = text + Environment.NewLine;
            File.WriteAllText("C:/Users/filip/Documents/Test", text);
            Console.WriteLine("Save Data");
        }

        public string LoadData()
        {
            return File.ReadAllText("C:/Users/filip/Documents/Test");
        }
    }
}