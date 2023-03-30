using System;

namespace p247_AccessModifier
{
    //7.7 접근 한정자로 공개 수준 결정하기

    //객체지향 프로그래밍의 3대 특성: 은닉성, 상속성, 다형성
    //은닉성: 클래스의 사용자에게 필요한 최소의 기능만 노출하고 내부를 감춤
    //상수를 제외한 필드는 무조건 감추는 것이 좋다

    // * public * 클래스 내외부 모든곳에서 접근가능
    // * protected * 클래스 외부에서 접근불가, 파생클래스에서 접근가능
    // * private * 클래스의 내부에서만 접근가능, 파생클래스에서도 접근불가
    // internal 같은 어셈블리에 있는 코드에서만 public으로 접근가능, 그외 private
    // protected internal 같은 어셈블리에 있는 코드에서만 protected로 접근가능, 그외 private
    // pribate protected 같은 어셈블리에 있는 클래스에서 상속받은 클래스 내부에서만 접근가능
    // 어셈블리: 컴파일을 통해 나온 결과 파일 및 배포의 단위
    // 접근한정자로 수식하지 않은 클래스의 맴버는 무조건 private로 자동지정됨

    //예시
    //private int Myfield_1;
    //protected int MyField_2;
    //int MyField_3;
    //public int MyMethod_1()
    //{...}
    //internal void MyMethod_1()
    //{...}

    class WaterHeater
    {
        protected int temperature;
        public void SetTemperature(int temperature)
        {
            if (temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperature range");
            }
            this.temperature = temperature;
        }
        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn on water : {temperature}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-2);
                heater.TurnOnWater();

                heater.SetTemperature(50);
                heater.TurnOnWater();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //트라이캐치는 마지막 방어수단. 고투처럼 흐름을 깸
            //클라이언트에선 거의 안씀 서버쪽에선 주구장창 씀
        }
    }
}