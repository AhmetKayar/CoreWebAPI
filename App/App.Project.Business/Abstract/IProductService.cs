using App.Project.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Project.Business.Abstract
{
    public interface IProductService:IServiceBase<Product>
    {
        Task<List<Product>> GetProductDisabled();
    }
}
