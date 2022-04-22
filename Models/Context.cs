using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Models.Enitites
{
    public partial class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RolePermission> RolePermissions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=DESKTOP-8BOK9CR;Initial Catalog=BoardCore;User ID=sa;Password=a10604541z");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CI_AS");

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Permission");

                entity.Property(e => e.CreDate)
                    .HasColumnType("datetime")
                    .HasComment("建立日期");

                entity.Property(e => e.CreUid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CreUID")
                    .HasComment("建立者ID");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("GUID")
                    .HasComment("主鍵ID");

                entity.Property(e => e.Icon)
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("圖標");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasComment("編輯日期");

                entity.Property(e => e.ModUid)
                    .HasMaxLength(50)
                    .HasColumnName("ModUID")
                    .HasComment("編輯者ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME")
                    .HasComment("權限/選單名稱");

                entity.Property(e => e.NeedPermission).HasComment("是否需要權限");

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasComment("父級ID");

                entity.Property(e => e.Sort).HasComment("排序");

                entity.Property(e => e.Status).HasComment("是否啟用");

                entity.Property(e => e.Type).HasComment("類型,選單=0,頁面=1,權限=2");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("選單位址");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Role");

                entity.Property(e => e.CreDate)
                    .HasColumnType("datetime")
                    .HasComment("建立日期");

                entity.Property(e => e.CreUid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CreUID")
                    .HasComment("建立者ID");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("GUID")
                    .HasComment("主鍵ID");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasComment("編輯日期");

                entity.Property(e => e.ModUid)
                    .HasMaxLength(50)
                    .HasColumnName("ModUID")
                    .HasComment("編輯者ID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("角色名稱");

                entity.Property(e => e.Status).HasComment("角色狀態是否啟用");
            });

            modelBuilder.Entity<RolePermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RolePermission");

                entity.Property(e => e.CreDate)
                    .HasColumnType("datetime")
                    .HasComment("建立者日期");

                entity.Property(e => e.CreUid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CreUID")
                    .HasComment("建立者ID");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("GUID")
                    .HasComment("主鍵ID");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasComment("編輯者日期");

                entity.Property(e => e.ModUid)
                    .HasMaxLength(50)
                    .HasColumnName("ModUID")
                    .HasComment("編輯者ID");

                entity.Property(e => e.PermissionId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("權限ID");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("角色ID");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasComment("是否啟用");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("User");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("帳號");

                entity.Property(e => e.CreDate)
                    .HasColumnType("datetime")
                    .HasComment("建立日期");

                entity.Property(e => e.CreUid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CreUID")
                    .HasComment("建立者ID");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("GUID")
                    .HasComment("主鍵ID");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasComment("編輯者ID");

                entity.Property(e => e.ModUid)
                    .HasMaxLength(50)
                    .HasColumnName("ModUID")
                    .HasComment("編輯者ID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("密碼");

                entity.Property(e => e.Status).HasComment("是否啟用");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("使用者名稱");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserRole");

                entity.Property(e => e.CreDate)
                    .HasColumnType("datetime")
                    .HasComment("建立日期");

                entity.Property(e => e.CreUid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("建立者ID");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("GUID");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasComment("編輯日期");

                entity.Property(e => e.ModUid)
                    .HasMaxLength(50)
                    .HasColumnName("ModUId")
                    .HasComment("編輯者ID");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("角色ID");

                entity.Property(e => e.Status).HasComment("是否啟用");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("使用者ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
