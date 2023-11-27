using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BaseLoan:IEntity
    {
        [Key]
        public int LoanId { get; set; }
        public int CustomerId { get; set; }
        public string LoanName { get; set; }
        public double MonthlyInterestRate { get; set; }
        
    }
}
