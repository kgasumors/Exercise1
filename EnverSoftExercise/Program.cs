﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnverSoftExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You have two arrays/lists as follows
            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };

            //a. Show the common elements in both lists. E.g the common elements are "3 4 5", because they are contained in both lists.
            var list3 = list1.Intersect(list2);
            Console.WriteLine("Common elements in both lists");
            foreach (int x in list3) Console.WriteLine(string.Join(" ", x));

            //b. Show the elements from list 1, but is not found in list2. E.g 1 2"
            var list4 = list1.Except(list2);
            Console.WriteLine("Elements from list1, but is not found in list2.");
            foreach (int x in list4) Console.WriteLine(string.Join(" ", x));

            //c. Complete here
            //Show the elements from list 2, but is not found in list1. E.g 6 7"
            var list5 = list2.Except(list1);
            Console.WriteLine("Elements from list2, but is not found in list1.");
            foreach (int x in list5) Console.WriteLine(string.Join(" ", x));

            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
        }
    }
}
