using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using MyWebSite1.Areas.Admin.Models;

namespace MyWebSite1.Areas.Admin.Controllers
{
    //No:118 Eğer aşağıdaki ifade yazılmazsa sayfaya gidemez.Sebebi Area içinde kullanıldığı için
    [Area("Admin")]
    public class BlogController : Controller
    {
        public IActionResult ExportStaticExcelBlogList()
        {
            ////No:118 Excelle yazdıracağımız satırlara ait verileri metotlar yardımıyla yazdırdık
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "Blog Adı";

                int BlogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    worksheet.Cell(BlogRowCount, 1).Value = item.ID;
                    worksheet.Cell(BlogRowCount, 2).Value = item.BlogName;
                    BlogRowCount++;
                }
                using(var stream=new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content=stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Workbook1.xlsx");
                }
            }
        }            

        public List<BlogModel> GetBlogList()
        {
            List<BlogModel> bm = new List<BlogModel>
            {
                new BlogModel(){ID=1,BlogName="C# Programlamaya Giriş" },
                new BlogModel(){ID=2,BlogName="Tesla Firmasının Araçları"},
                new BlogModel(){ID=3,BlogName="2026 Dünya Kupası"},

            };
            return bm;
        }
        //No:117 BlogListExcel yukarıda yazmış olduğumuz metotları tetiklemek için eklendi
        public IActionResult BlogListExcel()
        {
            return View();
        }





        //No:117 Dinamik Tablo Export işlemi için tanımlanan metot
        public IActionResult ExportDynamicExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "Blog Adı";

                int BlogRowCount = 2;
                foreach (var item in BlogTitleList())
                {
                    worksheet.Cell(BlogRowCount, 1).Value = item.Id;
                    worksheet.Cell(BlogRowCount, 2).Value = item.BlogName;
                    BlogRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Workbook1.xlsx");
                }
            }
        }

        //No:117 Dinamik Tablo Export için oluşturulan liste
        public List<BlogModel2> BlogTitleList()
        {
            List<BlogModel2> bm = new List<BlogModel2>();

            using(var c=new Context())
            {
                bm = c.Blogs.Select(x => new BlogModel2
                {
                    Id= (int)x.BlogID,
                    BlogName = x.BlogTitle


                }).ToList();
            }
            return bm;
        }
        //No:117 Dinamik Tabloyu Export tetiklemesi için yazılan metot
        public IActionResult BlogTitleListExcel()
        {
            return View();
        }

    }
        
}
