﻿using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Business.Interfaces
{
    public interface IRaporService : IGenericService<Rapor>
    {
        Rapor GetirGorevIleId(int id);
        int GetirRaporSayisiIleAppUserId(int id);
        int GetiRaporSayisi();
    }
}
