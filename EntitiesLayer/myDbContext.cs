using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace EntitiesLayer
{
    public partial class myDbContext : DbContext
    {
        public DbSet<urun> tbl_urun { get; set; }
        public DbSet<birim> tbl_birim { get; set; }
        public DbSet<kategori> tbl_kategori { get; set; }
        public DbSet<marka> tbl_marka { get; set; }
        public DbSet<toptanci> tbl_toptanci { get; set; }
        public DbSet<kullanici> tbl_adminKullanici { get; set; }
        public DbSet<zRapor> tbl_zRapor { get; set; }
        public DbSet<musteri> tbl_musteri { get; set; }
        public myDbContext() : base("otomasyonCon")
        {

        }

    }
}
