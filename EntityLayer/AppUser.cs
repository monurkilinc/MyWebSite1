using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    //nO:136 IdentityUserdan miras alarak SQL deki ASPNETUSER tablosuna ekleme amaçlandı
    public class AppUser:IdentityUser
    {

        public string NameSurname { get; set; }
        public string ImageURL { get; set; }
    }
}
