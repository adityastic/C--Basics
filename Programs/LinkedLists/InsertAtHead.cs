using System;
using System.IO;

namespace Practise.Programs.LinkedLists
{
    public class InsertAtHead
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

            public void insertNodeAtHead(int data)
            {
                SinglyLinkedListNode newHead = new SinglyLinkedListNode(data);
                newHead.next = head;
                head = newHead;
            }
        }

        public static void execute()
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            llist.insertNodeAtHead(13);
        }
    }
}
