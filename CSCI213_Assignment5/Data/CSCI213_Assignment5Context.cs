using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CSCI213_Assignment5.Models;

namespace CSCI213_Assignment5.Data
{
    public class CSCI213_Assignment5Context : DbContext
    {
        public CSCI213_Assignment5Context (DbContextOptions<CSCI213_Assignment5Context> options)
            : base(options)
        {
        }

        public DbSet<CSCI213_Assignment5.Models.Song> Song { get; set; } = default!;
    }
}
