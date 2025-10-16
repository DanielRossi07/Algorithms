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
        public bool HasCycle_Better(ListNode head)
        {
            var visited = new HashSet<ListNode>();

            while (head != null)
            {
                if (visited.Contains(head))
                {
                    return true;
                }

                visited.Add(head);
                head = head.next;
            }

            return false;
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