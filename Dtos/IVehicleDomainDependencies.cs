using no_more_typecasting.Domain;
using no_more_typecasting.Repository;

namespace no_more_typecasting.Dtos
{
    public interface IVehicleDomainDependencies
    {
         IRegistrationRepository RegistrationRepository { get; }
         ICarModelRepository CarModelRepository { get; }
         IMotorcycleModelRepository MotorcycleModelRepository { get; }
    }
}