// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete;

CustomerTest();
//LoanTest();

static void CustomerTest()
{
    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

    var result = customerManager.GetAll();

    foreach (var customer in result.Data)
    {
        Console.WriteLine(customer.Name + " " + customer.Surname);
    }
}

static void LoanTest()
{
    LoanManager loanManager = new LoanManager(new EfLoanDal());

    foreach (var loan in loanManager.GetLoanDetails())
    {
        Console.WriteLine(loan.LoanName + " --- " + loan.NationalId);
    }
}

