using System;
using System.Collections.Generic;

public class SimpleStackSolution
{
    public static void Run()
    {
        Console.WriteLine("\n=======================\nsimple Stack\n=======================");

        var stack = new Stack<int>();

        stack.Push(1);  // 1
        stack.Push(2);  // 1, 2
        stack.Push(3);  // 1, 2, 3
        stack.Pop();    // 1, 2
        stack.Pop();    // 1
        stack.Push(4);  // 1, 4
        stack.Push(5);  // 1, 4, 5
        stack.Pop();    // 1, 4
        stack.Push(6);  // 1, 4, 6
        stack.Push(7);  // 1, 4, 6, 7
        stack.Push(8);  // 1, 4, 6, 7, 8
        stack.Push(9);  // 1, 4, 6, 7, 8, 9
        stack.Pop();    // 1, 4, 6, 7, 8
        stack.Pop();    // 1, 4, 6, 7
        stack.Pop();    // 1, 4, 6
        stack.Push(10); // 1, 4, 6, 10
        stack.Pop();    // 1, 4, 6
        stack.Pop();    // 1, 4
        stack.Pop();    // 1
        stack.Push(11); // 1, 11
        stack.Push(12); // 1, 11, 12
        stack.Pop();    // 1, 11
        stack.Pop();    // 1
        stack.Pop();    // empty
        stack.Push(13); // 13
        stack.Push(14); // 13, 14
        stack.Push(15); // 13, 14, 15
        stack.Push(16); // 13, 14, 15, 16
        stack.Pop();    // 13, 14, 15
    }
}
