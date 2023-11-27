using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        public int RoomId { get; set; }

        [Required(ErrorMessage = "Lütfen oda numarası giriniz")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage ="Lütfen oda görselini giriniz")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage ="Lütfen oda sayısını giriniz")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısı bilgisi giriniz")]
        public string BedCount { get; set; }

        [Required]
        public string BathCount { get; set; }

        public string Wifi { get; set; }

        [Required(ErrorMessage ="Lütfen açıklamayı yazınız")]
        public string Description { get; set; }
    }
}
