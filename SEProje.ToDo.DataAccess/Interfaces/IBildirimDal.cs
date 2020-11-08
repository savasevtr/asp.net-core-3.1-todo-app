using SEProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace SEProje.ToDo.DataAccess.Interfaces
{
    public interface IBildirimDal : IGenericDal<Bildirim>
    {
        List<Bildirim> GetirOkunmayanlar(int AppUserId);
    }
}
