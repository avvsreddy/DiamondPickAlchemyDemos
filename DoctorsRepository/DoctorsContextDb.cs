using DoctorModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsRepository
{
    public class DoctorsContextDb : DbContext
    {
        public DoctorsContextDb(DbContextOptions<DoctorsContextDb> options) : base(options)
        {

        }

        public DbSet<Doctor> Doctors { get; set; }
    }
}
