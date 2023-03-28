using System;

namespace p225_BasicClass
{
    // 클래스
    //객체를 만들기 위한 설계도(틀)
    //정의: 객체를 정의해놓은 것.
    //용도: 객체를 생성할 때 사용.

    // 7.2 클래스의 선언과 객체의 선언
    class Cat
    {
        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.Color = "하얀색";
            kitty.Name = "키티";
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat(); //인스턴스
            nero.Color = "검은색";
            nero.Name = "네로";
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}
