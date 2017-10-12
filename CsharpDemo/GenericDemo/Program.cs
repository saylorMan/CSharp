using System;

namespace GenericDemo
{

    /// <summary>
    ///  1.泛型可以用来解决不确定类型的问题。
    /// 2.泛型可以避免拆箱和装箱的过程。
    /// 3.泛型强制VS进行类型检查，避免运行时类型出错。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a = (int)GetValue(1);
            bool b = (bool)GetValue(true);
            string c = (string)GetValue("string");


            int d = GetValueBy(1);
            bool e = GetValueBy(true);
            string f = GetValueBy("string");

            Console.WriteLine($"a:{a.ToString()}");
            Console.WriteLine($"b:{b.ToString()}");
            Console.WriteLine($"c:{c.ToString()}");
            Console.WriteLine($"d:{d.ToString()}");
            Console.WriteLine($"e:{e.ToString()}");
            Console.WriteLine($"f:{f.ToString()}");

            Console.ReadKey();
        }


        public static object  GetValue(object  input )
        {
            return input;
        }

        public static T GetValueBy<T>(T input)
        {
            return input;
        }
       
    }
}
