using no_more_typecasting.Domain;

namespace no_more_typecasting.Dtos
{
    public class MotorcyclePostMappableDto : VehiclePostMappableDto
    {
        public int MotorcycleModelId { get; set; }

        public override Vehicle ToDomain(IVehicleDomainDependencies dependencies)
        {
            return new Motorcycle()
            {
                Registration = dependencies.RegistrationRepository.GetRegistration(RegistrationId),
                Model = dependencies.MotorcycleModelRepository.GetMotorcycleModel(MotorcycleModelId)
            };

        }
    }
}