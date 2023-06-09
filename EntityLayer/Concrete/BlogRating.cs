using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //No:99 Blog Reyting Tablosu için eklenen class ve metodlar
    public class BlogRating
    {
        public int BlogRatingID { get; set; }
        public int BlogID { get; set; }
        public int BlogTotalScore { get; set; }
        public int BlogRatingCount { get; set; }

    }
}
