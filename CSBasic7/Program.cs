using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic7
{

    class Products
    {
        private List<string> products = new List<string>();

        public Products()
        {
            products.Add("아메리카노");
            products.Add("카페라떼");
            products.Add("딸기라떼");
            products.Add("자몽허니블랙티");
            products.Add("망고스무디");
            products.Add("녹차오레오버블티");
        }
        public string this[int i]
        {
            get 
            {
                
                return products[i];
            }
            set { Console.WriteLine(i + "번 째 상품 설정"); }
        }
    }

    class Wanted<T>
    {
        public T Value;
        public Wanted(T value)
        {
            this.Value = value;
        }
    }

    class Student
    {

    }
    class Program
    {
        static void NextPosition(int x, int y, int vx, int vy,
            out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }
        static void Main(string[] args)
        {

            int x = 0;
            int y = 0;
            int vx = 100;
            int vy = 100;
            Console.WriteLine("현재 좌표: (" + x + ", " + y + ")");
            NextPosition(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌표: (" + x + ", " + y + ")");

            Console.WriteLine("숫자 입력: ");
            int output = int.MinValue;
            bool result = int.TryParse(Console.ReadLine(), out output);
            if (result)
            {
                Console.WriteLine("입력한 숫자:" + output);
            }
            else
            {
                Console.WriteLine("숫자를 입력해주세요!" + output);
            }


            Products p = new Products();
            Console.WriteLine(p[2]);
            Console.WriteLine((new Products())[2]);
            Wanted<string> wantedString = new Wanted<string>("스트링");
            Wanted<int> wnatedInt = new Wanted<int>(3);
            Wanted<Student> wantedStudet = new Wanted<Student>(new Student());
        }
    }
}
