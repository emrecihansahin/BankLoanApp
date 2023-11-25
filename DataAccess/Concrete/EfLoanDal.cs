using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfLoanDal : ILoanDal
    {
        public void Add(BaseLoan entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(BaseLoan entity)
        {
            throw new NotImplementedException();
        }

        public List<BaseLoan> GetAll(Expression<Func<BaseLoan, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public BaseLoan GetT(Expression<Func<BaseLoan, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(BaseLoan entity)
        {
            throw new NotImplementedException();
        }
    }
}
