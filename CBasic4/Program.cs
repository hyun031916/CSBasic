using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasic4
{
    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public void SetInTime()
        {
            this.inTime = DateTime.Now;

        }
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }

    class Program
    {
        //클래스 이름 충돌
        /* class Math
        {

        }*/
        static void Main(string[] args)
        {
            Car[] cars = new Car[10];
            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(100));
            Console.WriteLine(random.Next(10, 100));


            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble()*100);

            List<int> list = new List<int>();
            list.Add(32);
            list.Add(256);
            list.Add(52);
            list.Add(64);
            foreach(var item in list)
            {
                Console.WriteLine("count: " + list.Count + "\titem:" + item);
            }
            list.Remove(52);
            foreach(var item in list)
            {
                Console.WriteLine("count: " + list.Count + "\titem:" + item);
                //list.remove(item);
            }
            Console.WriteLine(Math.Abs(-231));
            Console.WriteLine(Math.Ceiling(52.256));
            Console.WriteLine(Math.Floor(52.256));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 256));
            Console.WriteLine(Math.Round(52.256));


            Product product = new Product();
        }
    }

    class FirtstClass
    {

    }

    class SecondClass
    {
        class ChildClass
        {

        }
    }
}
