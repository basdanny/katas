using System;
using System.Diagnostics;
using System.Text;

namespace Interview
{
    // Given the head of a linked list, remove the nth node from the end of the list and return its head.
    public class ListNodeDeleteElement : IRunTests
    {
        // Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }

            public ListNode RemoveNthFromEnd(ListNode head, int n)
            {
                var currentNode = head;
                var beforeNth = head;

                while (currentNode != null)
                {
                    if (n < 0) beforeNth = beforeNth.next;
                    else n--;

                    currentNode = currentNode.next;
                }

                if (n == 0)
                    head = head.next;
                else
                    beforeNth.next = beforeNth.next.next;

                //Console.WriteLine("NodeList: " + head?.ToString());

                return head;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                ListNode current = this;
                while (current != null)
                {
                    sb.Append(current.val + ",");
                    current = current.next;
                }

                return sb.ToString().TrimEnd(',');
            }
        }


        public void RunTests()
        {
            ListNode input1 = new ListNode(val: 1, next: new ListNode(val: 2, next: new ListNode(3, null)));
            Debug.Assert(input1.RemoveNthFromEnd(input1, 2).ToString() == "1,3");

            ListNode input2 = new ListNode(val: 1, next: null);
            Debug.Assert(input1.RemoveNthFromEnd(input2, 1) == null);

            ListNode input3 = new ListNode(val: 1, next: new ListNode(val: 2, next: null));
            Debug.Assert(input3.RemoveNthFromEnd(input3, 1).ToString() == "1");

            ListNode input4 = new ListNode(val: 1, next: new ListNode(val: 2, next: null));
            Debug.Assert(input4.RemoveNthFromEnd(input4, 2).ToString() == "2");

        }


    }
}
