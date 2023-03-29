using System;

namespace p240_This
{
    // 7.6 this 키워드

    class Employee
    {
        private string Name; //private 접근제한자
        private string Position;
        // 접근제한자에 접근하는 방법 get,set
        // getter setter 검색해보기
        // getset 2중작업을 하는 이유: 보안성

        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetPosition(string Position)
        {
            this.Position = Position;
        }
        public string GetPosition()
        {
            return this.Position;
            //암호화예시
            //var arr = this.Position.ToCharArray();
            //for (int i = 0; i < arr.Length; i++)
            //    arr[i] = (char)(arr[i] + 10);
            //return new 다음뭐였지
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Employee pooh = new Employee();
            pooh.SetName("Pooh");
            pooh.SetPosition("Waiter");
            Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

            Employee tigger = new Employee();
            tigger.SetName("Tigger");
            tigger.SetPosition("Cleaner");
            Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");
        }
    }
}
