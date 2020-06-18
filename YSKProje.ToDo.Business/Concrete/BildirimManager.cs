using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.DataAccess.Interfaces;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Business.Concrete
{
    public class BildirimManager : IBildirimService
    {
        private readonly IBildirimDal _bildirimDal;
        public BildirimManager(IBildirimDal bildirimDal)
        {
            _bildirimDal = bildirimDal;
        }
        public List<Bildirim> GetirHepsi()
        {
            return _bildirimDal.GetirHepsi();
        }

        public Bildirim GetirIdile(int id)
        {
            return _bildirimDal.GetirIdile(id);
        }

        public List<Bildirim> GetirOkunmayanlar(int appUserId)
        {
            return _bildirimDal.GetirOkunmayanlar(appUserId);
        }

        public int GetirOkunmayanSayisiIleAppUserId(int appUserId)
        {
            return _bildirimDal.GetirOkunmayanSayisiIleAppUserId(appUserId);
        }

        public void Guncelle(Bildirim tablo)
        {
            _bildirimDal.Guncelle(tablo);
        }

        public void Kaydet(Bildirim tablo)
        {
            _bildirimDal.Kaydet(tablo);
        }

        public void Sil(Bildirim tablo)
        {
            _bildirimDal.Sil(tablo);
        }
    }
}
