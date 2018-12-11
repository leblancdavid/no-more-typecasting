using no_more_typecasting.Domain;

namespace no_more_typecasting.Dtos
{
    public class VehiclePostMappableDto : IDomainMappable<Vehicle, IVehicleDomainDependencies>
    {
        public int RegistrationId { get; set; }
        virtual public Vehicle ToDomain(IVehicleDomainDependencies dependencies)
        {
            return new Vehicle() 
            {
                Registration = dependencies.RegistrationRepository.GetRegistration(this.RegistrationId)
            };
        }
    }
}