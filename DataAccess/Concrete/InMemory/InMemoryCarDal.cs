using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car> {
            new Car {Id = 1 , BrandId =  1 , ColorId = 1 , DailyPrice = 250 , Description = "Muscle Car" , ModelYear=2016 },
            new Car {Id = 2 , BrandId =  2 , ColorId = 2 , DailyPrice = 1000 , Description = "Luxe Car" , ModelYear=2020 },
            new Car {Id = 3 , BrandId =  3 , ColorId = 3 , DailyPrice = 750 , Description = "Sport Car" , ModelYear=2018 }
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(car);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByColorId(int ColorID)
        {
          return  _car.Where(c => c.ColorId == ColorID).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUptade = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUptade.Id = car.Id;
            carToUptade.ColorId = car.ColorId;
            carToUptade.BrandId = car.BrandId;
            carToUptade.DailyPrice = car.DailyPrice;
            carToUptade.DailyPrice = car.DailyPrice;
            carToUptade.ModelYear = car.ModelYear;
        }
    }
}
