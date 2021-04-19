﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        string Var = "테스트";
        static void Main(string[] args)
        {
            var name = "김" + "수" + "현";
           

            var alpha = "알파";
            //var 0319 = "숫자 변수 안돼요";
            var 김수현 = "한글 변수 된다";
            //string ❤ = "이모지는 안 된다.";

            // 인라인 주석
            /*
             * 여러 줄 주석
             */
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

        }
    }
}
