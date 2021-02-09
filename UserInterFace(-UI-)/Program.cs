using Business.Concrete;
using DataAccess.Concrete.EntityFramwork;
using DataAccess.Concrete.InMemory;
using System;

namespace UserInterface__UI__
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager();
            //BrandManager();
        }

        private static void BrandManager()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + " " + brand.BrandName);
            }
        }

        private static void CarManager()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(" Car Name : " + car.CarName);
                Console.WriteLine(" Car Brand : " + car.BrandName);
                Console.WriteLine(" Car Color : " + car.ColorName);
                Console.WriteLine(" Car Daily Price : " + car.DailyPrice);
                Console.WriteLine("        *-------*           " );
            }
        }
    }
}
