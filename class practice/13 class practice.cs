// namespace ConsoleApp1
// {
//     class Module
//     {
//         public class Parentclass
//         {
//             public void ParentMethod()
//             {
//                 Console.WriteLine("부모 클래스");
//             }
//         }

//         public class Childclass : Parentclass
//         {
//             public new void ParentMethod()
//             {
//                 Console.WriteLine("자식 클래스");
//             }
//         }

//         public static void Main(string[] args)
//         {
//             Parentclass p = new Parentclass();
//             p.ParentMethod();
//             Childclass c = new Childclass();
//             c.ParentMethod();
//         }
//     }   
// }