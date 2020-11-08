﻿using SEProje.ToDo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEProje.ToDo.Entities.Concrete
{
    public class Bildirim : ITablo
    {
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}