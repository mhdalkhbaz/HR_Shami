using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using HRApp.Models;

namespace HRApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<HRApp.Models.vi_emp_this_month> vi_emp_this_month { get; set; }
        public DbSet<HRApp.Models.vwEmp> vwEmp { get; set; }

    }
}
