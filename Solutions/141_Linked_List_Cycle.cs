//https://leetcode.com/problems/linked-list-cycle/description/
namespace Algorithms.Solutions
{
    public class Linked_List_Cycle
    {
        public bool HasCycle(ListNode head)
        {
            var references = new HashSet<ListNode>();
            var hasCycle = false;

            if (head == null)
            {
                return hasCycle;
            }

            while (head != null)
            {
                if (references.Contains(head))
                {
                    hasCycle = true;
                    break;
                }
                references.Add(head);
                head = head.next;
            }

            return hasCycle;
        }
    }
}

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */