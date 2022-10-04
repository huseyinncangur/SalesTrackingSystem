using Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:BaseEntity, IEntity
    {
        public int BrandId{ get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
        public int Piece { get; set; }



    }
}
