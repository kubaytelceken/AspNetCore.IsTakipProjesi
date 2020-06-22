using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.DataAccess.Interfaces
{
    public interface IRaporDal : IGenericDal<Rapor>
    {
        Rapor GetirGorevIleId(int id);
        int GetirRaporSayisiIleAppUserId(int id);
        int GetiRaporSayisi();
    }
}
