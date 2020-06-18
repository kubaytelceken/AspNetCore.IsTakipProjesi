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
    public class EfRaporRepository : EfGenericRepository<Rapor>, IRaporDal
    {
        public Rapor GetirGorevIleId(int id)
        {
            using var context = new ToDoContext();
            return context.Raporlar.Include(I => I.Gorev).ThenInclude(I=>I.Aciliyet).Where(I => I.Id == id).FirstOrDefault();
        }

        public int GetirRaporSayisiIleAppUserId(int id)
        {
            using var context = new ToDoContext();
            var result= context.Gorevler.Include(I => I.Raporlar).Where(I => I.AppUserId == id);
            return result.SelectMany(I => I.Raporlar).Count();
            

        }
    }
}
