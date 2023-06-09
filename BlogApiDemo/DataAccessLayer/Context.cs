using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context:DbContext
    {
        //No:129 APİLERE GİRİŞ İŞLEMİ İÇİN EKLENDİ
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-VLDGDG5;database=DbCoreApi;Integrated Security=True;Trust Server Certificate=true;User Id=SA;Password={123456789};");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
