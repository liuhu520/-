

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //里氏转换
            //Person p = new Student();
            //1、子类可以赋值给父类 ：如果有一个地方需要父类作为参数，可以用子类代替。
            string.Join("|", new string[] { "1", "2", "3" });
            //上句，第二个参数要求一个object类型的（父类），现在给了一个子类，不会报错

            //2.如果父类中装的是子类的对象，那么可以将这个父类转换成子类对象；
            //就是说：如果将子类的对象赋值给父类后，可将该父类强制转换为该子类的对象；

            //万一父类包含的子类对象不是要转换成的子类的对象，就会抛异常；

            //可以这样写：
            //1. is
            //if(p is Teacher)
            //{
            //  Teacher ss=(Teacher)p;
            //}
            //else
            //  console.writeline("转换失败");
            //

            //2. as
            //Teacher t = p as Teacher;  //如过转换失败，t就等于null；
            //Console.ReadKey();



        }
    }
}
