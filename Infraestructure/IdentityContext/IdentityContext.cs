using Core.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Infrastructure.IdentityContext
{
    public class IdentityContext:DbContext
    {
        public IdentityContext(DbContextOptions<IdentityContext> options)
            : base(options)
        {
            
        }

        public DbSet<User> UserIdentity { get; set; }
    }
}
