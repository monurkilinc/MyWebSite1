using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        //No:120 Admin Paneli Admin Tablosu(Static4/Default.cshtml) için eklendi
        [Key]
        public int AdminID {get; set;}
        public string UserName {get; set;}
        public string Password {get; set;}
        public string Name {get; set;}
        public string ShortDescription {get; set;}
        public string ImageURL {get; set;}
        public string Role {get; set;}
        public string AdminEmail {get; set;}
        public string AdminAdress {get; set;}
        public string AdminContact { get; set;}



    }
}
