﻿using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Business.Interfaces
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        List<AppUser> getirAdminOlmayanlar();
        List<AppUser> getirAdminOlmayanlar(out int toplamSayfa, string aranacakKelime, int aktifSayfa = 1);
    }
}
