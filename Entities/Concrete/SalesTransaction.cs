using Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SalesTransaction : BaseEntity, IEntity
    {
        public string ProductName { get; set; }
        public string CustomerName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Piece { get; set; }
        public decimal TotalPrice { get; set; }


    }
}
