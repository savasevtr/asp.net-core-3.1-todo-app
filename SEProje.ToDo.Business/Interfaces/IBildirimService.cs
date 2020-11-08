using SEProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace SEProje.ToDo.Business.Interfaces
{
    public interface IBildirimService : IGenericService<Bildirim>
    {
        List<Bildirim> GetirOkunmayanlar(int AppUserId);
    }
}