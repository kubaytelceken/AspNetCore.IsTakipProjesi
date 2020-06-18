using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YSKProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context;
using YSKProje.ToDo.DataAccess.Interfaces;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfBildirimRepository : EfGenericRepository<Bildirim>, IBildirimDal
    {
        public List<Bildirim> GetirOkunmayanlar(int appUserId)
        {
            using var context = new ToDoContext();
            return context.Bildirimler.Where(I => I.AppUserId == appUserId && !I.Durum).ToList();
        }

        public int GetirOkunmayanSayisiIleAppUserId(int appUserId)
        {
            using var context = new ToDoContext();
            return context.Bildirimler.Count(I => I.AppUserId == appUserId && !I.Durum);
        }
    }
}
