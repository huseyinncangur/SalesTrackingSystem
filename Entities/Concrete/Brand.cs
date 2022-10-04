﻿using Core.Entities;

using Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Brand:BaseEntity,IEntity
    {
        public string Name { get; set; }
        public ICollection<Product> products { get; set; }

    }
}
