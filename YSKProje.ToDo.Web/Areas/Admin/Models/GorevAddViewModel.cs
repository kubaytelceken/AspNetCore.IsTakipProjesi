using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YSKProje.ToDo.Web.Areas.Admin.Models
{
    public class GorevAddViewModel
    {
        [Required(ErrorMessage ="Ad Alanı Gereklidir.")]
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        [Range(0,int.MaxValue,ErrorMessage ="Lütfen Geçerli Bir Aciliyet Durumu Seçiniz.")]
        public int AciliyetId { get; set; }


    }
}
