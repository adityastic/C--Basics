using System;
namespace Practise.Programs
{
    public class PrintLinkedLists
    {
        class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                }

                this.tail = node;
            }
        }

        public PrintLinkedLists()
        {
        }

        static void printLinkedList(SinglyLinkedListNode head)
        {
            while(head != null)
            {
                System.Console.WriteLine(head.data);
                head = head.next;       
            }
        }

        public static void execute()
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            llist.InsertNode(26);
            llist.InsertNode(13);

            printLinkedList(llist.head);
        }
    }
}
