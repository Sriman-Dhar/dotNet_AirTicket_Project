﻿using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class airdemoContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
       
        public DbSet<Flight> Flights { get; set; }
  
        public DbSet<User> Users { get; set; }
        public DbSet<Token> Tokens { get; set; }

    }
}
