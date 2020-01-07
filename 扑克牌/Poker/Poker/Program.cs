using System;
using System.Collections;

namespace Poker
{
    enum Color { HongTao = -1, HeiTao = -2, MeiHua = -3, FangPian = -4 }
    enum Point { A, two, three, four, five, six, seven, eight, nine, ten, Jack, Queen, King }
    struct Poker
    {
        private string p1, p2;
        public Poker(string p1, string p2)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
        }
        public void Printp()
        {
            Console.Write("({0},{1}) ", this.p1, this.p2);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            ArrayList myPoker = new ArrayList();
            ArrayList Person1 = new ArrayList();
            ArrayList Person2 = new ArrayList();
            ArrayList Person3 = new ArrayList();
            ArrayList Person4 = new ArrayList();
            Random r = new Random();
            for (int i = -4; i <= -1; i++)
            {
                for (int j = 0; j <= 12; j++)
                {
                    myPoker.Add(new Poker(
                        Enum.GetName(typeof(Color), i),
                        Enum.GetName(typeof(Point), j)
                        ));
                }
            }
            Console.WriteLine("打印所有的扑克牌：");
            for (int i = 0; i < 52; i++)
            {
                Poker poAll = (Poker)myPoker[i];
                poAll.Printp();
            }

            for (int i = 0; i < 13; i++)
            {
                int te = r.Next(0, myPoker.Count);
                Person1.Add(myPoker[te]);
                myPoker.RemoveAt(te);
            }
            for (int i = 0; i < 13; i++)
            {
                int te = r.Next(0, myPoker.Count);
                Person2.Add(myPoker[te]);
                myPoker.RemoveAt(te);
            }
            for (int i = 0; i < 13; i++)
            {
                int te = r.Next(0, myPoker.Count);
                Person3.Add(myPoker[te]);
                myPoker.RemoveAt(te);
            }
            for (int i = 0; i < 13; i++)
            {
                int te = r.Next(0, myPoker.Count);
                Person4.Add(myPoker[te]);
                myPoker.RemoveAt(te);
            }

            Console.WriteLine();
            Console.WriteLine("第一个人的扑克牌：");
            for (int i = 0; i < 13; i++)
            {
                Poker po1 = (Poker)Person1[i];
                po1.Printp();
            }
            Console.WriteLine();
            Console.WriteLine("第二个人的扑克牌：");
            for (int i = 0; i < 13; i++)
            {
                Poker po2 = (Poker)Person2[i];
                po2.Printp();
            }
            Console.WriteLine();
            Console.WriteLine("第三个人的扑克牌：");
            for (int i = 0; i < 13; i++)
            {
                Poker poker3 = (Poker)Person3[i];
                poker3.Printp();
            }
            Console.WriteLine();
            Console.WriteLine("第四个人的扑克牌：");
            for (int i = 0; i < 13; i++)
            {
                Poker poker4 = (Poker)Person4[i];
                poker4.Printp();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }


}
