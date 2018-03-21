using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 键值对集和
{
    class Program
    {
        static void Main(string[] args)
        {
            //hastable 键值对集和，相当于字典
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add("liuhu", "刘虎");
            //Console.WriteLine(ht["liuhu"]);
            //Console.WriteLine(ht[1]);
            //Console.ReadKey();

            //用foreach循环遍历hashtable
            foreach(var item in ht.Values)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
