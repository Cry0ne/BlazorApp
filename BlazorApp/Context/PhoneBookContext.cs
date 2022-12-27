using BlazorApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace BlazorApp.Context
{
    public class PhoneBookContext : DbContext
    {
        public PhoneBookContext()
        { }

        public PhoneBookContext(DbContextOptions<PhoneBookContext> options) : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Office> Offices { get; set; }
    }
}
