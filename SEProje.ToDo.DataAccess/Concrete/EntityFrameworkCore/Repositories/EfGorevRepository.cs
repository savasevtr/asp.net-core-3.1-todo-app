﻿using SEProje.ToDo.DataAccess.Interfaces;
using SEProje.ToDo.Entities.Concrete;

namespace SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGorevRepository : EfGenericRepository<Gorev>, IGorevDal
    {
        
    }
}