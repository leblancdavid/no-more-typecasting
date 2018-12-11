using no_more_typecasting.Domain;

namespace no_more_typecasting.Repository
{
    public interface ICarRepository
    {
         Car GetCar(int id);
    }
}