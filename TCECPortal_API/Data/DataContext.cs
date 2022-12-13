using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCECPortal_API.Models;

namespace TCECPortal_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.SetCommandTimeout(150000);
        }
        //public DbSet<Project> Projects { get; set; } = null;
        public DbSet<User> Users { get; set; } = null;
        //public DbSet<Transaction> Transactions{ get; set; } = null;
        //public DbSet<TransactionDetail> TransactionDetails { get; set; } = null;
        //public DbSet<Account> Accounts { get; set; } = null;
        public DbSet<Attendance> Attendances { get; set; } = null;
        //public DbSet<Order> Orders { get; set; } = null;
        //public DbSet<OrderDetail> OrderDetails { get; set; } = null;
        //public DbSet<DocAttachment> Attachments { get; set; } = null;

    }
}
