using App.Core.Dal.EntityFramework;
using App.Project.DataAccess.Abstract;
using App.Project.Entites.Concrete;

namespace App.Project.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, ProjectContext>, ICategoryDal
    {
    }
}
