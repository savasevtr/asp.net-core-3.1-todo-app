using SEProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace SEProje.ToDo.Business.Interfaces
{
    public interface IAppUserService
    {
        List<AppUser> GetirAdminOlmayanlar();
    }
}
