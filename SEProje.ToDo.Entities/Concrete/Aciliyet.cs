using System.Collections.Generic;

namespace SEProje.ToDo.Entities.Concrete
{
    public class Aciliyet
    {
        public int Id { get; set; }
        public string Tanim { get; set; }

        public List<Gorev> Gorevler { get; set; }
    }
}