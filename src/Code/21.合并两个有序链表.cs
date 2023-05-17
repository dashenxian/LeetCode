/*
 * @lc app=leetcode.cn id=21 lang=csharp
 *
 * [21] 合并两个有序链表
 */
namespace Namespace21;
// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{

    // public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    // {
    //     if (l1 == null) return l2;
    //     if (l2 == null) return l1;
    //     if (l1.val <= l2.val)
    //     {
    //         l1.next = MergeTwoLists(l1.next, l2);
    //         return l1;
    //     }
    //     else
    //     {
    //         l2.next = MergeTwoLists(l1, l2.next);
    //         return l2;
    //     }
    // }

    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode newListNode = null;
        ListNode curListNode = null;

        if (l1 == null)
        {
            return l2;
        }
        if (l2 == null)
        {
            return l1;
        }

        var curListNode1 = l1;
        var curListNode2 = l2;

        while (curListNode1 != null && curListNode2 != null)
        {
            ListNode curListNodeNext = null;
            if (curListNode1.val > curListNode2.val)
            {
                curListNodeNext = new ListNode(curListNode2.val, null);
                curListNode2 = curListNode2.next;
            }
            else
            {
                curListNodeNext = new ListNode(curListNode1.val, null);
                curListNode1 = curListNode1.next;
            }
            if (curListNode == null)
            {
                curListNode = curListNodeNext;
                newListNode = curListNode;
            }
            else
            {
                curListNode.next = curListNodeNext;
            }

            curListNode = curListNodeNext;

        }

        if (curListNode1 != null)
        {
            curListNode.next = curListNode1;
        }
        else if (curListNode2 != null)
        {
            curListNode.next = curListNode2;
        }
        return newListNode;
    }
}
// @lc code=end
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
