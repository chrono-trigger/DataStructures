using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tree<int> intTree = new Tree<int>();
            intTree.insert(5);
            intTree.printTree();
            intTree.insert(7);
            intTree.printTree();
            intTree.insert(3);
            intTree.printTree();
            intTree.insert(4);
            intTree.printTree();
        }
    }
}
