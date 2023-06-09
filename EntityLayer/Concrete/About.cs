using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        //NO:10 ABOUT PROPLARI EKLENDI
        [Key]//No:11 ,100
        public int AboutID { get; set; }
        public string AboutDetails1 { get; set; }
        public string AboutDetails2 { get; set; }
        public string AboutImage1 { get; set; }
        public string AboutImage2 { get; set; }
        public bool AboutStatus { get; set; }

        //IFRAME KULLANMAK İCİN HARİTA LOKASYON DEGERİNE IHTIYACIMIZ VAR
        public string AboutMapLocation { get; set; }
    }
}
