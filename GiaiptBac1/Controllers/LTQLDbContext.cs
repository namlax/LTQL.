using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GiaiptBac1.Models
{
    public partial class LTQLDbContext : DbContext

    {
        public LTQLDbContext() : base("name=LTQLDbContext")
        {
        }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().Property(e => e.Username).IsUnicode(false);
            modelBuilder.Entity<Student>().Property(e => e.StudentID).IsUnicode(false);
            modelBuilder.Entity<KhachHang>().Property(e => e.KhachHangID).IsUnicode(false);
        }
    }
}