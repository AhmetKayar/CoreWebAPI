using App.Core.Dal;
using App.Project.Entites.Concrete;

namespace App.Project.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //Diğer Standart dışı methodlar buraya yazılacak.
    }
}
