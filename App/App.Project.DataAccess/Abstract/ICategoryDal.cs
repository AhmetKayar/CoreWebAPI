using App.Core.Dal;
using App.Project.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Project.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
