using System;
using System.Collections;
using System.Collections.Generic;

namespace Zidian
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> open = new Dictionary<string, string>();
            open.Add("0", "aa");
            open.Add("1", "bb");
            open.Add("2", "vv");
            open.Add("3", "dd");

            Console.WriteLine("ok");
            if (!open.ContainsKey("qq"))
            {
                open.Add("qq", "123456");
                Console.WriteLine("为 键=\"qq\":添加的值是:{0}", open["qq"]);
            }
            Console.WriteLine("ok");


            foreach (KeyValuePair<string,string> pdd in open)
            {
                Console.WriteLine("键 = {0}  值 = {1}", pdd.Key, pdd.Value);
            }
            Console.WriteLine("ok");


            ICollection<string> mm = open.Values;
            Console.WriteLine();
            foreach (string b in mm)
            {
                Console.WriteLine("值 = {0} ", b);
            }
            Console.WriteLine("ok");

            mm = open.Keys;
            Console.WriteLine();
            foreach (string v in mm)
            {
                Console.WriteLine("键 = {0} ", v);
            }


            Console.WriteLine("这个字典类可以查询数据。");
            Console.ReadLine();

        }
    }
}
