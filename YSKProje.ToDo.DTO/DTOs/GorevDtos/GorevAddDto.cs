using System;
using System.Collections.Generic;
using System.Text;

namespace YSKProje.ToDo.DTO.DTOs.GorevDtos
{
    public class GorevAddDto
    {
        //[Required(ErrorMessage = "Ad Alanı Gereklidir.")]
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        //[Range(0, int.MaxValue, ErrorMessage = "Lütfen Geçerli Bir Aciliyet Durumu Seçiniz.")]
        public int AciliyetId { get; set; }
    }
}
