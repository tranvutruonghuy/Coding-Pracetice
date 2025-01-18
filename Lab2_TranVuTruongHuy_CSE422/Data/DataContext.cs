using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab2_TranVuTruongHuy_CSE422.Models;

namespace Lab2_TranVuTruongHuy_CSE422.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Lab2_TranVuTruongHuy_CSE422.Models.CategoryModel> Categories { get; set; } = default!;
        public DbSet<Lab2_TranVuTruongHuy_CSE422.Models.User> Users { get; set; } = default!;
        public DbSet<Lab2_TranVuTruongHuy_CSE422.Models.DeviceModel> Devices { get; set; } = default!;
    }
}
