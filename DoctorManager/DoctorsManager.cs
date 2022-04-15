using DoctorDtos;
using DoctorModels;
using DoctorsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorManager
{
    public class DoctorsManager
    {
        private readonly IDoctorsRepository repo;

        public DoctorsManager( IDoctorsRepository repo )
        {
            this.repo = repo;
        }
        public List<DoctorDto> GetDoctors()
        {
            List<DoctorDto> doctorDtos = (from d in repo.GetDoctors()
                                         select new DoctorDto { DoctorID = d.DoctorID, Name = d.Name }).ToList();
            return doctorDtos;
        }

    }
}
