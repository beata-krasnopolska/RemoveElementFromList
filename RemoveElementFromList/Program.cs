﻿using System;
using System.Collections.Generic;

namespace RemoveElementFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 3, 1, 2, 3, 4, 5 }; //k = 3, the output should be removeKFromList(l, k) = [1, 2, 4, 5]
            //var list = new List<int> {1, 2, 3, 4, 5, 6, 7}; // k=10, the output should be removeKFromList(l, k) = [1, 2, 3, 4, 5, 6, 7]

            int k = 3;
            //int k =10;

            var numbers = new Remover();
            var removeDuplicates = numbers.RemoveKFromList(list, k);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
