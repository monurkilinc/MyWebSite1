using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        //NO:5 Category'e ait propertylerin eklenmesi
        //No:11 ID IFADELERI PRIMARY KEY OLARAK TANIMLAMAK İÇİN KULLANILDI
      
		[Key]
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }

        //No:15 Category tablosu ile Blog tablosunu ilişkilendirdik
        public List<Blog>? Blogs { get; set; }
    }
}
