using System;
using Microsoft.EntityFrameworkCore;

namespace AoiBlogModel
{
    public class AoiBlogEntity:DbContext
    {
        public AoiBlogEntity(DbContextOptions<AoiBlogEntity> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
       
    }
}
