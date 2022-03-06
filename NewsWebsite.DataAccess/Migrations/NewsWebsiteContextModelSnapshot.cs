﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsWebsite.Data.Concrete.EntityFramework.Contexts;

namespace NewsWebsite.Data.Migrations
{
    [DbContext(typeof(NewsWebsiteContext))]
    partial class NewsWebsiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewsWebsite.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 3, 18, 41, 25, 693, DateTimeKind.Local).AddTicks(4511),
                            Description = "The opinion and analysis of global politics.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 3, 18, 41, 25, 693, DateTimeKind.Local).AddTicks(4521),
                            Name = "Politics"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 3, 18, 41, 25, 693, DateTimeKind.Local).AddTicks(4538),
                            Description = "The latest health news and read articles on fitness, diet, nutrition, parenting, medicine, and diseases.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 3, 18, 41, 25, 693, DateTimeKind.Local).AddTicks(4540),
                            Name = "Health"
                        },
                        new
                        {
                            Id = 3,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 3, 18, 41, 25, 693, DateTimeKind.Local).AddTicks(4544),
                            Description = "The Latest sports news, scores, schedules, stats and more.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 3, 18, 41, 25, 693, DateTimeKind.Local).AddTicks(4545),
                            Name = "Sports"
                        });
                });

            modelBuilder.Entity("NewsWebsite.Entities.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("NewsPostId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(750)
                        .HasColumnType("nvarchar(750)");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("NewsPostId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 3, 18, 41, 25, 695, DateTimeKind.Local).AddTicks(6453),
                            IsActive = true,
                            IsDeleted = false,
                            LanguageId = 1,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 3, 18, 41, 25, 695, DateTimeKind.Local).AddTicks(6462),
                            NewsPostId = 1,
                            Text = "No war, stop war!"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 3, 18, 41, 25, 695, DateTimeKind.Local).AddTicks(6477),
                            IsActive = true,
                            IsDeleted = false,
                            LanguageId = 1,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 3, 18, 41, 25, 695, DateTimeKind.Local).AddTicks(6478),
                            NewsPostId = 2,
                            Text = "These are good advice, I hope I can apply them."
                        },
                        new
                        {
                            Id = 3,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 3, 18, 41, 25, 695, DateTimeKind.Local).AddTicks(6482),
                            IsActive = true,
                            IsDeleted = false,
                            LanguageId = 2,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 3, 18, 41, 25, 695, DateTimeKind.Local).AddTicks(6483),
                            NewsPostId = 3,
                            Text = "Bu sene o sene mi, göreceğiz."
                        });
                });

            modelBuilder.Entity("NewsWebsite.Entities.Concrete.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 3, 18, 41, 25, 698, DateTimeKind.Local).AddTicks(5397),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 3, 18, 41, 25, 698, DateTimeKind.Local).AddTicks(5406),
                            Name = "English"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 3, 18, 41, 25, 698, DateTimeKind.Local).AddTicks(5415),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 3, 18, 41, 25, 698, DateTimeKind.Local).AddTicks(5416),
                            Name = "Turkish"
                        });
                });

            modelBuilder.Entity("NewsWebsite.Entities.Concrete.NewsPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AuthorDescription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CommentCount")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DislikeCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("LikeCount")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShareCount")
                        .HasColumnType("int");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ViewsCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("UserId");

                    b.ToTable("NewsPosts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Büşra Tuğlu",
                            AuthorDescription = "The author is interested in politics, health, and sports.",
                            CategoryId = 1,
                            CommentCount = 156,
                            Content = "Russian tennis player Andrey Rublev has appealed for peace between Russia and Ukraine by signing a camera lens with a 'no war please' message, after getting through to the final of the Dubai Tennis Championship.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 3, 18, 41, 25, 690, DateTimeKind.Local).AddTicks(4930),
                            Date = new DateTime(2022, 3, 3, 18, 41, 25, 690, DateTimeKind.Local).AddTicks(4125),
                            DislikeCount = 274,
                            IsActive = true,
                            IsDeleted = false,
                            LanguageId = 1,
                            LikeCount = 1463,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 3, 18, 41, 25, 690, DateTimeKind.Local).AddTicks(5212),
                            ShareCount = 355,
                            Thumbnail = "Default.jpg",
                            Title = "No War in Ukraine",
                            UserId = 1,
                            ViewsCount = 3500
                        },
                        new
                        {
                            Id = 2,
                            Author = "Büşra Tuğlu",
                            AuthorDescription = "The author is interested in politics, health, and sports.",
                            CategoryId = 2,
                            CommentCount = 302,
                            Content = "Many of my clients who work away from home have one common obstacle: they don't plan ahead when it comes to lunch. As a result, they typically wind up eating something—like a fast-food hamburger.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 3, 18, 41, 25, 690, DateTimeKind.Local).AddTicks(7054),
                            Date = new DateTime(2022, 3, 3, 18, 41, 25, 690, DateTimeKind.Local).AddTicks(7052),
                            DislikeCount = 484,
                            IsActive = true,
                            IsDeleted = false,
                            LanguageId = 1,
                            LikeCount = 2600,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 3, 18, 41, 25, 690, DateTimeKind.Local).AddTicks(7055),
                            ShareCount = 795,
                            Thumbnail = "Default.jpg",
                            Title = "5 Healthy and Easy Lunch Ideas for Work",
                            UserId = 1,
                            ViewsCount = 5000
                        },
                        new
                        {
                            Id = 3,
                            Author = "Büşra Tuğlu",
                            AuthorDescription = "The author is interested in politics, health, and sports.",
                            CategoryId = 3,
                            CommentCount = 5,
                            Content = "Süper Lig'de lider konumda bulunan Trabzonspor'da, şehri şampiyonluk havası sardı. En yakın rakibi Konyaspor ile aradaki puan farkını yükselten Trabzon'da Faroz civarında bulunan trafik ışıklarına kupa görseli yansıtıldı.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 3, 18, 41, 25, 690, DateTimeKind.Local).AddTicks(7062),
                            Date = new DateTime(2022, 3, 3, 18, 41, 25, 690, DateTimeKind.Local).AddTicks(7061),
                            DislikeCount = 3,
                            IsActive = true,
                            IsDeleted = false,
                            LanguageId = 2,
                            LikeCount = 19,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 3, 18, 41, 25, 690, DateTimeKind.Local).AddTicks(7063),
                            ShareCount = 57,
                            Thumbnail = "Default.jpg",
                            Title = "Trabzon'da Trafik Lambaları da Şampiyonluk İstiyor: 'O Sene, Bu Sene",
                            UserId = 1,
                            ViewsCount = 706
                        });
                });

            modelBuilder.Entity("NewsWebsite.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 3, 18, 41, 25, 700, DateTimeKind.Local).AddTicks(777),
                            Description = "Admin rolü tüm haklara sahiptir.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 3, 18, 41, 25, 700, DateTimeKind.Local).AddTicks(789),
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("NewsWebsite.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARBINARY(500)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 3, 18, 41, 25, 711, DateTimeKind.Local).AddTicks(3275),
                            Email = "btuglu@",
                            FirstName = "Büşra",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Tuğlu",
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 3, 18, 41, 25, 711, DateTimeKind.Local).AddTicks(3289),
                            PasswordHash = new byte[] { 55, 52, 56, 56, 101, 51, 51, 49, 98, 56, 98, 54, 52, 101, 53, 55, 57, 52, 100, 97, 51, 102, 97, 52, 101, 98, 49, 48, 97, 100, 53, 100 },
                            Picture = "https://www.pngkey.com/png/full/151-1518198_avatar-anonimo-mujer-women-user-icon-png.png",
                            RoleId = 1,
                            UserName = "btuglu"
                        });
                });

            modelBuilder.Entity("NewsWebsite.Entities.Concrete.Comment", b =>
                {
                    b.HasOne("NewsWebsite.Entities.Concrete.Language", "Language")
                        .WithMany("Comments")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NewsWebsite.Entities.Concrete.NewsPost", "NewsPost")
                        .WithMany("Comments")
                        .HasForeignKey("NewsPostId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("NewsPost");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Concrete.NewsPost", b =>
                {
                    b.HasOne("NewsWebsite.Entities.Concrete.Category", "Category")
                        .WithMany("NewsPosts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NewsWebsite.Entities.Concrete.Language", "Language")
                        .WithMany("NewsPosts")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NewsWebsite.Entities.Concrete.User", "User")
                        .WithMany("NewsPosts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Language");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Concrete.User", b =>
                {
                    b.HasOne("NewsWebsite.Entities.Concrete.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Concrete.Category", b =>
                {
                    b.Navigation("NewsPosts");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Concrete.Language", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("NewsPosts");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Concrete.NewsPost", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Concrete.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("NewsWebsite.Entities.Concrete.User", b =>
                {
                    b.Navigation("NewsPosts");
                });
#pragma warning restore 612, 618
        }
    }
}