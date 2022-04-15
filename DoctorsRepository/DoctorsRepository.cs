using DoctorModels;
using DoctorsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctors_Repository
{
    public class DoctorsRepo : IDoctorsRepository
    {
        private DoctorsContextDb db;
        public DoctorsRepo(DoctorsContextDb db)
        {
            this.db = db;
        }
        public List<Doctor> GetDoctors()
        {
            return new List<Doctor> 
            {
                new Doctor{DoctorID=111, Name = "Doctor 1", PracticeLocation="Loc 1" },
                new Doctor{DoctorID=222, Name = "Doctor 2", PracticeLocation="Loc 2" },
                new Doctor{DoctorID=333, Name = "Doctor 3", PracticeLocation="Loc 3" },
                new Doctor{DoctorID=444, Name = "Doctor 4", PracticeLocation="Loc 4" },
                new Doctor{DoctorID=555, Name = "Doctor 5", PracticeLocation="Loc 5" },
            };
            //return db.Doctors.ToList();
        }
    }
}
