using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.DataAccess.Interfaces
{
    public interface IGorevDal : IGenericDal<Gorev>
    {
        List<Gorev> GetirAciliyetIleTamamlanmayan();
        List<Gorev> GetirTumTablolarla();
        List<Gorev> GetirTumTablolarla(Expression<Func<Gorev,bool>>filter);
        List<Gorev> GetirTumTablolarlaTamamlanmayan(out int toplamSayfa, int userId,int aktifSayfa);
        List<Gorev> GetirileAppUserId(int appuserId);
        Gorev GetirAciliyetIdIle(int id);
        Gorev GetirRaporlarileId(int id);
        int GetirGorevSayisiTamamlananIleAppUserId(int id);
        int GetirGorevSayisiTamamlanmasiGerekenIleAppUserId(int id);
    }
}
