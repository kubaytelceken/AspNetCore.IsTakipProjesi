using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.DataAccess.Interfaces;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _userDal;
        public AppUserManager(IAppUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<DualHelper> EnCokGorevdeCalisanPersoneller()
        {
            return _userDal.EnCokGorevdeCalisanPersoneller();
        }

        public List<DualHelper> EnCokGorevTamamlamisPersoneller()
        {
            return _userDal.EnCokGorevTamamlamisPersoneller();
        }

        public List<AppUser> getirAdminOlmayanlar()
        {
            return _userDal.getirAdminOlmayanlar();
        }

        public List<AppUser> getirAdminOlmayanlar(out int toplamSayfa,string aranacakKelime, int aktifSayfa)
        {
            return _userDal.getirAdminOlmayanlar(out toplamSayfa,aranacakKelime,aktifSayfa);
        }

        public List<AppUser> GetirHepsi()
        {
            throw new NotImplementedException();
        }

        public AppUser GetirIdile(int id)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(AppUser tablo)
        {
            throw new NotImplementedException();
        }

        public void Kaydet(AppUser tablo)
        {
            throw new NotImplementedException();
        }

        public void Sil(AppUser tablo)
        {
            throw new NotImplementedException();
        }
    }
}
