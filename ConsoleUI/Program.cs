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
            var result = carManager.GetAll();
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarDescription + " " + car.BrandName + " " + car.ColorName);
            }
        }
    }
}
