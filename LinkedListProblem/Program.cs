using System;
namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to linked list operations");
            //LinkedList list = new LinkedList();
            LinkedListStack list = new LinkedListStack();
            LinkedListQueue queue = new LinkedListQueue();
            list.Push(56);
            list.Push(80);
            list.Push(70);
            list.Display();
            list.Peek();
            list.Pop();
            list.Display();

          
            queue.Enqueue(56);
            queue.Enqueue(38);
            queue.Enqueue(78);
            queue.Dequeue();
            queue.Display();

            //list.Add(56);
            //list.Add(30);
            //list.Add(70);

            //list.InsertAtParticularPosition(2, 40);
            //Console.WriteLine("Insert at particular position");
            //list.Display();

            //Console.WriteLine("Add in reverse");
            //list.AddInReverseOrder(70);
            //list.AddInReverseOrder(30);
            //list.AddInReverseOrder(56);

            //list.Display();

            //int a = list.Search(30);
            //Console.WriteLine(a);

            //Console.WriteLine("Remove firt node");
            //list.RemoveFirstNode();
            //list.Display();
            //Console.WriteLine("Remove last node");
            //list.RemoveLastNode();
            //list.Display();

            //list.DeleteNodeAtParticularPosition(2);
            //list.Display();




        }
    }
}
