using App.Project.Business.Abstract;
using App.Project.DataAccess.Abstract;
using App.Project.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Project.Business.Concrete
{
    public class CategoriyManager : ManagerBase<ICategoryDal, Category>, ICategoryService
    {
        public CategoriyManager(ICategoryDal manager) : base(manager)
        {
        }
    }
}
