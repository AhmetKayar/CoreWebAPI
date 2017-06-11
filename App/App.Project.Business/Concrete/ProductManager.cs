using App.Project.Business.Abstract;
using App.Project.DataAccess.Abstract;
using App.Project.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Project.Business.Concrete
{
    public class ProductManager : ManagerBase<IProductDal, Product>, IProductService
    {
        IProductDal _manager;
        public ProductManager(IProductDal manager) : base(manager)
        {
            _manager = manager;
        }

        public Task<List<Product>> GetProductDisabled()
        {
            return _manager.GetList(null, null);
        }
    }
}
