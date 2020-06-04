using System;
using System.IO;

namespace Practise.Programs.LinkedLists
{
    public class InsertAtTail
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

        static void execute()
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            llist.insertNodeAtTail(13);
        }
    }
}
