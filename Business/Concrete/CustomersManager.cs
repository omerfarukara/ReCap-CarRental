using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CustomersManager : ICustomersService
    {
        readonly ICustomersDal _customerDal;

        public CustomersManager(ICustomersDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customers customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customers customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customers>> GetAll()
        {
            var getAll = _customerDal.GetAll();
            return new SuccessDataResult<List<Customers>>(getAll);
        }

        public IDataResult<Customers> GetById(int customerId)
        {
            var getById = _customerDal.Get(u => u.UserId == customerId);
            return new SuccessDataResult<Customers>(getById);
        }

        public IResult Update(Customers customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}