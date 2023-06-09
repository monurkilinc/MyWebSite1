using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApiDemo.Controllers
{
    [AllowAnonymous]
    //No:130 APİ Yİ WEB PROJESİNDE ÇAĞIRMAK İSTERSEK AŞAĞIDAKİ route u KULLANACAĞIZ
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var c = new Context();
            var values=c.Employees.ToList();
            //No:130 API kavramında Ok kavramı döndürülür
            return Ok(values);
        }
        //nO:131 POSTMAN İLE VERİ EKLEME İÇİN EKLENDİ
        [HttpPost]
        public IActionResult EmployeeAdd(Employee employee)
        {
            using var c=new Context();
            c.Add(employee);
            c.SaveChanges();
            return Ok(); 
        }
        //No:132 APİLER İLE VERİ GETİRME
        [HttpGet("{id}")]
        public IActionResult EmployeeGet(int id)
        {
            using var c = new Context();
            var employee = c.Employees.Find(id);
            if (employee == null) 
            {
                return NotFound();
            }
            else
            {
                return Ok(employee);
            }
        }
        //No:133 APİLERLE VERİ SİLME İŞLEMİ İÇİN EKLENEN ACTİON
        [HttpDelete("{id}")]
        public IActionResult EmployeeDelete(int id) 
        {
            using var c= new Context();
            var employee=c.Employees.Find(id);

            if (employee == null)
            {
                return NotFound();

            }
            else
            {
                c.Remove(employee);
                c.SaveChanges();
                return Ok();
            }
            
        }
        //No:133 APİLERLE VERİ GÜNCELLEME İŞLEMİ İÇİN EKLENEN ACTİON
        [HttpPut]
        public IActionResult EmployeeUpdate(Employee employee) 
        {
            using var c=new Context();
            var emp = c.Find<Employee>(employee.ID);
            if (emp == null)
            {
                return NotFound();
            }
            else
            {
                emp.Name = employee.Name;
                c.Update(emp);
                c.SaveChanges();
                return Ok();
            }
        }

    }
}
