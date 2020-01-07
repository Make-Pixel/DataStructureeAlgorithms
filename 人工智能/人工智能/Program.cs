using System;
using System.Collections;
using System.Collections.Generic;
using static System.Net.WebRequestMethods;

namespace Enumera
{
    public  class MainClass
    {
        public static void Main(string[] args)
        {
            var Kestring = "人工智能";
            TestReadingFile(Kestring);
            Console.WriteLine("aa,bb,cc,dd,ee,ff,gg,hh");
            TestStreamReaderEnumerable(Kestring);
            Console.ReadKey();

            Console.WriteLine("Hello World!");
            Console.Read();
        }

        private static void TestStreamReaderEnumerable(string kestring)
        {
         
        }

        private static void TestReadingFile(string kestring)
        {
            Console.WriteLine("数量");
          
        }

       
    }
}
