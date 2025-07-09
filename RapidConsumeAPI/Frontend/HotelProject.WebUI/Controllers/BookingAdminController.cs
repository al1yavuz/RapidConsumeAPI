using HotelProject.WebUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient(); //consume edilmesi için istemci oluşturdum.
            var responseMessage = await client.GetAsync("http://localhost:5093/api/Booking");//daha sonra bu adrese istekte bulundum.
            if (responseMessage.IsSuccessStatusCode) //eğer adresten başarılı bir durum kodu dönerse gelen veriyi jsonData değişkenine atadım
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
