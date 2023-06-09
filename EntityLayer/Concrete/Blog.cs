using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        //NO:6 BLOG PROPERTYLERI EKLENDİ

        [Key]//No:11 ID IFADELERI PRIMARY KEY OLARAK TANIMLAMAK İÇİN KULLANILDI
        public int? BlogID { get; set; }

        public string? BlogTitle { get; set; }
        public string? BlogContent { get; set; }

        //KUCUK GÖRSELLER
        public string? BlogThumbNailImage { get; set; } 

        //BUYUK GÖRSELLER
        public string? BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }

        //No:15 Category tablosu ile Blog tablosunu ilişkilendirdik
        public int CategoryID { get; set; }
        public  Category? Category { get; set; }

        //No:79 Blog-yazar ilişkisi için ekledik
		public int WriterID { get; set; }
		public Writer? Writer { get; set; }

		//NO:16 Blog ve Comment tabloları arasında ilişki kurulması
		public List<Comment>?Comments { get; set; }
    }
}
