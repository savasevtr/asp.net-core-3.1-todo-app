using SEProje.ToDo.Entities.Concrete;

namespace SEProje.ToDo.Business.Interfaces
{
    public interface IRaporService : IGenericService<Rapor>
    {
        Rapor GetirGorevileId(int id);
    }
}
