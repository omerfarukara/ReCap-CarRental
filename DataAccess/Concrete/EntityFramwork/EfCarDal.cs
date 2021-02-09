﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramwork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result =  from c in context.Car 
                              join b in context.Brand 
                              on c.BrandId equals b.BrandId
                              join co in context.Color
                              on c.ColorId equals co.ColorId
                              select new CarDetailDto
                             {
                                 CarName = c.CarName, 
                                 BrandName = b.BrandName, 
                                 ColorName = co.ColorName, 
                                 DailyPrice = c.DailyPrice 
                             };
                return result.ToList();
            }
        }
    }
}
