using System;

namespace p229_Constructor
{

    // 7.3 객체의 삶과 죽음: 생성자와 종료자
    //객체가 생성될 때는 생성자가 호출되고 소멸할 때는 종료자가 호출됨
    //생성자는 클래스와 이름이 같고 반환형식이 없음
    //클래스를 선언할 때 명시적으로 생성자를 구현하지 않아도 컴파일러에서 생성자를 만들어줌

    class Cat
    {
        public Cat()
        {
            Name = "";
            Color = "";
        }

        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }

        ~Cat()
        {
            Console.WriteLine($"{Name} : 잘가");
        }

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
            Cat kitty = new Cat("키티", "하얀색");
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}
