using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        /*string Var = "테스트";
        //var testing = "전역변수에 var 시용 불가";*//*

        //상속과 생성자 코드1
        */
        class Boss
        {
            public int annual = 40;
        }

        class Staff : Boss
        {
            public double annual = 5.5;
        }

       static void Main(string[] args)
        {
            Staff staff = new Staff();
            Console.WriteLine(staff.annual);
        }
        /*

        //상속과 생성자 코드2
        class Parent
        {
            public Parent()
            {
                Console.WriteLine("부모 생성자");
            }
        }

        class Child : Parent
        {
            public Child():base()
            {
                Console.WriteLine("자식 생성자");
            }
        }
        static void Main(string[] args)
        {
            *//*var name = "김" + "수" + "현";
           

            var alpha = "알파";
            //var 0319 = "숫자 변수 안돼요";
            var 김수현 = "한글 변수 된다";
            //string ❤ = "이모지는 안 된다.";

            // 인라인 주석
            *//*
             * 여러 줄 주석
             *//*
            Console.Write("개행 안 됨");
            Console.WriteLine("개행 됨");

            Console.WriteLine(52);
            //Arithmetic Operator + - * /
            Console.WriteLine(52 + 273);
            //Operator Priority
            Console.WriteLine(5+3*2);

            Console.WriteLine(10 / 5);
            Console.WriteLine(10 % 5);
            Console.WriteLine(7 % 3);

            //Real Number
            Console.WriteLine(52.273);

            Console.WriteLine(0);
            Console.WriteLine(0.0);

            Console.WriteLine(1.0 + 2.0);
            Console.WriteLine(1.0 - 2.0);
            Console.WriteLine(1.0 * 2.0);

            Console.WriteLine(1.0 / 2.0);
            Console.WriteLine(1 / 2);
            Console.WriteLine(1.0 / 2);
            Console.WriteLine(1 / 2.0);

            Console.WriteLine('A');
            Console.WriteLine('가');
            // Console.WriteLine('AB'); //문아 error
            Console.WriteLine("AB");     //문자열 OK

            //Escape Character
            Console.WriteLine("미\t림여자정보\t과학고");
            Console.WriteLine("미림\t여자정보\t과학고");
            Console.WriteLine("미림여\t자정보과학고\t안녕");
            Console.WriteLine("미림여자정보과학고\t안녕");
            Console.WriteLine("\\ 역슬래시 \n 엔터문자 \" 큰따옴표");

            //문자열 연결 연산자 Concatenation Operator
            Console.WriteLine("A" + "B");
            Console.WriteLine("A" + 1);
            Console.WriteLine(1 + "A");
            Console.WriteLine("1" + "A");
            Console.WriteLine('A'+'B');
            Console.WriteLine('A'-'B');
            // Console.WriteLine("A"-"B"); 문자열에서 - 연산자를 사용할 수 없다.
            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("안녕하세요"[1]);
            Console.WriteLine("안녕하세요"[2]);
            Console.WriteLine("안녕하세요"[3]);
            Console.WriteLine("안녕하세요"[4]);
            //Console.WriteLine("안녕하세요"[100]);
            //Console.WriteLine("안녕하세요"[-1]);

            //bool / boolean
            Console.WriteLine(true);
            Console.WriteLine(false);

            //Comparison operator
            // == != > < <= >=
            // => =< NO!!
            Console.WriteLine(62 < 273);

            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
            Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);

            //integer overflow
            int a = 2147483647;
            int b = 1;
            Console.WriteLine(a + b);

            //sizeof 연산자
            Console.WriteLine("int: " + sizeof(int));
            Console.WriteLine("long: " + sizeof(long));
            Console.WriteLine("float: " + sizeof(float));
            Console.WriteLine("double: " + sizeof(double));
            Console.WriteLine("char: " + sizeof(char));
            Console.WriteLine("bool: " + sizeof(bool));

            bool TrueOrFalse = true;

            int output = 0;
            output += 52;
            output += 273;
            output += 103;

            Console.WriteLine(output);
            output *= 2;
            Console.WriteLine(output);

            //문자열 관련 복합 대입 연산자
            string output2 = "Hello";
            output2 += "World";
            output2 += "!";
            Console.WriteLine(output2);

            //증감 연산자
            int number = 10;
            Console.WriteLine(number++);
            Console.WriteLine(++number);
            Console.WriteLine(number--);
            Console.WriteLine(--number);
            Console.WriteLine(number);

            int _int = 273;
            long _long = 624235252342;
            float _float = 52.273F;
            double _double = 52.273;
            char _char = '나';
            string _string = "수현";

            Console.WriteLine((1000000000).GetType());
            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());
            Console.WriteLine((2211111111).GetType());
            Console.WriteLine((2211111111L).GetType());


            var number3 = 100;
            //var number4; error - 선언과 동시에 초기화 해야함
            var number4 = "앙";
            var number5 = 100.0;
            var number6 = 100.0F;

            *//*string input = Console.ReadLine();
            Console.WriteLine("input: " + input);*/
            /*while (true)
            {
                input = Console.ReadLine();
                if (input != "q")
                {
                    Console.WriteLine(input);
                }
                else
                {
                    break;
                }
            }*//*

            // 강제 형변환
            //long longNumber = 2147483647L + 21394932L;
            long longNumber = 100;
            int intNumber = (int)longNumber;
            Console.WriteLine(longNumber);
            Console.WriteLine(longNumber.GetType());
            Console.WriteLine(intNumber.GetType());

            // 자동 형 변환
            intNumber = 100;
            longNumber = (intNumber);
            Console.WriteLine(longNumber);
            Console.WriteLine(longNumber.GetType());
            Console.WriteLine(intNumber.GetType());

            //int -> long, float, double
            //long -> float, double;
            //char > int, long, float, double
            //float -> double

            //Widening Casting 자동 형변환 순서
            // byte-> short->char -> int -> long -> float=> double


            //강제 형변환
            //Narrowing Casting
            //double -> float -> long -> int -> char- short -> byte


            //int.Parse() / long.Parse()
            //float.Parse() /double.Parse()
            string numberString = "52273";
            //intNumber = (int)numberString;

            intNumber = int.Parse(numberString);
            Console.WriteLine(intNumber);

            try
            {
                Console.WriteLine(int.Parse("52.273"));
                Console.WriteLine(int.Parse("오십일"));
                Console.WriteLine(int.Parse("seven"));
            }
            catch(FormatException e)
            {
                Console.WriteLine("숫자로 변경할 수 없습니다.");
            }catch(Exception e)
            {
                Console.WriteLine("알 수 없는 오류: " + e.Message);
            }

            //다른 자료형 문자열로 변환
            Console.WriteLine((10).ToString());
            Console.WriteLine((52.237).ToString());
            Console.WriteLine(('A').ToString());
            Console.WriteLine((true).ToString());
            Console.WriteLine((false).ToString());

            double number2 = 62.23421;
            Console.WriteLine(number2.ToString("0.0"));
            Console.WriteLine(number2.ToString("0.00"));
            Console.WriteLine(number2.ToString("0.000"));
            Console.WriteLine(number2.ToString("0.0000"));
            Console.WriteLine(number2.ToString("0.00000"));

            Console.WriteLine(52 + "");
            Console.WriteLine(52 + 3+  "");
            Console.WriteLine(""+52 + 3);
            Console.WriteLine(52 +""+ 3);

            number = 273;
            string outputA = number + "";
            Console.WriteLine(number);

            char ch = 'a';
            string outputB = ch + "";
            //string outputB = ch;
            //string outputB = 3;
            Console.WriteLine(outputB);

            //string to bool 변환
            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("False"));
            Console.WriteLine(bool.Parse("false"));

            //최댓값 최솟값은 상수로! - 주관식으로 낼 수 있음
            Console.WriteLine(-1*int.MaxValue);
           // Console.WriteLine(-1 * int.MinValue);
            Console.WriteLine(-1L * int.MinValue);
*//*
            //Child child = new Child();



            
        }
*/
        
    }
}
