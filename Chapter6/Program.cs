﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    abstract class AbstractParent
    {
        public abstract void Test();
    }
    class AbstractChild: AbstractParent
    {
        public override void Test() { }
    }
    class Parent
    {
        public int variable = 273;
        public void Method()
        {
            Console.WriteLine("부모의 메서드");
        }
    }
    class Child : Parent
    {
        public new string variable = "shadowing";
        public new void Method()
        {
            Console.WriteLine("자식의 메서드");
        }
    }
    class Animal
    {
        public int Age { get; set; }
        public Animal() { this.Age = 0; }
        public void Eat() { Console.WriteLine("냠냠 먹습니다"); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다"); }
    }
    class Dog : Animal
    {
        public string Color { get; set; }
        public void Bark() { Console.WriteLine("왈왈 짓습니다."); }
    }
    class Cat : Animal
    {
        public void Meow() { Console.WriteLine("냐옹 웁니다."); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Cat(), new Dog()
            };
            foreach(var item in Animals)
            {
                item.Eat();
                item.Sleep();
                ((Cat)item).Meow();
            }
        }
    }
}
