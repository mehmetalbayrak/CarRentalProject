using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            foreach (var car in result.Data)
            {
                //Console.WriteLine(car.Description + " " + car.DailyPrice);
                Console.WriteLine(car.CarDescription + " " + car.BrandName + " " + car.ColorName);
            }

        }
    }
}
