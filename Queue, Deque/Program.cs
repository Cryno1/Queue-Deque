using Queue__Deque.Model;
using System;

namespace Queue__Deque
{
    class Program
    {
        static void Main(string[] args)
        {
            var easyDeque = new EasyDeque<int>();
            easyDeque.PushBack(1);
            easyDeque.PushFront(3);
            easyDeque.PushBack(4);
            easyDeque.PushFront(2);

            Console.WriteLine(easyDeque.PeekBack());
            Console.WriteLine(easyDeque.PeekFront());
            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PeekFront());
            Console.WriteLine(easyDeque.PopBack());
            Console.WriteLine(easyDeque.PeekBack());

            Console.ReadLine();
        }
    }
}
