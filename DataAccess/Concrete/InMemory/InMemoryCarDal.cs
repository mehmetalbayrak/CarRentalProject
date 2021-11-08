using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car { CarId = 1, BrandId = 1, ColorId = 1, ModelYear = "2020", DailyPrice = 15000,Description="BMW 335i 310 Beygir" },
            new Car { CarId = 2, BrandId = 2, ColorId = 2, ModelYear = "2021", DailyPrice = 200000,Description="Tesla Model S Plaid" },
            new Car { CarId = 3, BrandId = 3, ColorId = 3, ModelYear = "2021", DailyPrice = 500000,Description="Chevrolet Camora" },
            };
        }
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }
    }
}
