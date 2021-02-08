using System;

namespace _1872_回文链表
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ListNode node = new ListNode(1);
            node.next = new ListNode(2);

            Console.WriteLine(IsPalindrome(node));
        }

        /// <summary>
        /// 检查输入链表是否是回文的
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static bool IsPalindrome(ListNode head)
        {
            //快慢指针找中点
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            //反转后半部分
            ListNode pre = null;
            while (slow != null)
            {
                ListNode next = slow.next;
                slow.next = pre;
                pre = slow;
                slow = next;
            }
            //前后两端比较是否一致
            ListNode node = head;
            while (pre != null)
            {
                if (pre.val != node.val)
                {
                    return false;
                }
                pre = pre.next;
                node = node.next;
            }
            return true;
        }
    }


    //单链表
    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }

    
}
