using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcEgitimi.Models
{
    public class Uye
    {
        public int Id { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        public string Telefon { get; set; }
        [Required,MaxLength(11,ErrorMessage ="TC maksimum 11 haneli olmalı."),MinLength(11, ErrorMessage = "TC minimum 11 haneli olmalı."),
            DisplayName("TC Kimlik Numarası")]
        public string TCKimlikNo { get; set; }
        [Required,DisplayName("Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [Required,DisplayName("Şifre"),DataType(DataType.Password),StringLength(20,MinimumLength =5)]
        public string Sifre { get; set; }
        [Required, DisplayName("Şifre Tekrar"), DataType(DataType.Password), StringLength(20, MinimumLength = 5),Compare("Sifre")]
        public string SifreTekrar { get; set; }
        [Required,DisplayFormat(DataFormatString ="{0:dd.MM.yyy}"),DisplayName("Doğum Tarihi"),DataType(DataType.Date)]
        public string DogumTarihi { get; set; }
    }
}