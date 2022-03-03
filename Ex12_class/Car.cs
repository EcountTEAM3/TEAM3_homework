using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_class
{
    //요구사항
    //자동차는 이름을 가지고 있다, 자동차는 색상을 가지고 있다.
    //자동차는 기본 이름과 색상을 가지고 있고 요구에 따라 이름과 색상을 바꿀수 있다.
    //자동차를 생성하고 자동차의 이름과 색상 정보를 확인할수있다.
    //자동차 생성 후에는 자동차의 이름과 색상을 변경할 수 없습니다. 단 이름과 색상을 별도로 조회 가능
    class Car
    {
        string name;
        string color;

        public Car()
        {
            this.name = "hyendae";
            this.color = "gray";
        }

        public Car(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public string Name
        {
            get { return this.name; }
                
         }

        public string Color
        {
            get { return this.color; }
        }

        public void CarInfo()
        {
            Console.WriteLine($"Car name : {this.name}, Car color : {this.color}");
        }
        
    }
}
