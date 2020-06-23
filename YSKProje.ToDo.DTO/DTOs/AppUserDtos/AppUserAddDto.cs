using System;
using System.Collections.Generic;
using System.Text;

namespace YSKProje.ToDo.DTO.DTOs.AppUserDtos
{
    public class AppUserAddDto
    {
        //[Required(ErrorMessage = "Kullanıcı adı boş geçilemez.")]
        //[Display(Name = "Kullanıcı Adı :")]
        public string UserName { get; set; }

        //[DataType(DataType.Password)]
        //[Required(ErrorMessage = "Parola boş geçilemez.")]
        //[Display(Name = "Parola :")]
        public string Password { get; set; }

        //[DataType(DataType.Password)]
        //[Display(Name = "Parola Tekrar :")]
        //[Compare("Password", ErrorMessage = "Parolalar eşleşmiyor.")]
        public string ConfirmPassword { get; set; }

        //[Display(Name = "Email :")]
        //[EmailAddress(ErrorMessage = "Geçersiz Email")]
        //[Required(ErrorMessage = "Email boş geçilemez.")]
        public string Email { get; set; }

        //[Display(Name = "Ad :")]
        //[Required(ErrorMessage = "Ad geçilemez.")]
        public string Name { get; set; }

        //[Display(Name = "Soyad :")]
        //[Required(ErrorMessage = "Soyad boş geçilemez.")]
        public string Surname { get; set; }
    }
}
