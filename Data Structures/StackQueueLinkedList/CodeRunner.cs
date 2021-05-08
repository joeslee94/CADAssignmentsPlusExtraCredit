using NPOI.SS.Formula.Functions;
using System;

namespace StackQueueLinkedList
{
    class CodeRunner
    {
        static void Main(string[] args)
        {
            #region MyStack
            //MyStack<int> stack = new MyStack<int>(10);
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //stack.Push(6);
            //stack.Push(7);
            //stack.Push(8);
            //stack.Push(9);
            //stack.Push(10);
            //stack.Push(11);
            //stack.Push(12);

            //foreach(var i in stack)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("^^^^^Initial Stack^^^^^");

            //stack.Pop();
            //stack.Pop();
            //stack.Pop();
            //stack.Pop();

            //Console.WriteLine("I popped off 4 elements");
            //foreach (var i in stack)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("^^^^^Popped Stack^^^^^");

            //int t = 4;
            //while(t > 0)
            //{
            //    Console.WriteLine($"I am peeking {stack.Peek()}");
            //    Console.WriteLine($"I am popping {stack.Pop()}");
            //    Console.WriteLine("");
            //    t--;
            //}

            //foreach (var i in stack)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("^^^^^Peeked Popped Stack^^^^^");

            //stack.Peek();
            //Console.WriteLine($"Nothing should change from the last operation, I only peeked");
            //foreach (var i in stack)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region MyQueue
            //MyQueue<int> queue = new MyQueue<int>(3);
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //foreach (var i in queue)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("^^^^^Initial Queue^^^^^");

            //Console.WriteLine($"I have dequeued {queue.Dequeue()}.");
            //Console.WriteLine($"I have dequeued {queue.Dequeue()}.");
            //Console.WriteLine($"There should be two less items.");
            //foreach (var i in queue)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("^^^^^Dequeue^^^^^");

            //Console.WriteLine($"I have peeked {queue.Peek()}");
            //Console.WriteLine("Nothing should change unless I Dequeue the value I peeked");
            //foreach (var i in queue)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("^^^^^Peek^^^^^");
            #endregion

            #region MyLinkedList
            MyLinkedList<int> linkedList = new MyLinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);
            linkedList.AddLast(6);
            linkedList.AddLast(7);
            linkedList.AddLast(8);
            linkedList.AddLast(9);
            linkedList.AddFirst(9);

            linkedList.printAllNodes();

            Console.WriteLine("");
            linkedList.RemoveHead();
            linkedList.printAllNodes();

            Console.WriteLine("");
            linkedList.RemoveTail();
            linkedList.printAllNodes();
            #endregion
        }
    }
}
