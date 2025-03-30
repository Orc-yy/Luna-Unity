// using System;
// using System.Collections ;
// using System.Collections.Generic;
// using System.Collections.ObjectModel;

//namespace ConsoleApp3
//{
//    class Program
//    {
        
//        static void Main()
//        {
//            ArrayList list = new ArrayList();
//            Console.WriteLine(list.Add(7));
//            foreach (var item in list)
//            {
//                Console.WriteLine(item);
//            }

//            list.Insert(1, 100);
//            foreach (var item in list)
//            {
//                Console.WriteLine(item);
//            }

//            Collection<int> collection = new Collection<int>();
//            collection.Add(10);
//            collection.Add(20);
//            collection.Add(30);

//            list.AddRange(collection);

//            foreach (var item in collection)
//            {
//                Console.WriteLine(item);
//            }

//            list.Sort();
//            foreach (var item in list)
//            {
//                Console.WriteLine(item);
//            }

//            list.Remove(20);
//            foreach (var item in list)
//            {
//                Console.WriteLine(item);
//            }


//            list.RemoveRange(0, 2);
//            foreach (var item in list)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}


//namespace ConsoleApp3
//{
//    class User
//    {
//        static void Main()
//        {
//            Queue queue = new Queue();

//            for (int i = 20 ; i<= 100; i+=7)
//            {
//                queue.Enqueue(i);
//            }

//            Console.WriteLine(queue.Count); // 큐에 들어있는 요소의 개수
//            Console.WriteLine(queue.Peek()); // 전단에 있는 요소를 삭제X, 요소를 반환할때 사용
//            Console.WriteLine(queue.Dequeue()); // 전단에 있는 요소를 삭제O, 삭제한 요소를 반환
//            Console.WriteLine(queue.Count); 
//        }



//    }
//}


//namespace ConsoleApp3
//{
//    class User
//    {
//        static void Main()
//        {
//            Dictionary<string, string> dic = new Dictionary<string, string>();

//            dic["하나"] = "One";
//            dic["둘"] = "Two";
//            dic["셋"] = "Three";

            

//        }
//    }
//}