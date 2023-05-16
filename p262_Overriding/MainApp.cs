using System;

namespace p262_Overriding
{
    // 7.10 오버라이딩(재정의)과 다형성
    //다형성: 객체가 여러 형체를 가질 수 있음.
    //하위형식다형성의 준말, 파생클래스를 통해 다형성을 실현
    //오버라이딩: virtual, override

    class ArmorSuite // 아머수트
    {
        public virtual void Initialize() // 초기메소드
        // 오버라이딩할 메소드는 virtual(가상) 키워드로 한정
        { Console.WriteLine("Armored"); } // 아머드
    }
    class IronMan : ArmorSuite // 아이언맨 : 아머수트 상속
    {
        public override void Initialize() // 초기메소드 오버라이드(재정의) 
        // 오버라이드 하는 메소드는 override(재정의) 키워드로 한정
        {
            base.Initialize(); // 기반클래스의 초기메소드 호출 // 아머드
            Console.WriteLine("Repulsor Rays Armed"); // 리펄서레이 장비
        }
    }
    class WarMachine : ArmorSuite // 워머신 : 아머수트 상속
    {
        public override void Initialize() // 초기메소드 오버라이드(재정의) 
        {
            base.Initialize(); // 기반클래스의 초기메소드 호출 // 아머드
            Console.WriteLine("Double-Barrel Cannons Armed"); // 더블베럴캐논 장비
            Console.WriteLine("Micro-Rocket Launcher Armed"); // 소형로켓런처 장비
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating ArmorSuite...");
            ArmorSuite armorsuite = new ArmorSuite();
            armorsuite.Initialize();

            Console.WriteLine("\nCreating IronMan...");
            ArmorSuite ironman = new IronMan();
            ironman.Initialize();

            Console.WriteLine("\nCreating WarMachine...");
            ArmorSuite warmachine = new WarMachine();
            warmachine.Initialize();
        }
    }
}