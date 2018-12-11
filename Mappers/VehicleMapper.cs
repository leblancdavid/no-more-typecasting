using no_more_typecasting.Domain;
using no_more_typecasting.Dtos;
using no_more_typecasting.Repository;

namespace no_more_typecasting.Mappers
{
    public class VehicleMapper
    {
        private ICarModelRepository _carModelRepository;
        private IMotorcycleModelRepository _motorcycleModelRepository;
        private IRegistrationRepository _registrationRepository;

        //These will get injected via the container
        public VehicleMapper(ICarModelRepository carModelRepository,
            IMotorcycleModelRepository motorcycleModelRepository,
            IRegistrationRepository registrationRepository)
        {
            _carModelRepository = carModelRepository;
            _motorcycleModelRepository = motorcycleModelRepository;
            _registrationRepository = registrationRepository;
        }

        public Vehicle Map(VehiclePostDto dto)
        {
            //Typechecking here, can we get rid of this???
            if(dto is CarPostDto)
            {
                return new Car()
                {
                    Registration = _registrationRepository.GetRegistration(dto.RegistrationId),
                    Model = _carModelRepository.GetCarModel((dto as CarPostDto).CarModelId)
                };
            }
            else if(dto is MotorcyclePostDto)
            {
                return new Motorcycle()
                {
                    Registration = _registrationRepository.GetRegistration(dto.RegistrationId),
                    Model = _motorcycleModelRepository.GetMotorcycleModel((dto as MotorcyclePostDto).MotorcycleModelId)
                };;
            }

            return new Vehicle() { Registration = _registrationRepository.GetRegistration(dto.RegistrationId) };
        }
    }
}