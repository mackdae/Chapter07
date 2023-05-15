using System;

namespace p229_Constructor
{
    // 7.3 객체의 삶과 죽음: 생성자와 종료자
    //객체가 생성될 때는 생성자가 호출되고 소멸할 때는 종료자가 호출됨
    //생성자는 클래스와 이름이 같고 반환형식이 없음


    class Cat
    {
        public string Name; // 필드
        public string Color; // 필드
        public void Meow() // 메소드
        {
            Console.WriteLine($"{Name} : 야옹");
        }

        // 생성자는 클래스의 멤버 변수를 초기화하는 특수한 메소드
        // 클래스 선언시에 구현하지 않으면 컴파일러가 매개변수 없는 기본생성자를 만들어줌

        public Cat() // public한정자 Cat()생성자 Cat클래스명 (매개변수)
        { // 생성자를 하나라도 직접 정의하면 컴파일러가 기본생성자를 만들지 않기 때문에 직접 정의
            Name = "";
            Color = "";
        }

        public Cat(string _Name, string _Color) // 생성자도 다른 메소드처럼 오버로딩이 가능
        { // 객체를 생성할 때 이름과 색을 매개변수로 입력받아 초기화
            Name = _Name;
            Color = _Color;
        }

        ~Cat() // 종료자 (=소멸자) Destructor
            // 가비지 컬렉터가 객체가 소멸되는 시점을 판단하여 호출
            // 가비지 컬렉터가 언제 동작할지 예측할 수 없으므로 사용하지 않길 권장
            // 다른 기능을 사용하는 편이 메모리 관리 측면에서 효율적
        {
            Console.WriteLine($"{Name} : 잘가");
        }

    }
class MainApp
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.Name = "키티";
            kitty.Color = "하얀색";
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");

            // 가비지 컬렉터가 객체를 소멸시키는 순서에 보장이 없으므로 "잘가" 출력은 매 실행시 달라짐
        }
    }
}