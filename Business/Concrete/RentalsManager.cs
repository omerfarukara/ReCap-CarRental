using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class RentalsManager : IRentalsService
    {
        readonly IRentalsDal _rentalDal;

        public RentalsManager(IRentalsDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rentals rental)
        {
            var rentalsReturnDate = _rentalDal.GetAll(r => r.CarId == rental.CarId);

            if (rentalsReturnDate.Count > 0)
            {
                foreach (var rentalReturnDate in rentalsReturnDate)
                {
                    if (rentalReturnDate.ReturnDate == null)
                    {
                        return new ErrorResult(Messages.RentalReturnDateIsNull);
                    }
                }
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rentals rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            var getAll = _rentalDal.GetAll();
            return new SuccessDataResult<List<Rentals>>(getAll);
        }

        public IDataResult<Rentals> GetById(int rentalId)
        {
            var getById = _rentalDal.Get(u => u.Id == rentalId);
            return new SuccessDataResult<Rentals>(getById);
        }

        public IResult Update(Rentals rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}