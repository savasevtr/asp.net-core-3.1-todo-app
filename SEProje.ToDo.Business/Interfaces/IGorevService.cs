using SEProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace SEProje.ToDo.Business.Interfaces
{
    public interface IGorevService : IGenericService<Gorev>
    {
        List<Gorev> GetirAciliyetIleTamamlanmayan();
        List<Gorev> GetirTumTablolarla();
        Gorev GetirAclliyetIleId(int id);
        List<Gorev> GetirileAppUserId(int appUserId);
    }
}