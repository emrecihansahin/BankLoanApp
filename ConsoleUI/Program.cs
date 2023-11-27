// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete;

CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

foreach (var customer in customerManager.GetAll())
{
    Console.WriteLine(customer.Name);
}
