using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete
{
    public class EfLoanDal : EfEntityRepository<BaseLoan, NorthwindContext>, ILoanDal
    {
        public List<LoanDetailDto> GetLoanDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from l in context.Loans
                             join c in context.Customers
                             on l.CustomerId equals c.CustomerId
                             select new LoanDetailDto 
                             { 
                                 LoanName = l.LoanName, 
                                 NationalId = c.NationalId 
                             };
                return result.ToList();
            }
        }
    }
}