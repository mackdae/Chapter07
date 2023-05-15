using System;

namespace p240_This
{
    // 7.6 this 키워드
    // 객체 내부에서 자신의 필드나 메소드에 접근할 때 this 키워드 사용
    // 객체 외부에서 접근할 때 객체의 이름(변수 또는 식별자) 사용

    class Employee
    {
        private string Name; // private 접근제한자, 클래스 내부에서만 접근 가능
        private string Position; // 본래 필드 식별자는 소문자로 시작함이 명명규칙
        // 대문자시작: 파스칼케이스 // 소문자시작: 카멜케이스

        // private 접근제한자에 접근하는 방법 get,set
        // getter setter를 사용하는 이유: 데이터 보호

        // getter setter
        // 객체의 속성에 접근하고 값을 설정하기 위한 메소드
        // 객체의 상태를 캡슐화하고 외부와의 상호 작용을 제어할 수 있습니다.

        // getter setter 메소드 사용
        public void SetName(string Name) // 매개변수에 입력받은 이름을 Name 필드에 저장
        { this.Name = Name; } // this.Name는 자신의 필드, Name은 매개변수
                              // 이름이 같아도 this.로 구분가능
        public string GetName() // Name필드값을 반환
        { return Name; }

        public void SetPosition(string Position)
        { this.Position = Position; }
        public string GetPosition()
        { return this.Position; }

        // 프로퍼티Property 사용
        // getter와 setter 메소드를 간편하게 정의하고 사용할 수 있는 방법
        public string PropertyName
        {
            get { return Name; }
            set { Name = value; }
        }
        public string PropertyPosition
        {
            get { return Position; }
            set { Position = value; }
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Employee pooh = new Employee();
            pooh.SetName("Pooh");
            pooh.SetPosition("Waiter");
            Console.WriteLine($"{pooh.GetName()}, {pooh.GetPosition()}");

            Employee tigger = new Employee();
            tigger.PropertyName = "Tigger";
            tigger.PropertyPosition ="Cleaner";
            Console.WriteLine($"{tigger.PropertyName}, {tigger.PropertyPosition}");
        }
    }
}