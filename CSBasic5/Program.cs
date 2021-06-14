using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic5
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiClass m1 = new MultiClass();
            Console.WriteLine(m1.Multi(52, 273));
            Console.WriteLine(m1.Multi(103, 32));
            m1.Print();
            Console.WriteLine(m1.Sum(1, 100));
            MyMath.Abs(52);
            MyMath.Abs(273);
            MyMath.Abs(52.273f);
            MyMath.Abs(52.273);
            MyMath.Abs(30000000000);

            m1.somePublic();
            //m1.someDefault(); 기본은 private
            //m1.somePriavate();
        }

        class MyMath
        {
            //더블이 롱보다 범위가 더 큼
            /*public static void Abs(int input)
            {
                Console.WriteLine("정수 : "+((input < 0) ? -input : input));
            }*/
            public static void Abs(double input)    //플롯으로 하면 더블이 못들어감
            {
                Console.WriteLine("더블 : " + ((input < 0) ? -input : input));
            }

            /*public static void Abs(long input)
            {
                Console.WriteLine("롱 : " + ((input < 0) ? -input : input));
                *//*if (input < 0)
                    return -input;
                else
                    return input;*//*
            }*/
        }
        class MultiClass
        {
            public void somePublic()
            {
                Console.WriteLine("public");
            }

            void someDefault()
            {
                Console.WriteLine("DeFault");
            }

            private void somePrivate()
            {
                Console.WriteLine("private");
            }

            public int Multi(int x, int y)
            {
                return x * y;
            }
            public void Print()
            {
                Console.WriteLine("Print() 메서드 호출!");
            }
            public int Sum(int min, int max)
            {
                int output = 0;
                for (int i = min; i <= max; i++)
                {
                    output += i;
                }
                return output;
            }
        }
    }
}