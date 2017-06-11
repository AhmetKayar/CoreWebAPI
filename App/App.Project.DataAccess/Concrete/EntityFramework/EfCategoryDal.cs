using App.Core.Dal.EntityFramework;
using App.Project.DataAccess.Abstract;
using App.Project.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Project.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, ProjectContext>, ICategoryDal
    {
    }
}
