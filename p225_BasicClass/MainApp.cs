using System;

namespace p225_BasicClass
{
    // 클래스
    //객체를 만들기 위한 설계도(틀)
    //정의: 객체를 정의해놓은 것.
    //용도: 객체를 생성할 때 사용.

    // 7.2 클래스의 선언과 객체의 선언
    class Cat // 클래스 Cat은 청사진, 실체가 아님.
    {
        public string Name; // 필드
        public string Color; // 필드
        // 클래스 안에 선언된 변수 = 필드
        public void Meow() // 메소드
        {
            Console.WriteLine($"{Name} : 야옹");
        }
        // 필드, 메소드, 프로퍼티, 이벤트 등 클래스 내에서 선언된 요소들 = 멤버
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            //인스턴스(실체)
            Cat kitty = new Cat(); // kitty 객체 생성
            // new생성자호출연산자 Cat()생성자
            // 클래스는 복합 데이터 형식 = 참조형식
            // Cat kitty; 생성자가 없으면 kitty = null
            int a = new int();
            //new연산자와 생성자는 모든 데이터형식에 사용 가능하지만 변수선언에는 생략됨

            kitty.Color = "하얀색";
            kitty.Name = "키티";
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            //인스턴스(실체)
            Cat nero = new Cat(); // nero 객체 생성
            nero.Color = "검은색";
            nero.Name = "네로";
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}