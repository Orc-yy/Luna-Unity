//using System;
//using System.Numerics;

//namespace ConsoleApp2
//{
//    class Program
//    {
//        interface IPlayer
//        {
//            void Moveto(Vector3 destination);
//        }

//        public class Goblin : IPlayer
//        {
//            public void Moveto(Vector3 destination)
//            {
//                Console.WriteLine($"Goblin이 {destination}로 이동");
//            }
//        }
//    }
//}


//using System;

//namespace ConsoleApp1
//{
//    class Module
//    {
//        public class Player
//        {
//            private int Current_HP;

//            public void SetCurrent_Hp(int hp)
//            {
//                if (hp > 0)
//                {
//                    Current_HP = hp;
//                }
//            }

//            public int GetCurrent_HP()
//            {
//                return Current_HP;
//            }
//        }

//        public static void Main(string[] args)
//        {
//            Player player = new Player();
//            player.SetCurrent_Hp(100);
//            Console.WriteLine($"Current_HP : {player.GetCurrent_HP()}");
//        }

//        public class Entity 
//        {
//            public void Attack()
//            {
//                Console.WriteLine("공격하기");
//            }
//            public void Heal()
//            {
//                Console.WriteLine("힐하기");
//            }
//        }
//        public class Goblin : Entity
//        {
//            public void Avoid()
//            {
//                Console.WriteLine("고블린 피한다!");
//            }
//            public void Heal()
//            {
//                Console.WriteLine("고블린 회복한다!");
//            }

//            private Entity entity = new Entity(); // Attack, Heal
//            private Goblin goblin = new Goblin(); // Attack, Heal, Avoid
//            private Entity entity = new Goblin(); // Attack, Heal
//        }

//    }

//}