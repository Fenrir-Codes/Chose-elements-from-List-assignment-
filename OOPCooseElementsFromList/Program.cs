using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPListOpgave
{
    class Program
    {

        class Car
        {
            public int Id { get; set; }
            public string Model { get; set; }
            public string Brand { get; set; }
            public int Year { get; set; }
            public int Price { get; set; }
            public string Color { get; set; }

            public Car()
            {

            }

            public Car(int id, string model, string brand, int year, int price, string color)
            {

                Id = id;
                Model = model;
                Brand = brand;
                Year = year;
                Price = price;
                Color = color;

            }
            public string WriteModel()
            {
                return $"Models: {Id}\t{Model}\t{Brand}\t{Year}\t{Price}\t{Color}";
            }

        }

        static void Main(string[] args)
        {
            //Opgave A
            //Dan liste med alle tal mindre end eller lig 0
            //Dan liste med alle tal lig 7 ?
            //dan liste med alle tal større end 4

            List<int> numList = new List<int>() { 4, 7, 12, 17, -3, 8, 0, -45, 101 };

            List<int> mindreliste = numList.Where(num => num <= 0).ToList();
            List<int> ligemedsyv = numList.Where(num => num == 7).ToList();
            List<int> storreend4 = numList.Where(num => num > 4).ToList();

            Console.WriteLine("alle tal mindre end eller lig 0: ");

            mindreliste.Sort();
            mindreliste.ForEach(udskrivLister);
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("alle tal lig 7: ");
            ligemedsyv.ForEach(udskrivLister);
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("alle tal større end 4: ");
            storreend4.Sort();
            storreend4.ForEach(udskrivLister);
            Console.ReadKey(true);
            Console.Clear();




            //Opgave B____________________________________________________________________________________________________

            Car Car1 = new Car(1, "Rio", "Kia", 2006, 250000, "Red");
            Car Car2 = new Car(2, "Rio", "Kia", 2007, 265000, "Black");
            Car Car3 = new Car(3, "Panda", "Fiat", 2017, 265000, "Black");
            Car Car4 = new Car(4, "Panda", "Fiat", 2017, 365000, "Yellow");
            Car Car5 = new Car(5, "S40", "Volvo", 2018, 665000, "White");
            Car Car6 = new Car(6, "S65", "Volvo", 2018, 600000, "White");
            Car Car7 = new Car(7, "Gorm", "Ferrari", 2000, 4665000, "White");
            Car Car8 = new Car(8, "Gorm", "Ferrari", 2018, 4665000, "White");

            List<Car> CarList = new List<Car>() { Car1, Car2, Car3, Car4, Car5, Car6, Car7, Car8 };

            Console.WriteLine("All Rio models: \n");
            foreach (var item in CarList.FindAll(element => element.Model.Contains("Rio"))) // rio models
            {
                Console.WriteLine(item.WriteModel());
            }
            Console.ReadKey(true); Console.Clear();

            //-------------------------------------------------------------------------------------------------------
            Console.WriteLine("All Ferrari models: \n");
            foreach (var item in CarList.FindAll(element => element.Brand.Contains("Ferrari"))) // ferrari cars
            {
                Console.WriteLine(item.WriteModel());
            }
            Console.ReadKey(true); Console.Clear();

            //-------------------------------------------------------------------------------------------------------
            Console.WriteLine("White colored models: \n");
            foreach (var item in CarList.FindAll(element => element.Color.Contains("White"))) // white colored models
            {
                Console.WriteLine(item.WriteModel());
            }
            Console.ReadKey(true); Console.Clear();

            //-------------------------------------------------------------------------------------------------------

            Console.WriteLine("Year 2010 and over: \n");
            foreach (var item in CarList.FindAll(element => element.Year >= 2010)) // year 2010 and over...
            {
                Console.WriteLine(item.WriteModel());
            }
            Console.ReadKey(true); Console.Clear();

            //-------------------------------------------------------------------------------------------------------

            Console.WriteLine("All models with ID 8: \n");
            foreach (var item in CarList.FindAll(element => element.Id == 8)) // where id == 8
            {
                Console.WriteLine(item.WriteModel());
            }
            Console.ReadKey(true); Console.Clear();


        }

        public static void udskrivLister(int x)
        {

            Console.Write("{0}\t | ", x);


        }

    }
}
