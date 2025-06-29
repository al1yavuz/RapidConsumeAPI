using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto,Room>();   //mapleme işlemi sayesinde dto sınıfına geçmiş olduğumuz propertyler entity katmanında yer alan propertyler eşleşmiş olucak.
            CreateMap<Room, RoomAddDto>();

            CreateMap<UpdateRoomDto,Room>().ReverseMap(); //reversemap dediğimde kendisi tersine mapleme işini yapıyor.
        }
    }
}
