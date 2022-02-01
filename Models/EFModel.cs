using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Tedliu.WebApp.sideProject.Models
{
    public partial class EFModel : DbContext
    {
        public EFModel()
            : base("name=EFModel")
        {
        }

        public virtual DbSet<Guestbook> Guestbooks { get; set; }
        public virtual DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guestbook>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.AuthCode)
                .IsFixedLength();
        }
    }
}
