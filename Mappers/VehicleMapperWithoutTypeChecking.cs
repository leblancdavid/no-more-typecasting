using no_more_typecasting.Domain;
using no_more_typecasting.Dtos;

namespace no_more_typecasting.Mappers
{
    public class VehicleMapperWithoutTypeChecking
    {
        IVehicleDomainDependencies _dependencies;
        public VehicleMapperWithoutTypeChecking(IVehicleDomainDependencies dependencies)
        {
            _dependencies = dependencies;
        }

        public Vehicle Map(VehiclePostMappableDto dto)
        {
            return dto.ToDomain(_dependencies);
        }
    }
}