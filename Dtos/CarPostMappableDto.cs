using no_more_typecasting.Domain;

namespace no_more_typecasting.Dtos
{
    public class CarPostMappableDto : VehiclePostMappableDto
    {
        public int CarModelId { get; set; }

        public override Vehicle ToDomain(IVehicleDomainDependencies dependencies)
        {
            return new Car()
            {
                Registration = dependencies.RegistrationRepository.GetRegistration(RegistrationId),
                Model = dependencies.CarModelRepository.GetCarModel(CarModelId)
            };

        }
    }
}