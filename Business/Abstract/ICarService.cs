using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService 
    {
        IDataResult<List<Car>> GetAll();                    // +
        IDataResult<List<Car>> GetAllBrandId(int id);       // +
        IDataResult<List<Car>> GetAllColorId(int id);       // +
        IDataResult<List<CarDetailDto>> GetCarDetails();    // +
        IResult Add(Car car);                               // +
        IResult Delete(Car car);                            // -
        IResult Update(Car car);                            // -

    }
}
