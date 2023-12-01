using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILoanService
    {
        List<BaseLoan> GetAll();
        List<BaseLoan> GetByCustomerId(int customerId);
        List<LoanDetailDto> GetLoanDetails();
        void Add(BaseLoan loan);
        BaseLoan GetLoanById(int loanId);
    }
}
