using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("Mert");
            myList.Add("Berat");
            Console.WriteLine(myList);
        }
    }
}
