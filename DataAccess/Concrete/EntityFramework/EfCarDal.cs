using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 CarDescription = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Set<Car>().Where(x => x.BrandId == brandId).ToList();
            }
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Set<Car>().Where(x => x.BrandId == colorId).ToList();
            }
        }
    }
}
