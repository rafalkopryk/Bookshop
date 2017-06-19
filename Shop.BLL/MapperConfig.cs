using AutoMapper;
using Shop.BLL.DTOs;
using Shop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BLL
{
    public class MapperConfig
    {
        public static void Register()
        {
            Mapper.Initialize(obj => {

                obj.CreateMap<Carrier, CarrierDTO>();

                obj.CreateMap<Book, BookDTO>()
                    .AfterMap((model, dto) => dto.Author = String.Format("{0} {1}", model.Author.FirstName, model.Author.LastName))
                    .AfterMap((model, dto) => dto.Publisher = model.Publisher.Name);
            });
        }
    }
}
