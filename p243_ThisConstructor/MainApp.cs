using System;

namespace p243_ThisConstructor
{
    //7.6.2 this()생성자
    // this는 객체 자신을 가리킴
    // this()는 자신의 생성자를 가리킴

    class MyClass
    {
        int a, b, c;
        public MyClass() // 생성자
        {
            this.a = 5425;
            Console.WriteLine("MyClass()");
        }
        //public MyClass(int bb)
        //{
        //    this.a = 5425;
        //    this.b = bb;
        //    Console.WriteLine("MyClass()");
        //}
        //public MyClass(int bbb, int ccc)
        //{
        //    this.a = 5425;
        //    this.b = bbb;
        //    this.b = ccc;
        //    Console.WriteLine("MyClass()");
        //}

        // this()로 중복 개선
        public MyClass(int bb) : this() // this() = MyClass()를 호출
        {
            this.b = bb;
            Console.WriteLine($"MyClass({b})");
        }
        public MyClass(int bbb, int ccc) : this(bbb) // this(int) = MyClass(int)를 호출
        {
            this.c = ccc;
            Console.WriteLine($"MyClass({b},{c})");
        }
        public void PrintFields()
        { Console.WriteLine($"a:{a}, b:{b}, C:{c}"); }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.PrintFields();
            Console.WriteLine();

            MyClass b = new MyClass(1);
            b.PrintFields();
            Console.WriteLine();

            MyClass c = new MyClass(10,20);
            c.PrintFields();
        }
    }
}