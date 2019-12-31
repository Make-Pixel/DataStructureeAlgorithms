using System;

namespace 百鸡问题
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 3; x < 100; x = x + 3)
            { 
                for (int a = 1; a < 20; a++)
                {
                    for (int b = 1; b < 33; b++)
                    {

                        if (x + a + b == 100 && x / 3 + 5 * a + 3 * b == 100)
                        { 
                            Console.WriteLine("公鸡数量：" + a + "，母鸡数量：" + b + "，小鸡数量：" + x);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
