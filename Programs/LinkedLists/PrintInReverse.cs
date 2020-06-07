using System;
using System.IO;

namespace Practise.Programs.LinkedLists
{
    public class PrintInReverse
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

            public SinglyLinkedList()
            {
                this.head = null;
            }

            public void insertNodeAtTail(int data)
            {
                if (head == null)
                    head = new SinglyLinkedListNode(data);
                else
                {
                    SinglyLinkedListNode temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = new SinglyLinkedListNode(data);
                }
            }

        }

        public static void execute()
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            llist.insertNodeAtTail(13);
            llist.insertNodeAtTail(27);
            llist.insertNodeAtTail(10);
            llist.insertNodeAtTail(0);

            reversePrint(llist.head);
        }

        private static void reversePrint(SinglyLinkedListNode root)
        {
            if (root == null)
                return;

            reversePrint(root.next);
            System.Console.WriteLine(root.data);
        }
    }
}
