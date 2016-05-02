using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Dream.Data;

namespace dream.data.Migrations
{
    [DbContext(typeof(DreamContext))]
    [Migration("20160502043731_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dream.Data.Reminder", b =>
                {
                    b.Property<int>("ReminderId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UserId");

                    b.HasKey("ReminderId");
                });

            modelBuilder.Entity("Dream.Data.ReminderContent", b =>
                {
                    b.Property<int>("ReminderContentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Message");

                    b.Property<int>("ReminderId");

                    b.HasKey("ReminderContentId");
                });

            modelBuilder.Entity("Dream.Data.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("UserId");
                });

            modelBuilder.Entity("Dream.Data.Reminder", b =>
                {
                    b.HasOne("Dream.Data.User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Dream.Data.ReminderContent", b =>
                {
                    b.HasOne("Dream.Data.Reminder")
                        .WithMany()
                        .HasForeignKey("ReminderId");
                });
        }
    }
}
