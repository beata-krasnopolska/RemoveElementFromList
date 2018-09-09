using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementFromList
{
    internal class ListNode<T>
    {
        public int Value { get; set; }
        public ListNode<int> Next { get; set; }
    }
}
