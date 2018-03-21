using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集和的两个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            //练习一
            //list.Add(12);
            //list.Add(545);
            //list.Add(55);
            //int sum = 0;
            //for(int i = 0; i < list.Count; i++)
            //{
            //    sum += (int)list[i];
            //}
            //Console.WriteLine("平均值为{0}", sum / list.Count);
            //Console.ReadKey();


            //练习二
            //向集和中随机加入10个数字，要求0-9之间不能重复
            Random ran = new Random();
            int i = 10;
            int temp = 0;
            for(i=0;i<10;i++)
            {
                temp =ran.Next(0, 10);
                while(list.Contains(temp)){
                    temp = ran.Next(0, 10);
                }
                list.Add(temp);
            }
            for (i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
            Console.ReadKey();


        }
    }
}
