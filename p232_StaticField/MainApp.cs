using System;

// 7.4 정적 필드와 메소드
//static 정적 움직이지 않음
//메소드나 필드가 클래스의 인스턴스가 아닌 클래스 자체에 소속되도록 지정하는 한정자
//static으로 수식한 필드는 프로그램 전체에 걸쳐 하나밖에 존재하지 않음
//정적 메소드는 클래스의 인스턴스를 생성하지 않아도 호출이 가능

class Global
{
    public static int Count = 0;
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