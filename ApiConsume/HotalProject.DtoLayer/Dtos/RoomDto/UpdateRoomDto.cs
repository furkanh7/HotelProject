﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotalProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Numarasını Yazınız")]

        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Görseli Giriniz")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lüttfen Fiyat Bilgisi Giriniz")]
       
        public int Price { get; set; }
        [Required(ErrorMessage = "Lüttfen Oda Başlığı Bilgisi Giriniz")]
        [StringLength (100,ErrorMessage ="Lütfen En fazla 100 Karakter Veri Girişi Yapınız")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lüttfen Yatak Sayısı Giriniz")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lüttfen Banyo Sayısı Giriniz")]
        public string BathCount { get; set; }

        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen Açıklamayı Yazınız")]
        public string Description { get; set; }
    }
}