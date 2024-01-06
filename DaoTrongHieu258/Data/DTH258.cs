using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DaoTrongHieu258.Models;

namespace MVC.Data
{
    public class DTH258 : DbContext
    {
        public DTH258 (DbContextOptions<DTH258> options)
            : base(options)
        {
        }

        public DbSet<DaoTrongHieu258.Models.SinhVien> SinhVien { get; set; } = default!;
    }
}
