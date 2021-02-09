using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("dictionary", "sözlük");
            myDictionary.Add("yellow", "sarı");
            myDictionary.Add("rainbow", "gökkuşağı");
            myDictionary.Show();
        }
    }
}
