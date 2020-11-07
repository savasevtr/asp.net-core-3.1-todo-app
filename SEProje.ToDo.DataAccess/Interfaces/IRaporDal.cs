using SEProje.ToDo.Entities.Concrete;

namespace SEProje.ToDo.DataAccess.Interfaces
{
    public interface IRaporDal : IGenericDal<Rapor>
    {
        Rapor GetirGorevileId(int id);
    }
}
