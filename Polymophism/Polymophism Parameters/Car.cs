using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism_Parameters
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        protected CarIdInfo carIdInfo = new CarIdInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIdInfo.IDNum = idNum;
            carIdInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and is owned by {1}", carIdInfo.IDNum, carIdInfo.Owner);
        }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public Car()
        {

        }

        public void ShowDetails()
        {
            Console.WriteLine("HP: " + HP + " color:" + Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }

    }
}
