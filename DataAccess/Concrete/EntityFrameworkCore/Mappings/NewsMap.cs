using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameworkCore.Mappings
{
    public class NewsMap : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.ToTable(@"News", @"dbo");

            builder.HasKey(d => d.NewsID);

            builder.Property(d => d.Title).HasColumnName("Title");
            builder.Property(d => d.Description).HasColumnName("Description");
            builder.Property(d => d.PublishDate).HasColumnName("PublishDate");
            builder.Property(d => d.Category).HasColumnName("Category");
        }
    }
}
