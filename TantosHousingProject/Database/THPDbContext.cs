﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;

namespace TantosHousingProject.Database
{
    public class THPDbContext : IdentityDbContext<IdentityUser>
    {
        public THPDbContext(DbContextOptions<THPDbContext> 
            options) : base(options)
        { }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Tenant> Tenants { get; set; }

        public DbSet<Housekeeper> Housekeepers { get; set; }

        public DbSet<Contract> Contracts { get; set; }


    }
}
