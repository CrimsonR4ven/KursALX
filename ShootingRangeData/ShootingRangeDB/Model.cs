using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace ShootingRangeData.ShootingRangeDB
{
    public class ShootingRangeContext : DbContext
    {
        public DbSet<Gun> Guns { get; set; }
        public DbSet<Bundle> Bundles { get; set; }
        public DbSet<GunLane> Lanes { get; set; }
        public DbSet<GunLaneType> LaneTypes { get; set; }
        public DbSet<GunCategory> GunCategories { get; set; }
        public string DbPath { get; }
        private string ConnString;
        public ShootingRangeContext()
        {
            ConnString = "Server=tcp:shootingrange.database.windows.net,1433;Initial Catalog=ShootingRange;Persist Security Info=False;User ID=CloudSA0f94f61f;Password=Kacper2005;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }
        public ShootingRangeContext(string connString)
        {
            ConnString = connString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseLazyLoadingProxies().UseSqlServer(ConnString);
            options.ConfigureWarnings(b => b.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
//            modelBuilder.Entity<Document>()
//                .ToTable(tb => tb.HasTrigger("SomeTrigger"));
        }
    }
    [PrimaryKey("ID")]
    public class Bundle
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		
        public Guid ID { get; set; }
		[Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public virtual List<Gun> Guns { get; set; }
    }  
    [Index(nameof(Name))]
    [PrimaryKey("CategoryID")]
    public class GunCategory
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CategoryID { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public virtual List<Gun> Guns { get; set; }
    }
	[PrimaryKey("LaneID")]
    public class GunLaneType
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LaneID { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public virtual List<Gun> Guns { get; set; }
        public virtual List<GunLane> GunLanes { get; set; }
    }
    [Index(nameof(Price))]
	[Index(nameof(Name))]
    public class Gun
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
		[MaxLength(50)]
        public string ImgName { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        [ForeignKey("CategoryID")]
        public virtual GunCategory Category { get; set; }
        [Required]
        [ForeignKey("LaneID")]
        public virtual GunLaneType Lane { get; set; }
        [Required]
        public virtual List<Bundle> Bundles { get; set; }
    }
    public class GunLane
	{
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string ImgName { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        public int Distance { get; set; }
        [Required]
        public double RentPrice { get; set; }
        [Required]
        public virtual GunLaneType Lane { get; set; }
    }
}
