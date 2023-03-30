using System;

namespace p253_Inheritance
{
    //7.8 상속으로 코드 재활용하기

    /*
    class Base // 기반클래스
    {
        public void baseMethod() //맴버선언
        {
        }
    }
    class Derived : Base //class 파생클래스 : 기반클래스
    {
        //아무 맴버를 선언하지 않아도 기반 클래스의 모든 것을 물려받아 갖게 됨
        //private는 제외
    }
    */

    class Base
    {
        protected string Name;
        public Base(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Base()");
        }
        ~Base()
        {
            Console.WriteLine($"{this.Name}.~Base()");
        }
        public void BaseMethod()
        {
            Console.WriteLine($"{Name}.BaseMethod()");
        }
    }
    class Derived : Base
    {
        public Derived(string Name) : base(Name)
        {
            Console.WriteLine($"{this.Name}.Derived()");
        }
        ~Derived()
        {
            Console.WriteLine($"{this.Name}.~Derived()");
        }
        public void DerivedMethod()
        {
            Console.WriteLine($"{Name}.DerivedMethod()");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();
        }
    }
}
