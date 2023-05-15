using System;

namespace p253_Inheritance
{
    //7.8 상속으로 코드 재활용하기
    //콜론: 상속

    /*
    class Base // 기반클래스
    {
        public void baseMethod() //맴버선언
        {   ...   }
    }
    class Derived : Base //class 파생클래스 : 기반클래스
    {
        //아무 맴버를 선언하지 않아도 기반 클래스의 (private를 제외한) 멤버를 물려받아 갖게 됨
    }
    */

    class Base
    {
        protected string Name; // 필드
        public Base(string Name) // 생성자
        {
            this.Name = Name; // 매개변수를 받아서 필드를 초기화
            Console.WriteLine($"{this.Name}.Base()");
        }
        ~Base() // 소멸자
        { Console.WriteLine($"{this.Name}.~Base()"); }
        public void BaseMethod() // 메소드
        { Console.WriteLine($"{Name}.BaseMethod()"); }
    }
    class Derived : Base // Derived 클래스는 Base 클래스를 상속했으므로 BaseMethod()를 가짐
    {

        public Derived(string Name) : base(Name) // 생성자
                                                 // base(Name) = Base(string Name) 호출
                                                 // base()는 기반 클래스의 생성자 
        {
            // base.BaseMethod();
            // base 키워드를 통해 기반클래스에 속한 메서드에 접근 가능

            Console.WriteLine($"{this.Name}.Derived()");
        }
        ~Derived() // 종료자
        {
            Console.WriteLine($"{this.Name}.~Derived()");
        }
        public void DerivedMethod() // 메소드
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

// sealed 한정자로 수식한 클래스는 상속봉인