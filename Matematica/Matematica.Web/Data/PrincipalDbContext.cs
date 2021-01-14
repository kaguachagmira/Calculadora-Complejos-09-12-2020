using Matematica.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matematica.Web.Data
{
    public class PrincipalDbContext : DbContext
    {
        public PrincipalDbContext()
        {

        }
        public PrincipalDbContext(DbContextOptions<PrincipalDbContext> options)
            : base(options)
        {
        }
        public DbSet<Mascota> Mascotas { get; set; }
    }
}
