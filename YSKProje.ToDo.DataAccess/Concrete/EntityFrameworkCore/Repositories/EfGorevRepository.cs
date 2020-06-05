using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YSKProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context;
using YSKProje.ToDo.DataAccess.Interfaces;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGorevRepository : EfGenericRepository<Gorev>, IGorevDal
    {
        public Gorev GetirAciliyetIdIle(int id)
        {
            using var context = new ToDoContext();
            return context.Gorevler.Include(I => I.Aciliyet).FirstOrDefault(I => !I.Durum && I.Id == id);
        }

        public Gorev GetirRaporlarileId(int id)
        {
            using var context = new ToDoContext();
            return context.Gorevler.Include(I => I.Raporlar).Include(I=>I.AppUser).Where(I => I.Id == id).FirstOrDefault();
        }


        public List<Gorev> GetirAciliyetIleTamamlanmayan()
        {
            using var context = new ToDoContext();
            return context.Gorevler.Include(I => I.Aciliyet).Where(I => !I.Durum).OrderByDescending(I => I.OlusturulmaTarih).ToList();
        }

        public List<Gorev> GetirileAppUserId(int appuserId)
        {
            using var context = new ToDoContext();
            return context.Gorevler.Where(I => I.AppUserId == appuserId).ToList();
        }

        public List<Gorev> GetirTumTablolarla()
        {
            using var context = new ToDoContext();
            return context.Gorevler.Include(I => I.Aciliyet).Include(I=>I.Raporlar).Include(I=>I.AppUser).Where(I => !I.Durum).OrderByDescending(I => I.OlusturulmaTarih).ToList();
        }


    }
}
