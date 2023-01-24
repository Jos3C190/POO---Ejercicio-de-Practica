using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Cellphone = new Cellphone();
            Cellphone.Model = "Samsung Galaxy S22 Ultra";
            Cellphone.BatteryCharging = 25;
            Cellphone.ModelYear = 2022;

            //Cellphone.NoBatteryCharge();
            Cellphone.FullCharge();

            String message = $"Modelo: {Cellphone.Model} \n" +
                $"Carga de la bateria: {Cellphone.BatteryCharging}% \n" +
                $"Año del modelo: {Cellphone.ModelYear}. Por lo que {Cellphone.ModelYearCellphone()} \n";
            Console.WriteLine(message);

            //----------------------------------------------

            var Animal = new Animal();
            Animal.Name = "Perro";
            Animal.Age = 8;
            Animal.Weight = 16;

            Animal.EatLittle();

            String message2 = $"Animal: {Animal.Name} \n" +
                $"Peso: {Animal.Weight} kg \n" +
                $"Edad: {Animal.Age} años ({Animal.AgeCondition()}) \n";
            Console.WriteLine(message2);

            //----------------------------------------------

            var Vehicle = new Vehicle();
            Vehicle.Model = "BMW Serie 4 Coupe";
            Vehicle.Mileage = 35000;
            Vehicle.Year = 2021;

            Vehicle.IncreaseDailyMileage();

            String message3 = $"Modelo: {Vehicle.Model} \n" +
                $"Kilometraje: {Vehicle.Mileage} km \n" +
                $"Año: {Vehicle.Year} \n" +
                $"{Vehicle.NumberYears()}";
            Console.WriteLine(message3);


            Console.ReadKey();
        }
    }
}
