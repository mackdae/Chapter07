using System;

// p232_StaticField

// 7.4 정적 필드와 메소드
// static 정적 움직이지 않음
// 메소드나 필드가 클래스의 인스턴스가 아닌 클래스 자체에 소속되도록 지정하는 한정자

// 인스턴스는 여러개지만 클래스는 단 하나 = static 수식 멤버는 프로그램 전체에 하나만 존재
// 프로그램 전체에 걸쳐 공유해야 하는 멤버가 있다면 static 이용

// static 멤버는 클래스의 인스턴스를 생성하지 않고 직접 호출 가능


class Global
{
    public static int Count = 0; // 정적 필드
}
class ClassA
{
    public ClassA()
    {
        Global.Count++;
    }
}
class ClassB
{
    public ClassB()
    {
        Global.Count++;
    }
}
class MainApp
{
    static void Main()
    {
        Console.WriteLine($"Global.Count : {Global.Count}");

        new ClassA();
        new ClassA();
        new ClassB();
        new ClassB();

        Console.WriteLine($"Global.Count : {Global.Count}");
    }
}

// 정적 필드의 단점
// 상태 공유의 위험: 정적 필드는 모든 인스턴스가 공유하기 때문에, 여러 인스턴스에서 해당 필드의 값을 변경할 수 있습니다.
// 이로 인해 의도하지 않은 상태 공유가 발생할 수 있고, 프로그램의 복잡성과 오류 가능성을 증가시킬 수 있습니다.

// 상태 변경의 전역적 영향: 정적 필드의 값이 변경되면, 해당 클래스에 속한 모든 인스턴스가 영향을 받게 됩니다.
// 이는 프로그램의 유지 보수성을 저하시킬 수 있으며, 코드의 이해와 디버깅을 어렵게 만들 수 있습니다.

// 스레드 안전성 문제: 정적 필드는 여러 스레드에서 동시에 접근할 수 있으므로 스레드 안전성을 보장해야 합니다.
// 정적 필드에 동기화 기능을 추가하지 않으면 경합 상태(race condition)와 같은 문제가 발생할 수 있습니다.

// 유연성 제한: 정적 필드는 클래스 수준에서 공유되기 때문에, 해당 필드의 값을 변경하기 어렵습니다.
// 이는 유연성을 제한하고 의존성을 증가시킬 수 있습니다.
// 특히 테스트와 같은 상황에서 원하는 값으로 대체하기 어렵게 만들 수 있습니다.