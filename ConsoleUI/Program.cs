// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete;

//CustomerTest();
LoanTest();

static void CustomerTest()
{
    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

    foreach (var customer in customerManager.GetAll())
    {
        Console.WriteLine(customer.Name);
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

