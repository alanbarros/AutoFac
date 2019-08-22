using GeometricShapes.Domain.Shapes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes.Infra.Repository
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("GeometricShapes");
        }

        public DbSet<Square> Squares { get; set; }
        public DbSet<Rectangle> Rectangles { get; set; }
    }
}
