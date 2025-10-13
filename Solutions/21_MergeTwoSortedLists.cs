//https://leetcode.com/problems/merge-two-sorted-lists/description/
public class Merge_Two_Sorted_Lists
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null && list2 == null)
        {
            return default;
        }

        ListNode resultList = new ListNode();
        ListNode currentNode = resultList;
        var first = true;   

        while (true)
        {
            if (!first)
            {
                if (list1 != null || list2 != null)
                {
                    currentNode.next = new ListNode();
                    currentNode = currentNode.next;
                }
            }

            first = false;
            if (list1 != null && list2 != null)
            {
                currentNode.val = getSmallest(list1.val, list2.val);

                if (list1.val <= list2.val)
                {
                    list1 = list1.next;
                }
                else
                {
                    list2 = list2.next;
                }
                continue;
            }

            if (list1 != null)
            {
                currentNode.val = list1.val;
                list1 = list1.next;
                continue;
            }

            if (list2 != null)
            {
                currentNode.val = list2.val;
                list2 = list2.next;
                continue;
            }

            break;
        }


        return resultList;
        // Compara valor da lista1 com valor da lista2 e pega o menor.
        // Cria um node com menor valor.
        // Pega o próximo valor da lista que tinha o menor número e coloca na variável "smallest" da lista em questão.
        // Compara valor da lista1 com valor da lista2 e coloca e pega o menor.
        // Cria um node com o menor valor e coloca no next da lista de resultados.
        // Pega o próximo valor da lista que tinha o menor número e coloca na variável "smallest" da lista em questão.
        // Compara valor da lista1 com valor da lista2 e coloca e pega o menor.
        // Cria um node com o menor valor e coloca no next da lista de resultados.

    }

    private int getSmallest(int varA, int varB)
    {
        if (varA <= varB)
        {
            return varA;
        }
        return varB;
    }
}


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