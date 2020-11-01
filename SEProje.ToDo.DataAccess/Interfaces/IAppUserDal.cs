using SEProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace SEProje.ToDo.DataAccess.Interfaces
{
    public interface IAppUserDal : IGenericDal<AppUser>
    {
        List<AppUser> GetirAdminOlmayanlar();
    }
}
