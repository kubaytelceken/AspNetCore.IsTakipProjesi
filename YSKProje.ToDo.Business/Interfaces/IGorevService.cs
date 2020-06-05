using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Business.Interfaces
{
    public interface IGorevService : IGenericService<Gorev>
    {
        List<Gorev> GetirAciliyetIleTamamlanmayan();
        List<Gorev> GetirTumTablolarla();
        Gorev GetirAciliyetIdIle(int id);
        List<Gorev> GetirileAppUserId(int appuserId);
        Gorev GetirRaporlarileId(int id);
    }
}
