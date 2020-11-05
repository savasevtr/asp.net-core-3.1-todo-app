using System.Collections.Generic;

namespace SEProje.ToDo.Business.Interfaces
{
    public interface IDosyaManager
    {
        string AktarPdf<T>(List<T> entity) where T : class, new();
        byte AktarExcel<T>(List<T> entity) where T : class, new();
    }
}
