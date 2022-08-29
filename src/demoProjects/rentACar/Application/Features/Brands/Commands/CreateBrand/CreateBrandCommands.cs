using Application.Features.Brands.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.CreateBrand
{
    public class CreateBrandCommands:IRequest<CreatedBrandDto>
    {
        public string Name { get; set; }
    }
}
