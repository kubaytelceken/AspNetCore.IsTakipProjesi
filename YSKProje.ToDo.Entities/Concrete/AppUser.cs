﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.Entities.Interfaces;

namespace YSKProje.ToDo.Entities.Concrete
{
    public class AppUser : IdentityUser<int>,ITablo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Picture { get; set; } = "default.png";

        //bir kullanıcının birden fazla görevi olabilir. o yüzden liste ile görevleri çekecegiz.
        public List<Gorev> Gorevler { get; set; }
        public List<Bildirim> Bildirimler { get; set; }

    }
}
