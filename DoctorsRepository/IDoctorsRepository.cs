using DoctorModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsRepository
{
    public interface IDoctorsRepository
    {

        List<Doctor> GetDoctors();

    }
}
