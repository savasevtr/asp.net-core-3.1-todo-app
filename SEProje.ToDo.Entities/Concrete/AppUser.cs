using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SEProje.ToDo.Entities.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Picture { get; set; }
        public List<Gorev> Gorevler { get; set; }
    }
}