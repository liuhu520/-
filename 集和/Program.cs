using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集和
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建集和的好处：
            //1.数量不固定
            //2.数据类型多样(因为集和中的元素都是object类型，所以可以存任何了类型的值，变回原来的类
            //型就可以借助强制转换实现)


            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add('f');
            list.Add("string");


            list.AddRange(new int[] { 1, 2, 3, 4, 5 });//给集和中添加数组


            //如果添加数组的时候不这样写，而是这样写：
            //list.Add(new int[] { 1, 2, 3, 4, 5 });
            ////输出的时候就得这样写：
            //int i = 3;
            //if (list[i] is int[])
            //{
            //    for (int j = 0; j < ((int[])list[i]).Length; j++)
            //    {
            //        Console.WriteLine(((int[])list[i])[j]);
            //    }
            //}
            //Console.ReadKey();




            //删除集和中的元素
            list.Remove('f');//写谁就删除谁
            list.RemoveAt(0);//根据下标删除元素
            list.RemoveRange(0, 1);//从下标为0开始，删1个；
            list.Sort();//升序排序；
            list.Reverse();//反转
            list.Insert(0, "插的内容");//在指定位置插入；
            list.InsertRange(0, new string[] { "张三", "李四" });//在指定位置插入一个数组；
            bool b = list.Contains("插的内容");//判断是否包含
            list.Clear();//全部删除



            //list 的长度问题
            //每次集和实际包含的元素个数（count）超过了可包含的个数(capcity)，
            //集和就会向内存中申请多开辟一倍的空间
            //来保证集和的长度够用

           
        }
    }
}

