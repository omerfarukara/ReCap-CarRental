using Business.Concrete;
using DataAccess.Concrete.EntityFramwork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // UserTest();
            // CustomerTest();

            RentalsManager rentalManager = new RentalsManager(new EfRentalDal());

            var rental = rentalManager.Add(new Rentals
            {
                CarId = 1,
                CustomerId = 2,
                RentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
            });

            Console.WriteLine(rental.Message);
        }

        private static void CustomerTest()
        {
            CustomersManager customerManager = new CustomersManager(new EfCustomerDal());

            var listCustomers = customerManager.GetAll();

            foreach (var customer in listCustomers.Data)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }

        private static void UserTest()
        {
            UsersManager userManager = new UsersManager(new EfUsersDal());

            var listUsers = userManager.GetAll();

            foreach (var user in listUsers.Data)
            {
                Console.WriteLine(user.FirstName);
            }
        }
    }
}