using System.ComponentModel.DataAnnotations;

namespace BlogApiDemo.DataAccessLayer
{
    public class Employee
    {
        //No:129 APİLERE GİRİŞ İŞLEMİ İÇİN EKLENDİ

        [Key] 
        public int ID { get; set; }
        public string? Name { get; set; }
    }
}
