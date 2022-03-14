using System;
using System.Collections.Generic;
using System.Text;

namespace task13
{
    class Car:Vehicle
    {
        public string Brand;
        public string Model;
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;

        public Car(int Year,string Brand,string Model,double FuelCapacity, double FuelFor1Km):base(Year)
        {
            this.Brand = Brand; this.Model = Model;this.FuelCapacity = FuelCapacity;this.FuelFor1Km = FuelFor1Km;           
        }
        public Car(int Year,string Brand, string Model, double FuelCapacity, double FuelFor1Km,double CurrentFuel):this(Year,Brand,Model,FuelCapacity,FuelFor1Km)
        {
            this.CurrentFuel = CurrentFuel;
        }
        public Car(int Year, string Brand, string Model, double FuelCapacity, double FuelFor1Km, double CurrentFuel, string Color):this(Year, Brand, Model, FuelCapacity, FuelFor1Km,CurrentFuel)
        {
            this.Color = Color;
        }
      
        public void ShowInfo()
        {
            Console.WriteLine("Mashinin istehsal tarixi : " + Year);
            Console.WriteLine("Mashinin markasi : " + Brand);
            Console.WriteLine("Mashinin modeli  : " + Model);
            Console.WriteLine("Mashinin umumi benzin tutumu : "+ FuelCapacity+"L");
            Console.WriteLine("Mashinin 1KM ucun benzin serfiyyati : "+FuelFor1Km+"L" );
            Console.WriteLine("Mashinda hall hazinda olan benzin miqdari : "+ CurrentFuel+"L");
        }
        public void Drive(double yol)
        {
            double LazimOlanYanacaq = yol * FuelFor1Km;
            if (LazimOlanYanacaq<CurrentFuel)
            {
                Console.WriteLine("Mashinda kifayet qeder benzin var.Teyin olunmush menteqeye getdikden sonra bakda qalacaq yanacaq miqdari : "+(CurrentFuel-LazimOlanYanacaq)+"L");
            }
            else
            {
                Console.WriteLine("Mashinda kifayet qeder benzin yoxdu");
            }
            


        }

    }
}
