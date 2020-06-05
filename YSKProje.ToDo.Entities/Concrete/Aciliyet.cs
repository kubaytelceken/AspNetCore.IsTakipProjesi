﻿using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.Entities.Interfaces;

namespace YSKProje.ToDo.Entities.Concrete
{
    public class Aciliyet : ITablo
    {
        public int Id { get; set; }
        public string Tanim { get; set; }


        //aciliyeti olan birden fazla görev olabilir.
        public List<Gorev> Gorevler { get; set; }
    }
}
