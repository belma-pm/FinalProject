using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Product:IEntity
    {
        public int ProductId { get; set; }
        public string CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }

        public Product SingleOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
