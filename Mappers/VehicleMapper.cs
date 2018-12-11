using no_more_typecasting.Domain;
using no_more_typecasting.Dtos;

namespace no_more_typecasting.Mappers
{
    public class VehicleMapper
    {
        public Vehicle Map(VehiclePostDto dto)
        {
            //Typechecking here, can we get rid of this???
            if(dto is CarPostDto)
            {
                return new Car();
            }

            return new Vehicle();
        }
    }
}