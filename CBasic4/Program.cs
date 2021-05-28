using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasic4
{
    class MyMath { 
        public static double PI = 3.141592;
        public static void Hello()
        {
            Console.WriteLine("Greeting");
        }
    }

    class Product
    {
        public string name = "defualt";
        public int price = 100;

        public override string ToString()
        {
            return this.name + "/" + this.price;
        }
    }
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
            Console.WriteLine(product);
            Product productA = new Product() { name = "옥수수", price = 3000 };
            Console.WriteLine(productA);
            Product productB = new Product() { name = "고구마", price = 2000 };
            Console.WriteLine(productB);

            Console.WriteLine(MyMath.PI);
            MyMath.Hello();


            /*students.Add(new Student() { name = "윤인성", grade = 1});
            students.Add(new Student() { name = "김민경", grade = 2 });
            students.Add(new Student() { name = "이지민", grade = 5});
            students.Add(new Student() { name = "류현서", grade = 4});
            students.Add(new Student() { name = "강은별", grade =21});
            students.Add(new Student() { name = "김수현", grade = 1});*/

            List<Student> students = new List<Student> {
                new Student() { name="윤인성", grade=1},
                new Student() { name="김민경", grade = 2},
                new Student() { name="이지민", grade = 5},
                new Student() { name="강은별", grade=1},
                new Student() { name="류현서", grade=4},
                new Student() { name="김수현", grade=1},
                new Student() { name="함기훈 선생님", favoriteFood="밀크티"},
                new Student()
            };
            foreach (var item in students)
                Console.WriteLine(item.name + " : " + item.grade);
            /*
            for (int i = 0; i < students.Count; i++)
                if (students[i].grade > 0) {
                    students.RemoveAt(i);
                    i--;
                }
            */
            for (int i = students.Count - 1; i >= 0; i--)
                if (students[i].grade > 0)
                    students.RemoveAt(i);

            foreach (var item in students)
                Console.WriteLine(item.name + " : " + item.grade);
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
