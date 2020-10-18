using Microsoft.EntityFrameworkCore;
using SEProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class TodoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("server=.; database=UdemyTodo; integrated security=true;");
            optionsBuilder.UseSqlServer("data source=localhost;Initial Catalog=UdemyTodo;Integrated Security=True");
        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Calisma> Calismalar { get; set; }
    }
}
