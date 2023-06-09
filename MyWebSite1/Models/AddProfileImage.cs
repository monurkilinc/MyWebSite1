//No:102 Profil Resmi eklemek için ekledik

namespace MyWebSite1.Models
{
    public class AddProfileImage
    {
        //No:102 proplar eklendi


        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }

        //No:102 Dosyadan bir veri seçebilmek için IFormFile türünde kullandık
        public IFormFile WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }
    }
}
