using System;
using System.IO;

namespace Practise.Programs.LinkedLists
{
    public class DeleteNode
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

            public void deleteNode(int data)
            {
                if (head == null)
                    return;
                else
                {
                    SinglyLinkedListNode temp = head;
                    while(temp.next != null)
                    {
                        if(temp.next.data == data)
                        {
                            temp.next = temp.next.next;
                            return;
                        }
                        temp = temp.next;
                    }
                }
            }
        }

        public static void execute()
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            llist.insertNodeAtHead(13);
            llist.insertNodeAtHead(27);
            llist.insertNodeAtHead(10);
            llist.insertNodeAtHead(0);

            llist.deleteNode(13);
        }
    }
}
