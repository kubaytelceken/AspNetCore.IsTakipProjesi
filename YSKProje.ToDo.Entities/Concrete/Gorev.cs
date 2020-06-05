using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using YSKProje.ToDo.Entities.Interfaces;

namespace YSKProje.ToDo.Entities.Concrete
{
    public class Gorev : ITablo
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public DateTime OlusturulmaTarih { get; set; } = DateTime.Now;
        public bool Durum { get; set; }
        //bir görevin bir aciliyet durumu olabilir.foreign key ile
        public int AciliyetId { get; set; }
        public Aciliyet Aciliyet { get; set; }
        //bir görevin bir kullanıcısı vardır.
        public int? AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        //bir görevin birden fazla raporu vardır.
        public List<Rapor> Raporlar { get; set; }
    }
}
