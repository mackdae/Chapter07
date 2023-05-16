using System;

namespace p258_TypeCasting
{
    // 7.9 기반클래스와 파생 클래스 사이의 형변환, is와 as
    // 기반클래스와 파생클래스 사이에는 형변환이 가능하며
    // 파생클래스의 인스턴스는 기반클래스의 인스턴스로도 사용가능 (코드 생산성 업)
    // is 객체가 해당 형식에 해당하는지 검사하여 bool값 반환
    // as 형변환 연산자와 같은 역할, 형변환 실패시 참조값을 null로 만듦. (형변환 연산자는 실패시 예외처리)

    class Mammal // 포유류
    {
        public void Nurse() // 수유 메소드
        { Console.WriteLine("Nurse()"); }
    }

    class Dog : Mammal // 개:포유류
    {
        public void Bark() // 멍멍 메소드
        { Console.WriteLine("Bark()"); }
    }

    class Cat : Mammal // 고양이:포유류
    {
        public void Meow() // 야옹 메소드
        { Console.WriteLine("Meow()"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammalA = new Dog(); // 포유류타입 포유류A 선언, 새로운 개타입 객체 참조 할당
            // 업캐스팅: 부모 클래스 타입의 변수에 자식 클래스의 객체를 할당, 자동
            Dog dogA = (Dog)mammalA; // 개타입 개A 선언, 포유류타입 포유류A의 참조값을 할당 (형변환)
            // 다운캐스팅: 자식 클래스 타입의 변수에 부모 클래스의 객체를 할당, 형변환 연산자로 명시
            // 다운캐스팅은 기반클래스 타입의 변수가 실제로 파생클래스의 객체를 참조하고 있을 때 작동

            //Cat catB = (Cat)new Mammal(); 불가능
            // 형변환 해도 컴파일러는 해당 객체를 여전히 본래 클래스 타입으로 인식하고 본래클래스에 정의된 멤버에만 접근 가능.
            // 포유류 객체는 수유메소드만 갖고있기에 개타입에 넣으면 멍멍메소드에 접근할 수 없어서 컴파일에러

            // 부모타입에 자식객체 넣기 가능, 자식타입에 부모객체 넣기 불가능

            Mammal mammal1 = new Dog(); // 포유류타입 포유류1 선언, 개타입 객체 할당
            Dog dog1; // 개형식 개1 선언

            // is 객체가 해당 형식에 해당하는지 검사하여 bool값 반환
            if (mammal1 is Dog) // 포유류타입 포유류1이 개타입 객체면
            { 
                dog1 = (Dog)mammal1; // 개1에 (형변환)포유류1 할당
                dog1.Bark(); // 멍멍
            }

            Mammal mammal2 = new Cat(); // 포유류타입 포유류2 선언, 고양이타입 객체 할당

            // as 형변환 연산자와 같은 역할, 형변환 실패시 참조값을 null로 만듦. (형변환 연산자는 실패시 예외처리)
            Cat cat1 = mammal2 as Cat; // = (Cat)mammal2; // 고양이타입 고양이1 선언, 포유류2 형변환 할당
            if (cat1 != null) // 할당 성공시
                cat1.Meow(); // 야옹

            Cat cat2 = mammal1 as Cat; // 고양이타입 고양이2 선언, 포유류1 형변환 할당
            if (cat2 != null) // 할당 성공시
                cat2.Meow(); // 야옹
            else // 할당 실패시
                Console.WriteLine("cat2 is not a Cat"); // 고양이2는 고양이가 아님
        }
    }
}