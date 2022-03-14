 using System;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(2015,"BMW", "528(f10 twin turbo)",70,0.1,20,"Black");
            car.ShowInfo();
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");
            car.Drive(50);
        }
    }
}
