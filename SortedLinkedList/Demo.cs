using System;

namespace SortedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, data;

            SortedLinkedList list = new SortedLinkedList();
            list.CreateList();

            while (true)
            {
                Console.WriteLine("1.Display list ");
                Console.WriteLine("2.Insert a new node");
                Console.WriteLine("3.Search");
                Console.Write(" enter your choice ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 4)
                    break;
                switch (choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        Console.WriteLine("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInOrder(data);
                        break;
                    case 3:
                        Console.WriteLine("Enter the element to be searched : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Search(data);
                        break;
                    default:
                        Console.Write("Wrong choice ");
                        break;
                }
            }
        }
    }
}
