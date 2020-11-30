using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Category : IEntity
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}
