using System;

namespace LinkedList2023
{
    internal class LL_Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ILL<int> myLL = new LL<int>();
            LL<string> newLL = new LL<string>();
            myLL.insertFront(3);
            myLL.insertFront(9);
            myLL.insertFront(1);
            myLL.traverse();
            Console.ReadLine();
        }
    }
}
