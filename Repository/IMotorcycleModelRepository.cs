using no_more_typecasting.Domain;

namespace no_more_typecasting.Repository
{
    public interface IMotorcycleModelRepository
    {
         MotorcycleModel GetMotorcycleModel(int id);
    }
}