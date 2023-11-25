using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Surname { get; set; }
        public string NationalId { get; set; }
        public int LoanId { get; set; }
    }
}
