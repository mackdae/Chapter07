using System;

namespace p281_Structure
{
    // 7.17 구조체
    //클래스의 사촌, 필드와 메소드를 가짐

    //복합데이터형식: 클래스, 구조체
    //class 대신 struct 키워드 사용
    //class 클래스는 실세계의 객체를 추상화하기 위해 존재
    //struct 구조체는 데이터를 담기 위한 자료구조로 사용
    //자료구조: 데이터를 효율적으로 접근하고 조작할 수 있게 데이터 구조를 만들어 관리하는 것
    //따라서 굳이 은닉성을 비롯한 객체지향원칙을 강하게 적용하지 않고
    //편의를 위해 필드를 public으로 선언하는 경우가 많음
    //클래스는 참조형식, 구조체는 값형식: 성능의 이점

    // new 생성자 없이 선언만으로 인스턴스 생성
    // 값형식이라 상속불가

    struct Point3D // 구조체
    {
        public int X; // 필드
        public int Y; // 필드
        public int Z; // 필드

        public Point3D(int X, int Y, int Z) // 메소드
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public override string ToString() // System.Object 형식의 ToString() 메소드를 오버라이딩
        {
            return string.Format($"{X},{Y},{Z}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Point3D p3d1; // 구조체는 선언만으로도 인스턴스 생성. (기본데이터 형식처럼 new 생성자가 없어도 됨)
            p3d1.X = 10;
            p3d1.Y = 20;
            p3d1.Z = 40;

            Console.WriteLine(p3d1.ToString());

            Point3D p3d2 = new Point3D(100, 200, 300); // 생성자를 이용한 인스턴스 생성도 가능
            Point3D p3d3 = p3d2; // 구조체의 인스턴스를 다른 인스턴스에 할당하면 깊은복사
            p3d3.Z = 400;

            Console.WriteLine(p3d2.ToString());
            Console.WriteLine(p3d3.ToString());
        }
    }
}

// 변경불가능 구조체 선언 readonly 키워드
//readonly struct 구조체명
//{ }
// readonly 키워드를 사용한 구조체의 모든 필드는 readonly로 선언되어야 함

// 읽기전용 메소드는 구조체에서만 선언 가능

//7.18 튜플
//튜플도 여러 필드를 담을 수 있는 구조체
//형식이름 없음, 값형식
//즉석사용 복합데이터 형식을 선언할 때 적합.
//필드의 이름을 지정하지 않은 튜플: 명명되지 않은 튜플