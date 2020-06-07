using System;
using Practise.Programs;
using Practise.Programs.LinkedLists;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Sparse Array -> ");
            SparseArrays.execute();
            System.Console.WriteLine("\n\nPrint Linked List-> ");
            PrintLinkedLists.execute();
            System.Console.WriteLine("\n\nInsert Tail Linked List-> ");
            InsertAtTail.execute();
            System.Console.WriteLine("\n\nInsert Head Linked List-> ");
            InsertAtHead.execute();
            System.Console.WriteLine("\n\nDelete Linked List-> ");
            DeleteNode.execute();
            System.Console.WriteLine("\n\nPrint in Reverse Linked List-> ");
            PrintInReverse.execute();
        }
    }
}
