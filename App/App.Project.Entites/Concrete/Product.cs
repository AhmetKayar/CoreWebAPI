using App.Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Project.Entites.Concrete
{
    public class Product : IEntity
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public long CategoryId { get; set; }

        public virtual Category Categories { get; set; }
    }
}
