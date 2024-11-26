using AutoMapper;
using ContaBancaria;
using Core._03Entidade.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {


            CreateMap<ContaDTO, Conta>().ReverseMap();
        }
    }
}
