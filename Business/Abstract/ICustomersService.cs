using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICustomersService
    {
        IDataResult<List<Customers>> GetAll();
        IDataResult<Customers> GetById(int customerId);

        IResult Add(Customers customer);
        IResult Update(Customers customer);
        IResult Delete(Customers customer);
    }
}