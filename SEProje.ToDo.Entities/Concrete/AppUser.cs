using Microsoft.AspNetCore.Identity;
using SEProje.ToDo.Entities.Interfaces;
using System.Collections.Generic;

namespace SEProje.ToDo.Entities.Concrete
{
    public class AppUser : IdentityUser<int>, ITablo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Picture { get; set; }
        public List<Gorev> Gorevler { get; set; }
    }
}