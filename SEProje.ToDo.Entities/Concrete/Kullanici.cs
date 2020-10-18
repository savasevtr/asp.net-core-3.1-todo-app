﻿using SEProje.ToDo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEProje.ToDo.Entities.Concrete
{
    public class Kullanici : ITablo
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public List<Calisma> Calismalar { get; set; }
    }
}
