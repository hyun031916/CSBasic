using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSBasic3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 52, 172, 13, 13, 103 };
            intArray[2] = 0;
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);
            Console.WriteLine(intArray[4]);
            Console.WriteLine(intArray.Length);

            int[] intArray2 = new int[1000];
            Console.WriteLine(intArray2[0]);
            Console.WriteLine(intArray2[999]);

            int i = 0;
            int[] intArray3 = { 52, 273, 32, 65, 103 };
            while(i < intArray3.Length)
            {
                Console.WriteLine(i + "번째 출력: " + intArray3[i]);
                i++;
            }

           /* string input;
            do
            {
                Console.Write("입력(exit을 입력하면 종료하기): ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("밥먹기");
                        break;
                    case "2":
                        Console.WriteLine("양치하기");
                        break;
                    case "3":
                        Console.WriteLine("씻기");
                        break;
                    case "4":
                        Console.WriteLine("자기");
                        break;
                    default:
                        Console.WriteLine("선택지가 없습니다. 입력값은 1~4입니다");
                        break;
                }
            } while (input != "exit");*/
            
            /*for(int i2 = '가'; i2 <= '힣'; i2++)
            {
                Console.Write((char)i2);
            }*/

            for (int i3 = intArray3.Length -1; i3 >= 0; i3--)
            {
                Console.WriteLine(intArray3[i3]);
            }

            string[] array = { "과자", "음료수", "떡볶이", "피자", "곱창", "마라탕" };
            foreach(var item in array)
            {
                Console.Write(item+", ");
            }
            Console.Write("먹고싶다.");

            for(i = 0; i < 10; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            for(i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10 - i; j++)
                    Console.Write(" ");
                for (int j = 0; j < i + 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            string inputString = "Potato Tomato";
            inputString.ToUpper();  //return POTATO TOMATO
            Console.WriteLine(inputString); //Potato Tomato
            Console.WriteLine(inputString.ToLower());   //potato tomato
            Console.WriteLine(inputString); //Potato Tomato

            string foodString = "감자 고구마 옥수수 빵";
            string[] foods = foodString.Split(new char[] { ' ' });
            foreach(var food in foods)
            {
                Console.WriteLine(food);
            }
            string pathString = "C:\\Python27\\;C:\\Python27\\Scripts;C:\\oraclexe\\app\\oracle\\product\\11.2.0\\server\\bin;C:\\Program Files (x86)\\Common Files\\Oracle\\Java\\javapath;C:\\Program Files (x86)\\Intel\\Intel(R) Management Engine Components\\iCLS\\;C:\\Program Files\\Intel\\Intel(R) Management Engine Components\\iCLS\\;C:\\windows\\system32;C:\\windows;C:\\windows\\System32\\Wbem;C:\\windows\\System32\\WindowsPowerShell\\v1.0\\;C:\\windows\\System32\\OpenSSH\\;C:\\Program Files (x86)\\NVIDIA Corporation\\PhysX\\Common;C:\\Program Files\\Intel\\WiFi\\bin\\;C:\\Program Files\\Common Files\\Intel\\WirelessCommon\\;C:\\Program Files (x86)\\Intel\\Intel(R) Management Engine Components\\DAL;C:\\Program Files\\Intel\\Intel(R) Management Engine Components\\DAL;C:\\Program Files\\Git\\cmd;C:\\Program Files\\nodejs\\;C:\\Program Files\\dotnet\\;C:\\Program Files\\Microsoft SQL Server\\130\\Tools\\Binn\\;C:\\Program Files\\Microsoft SQL Server\\Client SDK\\ODBC\\170\\Tools\\Binn\\;%SystemRoot%\\system32;%SystemRoot%;%SystemRoot%\\System32\\Wbem;%SYSTEMROOT%\\System32\\WindowsPowerShell\\v1.0\\;%SYSTEMROOT%\\System32\\OpenSSH\\;C:\\Program Files\\java\\jdk1.8.0_241\\bin;C:\\Users\\abc\\Downloads\\gradle-7.0\\bin;C:\\Program Files\\Docker\\Docker\\resources\\bin;C:\\ProgramData\\DockerDesktop\\version-bin;C:\\Program Files\\PuTTY\\;C:\\Program Files\\Amazon\\AWSCLIV2\\;C:\\src\\flutter\\bin;C:\\apache-cassandra-3.11.10\\bin;";
            string[] paths = pathString.Split(new char[] { ';' });
            foreach (var path in paths)
                Console.WriteLine(path);

            string StrangeInput = "  test   \n  \n";
            Console.WriteLine("[" + StrangeInput + "]");
            Console.WriteLine("[" + StrangeInput.Trim() + "]");

            string[] foodsArray = { "감자", "고구마", "토마토" };
            Console.WriteLine(string.Join(", ", foodsArray));

            Console.Clear();
            Console.WriteLine("포맷 중 : 0% [__________]");
            for(int f = 0; f < 10; f++)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("포맷 중 : ");
                Console.Write((f + 1) * 10 + "% [");
                for(int f2 = 0; f2 < f+1; f2++)
                    Console.Write("#");
                for(int f2 = f+1; f2 < 10; f2++) 
                    Console.Write("_");
                Console.WriteLine("]");
                Thread.Sleep(1000);
            }
            Thread.Sleep(3000);
            int x = 1;
            while( x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);
                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");                
                else
                    Console.WriteLine("^_@");

                Thread.Sleep(1000);
                x++;
            }
        }
    }
}
