using AppSmartDoctor.Models;
using AppSmartDoctor.Models.ViewModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Mapping
{
    public class SmProfile: Profile
    {

        public SmProfile() {
            CreateMap<Paciente, PacienteDTO>().ReverseMap();
        }

    }
}
