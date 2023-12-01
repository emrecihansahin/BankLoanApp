using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LoanManager : ILoanService
    {
        ILoanDal _loanDal;

        public LoanManager(ILoanDal loanDal)
        {
            _loanDal = loanDal;
        }

        public void Add(BaseLoan loan)
        {
            _loanDal.Add(loan);
        }

        public List<BaseLoan> GetAll()
        {
            return _loanDal.GetAll();
        }

        public List<BaseLoan> GetByCustomerId(int customerId)
        {
            return _loanDal.GetAll(l => l.CustomerId == customerId);
        }

        public BaseLoan GetLoanById(int loanId)
        {
            return _loanDal.Get(l => l.LoanId == loanId);
        }

        public List<LoanDetailDto> GetLoanDetails()
        {
            return _loanDal.GetLoanDetails();
        }
    }
}
