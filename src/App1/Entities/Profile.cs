using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace App1
{
    class MappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return this.GetType().Name; }
        }

        protected override void Configure()
        {
            this.CreateMap<Source, Dest>()
                 .ForMember(x => x.Title, x => x.MapFrom(y => y.Title))
                 .ForMember(x => x.Description, x => x.MapFrom(y => y.Description));
        }
    }
}
