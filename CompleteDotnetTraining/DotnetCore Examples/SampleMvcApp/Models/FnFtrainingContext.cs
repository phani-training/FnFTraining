using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SampleMvcApp.Models;

public partial class FnFtrainingContext : DbContext
{
    public FnFtrainingContext()
    {
    }

    public FnFtrainingContext(DbContextOptions<FnFtrainingContext> options)
        : base(options)
    {
    }
    public virtual DbSet<TblBook> TblBooks { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=FnFTraining; Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       
        modelBuilder.Entity<TblBook>(entity =>
        {
            entity.HasKey(e => e.BookId);

            entity.ToTable("tblBook");

            entity.Property(e => e.BookPublisher).HasDefaultValueSql("(N'')");
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
