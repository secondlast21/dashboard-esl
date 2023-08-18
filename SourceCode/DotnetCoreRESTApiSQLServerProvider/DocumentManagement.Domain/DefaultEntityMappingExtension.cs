﻿using DocumentManagement.Data;
using DocumentManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DocumentManagement.Domain
{
    public static class DefaultEntityMappingExtension
    {
        public static void DefalutMappingValue(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Operation>()
               .Property(b => b.ModifiedDate)
               .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<Screen>()
           .Property(b => b.ModifiedDate)
           .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<ScreenOperation>()
            .Property(b => b.ModifiedDate)
            .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<Document>()
          .Property(b => b.ModifiedDate)
          .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<Category>()
           .Property(b => b.ModifiedDate)
           .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<DocumentAuditTrail>()
             .Property(b => b.ModifiedDate)
             .HasDefaultValueSql("GETUTCDATE()");
        }

        public static void DefalutDeleteValueFilter(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasQueryFilter(p => !p.IsDeleted);

            modelBuilder.Entity<Role>()
                .HasQueryFilter(p => !p.IsDeleted);

            modelBuilder.Entity<Operation>()
                .HasQueryFilter(p => !p.IsDeleted);

            modelBuilder.Entity<Screen>()
                .HasQueryFilter(p => !p.IsDeleted);

            modelBuilder.Entity<ScreenOperation>()
                .HasQueryFilter(p => !p.IsDeleted);

            modelBuilder.Entity<Document>()
                .HasQueryFilter(p => !p.IsDeleted);

            modelBuilder.Entity<Category>()
                .HasQueryFilter(p => !p.IsDeleted);

            modelBuilder.Entity<Reminder>()
                .HasQueryFilter(p => !p.IsDeleted);

            modelBuilder.Entity<EmailSMTPSetting>()
            .HasQueryFilter(p => !p.IsDeleted);
        }
    }
}
