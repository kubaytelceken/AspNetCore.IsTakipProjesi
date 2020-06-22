using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Business.Interfaces
{
    public interface IGorevService : IGenericService<Gorev>
    {
        List<Gorev> GetirAciliyetIleTamamlanmayan();
        List<Gorev> GetirTumTablolarla();
        List<Gorev> GetirTumTablolarla(Expression<Func<Gorev, bool>> filter);
        List<Gorev> GetirTumTablolarlaTamamlanmayan(out int toplamSayfa, int userId, int aktifSayfa=1);
        Gorev GetirAciliyetIdIle(int id);
        List<Gorev> GetirileAppUserId(int appuserId);
        Gorev GetirRaporlarileId(int id);
        int GetirGorevSayisiTamamlananIleAppUserId(int id);
        int GetirGorevSayisiTamamlanmasiGerekenIleAppUserId(int id);
        int GetirAtanmayıBekleyenGörevSayisi();
        int GetirTamamlanmisGorevSayisi();
    }
}
