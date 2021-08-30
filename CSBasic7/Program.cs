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
        static void Main(string[] args)
        {
            Products p = new Products();
            Console.WriteLine(p[2]);
            Console.WriteLine((new Products())[2]);
            Wanted<string> wantedString = new Wanted<string>("스트링");
            Wanted<int> wnatedInt = new Wanted<int>(3);
            Wanted<Student> wantedStudet = new Wanted<Student>(new Student());
        }
    }
}
