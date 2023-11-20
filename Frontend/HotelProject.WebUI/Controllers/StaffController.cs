using HotelProject.WebUI.Models.Staff;
using HotelProject.WebUI.Models.Testimonial;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class StaffController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public StaffController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5134/api/Testimonial");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<TestimonialViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddTestimonial(TestimonialViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5134/api/Testimonial", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responsemesage = await client.DeleteAsync($"http://localhost:5134/api/Testimonial/{id}"); // Dolar işareti parametre geldiğinin göstergesidir

            if (responsemesage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateStaff(int id)
        {
            var client=_httpClientFactory.CreateClient();  
            var responsemessage=await client.GetAsync($"http://localhost:5134/api/Testimonial/{id}");

            if (responsemessage.IsSuccessStatusCode)
            {
                var jsondata = await responsemessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<UpdateViewModel>(jsondata);
                return View(values);
            }
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> UpdateStaff(UpdateViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsondata=JsonConvert.SerializeObject(model);    
            StringContent stringContent = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var responsemessage = await client.PutAsync("http://localhost:5134/api/Testimonial/", stringContent);

            if (responsemessage.IsSuccessStatusCode)
            {
                
                return RedirectToAction("Index");
            }
            return View();

        }

    }
}
