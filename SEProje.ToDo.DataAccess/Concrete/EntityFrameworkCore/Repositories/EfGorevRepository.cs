using Microsoft.EntityFrameworkCore;
using SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context;
using SEProje.ToDo.DataAccess.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGorevRepository : EfGenericRepository<Gorev>, IGorevDal
    {
        public List<Gorev> GetirAciliyetIleTamamlanmayan()
        {
            using (var context = new TodoContext())
            {
                return context.Gorevler.Where(x => x.Durum == false).Include(x => x.Aciliyet).OrderByDescending(x => x.OlusturmaTarihi).ToList();
            }
        }
    }
}