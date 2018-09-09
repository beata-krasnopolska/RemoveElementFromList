using System;
using System.Collections.Generic;

namespace RemoveElementFromList
{
    class Remover
    {
        public ListNode<int> RemoveKFromList(List<int> list, int k)
        {
            var response = new List<int>();
            list.RemoveAll(x => x == k);
            response = list;
            return new ListNode<int>();
        }
    }
}
