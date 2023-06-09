using EntityLayer;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    //No:12 Context classını bağlantı adresi tanımlamak (Connection String) için ekledik.
    //No:136 IDENTITY KÜTÜPHANESİ İÇİN DBCONTEXT->IdentityDbContext  OLARAK DEĞİŞTİRİLDİ
    //No:136 AppUser parametresi eklendi
    public class Context:DbContext
    //Conctext classı Dbcontext classından miras alır.DbContext 
    {
        //No:13 SQL Server Baglantısı için Onconfiguring metodu tanımlayıp server bilgilerimizi yazdık.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-VLDGDG5;database=DbMyWebSite1;Integrated Security=True;Trust Server Certificate=true;User Id=SA;Password={123456789};");
        }

        //No:105 Entity Framework Code First Two Foreign Keys From Same Table işlemini anlatmak için eklendi 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
                .HasOne(x => x.HomeTeam)
                .WithMany(y => y.HomeMatches)
                .HasForeignKey(z => z.HomeTeamID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Match>()
                .HasOne(x=>x.GuestTeam)
                .WithMany(y=>y.AwayMatches)
                .HasForeignKey(z=>z.GuestTeamID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            //No:106 Mesaj-Yazar ilişkisi için eklendi
            modelBuilder.Entity<Message2>()
                .HasOne(x => x.SenderUser)
                .WithMany(y => y.WriterSender)
                .HasForeignKey(z => z.SenderID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>()
                .HasOne(x => x.ReceiverUser)
                .WithMany(y => y.WriterReceiver)
                .HasForeignKey(z => z.ReceiverID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(modelBuilder);
            //HomeMatches-->WriterSender
            //AwayMatches--> WriterReceiver

            //HomeTeam-->SenderUser
            //GuestTeam-->ReceiverUser


        }





        //No:14 Contextlerimizi yazdık.(EntityLayer/Concrete içindeki classlar)
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category>Categories  { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }

        //No:80 EntityLayer/Concrete de yer alan NewsLetter classından sonra Dbset olarak tanımlandı
        public DbSet<NewsLetter> NewsLetters { get; set; }

        //No:99 BlogRating için yazıldı
        public DbSet<BlogRating> Blogratings { get; set; }

        //No:103 Notification Sınıfı için eklendi(Dashboard)
        public DbSet<Notification> Notifications { get; set; }

        //No:104 Message sınıfı için eklendi
        public DbSet<Message> Messages { get; set; }

        //No:105 Entity Framework Code First Two Foreign Keys From Same Table işlemini anlatmak için eklendi 
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }


        //No:106 Mesaj-Yazar ilişkisi için eklendi
        public DbSet<Message2> Message2s { get; set; }

        //No:120 Admin Paneli Admin Tablosu için eklendi
        public DbSet<Admin> Admins { get; set; }

    }
}
