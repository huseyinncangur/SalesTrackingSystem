using Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BaseCustomer:BaseEntity,IEntity
    {
        public int CustomerNumber { get; set; }
    }
}
