﻿// See https://aka.ms/new-console-template for more information

//["MinStack","push","push","push","push","getMin","pop","getMin","pop","getMin","pop","getMin"]
//[[],[2],[0],[3],[0],[],[],[],[],[],[],[]]
//[null,null,null,null,null,0,null,0,null,0,null,2]

//["MinStack","push","push","push","top","pop","getMin","pop","getMin","pop","push","top","getMin","push","top","getMin","pop","getMin"]
//[[],[2147483646],[2147483646],[2147483647],[],[],[],[],[],[],[2147483647],[],[],[-2147483648],[],[],[],[]]


//int[] temperatures = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };
//new Daily_Temperatures().DailyTemperatures(temperatures);


//var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
//var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

//var result = new Merge_Two_Sorted_Lists().MergeTwoLists(list1, list2);
//Console.WriteLine(result);

using Algorithms.Solutions;

var s = "anagram"; 
var t = "nagaram";

new Valid_Anagram().IsAnagram(s, t);