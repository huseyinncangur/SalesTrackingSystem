using Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CorporateCustomer:BaseEntity,IEntity
    {
        public string CompanyName { get; set; }
        public int TaxNumber { get; set; }


    }
}
