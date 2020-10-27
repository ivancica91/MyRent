using Microsoft.EntityFrameworkCore;
using My_Rent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Rent.Data
{
    public class MvcPropertyContext : DbContext 
    {
        public MvcPropertyContext (DbContextOptions<MvcPropertyContext> options) : base(options)
        {

        }

        public DbSet<Property> Property { get; set; }
    }
}
