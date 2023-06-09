using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        //NO:7 WRITER PROPERTYLERI EKLENDİ
        [Key] //No:11 ID IFADELERI PRIMARY KEY OLARAK TANIMLAMAK İÇİN KULLANILDI
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public string WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }

        //No:79 Blog-Write ilişkisi için eklendi
		public List<Blog>? Blogs { get; set; }

        //No:106 Mesaj-Yazar ilişkisi için eklendi
        public virtual ICollection<Message2> WriterSender { get; set; }
        public virtual ICollection<Message2> WriterReceiver { get; set; }


    }
}
