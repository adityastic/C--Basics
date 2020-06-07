using System;
using System.Collections.Generic;

namespace Practise.Programs.LinkedLists
{
    public class LinkedList
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

            public void deleteNodeAtPosition(int position)
            {
                SinglyLinkedListNode temp = head;

                if (head == null)
                    return;

                if (position == 0)
                {
                    head = head.next;
                }

                while (temp.next != null)
                {
                    if ((position-- - 1) == 0)
                    {
                        temp.next = temp.next.next;
                    }
                    temp = temp.next;
                }
            }

            public void reversePrint()
            {
                reversePrintHelper(head);
            }

            private void reversePrintHelper(SinglyLinkedListNode root)
            {
                if (root == null)
                    return;

                reversePrintHelper(root.next);
                System.Console.WriteLine(root.data);
            }

            public void print()
            {
                SinglyLinkedListNode temp = head;
                while (temp != null)
                {
                    System.Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }

            public void reverseLinkedList()
            {
                SinglyLinkedListNode curr = head, prev = null, next = null;
                while (curr != null)
                {
                    next = curr.next;
                    curr.next = prev;
                    prev = curr;
                    curr = next;
                }
                head = prev;
            }

            public bool compareLists(SinglyLinkedList list)
            {
                SinglyLinkedListNode head1 = head, head2 = list.head;

                if (head1 == null && head2 == null)
                    return true;

                if (head1 == null || head2 == null)
                    return false;

                while (head1 != null && head2 != null)
                {
                    if (head1.data != head2.data)
                        return false;
                    head1 = head1.next;
                    head2 = head2.next;
                }

                if (head1 != null || head2 != null)
                    return false;

                return true;
            }
        }

        public static void execute()
        { 
            SinglyLinkedList llist = new SinglyLinkedList();

            llist.insertNodeAtHead(13);
            llist.insertNodeAtHead(27);
            llist.insertNodeAtHead(10);
            llist.insertNodeAtHead(0);
            llist.insertNodeAtTail(16);
            llist.insertNodeAtTail(90);

            llist.deleteNodeAtPosition(2);

            llist.reversePrint();
            llist.print();
            llist.reverseLinkedList();
            llist.print();

            System.Console.Write("Lists Same: " + llist.compareLists(llist));
        }
    }
}
