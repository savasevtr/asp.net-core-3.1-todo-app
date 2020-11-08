using SEProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SEProje.ToDo.Business.Interfaces
{
    public interface IGorevService : IGenericService<Gorev>
    {
        List<Gorev> GetirAciliyetIleTamamlanmayan();
        List<Gorev> GetirTumTablolarla();
        List<Gorev> GetirTumTablolarla(Expression<Func<Gorev, bool>> filter);
        List<Gorev> GetirTumTablolarlaTamamlanan(out int pageCount, int userId, int currentPage = 1);
        Gorev GetirAclliyetIleId(int id);
        List<Gorev> GetirileAppUserId(int appUserId);
        Gorev GetirRaporlarileId(int id);
        int GetirGorevSayisiTamamlananileAppUserId(int id);
        int GetirGorevSayisiTamamlanmayanileAppUserId(int id);
        int GetirGorevSayisiAtanmayiBekleyen();
        int GetirGorevSayisiTamamlanan();
    }
}