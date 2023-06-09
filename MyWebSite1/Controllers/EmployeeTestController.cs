using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace MyWebSite1.Controllers
{
    public class EmployeeTestController : Controller
    {
        //No:134 API LER ASYNC İLE ÇALIŞIR
        public async Task<IActionResult> Index()
        {
            var htttpClient=new HttpClient();
            //No:134 SWAGGER/GET/REQUEST URL ADRESİ
            var responseMessage = await htttpClient.GetAsync("https://localhost:44390/api/Default");
            var jsonString=await responseMessage.Content.ReadAsStringAsync();
            var values=JsonConvert.DeserializeObject<List<Class1>>(jsonString);

            return View(values);
        }
        //No:134 APİLERLE PROJEYE ADD İŞLEMİ
        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }
        //No:134 APİLERLE PROJEYE ADD İŞLEMİ
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Class1 p)
        {
            var htttpClient=new HttpClient();
            var jsonEmployee=JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(jsonEmployee,Encoding.UTF8,"application/json");
            var responseMessage = await htttpClient.PostAsync("https://localhost:44390/api/Default",content);
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction();
            }
            return View(p);
        }
        //No:135 apilerle düzenleme işlemi için yazıldı
        [HttpGet]
        public async Task<IActionResult> EditEmployee(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44390/api/Default/"+id);
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonEmployee=await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<Class1>(jsonEmployee);
                return View(values);
            }
            return RedirectToAction("Index","EmployeeTest");
        }
        //No:135 apilerle düzenleme işlemi için yazıldı

        [HttpPost]
        public async Task<IActionResult> EditEmployee(Class1 p)
        {
            var httpClient = new HttpClient();
            var jsonEmployee=JsonConvert.SerializeObject(p);
            var content=new StringContent(jsonEmployee,Encoding.UTF8,"application/json");
            var responseMessage = await httpClient.PutAsync("https://localhost:44390/api/Default/",content);
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "EmployeeTest");
            }
            return View(p);
        }
        //No:135 apilerle silme işlemi için yazıldı
   
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync("https://localhost:44390/api/Default/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "EmployeeTest");

            }
            return View();
        }
    }
    public class Class1
    {
        public int ID { get; set; }
        public string? Name { get; set; }

    }
}
