using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage ="Hizmet ikon linkini giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage ="Hizmet başlığını giriniz")]
        [StringLength(30,ErrorMessage ="Başlık en fazla 30 karakter olabilir")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Hizmet açıklamasını giriniz")]
        [StringLength(100,ErrorMessage ="Hizmet açıklaması en fazla 100 karakter olabilir")]
        public string Description { get; set; }
    }
}
