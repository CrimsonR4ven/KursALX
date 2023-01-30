using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

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
            options.UseSqlServer(ConnString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
//            modelBuilder.Entity<Document>()
//                .ToTable(tb => tb.HasTrigger("SomeTrigger"));
        }
    }
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
        public List<Gun> Guns { get; set; }
    }  
    [Index(nameof(Name))]
    public class GunCategory
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public List<Gun> Guns { get; set; }
    }
    public class GunLaneType
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public List<Gun> Guns { get; set; }
        public List<GunLane> GunLanes { get; set; }
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
        public GunCategory Category { get; set; }
        [Required]
        public GunLaneType Lane { get; set; }
		[Required]
        public List<Bundle> Bundles { get; set; }
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
        public GunLaneType Lane { get; set; }
    }
}
