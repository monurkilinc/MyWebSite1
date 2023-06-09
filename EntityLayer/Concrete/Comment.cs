using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        //NO:8 COMMENT PROPLARI EKLENDI
        [Key]//No:11 ID IFADELERI PRIMARY KEY OLARAK TANIMLAMAK İÇİN KULLANILDI
        public int CommentID { get; set; }
        public string CommentUserName { get; set; }
        public string CommentContent { get; set; }
        public string CommentTitle { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }

        //No:99 Blog Reyting tablosu için eklendi
        public int BlogScore { get; set; } 


        //NO:16 Blog ve Comment tabloları arasında ilişki kurulması
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}
