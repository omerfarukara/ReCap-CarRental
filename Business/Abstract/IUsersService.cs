using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUsersService
    {
        IDataResult<List<Users>> GetAll();
        IDataResult<Users> GetById(int userId);

        IResult Add(Users user);
        IResult Update(Users user);
        IResult Delete(Users user);
    }
}