using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YSKProje.ToDo.Web.Areas.Admin.Models
{
    public class AppUserListViewModel
    {
        public int Id { get; set; }
        [Display(Name="Ad :")]
        [Required(ErrorMessage ="Ad Alanı Boş Geçilemez.")]
        public string Name { get; set; }
        [Display(Name = "Soyad :")]
        [Required(ErrorMessage = "Soyad Alanı Boş Geçilemez.")]
        public string Surname { get; set; }
        [Display(Name = "Email :")]
        public string Email { get; set; }
        [Display(Name = "Resim :")]
        public string Picture { get; set; }
    }
}
