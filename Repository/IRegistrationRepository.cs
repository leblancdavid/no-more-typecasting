using no_more_typecasting.Domain;

namespace no_more_typecasting.Repository
{
    public interface IRegistrationRepository
    {
         Registration GetRegistration(int id);
    }
}