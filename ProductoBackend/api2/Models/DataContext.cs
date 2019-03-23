﻿using System.Data.Entity;

namespace api2.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<api2.Models.Product> Products { get; set; }
    }
}